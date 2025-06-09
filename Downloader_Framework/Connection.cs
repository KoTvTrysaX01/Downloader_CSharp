using System.Data;
using System.Text;
using Microsoft.Data.Sqlite;
using System.Net.Sockets;
using Renci.SshNet;
using Newtonsoft.Json;
using Renci.SshNet.Sftp;
using System.Diagnostics;
using Downloader_Framework;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System;
using System.Drawing;

namespace Downloader_Framework
{
    public class Connection
    {
        public List<AppToDownload> ReadTable()
        {
            List<AppToDownload> listApps = new List<AppToDownload>();
            string source = "Data source = 'C:\\Users\\elshi\\Desktop\\Downloader_DB.db'";

            using (var conn = new SqliteConnection(source))
            {
                conn.Open();
                using (SqliteCommand cmd = new SqliteCommand("Select * from AppToDownload", conn))
                {
                    cmd.Connection = conn;
                    using (SqliteDataReader reader = cmd.ExecuteReader())
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

        public bool PingHost()
        {
            try
            {
                using (var client = new TcpClient())
                {
                    var result = client.BeginConnect("79.112.50.56", 22, null, null);
                    var success = result.AsyncWaitHandle.WaitOne(5000);
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

        public void DownloadApps(List<AppToDownload> listApps, string SourcePath, bool tryInstall)
        {
            try
            {
                int Port = 22;
                string Host = "79.112.50.56";
                string Username = "vadim";
                string Password = "123";
                string RemotePath = "Files/";

                foreach (AppToDownload app in listApps)
                {
                    string SourceFilePath = SourcePath + "\\" + app.fileName;
                    using (var stream = new FileStream(SourceFilePath, FileMode.Create))
                    using (var client = new SftpClient(Host, Port, Username, Password))
                    {
                        client.Connect();
                        string RemoteFilePath = RemotePath + app.fileName;
                        SftpFileAttributes attrs = client.GetAttributes(RemoteFilePath);
                        // Set progress bar maximum on foreground thread
                        int max = (int)attrs.Size;
                        MainFrame.progbar_DownloadPrc.Invoke(
                            (MethodInvoker)delegate { MainFrame.progbar_DownloadPrc.Maximum = max; });
                        // Download with progress callback
                        client.DownloadFile(RemoteFilePath, stream, DownloadProgresBar);
                    }
                    if (tryInstall && app.commandLine != null)
                    {
                        InstallApps(SourceFilePath, app.commandLine);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

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

        public void InstallApps(string filePath, string fileCommand)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = filePath;
                process.StartInfo.Arguments = fileCommand;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.Start();
                process.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<UsersProfile> ReadJSONFile()
        {
            List<Profile> listProfiles = JsonConvert.DeserializeObject<List<Profile>>(File.ReadAllText("C:\\Users\\elshi\\Desktop\\Downloader C#\\Project\\Downloader\\Downloader\\json.txt"));
            List<UsersProfile> listPanels = new List<UsersProfile>();
            if (listProfiles != null)
            {
                foreach (Profile p in listProfiles)
                {
                    if (p != null) ;
                    listPanels.Add(new UsersProfile(p.name, p.apps));
                }
            }
            return listPanels;
        }


        public void WriteJSONFile()
        {
            List<Profile> listProfiles = new List<Profile>();
            List<AppToDownload> listApps = null;

            foreach (UsersProfile panel in MainFrame.list_UsersProfiles)
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

            using (StreamWriter writetext = new StreamWriter("C:\\Users\\elshi\\Desktop\\Downloader C#\\Project\\Downloader\\Downloader\\json.txt"))
            {
                writetext.WriteLine(output);
            }
        }


        public static Image ConvertSqlToImage(string appName)
        {
            Image image = null;
            string source = "Data source = 'C:\\Users\\elshi\\Desktop\\Downloader_DB.db'";

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
    }
}
