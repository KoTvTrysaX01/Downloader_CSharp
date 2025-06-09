using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Downloader_Framework
{
    partial class MainFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tablepnl_TopPanel = new TableLayoutPanel();
            lbl_Author = new Label();
            lbl_PrgName = new Label();
            lbl_ImageStatus = new Label();
            btn_CheckCon = new System.Windows.Forms.Button();
            tablepnl_LeftPanel = new TableLayoutPanel();
            btn_Profiles = new System.Windows.Forms.Button();
            btn_Other = new System.Windows.Forms.Button();
            btn_Tools = new System.Windows.Forms.Button();
            btn_Apps = new System.Windows.Forms.Button();
            btn_Download = new System.Windows.Forms.Button();
            tablepnl_Console = new TableLayoutPanel();
            richtxtbox_Console = new RichTextBox();
            lbl_CurApps = new Label();
            tabpage_Apps = new TabControl();
            tab_Browsers = new TabPage();
            flowpnl_Browsers = new FlowLayoutPanel();
            tab_Launchers = new TabPage();
            flowpnl_Launchers = new FlowLayoutPanel();
            tab_Media = new TabPage();
            flowpnl_Media = new FlowLayoutPanel();
            tab_Communication = new TabPage();
            flowpnl_Communication = new FlowLayoutPanel();
            tab_Programming = new TabPage();
            flowpnl_Programming = new FlowLayoutPanel();
            tab_Overview = new TabPage();
            flowpnl_Overview = new FlowLayoutPanel();
            tab_Tests = new TabPage();
            flowpnl_Tests = new FlowLayoutPanel();
            tab_Network = new TabPage();
            flowpnl_Network = new FlowLayoutPanel();
            tab_OSsAndISOs = new TabPage();
            flowpnl_OSsAndISOs = new FlowLayoutPanel();
            tab_Disk = new TabPage();
            flowpnl_Disk = new FlowLayoutPanel();
            tab_Protection = new TabPage();
            flowpnl_Protection = new FlowLayoutPanel();
            tab_OtherApps = new TabPage();
            flowpnl_OtherApps = new FlowLayoutPanel();
            tab_Archives = new TabPage();
            flowpnl_Archives = new FlowLayoutPanel();
            tabpage_Tools = new TabControl();
            tabpage_Other = new TabControl();
            pnl_Profiles = new Panel();
            btn_AddProfile = new System.Windows.Forms.Button();
            flowpnl_YourProfiles = new FlowLayoutPanel();
            lbl_YourProfiles = new Label();
            pnl_Download = new Panel();
            pnl_DownloadProc = new Panel();
            btn_StartDownload = new MyButton();
            lbl_ProgPer = new Label();
            lbl_DownloadFile = new Label();
            progbar_DownloadPrc = new System.Windows.Forms.ProgressBar();
            pnl_DestFolder = new Panel();
            lbl_TryInstall = new Label();
            chkbox_TryInstall = new MyToggleButton();
            btn_BrowseFolder = new MyButton();
            txtbox_DestFolder = new MyTextBox();
            pnl_SelectedApps = new Panel();
            lbl_SelectedApps = new Label();
            flowpnl_SelectedApps = new FlowLayoutPanel();
            btn_ClearAll = new MyButton();
            tablepnl_TopPanel.SuspendLayout();
            tablepnl_LeftPanel.SuspendLayout();
            tablepnl_Console.SuspendLayout();
            tabpage_Apps.SuspendLayout();
            tab_Browsers.SuspendLayout();
            tab_Launchers.SuspendLayout();
            tab_Media.SuspendLayout();
            tab_Communication.SuspendLayout();
            tab_Programming.SuspendLayout();
            tab_Overview.SuspendLayout();
            tab_Tests.SuspendLayout();
            tab_Network.SuspendLayout();
            tab_OSsAndISOs.SuspendLayout();
            tab_Disk.SuspendLayout();
            tab_Protection.SuspendLayout();
            tab_OtherApps.SuspendLayout();
            tab_Archives.SuspendLayout();
            tabpage_Tools.SuspendLayout();
            tabpage_Other.SuspendLayout();
            pnl_Profiles.SuspendLayout();
            pnl_Download.SuspendLayout();
            pnl_DownloadProc.SuspendLayout();
            pnl_DestFolder.SuspendLayout();
            pnl_SelectedApps.SuspendLayout();
            SuspendLayout();
            // 
            // tablepnl_TopPanel
            // 
            tablepnl_TopPanel.BackColor = Color.CornflowerBlue;
            tablepnl_TopPanel.ColumnCount = 4;
            tablepnl_TopPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.80428F));
            tablepnl_TopPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.19572F));
            tablepnl_TopPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 314F));
            tablepnl_TopPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tablepnl_TopPanel.Controls.Add(lbl_Author, 1, 0);
            tablepnl_TopPanel.Controls.Add(lbl_PrgName, 0, 0);
            tablepnl_TopPanel.Controls.Add(lbl_ImageStatus, 3, 0);
            tablepnl_TopPanel.Controls.Add(btn_CheckCon, 2, 0);
            tablepnl_TopPanel.Location = new Point(14, 14);
            tablepnl_TopPanel.Margin = new Padding(4, 3, 4, 3);
            tablepnl_TopPanel.Name = "tablepnl_TopPanel";
            tablepnl_TopPanel.RowCount = 1;
            tablepnl_TopPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablepnl_TopPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablepnl_TopPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tablepnl_TopPanel.Size = new Size(1257, 61);
            tablepnl_TopPanel.TabIndex = 0;
            // 
            // lbl_Author
            // 
            lbl_Author.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl_Author.AutoSize = true;
            lbl_Author.BackColor = Color.DeepSkyBlue;
            lbl_Author.BorderStyle = BorderStyle.Fixed3D;
            lbl_Author.FlatStyle = FlatStyle.Flat;
            lbl_Author.Font = new Font("Arial Narrow", 21F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbl_Author.ForeColor = Color.Navy;
            lbl_Author.Location = new Point(283, 10);
            lbl_Author.Margin = new Padding(6, 0, 6, 0);
            lbl_Author.Name = "lbl_Author";
            lbl_Author.Padding = new Padding(0, 3, 0, 3);
            lbl_Author.Size = new Size(583, 41);
            lbl_Author.TabIndex = 4;
            lbl_Author.Text = "VADIM ELSHIN | DAW 1 | IES DOCTOR BALMIS";
            lbl_Author.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_PrgName
            // 
            lbl_PrgName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl_PrgName.AutoSize = true;
            lbl_PrgName.BackColor = Color.Navy;
            lbl_PrgName.BorderStyle = BorderStyle.Fixed3D;
            lbl_PrgName.FlatStyle = FlatStyle.Flat;
            lbl_PrgName.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbl_PrgName.ForeColor = Color.White;
            lbl_PrgName.Location = new Point(6, 10);
            lbl_PrgName.Margin = new Padding(6, 0, 6, 0);
            lbl_PrgName.Name = "lbl_PrgName";
            lbl_PrgName.Padding = new Padding(0, 3, 0, 3);
            lbl_PrgName.Size = new Size(265, 41);
            lbl_PrgName.TabIndex = 0;
            lbl_PrgName.Text = "DOWNLOADER";
            lbl_PrgName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_ImageStatus
            // 
            lbl_ImageStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl_ImageStatus.Image = new Bitmap(Properties.Resources.neutral, new Size(50, 50));
            lbl_ImageStatus.Location = new Point(1190, 3);
            lbl_ImageStatus.Margin = new Padding(4, 0, 4, 0);
            lbl_ImageStatus.Name = "lbl_ImageStatus";
            lbl_ImageStatus.Size = new Size(63, 54);
            lbl_ImageStatus.TabIndex = 3;
            lbl_ImageStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_CheckCon
            // 
            btn_CheckCon.Anchor = AnchorStyles.None;
            btn_CheckCon.BackColor = Color.MediumBlue;
            btn_CheckCon.Cursor = Cursors.Hand;
            btn_CheckCon.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            btn_CheckCon.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn_CheckCon.ForeColor = Color.White;
            btn_CheckCon.Location = new Point(881, 6);
            btn_CheckCon.Margin = new Padding(4, 3, 4, 3);
            btn_CheckCon.Name = "btn_CheckCon";
            btn_CheckCon.Padding = new Padding(0, 3, 0, 3);
            btn_CheckCon.Size = new Size(296, 48);
            btn_CheckCon.TabIndex = 2;
            btn_CheckCon.Text = "CHECK CONNECTION";
            btn_CheckCon.UseVisualStyleBackColor = false;
            btn_CheckCon.Click += btn_CheckCon_Click;
            // 
            // tablepnl_LeftPanel
            // 
            tablepnl_LeftPanel.BackColor = Color.Navy;
            tablepnl_LeftPanel.ColumnCount = 1;
            tablepnl_LeftPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablepnl_LeftPanel.Controls.Add(btn_Profiles, 0, 3);
            tablepnl_LeftPanel.Controls.Add(btn_Other, 0, 2);
            tablepnl_LeftPanel.Controls.Add(btn_Tools, 0, 1);
            tablepnl_LeftPanel.Controls.Add(btn_Apps, 0, 0);
            tablepnl_LeftPanel.Controls.Add(btn_Download, 0, 4);
            tablepnl_LeftPanel.Location = new Point(14, 93);
            tablepnl_LeftPanel.Margin = new Padding(4, 3, 4, 3);
            tablepnl_LeftPanel.Name = "tablepnl_LeftPanel";
            tablepnl_LeftPanel.RowCount = 5;
            tablepnl_LeftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tablepnl_LeftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tablepnl_LeftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tablepnl_LeftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tablepnl_LeftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tablepnl_LeftPanel.Size = new Size(260, 421);
            tablepnl_LeftPanel.TabIndex = 1;
            // 
            // btn_Profiles
            // 
            btn_Profiles.Anchor = AnchorStyles.None;
            btn_Profiles.Font = new Font("Arial Narrow", 28F, FontStyle.Bold);
            btn_Profiles.Location = new Point(16, 264);
            btn_Profiles.Margin = new Padding(4, 3, 4, 3);
            btn_Profiles.Name = "btn_Profiles";
            btn_Profiles.Size = new Size(227, 60);
            btn_Profiles.TabIndex = 3;
            btn_Profiles.Text = "PROFILES";
            btn_Profiles.UseVisualStyleBackColor = true;
            btn_Profiles.Click += btn_Profiles_Click;
            // 
            // btn_Other
            // 
            btn_Other.Anchor = AnchorStyles.None;
            btn_Other.Font = new Font("Arial Narrow", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn_Other.Location = new Point(16, 180);
            btn_Other.Margin = new Padding(4, 3, 4, 3);
            btn_Other.Name = "btn_Other";
            btn_Other.Size = new Size(227, 60);
            btn_Other.TabIndex = 2;
            btn_Other.Text = "OTHER";
            btn_Other.UseVisualStyleBackColor = true;
            btn_Other.Click += btn_Other_apps_Click;
            // 
            // btn_Tools
            // 
            btn_Tools.Anchor = AnchorStyles.None;
            btn_Tools.Font = new Font("Arial Narrow", 28F, FontStyle.Bold);
            btn_Tools.Location = new Point(16, 96);
            btn_Tools.Margin = new Padding(4, 3, 4, 3);
            btn_Tools.Name = "btn_Tools";
            btn_Tools.Size = new Size(227, 60);
            btn_Tools.TabIndex = 1;
            btn_Tools.Text = "TOOLS";
            btn_Tools.UseVisualStyleBackColor = true;
            btn_Tools.Click += btn_Tools_Click;
            // 
            // btn_Apps
            // 
            btn_Apps.Anchor = AnchorStyles.None;
            btn_Apps.Cursor = Cursors.Hand;
            btn_Apps.Font = new Font("Arial Narrow", 28F, FontStyle.Bold);
            btn_Apps.Location = new Point(16, 12);
            btn_Apps.Margin = new Padding(4, 3, 4, 3);
            btn_Apps.Name = "btn_Apps";
            btn_Apps.Size = new Size(227, 60);
            btn_Apps.TabIndex = 0;
            btn_Apps.Text = "APPS";
            btn_Apps.UseVisualStyleBackColor = true;
            btn_Apps.Click += btn_Apps_Click;
            // 
            // btn_Download
            // 
            btn_Download.Anchor = AnchorStyles.None;
            btn_Download.Font = new Font("Arial Narrow", 28F, FontStyle.Bold);
            btn_Download.Location = new Point(16, 348);
            btn_Download.Margin = new Padding(4, 3, 4, 3);
            btn_Download.Name = "btn_Download";
            btn_Download.Size = new Size(227, 60);
            btn_Download.TabIndex = 4;
            btn_Download.Text = "DOWNLOAD";
            btn_Download.UseVisualStyleBackColor = true;
            btn_Download.Click += btn_Download_Click;
            // 
            // tablepnl_Console
            // 
            tablepnl_Console.BackColor = Color.RoyalBlue;
            tablepnl_Console.ColumnCount = 1;
            tablepnl_Console.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablepnl_Console.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablepnl_Console.Controls.Add(richtxtbox_Console, 0, 1);
            tablepnl_Console.Controls.Add(lbl_CurApps, 0, 0);
            tablepnl_Console.Location = new Point(14, 531);
            tablepnl_Console.Margin = new Padding(4, 3, 4, 3);
            tablepnl_Console.Name = "tablepnl_Console";
            tablepnl_Console.RowCount = 2;
            tablepnl_Console.RowStyles.Add(new RowStyle(SizeType.Percent, 16.83502F));
            tablepnl_Console.RowStyles.Add(new RowStyle(SizeType.Percent, 83.16499F));
            tablepnl_Console.Size = new Size(260, 268);
            tablepnl_Console.TabIndex = 2;
            // 
            // richtxtbox_Console
            // 
            richtxtbox_Console.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richtxtbox_Console.Location = new Point(4, 48);
            richtxtbox_Console.Margin = new Padding(4, 3, 4, 3);
            richtxtbox_Console.Name = "richtxtbox_Console";
            richtxtbox_Console.ReadOnly = true;
            richtxtbox_Console.Size = new Size(252, 217);
            richtxtbox_Console.TabIndex = 1;
            richtxtbox_Console.Text = "";
            // 
            // lbl_CurApps
            // 
            lbl_CurApps.Anchor = AnchorStyles.None;
            lbl_CurApps.AutoSize = true;
            lbl_CurApps.BackColor = Color.DarkBlue;
            lbl_CurApps.Font = new Font("Arial", 18.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbl_CurApps.ForeColor = Color.White;
            lbl_CurApps.Location = new Point(0, 1);
            lbl_CurApps.Margin = new Padding(0);
            lbl_CurApps.Name = "lbl_CurApps";
            lbl_CurApps.Padding = new Padding(29, 7, 29, 7);
            lbl_CurApps.Size = new Size(259, 42);
            lbl_CurApps.TabIndex = 0;
            lbl_CurApps.Text = "Selected apps: 0";
            lbl_CurApps.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabpage_Apps
            // 
            tabpage_Apps.Appearance = TabAppearance.Buttons;
            tabpage_Apps.Controls.Add(tab_Browsers);
            tabpage_Apps.Controls.Add(tab_Launchers);
            tabpage_Apps.Controls.Add(tab_Media);
            tabpage_Apps.Controls.Add(tab_Communication);
            tabpage_Apps.Controls.Add(tab_Programming);
            tabpage_Apps.Location = new Point(295, 93);
            tabpage_Apps.Name = "tabpage_Apps";
            tabpage_Apps.SelectedIndex = 0;
            tabpage_Apps.Size = new Size(976, 706);
            tabpage_Apps.TabIndex = 3;
            tabpage_Apps.Visible = false;
            // 
            // tab_Browsers
            // 
            tab_Browsers.Controls.Add(flowpnl_Browsers);
            tab_Browsers.Location = new Point(4, 27);
            tab_Browsers.Name = "tab_Browsers";
            tab_Browsers.Padding = new Padding(3);
            tab_Browsers.Size = new Size(968, 675);
            tab_Browsers.TabIndex = 0;
            tab_Browsers.Text = "Browsers";
            tab_Browsers.UseVisualStyleBackColor = true;
            // 
            // flowpnl_Browsers
            // 
            flowpnl_Browsers.Location = new Point(6, 6);
            flowpnl_Browsers.Name = "flowpnl_Browsers";
            flowpnl_Browsers.Padding = new Padding(5);
            flowpnl_Browsers.Size = new Size(956, 663);
            flowpnl_Browsers.TabIndex = 0;
            // 
            // tab_Launchers
            // 
            tab_Launchers.Controls.Add(flowpnl_Launchers);
            tab_Launchers.Location = new Point(4, 27);
            tab_Launchers.Name = "tab_Launchers";
            tab_Launchers.Padding = new Padding(3);
            tab_Launchers.Size = new Size(968, 675);
            tab_Launchers.TabIndex = 1;
            tab_Launchers.Text = "Launchers";
            tab_Launchers.UseVisualStyleBackColor = true;
            // 
            // flowpnl_Launchers
            // 
            flowpnl_Launchers.Location = new Point(6, 6);
            flowpnl_Launchers.Name = "flowpnl_Launchers";
            flowpnl_Launchers.Padding = new Padding(5);
            flowpnl_Launchers.Size = new Size(956, 663);
            flowpnl_Launchers.TabIndex = 1;
            // 
            // tab_Media
            // 
            tab_Media.Controls.Add(flowpnl_Media);
            tab_Media.Location = new Point(4, 27);
            tab_Media.Name = "tab_Media";
            tab_Media.Padding = new Padding(3);
            tab_Media.Size = new Size(968, 675);
            tab_Media.TabIndex = 2;
            tab_Media.Text = "Media";
            tab_Media.UseVisualStyleBackColor = true;
            // 
            // flowpnl_Media
            // 
            flowpnl_Media.Location = new Point(6, 6);
            flowpnl_Media.Name = "flowpnl_Media";
            flowpnl_Media.Padding = new Padding(5);
            flowpnl_Media.Size = new Size(956, 663);
            flowpnl_Media.TabIndex = 1;
            // 
            // tab_Communication
            // 
            tab_Communication.Controls.Add(flowpnl_Communication);
            tab_Communication.Location = new Point(4, 27);
            tab_Communication.Name = "tab_Communication";
            tab_Communication.Padding = new Padding(3);
            tab_Communication.Size = new Size(968, 675);
            tab_Communication.TabIndex = 3;
            tab_Communication.Text = "Communication";
            tab_Communication.UseVisualStyleBackColor = true;
            // 
            // flowpnl_Communication
            // 
            flowpnl_Communication.Location = new Point(6, 6);
            flowpnl_Communication.Name = "flowpnl_Communication";
            flowpnl_Communication.Padding = new Padding(5);
            flowpnl_Communication.Size = new Size(956, 663);
            flowpnl_Communication.TabIndex = 1;
            // 
            // tab_Programming
            // 
            tab_Programming.Controls.Add(flowpnl_Programming);
            tab_Programming.Location = new Point(4, 27);
            tab_Programming.Name = "tab_Programming";
            tab_Programming.Padding = new Padding(3);
            tab_Programming.Size = new Size(968, 675);
            tab_Programming.TabIndex = 4;
            tab_Programming.Text = "Programming";
            tab_Programming.UseVisualStyleBackColor = true;
            // 
            // flowpnl_Programming
            // 
            flowpnl_Programming.Location = new Point(6, 6);
            flowpnl_Programming.Name = "flowpnl_Programming";
            flowpnl_Programming.Padding = new Padding(5);
            flowpnl_Programming.Size = new Size(956, 663);
            flowpnl_Programming.TabIndex = 1;
            // 
            // tab_Overview
            // 
            tab_Overview.Controls.Add(flowpnl_Overview);
            tab_Overview.Location = new Point(4, 27);
            tab_Overview.Name = "tab_Overview";
            tab_Overview.Padding = new Padding(3);
            tab_Overview.Size = new Size(968, 675);
            tab_Overview.TabIndex = 0;
            tab_Overview.Text = "Overview";
            tab_Overview.UseVisualStyleBackColor = true;
            // 
            // flowpnl_Overview
            // 
            flowpnl_Overview.Location = new Point(6, 6);
            flowpnl_Overview.Name = "flowpnl_Overview";
            flowpnl_Overview.Padding = new Padding(5);
            flowpnl_Overview.Size = new Size(956, 663);
            flowpnl_Overview.TabIndex = 1;
            // 
            // tab_Tests
            // 
            tab_Tests.Controls.Add(flowpnl_Tests);
            tab_Tests.Location = new Point(4, 27);
            tab_Tests.Name = "tab_Tests";
            tab_Tests.Padding = new Padding(3);
            tab_Tests.Size = new Size(968, 675);
            tab_Tests.TabIndex = 1;
            tab_Tests.Text = "Tests";
            tab_Tests.UseVisualStyleBackColor = true;
            // 
            // flowpnl_Tests
            // 
            flowpnl_Tests.Location = new Point(6, 6);
            flowpnl_Tests.Name = "flowpnl_Tests";
            flowpnl_Tests.Padding = new Padding(5);
            flowpnl_Tests.Size = new Size(956, 663);
            flowpnl_Tests.TabIndex = 1;
            // 
            // tab_Network
            // 
            tab_Network.Controls.Add(flowpnl_Network);
            tab_Network.Location = new Point(4, 27);
            tab_Network.Name = "tab_Network";
            tab_Network.Padding = new Padding(3);
            tab_Network.Size = new Size(968, 675);
            tab_Network.TabIndex = 2;
            tab_Network.Text = "Network";
            tab_Network.UseVisualStyleBackColor = true;
            // 
            // flowpnl_Network
            // 
            flowpnl_Network.Location = new Point(6, 6);
            flowpnl_Network.Name = "flowpnl_Network";
            flowpnl_Network.Padding = new Padding(5);
            flowpnl_Network.Size = new Size(956, 663);
            flowpnl_Network.TabIndex = 1;
            // 
            // tab_OSsAndISOs
            // 
            tab_OSsAndISOs.Controls.Add(flowpnl_OSsAndISOs);
            tab_OSsAndISOs.Location = new Point(4, 27);
            tab_OSsAndISOs.Name = "tab_OSsAndISOs";
            tab_OSsAndISOs.Padding = new Padding(3);
            tab_OSsAndISOs.Size = new Size(968, 675);
            tab_OSsAndISOs.TabIndex = 3;
            tab_OSsAndISOs.Text = "OSs & ISOs";
            tab_OSsAndISOs.UseVisualStyleBackColor = true;
            // 
            // flowpnl_OSsAndISOs
            // 
            flowpnl_OSsAndISOs.Location = new Point(6, 6);
            flowpnl_OSsAndISOs.Name = "flowpnl_OSsAndISOs";
            flowpnl_OSsAndISOs.Padding = new Padding(5);
            flowpnl_OSsAndISOs.Size = new Size(956, 663);
            flowpnl_OSsAndISOs.TabIndex = 1;
            // 
            // tab_Disk
            // 
            tab_Disk.Controls.Add(flowpnl_Disk);
            tab_Disk.Location = new Point(4, 27);
            tab_Disk.Name = "tab_Disk";
            tab_Disk.Padding = new Padding(3);
            tab_Disk.Size = new Size(968, 675);
            tab_Disk.TabIndex = 4;
            tab_Disk.Text = "Disk";
            tab_Disk.UseVisualStyleBackColor = true;
            // 
            // flowpnl_Disk
            // 
            flowpnl_Disk.Location = new Point(6, 6);
            flowpnl_Disk.Name = "flowpnl_Disk";
            flowpnl_Disk.Padding = new Padding(5);
            flowpnl_Disk.Size = new Size(956, 663);
            flowpnl_Disk.TabIndex = 1;
            // 
            // tab_Protection
            // 
            tab_Protection.Controls.Add(flowpnl_Protection);
            tab_Protection.Location = new Point(4, 27);
            tab_Protection.Name = "tab_Protection";
            tab_Protection.Padding = new Padding(3);
            tab_Protection.Size = new Size(968, 675);
            tab_Protection.TabIndex = 5;
            tab_Protection.Text = "Protection";
            tab_Protection.UseVisualStyleBackColor = true;
            // 
            // flowpnl_Protection
            // 
            flowpnl_Protection.Location = new Point(6, 6);
            flowpnl_Protection.Name = "flowpnl_Protection";
            flowpnl_Protection.Padding = new Padding(5);
            flowpnl_Protection.Size = new Size(956, 663);
            flowpnl_Protection.TabIndex = 1;
            // 
            // tab_OtherApps
            // 
            tab_OtherApps.Controls.Add(flowpnl_OtherApps);
            tab_OtherApps.Location = new Point(4, 27);
            tab_OtherApps.Name = "tab_OtherApps";
            tab_OtherApps.Padding = new Padding(3);
            tab_OtherApps.Size = new Size(968, 675);
            tab_OtherApps.TabIndex = 0;
            tab_OtherApps.Text = "Other apps";
            tab_OtherApps.UseVisualStyleBackColor = true;
            // 
            // flowpnl_OtherApps
            // 
            flowpnl_OtherApps.Location = new Point(6, 6);
            flowpnl_OtherApps.Name = "flowpnl_OtherApps";
            flowpnl_OtherApps.Padding = new Padding(5);
            flowpnl_OtherApps.Size = new Size(956, 663);
            flowpnl_OtherApps.TabIndex = 1;
            // 
            // tab_Archives
            // 
            tab_Archives.Controls.Add(flowpnl_Archives);
            tab_Archives.Location = new Point(4, 27);
            tab_Archives.Name = "tab_Archives";
            tab_Archives.Padding = new Padding(3);
            tab_Archives.Size = new Size(968, 675);
            tab_Archives.TabIndex = 1;
            tab_Archives.Text = "Archives";
            tab_Archives.UseVisualStyleBackColor = true;
            // 
            // flowpnl_Archives
            // 
            flowpnl_Archives.Location = new Point(6, 6);
            flowpnl_Archives.Name = "flowpnl_Archives";
            flowpnl_Archives.Padding = new Padding(5);
            flowpnl_Archives.Size = new Size(956, 663);
            flowpnl_Archives.TabIndex = 1;
            // 
            // tabpage_Tools
            // 
            tabpage_Tools.Appearance = TabAppearance.Buttons;
            tabpage_Tools.Controls.Add(tab_Overview);
            tabpage_Tools.Controls.Add(tab_Tests);
            tabpage_Tools.Controls.Add(tab_Network);
            tabpage_Tools.Controls.Add(tab_OSsAndISOs);
            tabpage_Tools.Controls.Add(tab_Disk);
            tabpage_Tools.Controls.Add(tab_Protection);
            tabpage_Tools.Location = new Point(295, 93);
            tabpage_Tools.Name = "tabpage_Tools";
            tabpage_Tools.SelectedIndex = 0;
            tabpage_Tools.Size = new Size(976, 706);
            tabpage_Tools.TabIndex = 0;
            tabpage_Tools.Visible = false;
            // 
            // tabpage_Other
            // 
            tabpage_Other.Appearance = TabAppearance.Buttons;
            tabpage_Other.Controls.Add(tab_OtherApps);
            tabpage_Other.Controls.Add(tab_Archives);
            tabpage_Other.Location = new Point(295, 93);
            tabpage_Other.Name = "tabpage_Other";
            tabpage_Other.SelectedIndex = 0;
            tabpage_Other.Size = new Size(976, 706);
            tabpage_Other.TabIndex = 3;
            tabpage_Other.Visible = false;
            // 
            // pnl_Profiles
            // 
            pnl_Profiles.BackColor = Color.White;
            pnl_Profiles.Controls.Add(btn_AddProfile);
            pnl_Profiles.Controls.Add(flowpnl_YourProfiles);
            pnl_Profiles.Controls.Add(lbl_YourProfiles);
            pnl_Profiles.Location = new Point(295, 93);
            pnl_Profiles.Name = "pnl_Profiles";
            pnl_Profiles.Size = new Size(976, 706);
            pnl_Profiles.TabIndex = 0;
            pnl_Profiles.Visible = false;
            // 
            // btn_AddProfile
            // 
            btn_AddProfile.Location = new Point(775, 11);
            btn_AddProfile.Name = "btn_AddProfile";
            btn_AddProfile.Size = new Size(186, 43);
            btn_AddProfile.TabIndex = 5;
            btn_AddProfile.Text = "Add new profile";
            btn_AddProfile.UseVisualStyleBackColor = true;
            btn_AddProfile.Click += AddProfile_btn_Click;
            // 
            // flowpnl_YourProfiles
            // 
            flowpnl_YourProfiles.BackColor = Color.Yellow;
            flowpnl_YourProfiles.Location = new Point(12, 67);
            flowpnl_YourProfiles.Name = "flowpnl_YourProfiles";
            flowpnl_YourProfiles.Padding = new Padding(10);
            flowpnl_YourProfiles.Size = new Size(949, 625);
            flowpnl_YourProfiles.TabIndex = 1;
            // 
            // lbl_YourProfiles
            // 
            lbl_YourProfiles.BackColor = Color.White;
            lbl_YourProfiles.Location = new Point(12, 11);
            lbl_YourProfiles.Name = "lbl_YourProfiles";
            lbl_YourProfiles.Size = new Size(217, 43);
            lbl_YourProfiles.TabIndex = 0;
            lbl_YourProfiles.Text = "YOUR PROFILES";
            lbl_YourProfiles.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnl_Download
            // 
            pnl_Download.BackColor = Color.White;
            pnl_Download.Controls.Add(pnl_DownloadProc);
            pnl_Download.Controls.Add(pnl_DestFolder);
            pnl_Download.Controls.Add(pnl_SelectedApps);
            pnl_Download.Location = new Point(295, 93);
            pnl_Download.Name = "pnl_Download";
            pnl_Download.Padding = new Padding(10);
            pnl_Download.Size = new Size(976, 706);
            pnl_Download.TabIndex = 0;
            pnl_Download.Visible = false;
            // 
            // pnl_DownloadProc
            // 
            pnl_DownloadProc.BackColor = SystemColors.ActiveCaption;
            pnl_DownloadProc.Controls.Add(btn_StartDownload);
            pnl_DownloadProc.Controls.Add(lbl_ProgPer);
            pnl_DownloadProc.Controls.Add(lbl_DownloadFile);
            pnl_DownloadProc.Controls.Add(progbar_DownloadPrc);
            pnl_DownloadProc.Location = new Point(13, 478);
            pnl_DownloadProc.Name = "pnl_DownloadProc";
            pnl_DownloadProc.Padding = new Padding(10);
            pnl_DownloadProc.Size = new Size(950, 215);
            pnl_DownloadProc.TabIndex = 1;
            // 
            // btn_StartDownload
            // 
            btn_StartDownload.BackColor = Color.MediumSlateBlue;
            btn_StartDownload.BackgroundColor = Color.MediumSlateBlue;
            btn_StartDownload.BorderColor = Color.PaleVioletRed;
            btn_StartDownload.BorderRadius = 20;
            btn_StartDownload.BorderSize = 0;
            btn_StartDownload.FlatAppearance.BorderSize = 0;
            btn_StartDownload.FlatStyle = FlatStyle.Flat;
            btn_StartDownload.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn_StartDownload.ForeColor = Color.White;
            btn_StartDownload.Location = new Point(350, 135);
            btn_StartDownload.Name = "btn_StartDownload";
            btn_StartDownload.Size = new Size(250, 62);
            btn_StartDownload.TabIndex = 8;
            btn_StartDownload.Text = "DOWNLOAD";
            btn_StartDownload.TextColor = Color.White;
            btn_StartDownload.UseVisualStyleBackColor = false;
            btn_StartDownload.Click += btn_StartDownload_Click;
            // 
            // lbl_ProgPer
            // 
            lbl_ProgPer.BackColor = SystemColors.ActiveBorder;
            lbl_ProgPer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbl_ProgPer.Location = new Point(442, 103);
            lbl_ProgPer.Name = "lbl_ProgPer";
            lbl_ProgPer.Size = new Size(70, 23);
            lbl_ProgPer.TabIndex = 9;
            lbl_ProgPer.Text = "0%";
            lbl_ProgPer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_DownloadFile
            // 
            lbl_DownloadFile.BackColor = SystemColors.ActiveBorder;
            lbl_DownloadFile.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbl_DownloadFile.Location = new Point(250, 10);
            lbl_DownloadFile.Name = "lbl_DownloadFile";
            lbl_DownloadFile.Size = new Size(450, 36);
            lbl_DownloadFile.TabIndex = 8;
            lbl_DownloadFile.Text = "Now downloading: \r\n";
            lbl_DownloadFile.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progbar_DownloadPrc
            // 
            progbar_DownloadPrc.Location = new Point(13, 52);
            progbar_DownloadPrc.Name = "progbar_DownloadPrc";
            progbar_DownloadPrc.Size = new Size(924, 48);
            progbar_DownloadPrc.TabIndex = 0;
            // 
            // pnl_DestFolder
            // 
            pnl_DestFolder.BackColor = SystemColors.ActiveCaption;
            pnl_DestFolder.Controls.Add(lbl_TryInstall);
            pnl_DestFolder.Controls.Add(chkbox_TryInstall);
            pnl_DestFolder.Controls.Add(btn_BrowseFolder);
            pnl_DestFolder.Controls.Add(txtbox_DestFolder);
            pnl_DestFolder.Location = new Point(13, 244);
            pnl_DestFolder.Name = "pnl_DestFolder";
            pnl_DestFolder.Padding = new Padding(10);
            pnl_DestFolder.Size = new Size(950, 215);
            pnl_DestFolder.TabIndex = 1;
            // 
            // lbl_TryInstall
            // 
            lbl_TryInstall.AutoSize = true;
            lbl_TryInstall.BackColor = SystemColors.ActiveBorder;
            lbl_TryInstall.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbl_TryInstall.Location = new Point(13, 124);
            lbl_TryInstall.Name = "lbl_TryInstall";
            lbl_TryInstall.Size = new Size(663, 40);
            lbl_TryInstall.TabIndex = 7;
            lbl_TryInstall.Text = "Do you wish to automatically install selected apps?\r\n";
            lbl_TryInstall.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkbox_TryInstall
            // 
            chkbox_TryInstall.AutoSize = true;
            chkbox_TryInstall.Location = new Point(768, 124);
            chkbox_TryInstall.MinimumSize = new Size(105, 40);
            chkbox_TryInstall.Name = "chkbox_TryInstall";
            chkbox_TryInstall.OffBackColor = Color.Gray;
            chkbox_TryInstall.OffToggleColor = Color.Gainsboro;
            chkbox_TryInstall.OnBackColor = Color.MediumSlateBlue;
            chkbox_TryInstall.OnToggleColor = Color.WhiteSmoke;
            chkbox_TryInstall.Size = new Size(105, 40);
            chkbox_TryInstall.TabIndex = 5;
            chkbox_TryInstall.UseVisualStyleBackColor = true;
            // 
            // btn_BrowseFolder
            // 
            btn_BrowseFolder.BackColor = Color.MediumSlateBlue;
            btn_BrowseFolder.BackgroundColor = Color.MediumSlateBlue;
            btn_BrowseFolder.BorderColor = Color.PaleVioletRed;
            btn_BrowseFolder.BorderRadius = 20;
            btn_BrowseFolder.BorderSize = 0;
            btn_BrowseFolder.FlatAppearance.BorderSize = 0;
            btn_BrowseFolder.FlatStyle = FlatStyle.Flat;
            btn_BrowseFolder.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn_BrowseFolder.ForeColor = Color.White;
            btn_BrowseFolder.Location = new Point(13, 13);
            btn_BrowseFolder.Name = "btn_BrowseFolder";
            btn_BrowseFolder.Size = new Size(172, 50);
            btn_BrowseFolder.TabIndex = 3;
            btn_BrowseFolder.Text = "Browse";
            btn_BrowseFolder.TextColor = Color.White;
            btn_BrowseFolder.UseVisualStyleBackColor = false;
            btn_BrowseFolder.Click += btn_BrowseFolder_Click;
            // 
            // txtbox_DestFolder
            // 
            txtbox_DestFolder.BackColor = SystemColors.Window;
            txtbox_DestFolder.BorderColor = Color.MediumSlateBlue;
            txtbox_DestFolder.BorderFocusColor = Color.HotPink;
            txtbox_DestFolder.BorderSize = 2;
            txtbox_DestFolder.Enabled = false;
            txtbox_DestFolder.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtbox_DestFolder.ForeColor = Color.DimGray;
            txtbox_DestFolder.Location = new Point(215, 19);
            txtbox_DestFolder.Margin = new Padding(4);
            txtbox_DestFolder.Multiline = false;
            txtbox_DestFolder.Name = "txtbox_DestFolder";
            txtbox_DestFolder.Padding = new Padding(7);
            txtbox_DestFolder.PasswordChar = false;
            txtbox_DestFolder.Size = new Size(721, 39);
            txtbox_DestFolder.TabIndex = 3;
            txtbox_DestFolder.Texts = "";
            txtbox_DestFolder.UnderlinedStyle = false;
            // 
            // pnl_SelectedApps
            // 
            pnl_SelectedApps.BackColor = SystemColors.ActiveCaption;
            pnl_SelectedApps.Controls.Add(lbl_SelectedApps);
            pnl_SelectedApps.Controls.Add(flowpnl_SelectedApps);
            pnl_SelectedApps.Controls.Add(btn_ClearAll);
            pnl_SelectedApps.Location = new Point(13, 13);
            pnl_SelectedApps.Name = "pnl_SelectedApps";
            pnl_SelectedApps.Padding = new Padding(10);
            pnl_SelectedApps.Size = new Size(950, 216);
            pnl_SelectedApps.TabIndex = 0;
            // 
            // lbl_SelectedApps
            // 
            lbl_SelectedApps.AutoSize = true;
            lbl_SelectedApps.BackColor = SystemColors.ActiveBorder;
            lbl_SelectedApps.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbl_SelectedApps.Location = new Point(511, 10);
            lbl_SelectedApps.Name = "lbl_SelectedApps";
            lbl_SelectedApps.Size = new Size(132, 25);
            lbl_SelectedApps.TabIndex = 3;
            lbl_SelectedApps.Text = "Selected apps:";
            lbl_SelectedApps.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowpnl_SelectedApps
            // 
            flowpnl_SelectedApps.BackColor = SystemColors.ButtonHighlight;
            flowpnl_SelectedApps.Location = new Point(207, 47);
            flowpnl_SelectedApps.Name = "flowpnl_SelectedApps";
            flowpnl_SelectedApps.Size = new Size(728, 156);
            flowpnl_SelectedApps.TabIndex = 2;
            // 
            // btn_ClearAll
            // 
            btn_ClearAll.BackColor = Color.MediumSlateBlue;
            btn_ClearAll.BackgroundColor = Color.MediumSlateBlue;
            btn_ClearAll.BorderColor = Color.Violet;
            btn_ClearAll.BorderRadius = 20;
            btn_ClearAll.BorderSize = 2;
            btn_ClearAll.FlatAppearance.BorderSize = 0;
            btn_ClearAll.FlatStyle = FlatStyle.Flat;
            btn_ClearAll.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn_ClearAll.ForeColor = Color.White;
            btn_ClearAll.Location = new Point(13, 91);
            btn_ClearAll.Name = "btn_ClearAll";
            btn_ClearAll.Size = new Size(172, 63);
            btn_ClearAll.TabIndex = 1;
            btn_ClearAll.Text = "Clear all";
            btn_ClearAll.TextColor = Color.White;
            btn_ClearAll.UseVisualStyleBackColor = false;
            btn_ClearAll.Click += btn_ClearAll_Click;
            // 
            // MainFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1284, 811);
            Controls.Add(tabpage_Apps);
            Controls.Add(tabpage_Tools);
            Controls.Add(tabpage_Other);
            Controls.Add(tablepnl_Console);
            Controls.Add(tablepnl_LeftPanel);
            Controls.Add(tablepnl_TopPanel);
            Controls.Add(pnl_Profiles);
            Controls.Add(pnl_Download);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainFrame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Downloader";
            FormClosing += MainFrame_FormClosing;
            tablepnl_TopPanel.ResumeLayout(false);
            tablepnl_TopPanel.PerformLayout();
            tablepnl_LeftPanel.ResumeLayout(false);
            tablepnl_Console.ResumeLayout(false);
            tablepnl_Console.PerformLayout();
            tabpage_Apps.ResumeLayout(false);
            tab_Browsers.ResumeLayout(false);
            tab_Launchers.ResumeLayout(false);
            tab_Media.ResumeLayout(false);
            tab_Communication.ResumeLayout(false);
            tab_Programming.ResumeLayout(false);
            tab_Overview.ResumeLayout(false);
            tab_Tests.ResumeLayout(false);
            tab_Network.ResumeLayout(false);
            tab_OSsAndISOs.ResumeLayout(false);
            tab_Disk.ResumeLayout(false);
            tab_Protection.ResumeLayout(false);
            tab_OtherApps.ResumeLayout(false);
            tab_Archives.ResumeLayout(false);
            tabpage_Tools.ResumeLayout(false);
            tabpage_Other.ResumeLayout(false);
            pnl_Profiles.ResumeLayout(false);
            pnl_Download.ResumeLayout(false);
            pnl_DownloadProc.ResumeLayout(false);
            pnl_DestFolder.ResumeLayout(false);
            pnl_DestFolder.PerformLayout();
            pnl_SelectedApps.ResumeLayout(false);
            pnl_SelectedApps.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tablepnl_TopPanel;
        private Label lbl_Author;
        private Label lbl_PrgName;
        private System.Windows.Forms.Button btn_CheckCon;
        private TableLayoutPanel tablepnl_LeftPanel;
        private System.Windows.Forms.Button btn_Apps;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.Button btn_Profiles;
        private System.Windows.Forms.Button btn_Other;
        private System.Windows.Forms.Button btn_Tools;
        private TableLayoutPanel tablepnl_Console;
        private TabControl tabpage_Apps;
        private TabControl tabpage_Tools;
        private TabControl tabpage_Other;
        private TabPage tab_Browsers;
        private FlowLayoutPanel flowpnl_Browsers;
        private TabPage tab_Launchers;
        private FlowLayoutPanel flowpnl_Launchers;
        private TabPage tab_Media;
        private FlowLayoutPanel flowpnl_Media;
        private TabPage tab_Communication;
        private FlowLayoutPanel flowpnl_Communication;
        private TabPage tab_Programming;
        private FlowLayoutPanel flowpnl_Programming;
        private TabPage tab_Overview;
        private FlowLayoutPanel flowpnl_Overview;
        private TabPage tab_Tests;
        private FlowLayoutPanel flowpnl_Tests;
        private TabPage tab_Network;
        private FlowLayoutPanel flowpnl_Network;
        private TabPage tab_OSsAndISOs;
        private FlowLayoutPanel flowpnl_OSsAndISOs;
        private TabPage tab_Disk;
        private FlowLayoutPanel flowpnl_Disk;
        private TabPage tab_Protection;
        private FlowLayoutPanel flowpnl_Protection;
        private TabPage tab_OtherApps;
        private FlowLayoutPanel flowpnl_OtherApps;
        private TabPage tab_Archives;
        private FlowLayoutPanel flowpnl_Archives;
        private Panel pnl_Profiles;
        private System.Windows.Forms.Button btn_AddProfile;
        private FlowLayoutPanel flowpnl_YourProfiles;
        private Label lbl_YourProfiles;
        private Panel pnl_Download;
        private Panel pnl_DownloadProc;
        private Panel pnl_DestFolder;
        private Panel pnl_SelectedApps;
        private MyTextBox txtbox_DestFolder;
        private FlowLayoutPanel flowpnl_SelectedApps;
        private MyButton btn_ClearAll;
        private MyToggleButton chkbox_TryInstall;
        private MyButton btn_BrowseFolder;
        private Label lbl_SelectedApps;
        private Label lbl_TryInstall;
        private Label lbl_DownloadFile;
        private MyButton btn_StartDownload;
        public static Label lbl_CurApps;
        public static Label lbl_ImageStatus;
        public static System.Windows.Forms.ProgressBar progbar_DownloadPrc;
        public static Label lbl_ProgPer;
        public static RichTextBox richtxtbox_Console;
    }
}

