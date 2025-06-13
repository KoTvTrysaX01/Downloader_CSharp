using Microsoft.Data.Sqlite;
using System.Net.Sockets;
using Renci.SshNet;
using Newtonsoft.Json;
using Renci.SshNet.Sftp;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System;
using System.Drawing;

namespace Downloader_Framework
{
    public class Connection
    {
        static string userName = Environment.UserName;
        static string database = $@"Downloader_DB.db";
        static string profilesJSON = $@"ProfilesJSON.txt";

        //Reads DBs table and creates AppButton for each page.
        public List<AppToDownload> ReadTable()
        {
            try
            {
                if(File.Exists(database))
                {
                    List<AppToDownload> listApps = new List<AppToDownload>();
                    string source = $"Data source = {database}";

                    using (SqliteConnection connection = new SqliteConnection(source))
                    {
                        connection.Open();
                        using (SqliteCommand command = new SqliteCommand("Select * from AppToDownload", connection))
                        {
                            command.Connection = connection;
                            using (SqliteDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    AppToDownload app = new AppToDownload(
                                        reader["AppName"].ToString(),
                                        reader["FileName"].ToString(),
                                        reader["CommandLine"].ToString(),
                                        reader["Section"].ToString()
                                        );
                                    listApps.Add(app);
                                }
                                return listApps;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Database is unreachable.");
                    return null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed connection to the database.");
                return null;
            }
        }

        //Returns image of an app from DB using SQL.
        public static Image ConvertSqlToImage(string appName)
        {
            Image image = null;
            try
            {
                string source = $"Data source = {database}";
                using (var conn = new SqliteConnection(source))
                {
                    conn.Open();
                    using (SqliteCommand cmd = new SqliteCommand($"Select Icon from AppToDownload where AppName = \"{appName}\"", conn))
                    {
                        cmd.Connection = conn;
                        using (SqliteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                image = MainFrame.MyBytesToImage((byte[])reader["Icon"]);
                            }
                            return image;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return image;
            }
        }


        //Check the connection with the host and changes ImageStatus depending on the response.
        public bool PingHost()
        {
            try
            {
                using (var client = new TcpClient())
                {
                    var result = client.BeginConnect("79.112.50.56", 22, null, null);
                    var success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(10));
                    client.EndConnect(result);
                    MainFrame.lbl_ImageStatus.Invoke(new MethodInvoker(delegate
                    {
                        MainFrame.lbl_ImageStatus.Image = new Bitmap(Properties.Resources.happy, new Size(50, 50));
                        MainFrame.AppendTextToConsole("Successful connection.");
                    }));
                    ;
                    return true;
                }
            }
            catch (Exception ex)
            {
                MainFrame.lbl_ImageStatus.Invoke(new MethodInvoker(delegate
                {
                    MainFrame.lbl_ImageStatus.Image = new Bitmap(Properties.Resources.sad, new Size(50, 50));
                    MainFrame.AppendTextToConsole("Server is unreachable.");
                }));
                return false;
            }
        }

        //Downloades apps from sftp server using list of saved apps.
        //Can call for InstallApps if app is installable. 
        //Can use WinGet to update all installed apps.
        public void DownloadApps(List<AppToDownload> listApps, string SourcePath, bool tryInstall, bool updateAll)
        {
            int Port = 22;
            string Host = "79.112.50.56";
            string Username = "sftpuser";
            string Password = "V4J2X01Yb";
            string RemotePath = "Files/";
            try
            {
                MainFrame.richtxtbox_Console.Invoke(new MethodInvoker(delegate
                {
                    MainFrame.AppendTextToConsole("----------------------------------------------------------");
                    MainFrame.AppendTextToConsole("Starting session.");
                }));

                foreach (AppToDownload app in listApps)
                {
                    string SourceFilePath = SourcePath + "\\" + app.fileName;
                    using (var stream = new FileStream(SourceFilePath, FileMode.Create))
                    using (var client = new SftpClient(Host, Port, Username, Password))
                    {
                        client.Connect();
                        MainFrame.txtbox_DownloadFile.Invoke(new MethodInvoker(delegate
                        {
                            MainFrame.txtbox_DownloadFile.Texts = $"Now downloading: {app.appName}";
                            MainFrame.AppendTextToConsole($"Now downloading: {app.appName}");
                        }));
                        string RemoteFilePath = RemotePath + app.fileName;
                        SftpFileAttributes attrs = client.GetAttributes(RemoteFilePath);
                        // Set progress bar maximum on foreground thread
                        int max = (int)attrs.Size;
                        MainFrame.progbar_DownloadPrc.Invoke(
                            (MethodInvoker)delegate { MainFrame.progbar_DownloadPrc.Maximum = max; });
                        // Download with progress callback
                        client.DownloadFile(RemoteFilePath, stream, DownloadProgresBar);
                    }
                    MainFrame.richtxtbox_Console.Invoke(new MethodInvoker(delegate
                    {
                        MainFrame.AppendTextToConsole($"Finished downloading {app.appName}");
                    }));

                    if (tryInstall)
                    {
                        if (app.commandLine == null)
                        {
                            MainFrame.richtxtbox_Console.Invoke(new MethodInvoker(delegate
                            {
                                MainFrame.AppendTextToConsole($"{app.fileName} cannot be installed");
                            }));
                        }
                        else
                        {
                            InstallApps(SourceFilePath, app);
                        }
                    }
                }
                if(updateAll)
                {
                    try
                    {
                        MainFrame.richtxtbox_Console.Invoke(new MethodInvoker(delegate
                        {
                            MainFrame.AppendTextToConsole($"Beginning to update all apps.");
                            MainFrame.AppendTextToConsole($"This will take a while.");
                        }));

                        string[] commands = new string[]{ @"iex ""& { $(irm https://aka.ms/install-powershell.ps1) } -UseMSI -Quiet""", @"irm bonguides.com/winget | iex", @"Add-AppxPackage -Path 'https://github.com/microsoft/winget-cli/releases/download/v1.10.390/Microsoft.DesktopAppInstaller_8wekyb3d8bbwe.msixbundle'  -ForceApplicationShutdown", @"winget upgrade --all"};
                        for(int i = 0; i < commands.Length; i++)
                        {
                            ProcessStartInfo processStartInfo = new ProcessStartInfo("powershell.exe", commands[i]);
                            processStartInfo.RedirectStandardOutput = true;
                            processStartInfo.RedirectStandardError = true;
                            processStartInfo.UseShellExecute = false;

                            Process process = new Process();
                            process.StartInfo = processStartInfo;
                            process.Start();
                            process.WaitForExit();
                        }
                        MainFrame.richtxtbox_Console.Invoke(new MethodInvoker(delegate
                        {
                            MainFrame.AppendTextToConsole($"Updates completed.");
                        }));
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                MainFrame.richtxtbox_Console.Invoke(new MethodInvoker(delegate
                {
                    MainFrame.txtbox_DownloadFile.Texts = $"Process is over.";
                    MainFrame.AppendTextToConsole("Session is finished.");
                    MainFrame.AppendTextToConsole("----------------------------------------------------------");
                    MainFrame.btn_StartDownload.Enabled = true;
                }));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MainFrame.richtxtbox_Console.Invoke(new MethodInvoker(delegate
                {
                    MainFrame.AppendTextToConsole($"Failed to connect.");
                    MainFrame.AppendTextToConsole("----------------------------------------------------------");
                    MainFrame.btn_StartDownload.Enabled = true;
                }));
            }
        }


        //Updates ProgressBar.
        private void DownloadProgresBar(ulong uploaded)
        {
            // Update progress bar on foreground thread
            MainFrame.progbar_DownloadPrc.Invoke(
                (MethodInvoker)delegate
                {
                    MainFrame.progbar_DownloadPrc.Value = (int)uploaded;
                    MainFrame.lbl_ProgPer.Text = (((double)uploaded / MainFrame.progbar_DownloadPrc.Maximum) * 100).ToString("0.0") + " %";
                });
        }


        //Tries to install apps using their commandLine. 
        public void InstallApps(string filePath, AppToDownload app)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = filePath;
                process.StartInfo.Arguments = app.commandLine;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                MainFrame.richtxtbox_Console.Invoke(new MethodInvoker(delegate
                {
                    MainFrame.AppendTextToConsole($"Now installing {app.appName}");
                }));
                process.Start();
                process.WaitForExit();
                MainFrame.richtxtbox_Console.Invoke(new MethodInvoker(delegate
                {
                    MainFrame.AppendTextToConsole($"Finished installing {app.appName}");
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MainFrame.richtxtbox_Console.Invoke(new MethodInvoker(delegate
                {
                    MainFrame.AppendTextToConsole($"Failed to install {app.appName}");
                }));
            }
        }

        //Reads JSON files and returns list of saved profiles (if there are any).
        public List<ProfilePanel> ReadJSONFile()
        {
            List<ProfilePanel> listPanels = new List<ProfilePanel>();
            try
            {
                if (File.Exists(profilesJSON))
                {
                    List<Profile> listProfiles = JsonConvert.DeserializeObject<List<Profile>>(File.ReadAllText(profilesJSON));
                    if (listProfiles != null)
                    {
                        foreach (Profile p in listProfiles)
                        {
                            if (p != null) ;
                            listPanels.Add(new ProfilePanel(p.name, p.apps));
                        }
                    }
                    return listPanels;
                }
                else
                {
                    using (StreamWriter writetext = new StreamWriter(profilesJSON))
                    {
                        writetext.WriteLine("[]");
                        return listPanels;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listPanels;
            }
        }

        //Creates or rewrites JSON file with saved profiles.
        public void WriteJSONFile()
        {
            List<Profile> listProfiles = new List<Profile>();
            List<AppToDownload> listApps = null;

            foreach (ProfilePanel panel in MainFrame.list_UsersProfiles)
            {
                if (panel != null)
                    listApps = new List<AppToDownload>();

                foreach (AppToDownload app in panel.list_ProfileApps)
                {
                    var a = (AppToDownload)app.Clone();
                    listApps.Add(a);
                }
                listProfiles.Add(new Profile(panel.name_Profile, listApps));
            }

            string output = JsonConvert.SerializeObject(listProfiles);
            using (StreamWriter writetext = new StreamWriter(profilesJSON))
            {
                writetext.WriteLine(output);
            }
        }
    }
}
