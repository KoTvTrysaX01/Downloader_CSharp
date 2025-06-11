using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Downloader_Framework
{
    public partial class MainFrame : Form
    {
        public static List<ProfilePanel> list_UsersProfiles = new List<ProfilePanel>();
        public static List<AppToDownload> list_SelectedApps = new List<AppToDownload>();
        public static List<AppButton> list_AppButtons = new List<AppButton>();
        Connection connection = new Connection();

        public static Color color1 = Color.FromArgb(255, 255, 255);
        public static Color color2 = Color.FromArgb(147, 184, 250);
        public static Color color3 = Color.FromArgb(53, 206, 252);
        public static Color color4 = Color.FromArgb(65, 105, 225);
        public static Color color5 = Color.FromArgb(0, 0, 205);
        public static Color color6 = Color.FromArgb(1, 11, 143);
        public static Color color7 = Color.FromArgb(250, 118, 102);

        public static Font font1 = new Font("Arial", 20, FontStyle.Bold);
        public static Font font2 = new Font("Arial", 25, FontStyle.Bold);
        public static Font font3 = new Font("Arial", 8, FontStyle.Regular);
        public static Font font4 = new Font("Segou UI", 18, FontStyle.Regular);
        
        

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
            AppendTextToConsole("Checking connection...");
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
                btn_StartDownload.Enabled = false;
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

        private void ReadSavedProfiles(List<ProfilePanel> listOfProfiles)
        {
            int counter = 0;
            foreach (ProfilePanel panel in listOfProfiles)
            {
                if(counter < 5)
                {
                    flowpnl_YourProfiles.Controls.Add(panel);
                }
                counter++;
            }
            AppendTextToConsole(counter > 0 ? $"{counter} profiles found in json file." : "No profiles found in json file.");
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
                list_UsersProfiles.Add(new ProfilePanel("", list_SelectedApps));
                flowpnl_YourProfiles.Controls.Add(list_UsersProfiles.Last());
                AppendTextToConsole($"Created new profile with: {list_SelectedApps.Count} apps.");
            }
        }

        static public void DeleteProfile_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var id_number = button.Tag;
            //int id_number = (int)button.Tag;
                                                                        //p.id_number
            ProfilePanel profile = list_UsersProfiles.FirstOrDefault(p => p.Tag == id_number);
            if (profile != null)
            {
                button.Dispose();
                AppendTextToConsole($"Removed profile: {profile.name_Profile}");
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
            if(list_SelectedApps.Count != 0)
            {
                list_SelectedApps.Clear();

                foreach (AppButton appButton in list_AppButtons)
                {
                    appButton.BackColor = MainFrame.color2;
                }
                UpdateSelectedAppsPanel();
                UpdateSelectedApps();
                AppendTextToConsole("Cleared all selected apps.");
            }
            else
            {
                AppendTextToConsole("Nothing to clear");
            }
            
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

        public void label_Paint(object sender, PaintEventArgs e)
        {
            Label l = sender as Label;
            ControlPaint.DrawBorder(e.Graphics, l.DisplayRectangle, color1, ButtonBorderStyle.Solid);
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            FlowLayoutPanel p = sender as FlowLayoutPanel;
            ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle, color5, ButtonBorderStyle.Solid);
        }



        private void FocusOnButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = color2;
        }
        private void LeaveButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = color4;
        }

        public static string GenerateRandomNumbersForID()
        {
            Random rnd = new Random();
            int num1 = rnd.Next(100);
            int num2 = rnd.Next(100);
            int num3 = rnd.Next(100);
            return $"{num1}{num2}{num3}";

        }
 
        private void MainFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.WriteJSONFile();
        }
    }
}