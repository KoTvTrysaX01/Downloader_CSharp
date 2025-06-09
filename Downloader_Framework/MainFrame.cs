using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Downloader_Framework
{
    public partial class MainFrame : Form
    {
        public static List<UsersProfile> list_UsersProfiles = new List<UsersProfile>();
        public static List<AppToDownload> list_SelectedApps = new List<AppToDownload>();
        public static List<AppButton> list_AppButtons = new List<AppButton>();
        Connection connection = new Connection();

        public MainFrame()
        {
            InitializeComponent();
            List<AppToDownload> list_AppsOfDB = connection.ReadTable();
            list_UsersProfiles = connection.ReadJSONFile();

            ReadSavedProfiles(list_UsersProfiles);

            foreach (AppToDownload app in list_AppsOfDB)
            {
                switch (app.section)
                {
                    case "Browsers":
                        flowpnl_Browsers.Controls.Add(new AppButton(app));
                        foreach (AppButton appButton in flowpnl_Browsers.Controls)
                        {
                            list_AppButtons.Add(appButton);
                        }
                        break;

                    case "Launchers":
                        flowpnl_Launchers.Controls.Add(new AppButton(app));
                        foreach (AppButton appButton in flowpnl_Launchers.Controls)
                        {
                            list_AppButtons.Add(appButton);
                        }
                        break;

                    case "Media":
                        flowpnl_Media.Controls.Add(new AppButton(app));
                        foreach (AppButton appButton in flowpnl_Media.Controls)
                        {
                            list_AppButtons.Add(appButton);
                        }
                        break;

                    case "Programming":
                        flowpnl_Programming.Controls.Add(new AppButton(app));
                        foreach (AppButton appButton in flowpnl_Programming.Controls)
                        {
                            list_AppButtons.Add(appButton);
                        }
                        break;

                    case "Communication":
                        flowpnl_Communication.Controls.Add(new AppButton(app));
                        foreach (AppButton appButton in flowpnl_Communication.Controls)
                        {
                            list_AppButtons.Add(appButton);
                        }
                        break;

                    case "Overview":
                        flowpnl_Overview.Controls.Add(new AppButton(app));
                        foreach (AppButton appButton in flowpnl_Overview.Controls)
                        {
                            list_AppButtons.Add(appButton);
                        }
                        break;

                    case "Tests":
                        flowpnl_Tests.Controls.Add(new AppButton(app));
                        foreach (AppButton appButton in flowpnl_Tests.Controls)
                        {
                            list_AppButtons.Add(appButton);
                        }
                        break;

                    case "Network":
                        flowpnl_Network.Controls.Add(new AppButton(app));
                        foreach (AppButton appButton in flowpnl_Network.Controls)
                        {
                            list_AppButtons.Add(appButton);
                        }
                        break;

                    case "OSs & ISOs":
                        flowpnl_OSsAndISOs.Controls.Add(new AppButton(app));
                        foreach (AppButton appButton in flowpnl_OSsAndISOs.Controls)
                        {
                            list_AppButtons.Add(appButton);
                        }
                        break;

                    case "Disk":
                        flowpnl_Disk.Controls.Add(new AppButton(app));
                        foreach (AppButton appButton in flowpnl_Disk.Controls)
                        {
                            list_AppButtons.Add(appButton);
                        }
                        break;

                    case "Protection":
                        flowpnl_Protection.Controls.Add(new AppButton(app));
                        foreach (AppButton appButton in flowpnl_Protection.Controls)
                        {
                            list_AppButtons.Add(appButton);
                        }
                        break;

                    case "Other apps":
                        flowpnl_OtherApps.Controls.Add(new AppButton(app));
                        foreach (AppButton appButton in flowpnl_OtherApps.Controls)
                        {
                            list_AppButtons.Add(appButton);
                        }
                        break;

                    case "Archives":
                        flowpnl_Archives.Controls.Add(new AppButton(app));
                        foreach (AppButton appButton in flowpnl_Archives.Controls)
                        {
                            list_AppButtons.Add(appButton);
                        }
                        break;

                    default:
                        MessageBox.Show("Error: \"" + app.section + "\" section is not provided by the system.");
                        break;
                }
            }

        }

        private void btn_CheckCon_Click(object sender, EventArgs e)
        {
            Task.Run(() => connection.PingHost());
        }

        private async void btn_StartDownload_Click(object sender, EventArgs e)
        {
            if (MainFrame.list_SelectedApps.Count <= 0)
            {
                AppendTextToConsole("You must select at least 1 app.");
            }
            else if (txtbox_DestFolder.Texts.ToString() == "")
            {
                AppendTextToConsole("You must provide the destination folder.");
            }
            else
            {
                Task.Run(() => connection.DownloadApps(MainFrame.list_SelectedApps, txtbox_DestFolder.Texts, chkbox_TryInstall.Checked));
            }

        }


        private void btn_Apps_Click(object sender, EventArgs e)
        {
            tabpage_Apps.Visible = true;
            tabpage_Tools.Visible = false;
            tabpage_Other.Visible = false;
            pnl_Profiles.Visible = false;
            pnl_Download.Visible = false;
        }

        private void btn_Tools_Click(object sender, EventArgs e)
        {
            tabpage_Apps.Visible = false;
            tabpage_Tools.Visible = true;
            tabpage_Other.Visible = false;
            pnl_Profiles.Visible = false;
            pnl_Download.Visible = false;
        }

        private void btn_Other_apps_Click(object sender, EventArgs e)
        {
            tabpage_Apps.Visible = false;
            tabpage_Tools.Visible = false;
            tabpage_Other.Visible = true;
            pnl_Profiles.Visible = false;
            pnl_Download.Visible = false;
        }

        private void btn_Profiles_Click(object sender, EventArgs e)
        {
            tabpage_Apps.Visible = false;
            tabpage_Tools.Visible = false;
            tabpage_Other.Visible = false;
            pnl_Profiles.Visible = true;
            pnl_Download.Visible = false;
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            tabpage_Apps.Visible = false;
            tabpage_Tools.Visible = false;
            tabpage_Other.Visible = false;
            pnl_Profiles.Visible = false;
            pnl_Download.Visible = true;
            UpdateSelectedAppsPanel();

        }

        private void ReadSavedProfiles(List<UsersProfile> listOfProfiles)
        {
            if (listOfProfiles.Count > 0)
            {
                foreach (UsersProfile panel in listOfProfiles)
                {
                    flowpnl_YourProfiles.Controls.Add(panel);
                }
            }
        }

        public static void AppendTextToConsole(string message)
        {
            richtxtbox_Console.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": " + message + "\n");
        }

        private void AddProfile_btn_Click(object sender, EventArgs e)
        {
            if (list_UsersProfiles.Count >= 5)
            {
                AppendTextToConsole("You reached the maximun ammount of Profiles.");
            }
            else if (list_SelectedApps.Count <= 0)
            {
                AppendTextToConsole("You must select at least 1 app to create a Profile.");
            }
            else
            {
                list_UsersProfiles.Add(new UsersProfile("", list_SelectedApps));
                flowpnl_YourProfiles.Controls.Add(list_UsersProfiles.Last());
            }
        }

        static public void DeleteProfile_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int id_number = (int)button.Tag;

            UsersProfile profile = list_UsersProfiles.FirstOrDefault(p => p.id_Number == id_number);
            if (profile != null)
            {
                button.Dispose();
                list_UsersProfiles.Remove(profile);
                profile.Dispose();
            }
        }

        private void btn_BrowseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtbox_DestFolder.Texts = dialog.SelectedPath;
            }
            else
            {
                AppendTextToConsole("You didn't select the folder!");
            }
        }

        private void btn_ClearAll_Click(object sender, EventArgs e)
        {
            list_SelectedApps.Clear();

            foreach (AppButton appButton in list_AppButtons)
            {
                appButton.FlatAppearance.BorderColor = Color.Green;
            }
            UpdateSelectedAppsPanel();
            UpdateSelectedApps();
        }

        private void UpdateSelectedAppsPanel()
        {
            flowpnl_SelectedApps.Controls.Clear();
            foreach (AppToDownload app in list_SelectedApps)
            {
                Label lbl = new Label();
                lbl.AutoSize = false;
                lbl.Size = new Size(20, 20);
                lbl.FlatStyle = FlatStyle.Standard;
                lbl.BackColor = Color.Red;
                lbl.Image = ResizeImage(app.GetIcon(), 20, 20);
                lbl.Margin = new Padding(3);

                flowpnl_SelectedApps.Controls.Add(lbl);
            }
        }


        public static Bitmap MyBytesToImage(byte[] bytes)
        {
            using (var ms = new MemoryStream(bytes))
            {
                Image img = Image.FromStream(ms);
                return ResizeImage(Image.FromStream(ms), 50, 50);
            }
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return destImage;
        }

        private void MainFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.WriteJSONFile();
        }

        public static void CompareButtonAndApp(string appName)
        {
            foreach (AppToDownload app in list_SelectedApps.ToList())
            {
                if (app.appName == appName)
                {
                    list_SelectedApps.Remove(app);
                }
            }
        }

        public static void UpdateSelectedApps()
        {
            lbl_CurApps.Text = $"Selected apps: {list_SelectedApps.Count}";
        }
    }
}