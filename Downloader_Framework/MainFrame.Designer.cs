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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.tablepnl_TopPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Author = new System.Windows.Forms.Label();
            this.lbl_PrgName = new System.Windows.Forms.Label();
            lbl_ImageStatus = new System.Windows.Forms.Label();
            this.btn_CheckCon = new System.Windows.Forms.Button();
            this.tablepnl_LeftPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Profiles = new System.Windows.Forms.Button();
            this.btn_Other = new System.Windows.Forms.Button();
            this.btn_Tools = new System.Windows.Forms.Button();
            this.btn_Apps = new System.Windows.Forms.Button();
            this.btn_Download = new System.Windows.Forms.Button();
            this.tablepnl_Console = new System.Windows.Forms.TableLayoutPanel();
            richtxtbox_Console = new System.Windows.Forms.RichTextBox();
            lbl_CurApps = new System.Windows.Forms.Label();
            this.tabpage_Apps = new System.Windows.Forms.TabControl();
            this.tab_Browsers = new System.Windows.Forms.TabPage();
            this.flowpnl_Browsers = new System.Windows.Forms.FlowLayoutPanel();
            this.tab_Launchers = new System.Windows.Forms.TabPage();
            this.flowpnl_Launchers = new System.Windows.Forms.FlowLayoutPanel();
            this.tab_Media = new System.Windows.Forms.TabPage();
            this.flowpnl_Media = new System.Windows.Forms.FlowLayoutPanel();
            this.tab_Communication = new System.Windows.Forms.TabPage();
            this.flowpnl_Communication = new System.Windows.Forms.FlowLayoutPanel();
            this.tab_Programming = new System.Windows.Forms.TabPage();
            this.flowpnl_Programming = new System.Windows.Forms.FlowLayoutPanel();
            this.tab_Overview = new System.Windows.Forms.TabPage();
            this.flowpnl_Overview = new System.Windows.Forms.FlowLayoutPanel();
            this.tab_Tests = new System.Windows.Forms.TabPage();
            this.flowpnl_Tests = new System.Windows.Forms.FlowLayoutPanel();
            this.tab_Network = new System.Windows.Forms.TabPage();
            this.flowpnl_Network = new System.Windows.Forms.FlowLayoutPanel();
            this.tab_OSsAndISOs = new System.Windows.Forms.TabPage();
            this.flowpnl_OSsAndISOs = new System.Windows.Forms.FlowLayoutPanel();
            this.tab_Disk = new System.Windows.Forms.TabPage();
            this.flowpnl_Disk = new System.Windows.Forms.FlowLayoutPanel();
            this.tab_Protection = new System.Windows.Forms.TabPage();
            this.flowpnl_Protection = new System.Windows.Forms.FlowLayoutPanel();
            this.tab_OtherApps = new System.Windows.Forms.TabPage();
            this.flowpnl_OtherApps = new System.Windows.Forms.FlowLayoutPanel();
            this.tab_Archives = new System.Windows.Forms.TabPage();
            this.flowpnl_Archives = new System.Windows.Forms.FlowLayoutPanel();
            this.tabpage_Tools = new System.Windows.Forms.TabControl();
            this.tabpage_Other = new System.Windows.Forms.TabControl();
            this.pnl_Profiles = new System.Windows.Forms.Panel();
            this.btn_AddProfile = new System.Windows.Forms.Button();
            this.flowpnl_YourProfiles = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_YourProfiles = new System.Windows.Forms.Label();
            this.pnl_Download = new System.Windows.Forms.Panel();
            this.pnl_DownloadProc = new System.Windows.Forms.Panel();
            btn_StartDownload = new System.Windows.Forms.Button();
            lbl_ProgPer = new System.Windows.Forms.Label();
            txtbox_DownloadFile = new MyTextBox();
            progbar_DownloadPrc = new System.Windows.Forms.ProgressBar();
            this.pnl_DestFolder = new System.Windows.Forms.Panel();
            this.txtbox_TryInstall = new MyTextBox();
            this.chkbox_TryInstall = new Downloader_Framework.MyToggleButton();
            this.btn_BrowseFolder = new System.Windows.Forms.Button();
            this.txtbox_DestFolder = new Downloader_Framework.MyTextBox();
            this.pnl_SelectedApps = new System.Windows.Forms.Panel();
            this.txtbox_SelectedApps = new MyTextBox();
            this.flowpnl_SelectedApps = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_ClearAll = new System.Windows.Forms.Button();
            this.tablepnl_TopPanel.SuspendLayout();
            this.tablepnl_LeftPanel.SuspendLayout();
            this.tablepnl_Console.SuspendLayout();
            this.tabpage_Apps.SuspendLayout();
            this.tab_Browsers.SuspendLayout();
            this.tab_Launchers.SuspendLayout();
            this.tab_Media.SuspendLayout();
            this.tab_Communication.SuspendLayout();
            this.tab_Programming.SuspendLayout();
            this.tab_Overview.SuspendLayout();
            this.tab_Tests.SuspendLayout();
            this.tab_Network.SuspendLayout();
            this.tab_OSsAndISOs.SuspendLayout();
            this.tab_Disk.SuspendLayout();
            this.tab_Protection.SuspendLayout();
            this.tab_OtherApps.SuspendLayout();
            this.tab_Archives.SuspendLayout();
            this.tabpage_Tools.SuspendLayout();
            this.tabpage_Other.SuspendLayout();
            this.pnl_Profiles.SuspendLayout();
            this.pnl_Download.SuspendLayout();
            this.pnl_DownloadProc.SuspendLayout();
            this.pnl_DestFolder.SuspendLayout();
            this.pnl_SelectedApps.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablepnl_TopPanel
            // 
            this.tablepnl_TopPanel.BackColor = color6;
            this.tablepnl_TopPanel.ColumnCount = 4;
            this.tablepnl_TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26));
            this.tablepnl_TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69));
            this.tablepnl_TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 313F));
            this.tablepnl_TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tablepnl_TopPanel.Controls.Add(this.lbl_Author, 1, 0);
            this.tablepnl_TopPanel.Controls.Add(this.lbl_PrgName, 0, 0);
            this.tablepnl_TopPanel.Controls.Add(lbl_ImageStatus, 3, 0);
            this.tablepnl_TopPanel.Controls.Add(this.btn_CheckCon, 2, 0);
            this.tablepnl_TopPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tablepnl_TopPanel.Location = new System.Drawing.Point(14, 14);
            this.tablepnl_TopPanel.Name = "tablepnl_TopPanel";
            this.tablepnl_TopPanel.RowCount = 1;
            this.tablepnl_TopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablepnl_TopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablepnl_TopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tablepnl_TopPanel.Size = new System.Drawing.Size(1257, 61);
            this.tablepnl_TopPanel.TabIndex = 0;
            // 
            // lbl_Author
            // 
            this.lbl_Author.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Author.AutoSize = true;
            this.lbl_Author.BackColor = color3;
            this.lbl_Author.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            //this.lbl_Author.Font = new System.Drawing.Font("Arial Narrow", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Author.Font = font1;
            this.lbl_Author.ForeColor = color6;
            this.lbl_Author.Location = new System.Drawing.Point(283, 10);
            this.lbl_Author.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lbl_Author.Size = new System.Drawing.Size(583, 50);
            this.lbl_Author.TabIndex = 4;
            this.lbl_Author.Text = "VADIM ELSHIN | DAW 1 | IES DOCTOR BALMIS";
            this.lbl_Author.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Author.Paint += label_Paint;
            // 
            // lbl_PrgName
            // 
            this.lbl_PrgName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PrgName.AutoSize = true;
            this.lbl_PrgName.BackColor = color1;
            this.lbl_PrgName.ForeColor = color6;
            this.lbl_PrgName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_PrgName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_PrgName.Font = font1;
            this.lbl_PrgName.Location = new System.Drawing.Point(6, 10);
            this.lbl_PrgName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_PrgName.Name = "lbl_PrgName";
            this.lbl_PrgName.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lbl_PrgName.Size = new System.Drawing.Size(265, 50);
            this.lbl_PrgName.TabIndex = 0;
            this.lbl_PrgName.Text = "DOWNLOADER";
            this.lbl_PrgName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ImageStatus
            // 
            lbl_ImageStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            lbl_ImageStatus.Image = new Bitmap(Properties.Resources.neutral, new System.Drawing.Size(50, 50));
            lbl_ImageStatus.Location = new System.Drawing.Point(1190, 3);
            lbl_ImageStatus.Name = "lbl_ImageStatus";
            lbl_ImageStatus.Size = new System.Drawing.Size(55, 55);
            lbl_ImageStatus.TabIndex = 3;
            lbl_ImageStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_CheckCon
            // 
            this.btn_CheckCon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CheckCon.BackColor = color4;
            this.btn_CheckCon.ForeColor = color1;
            this.btn_CheckCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CheckCon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_CheckCon.Font = new Font("Arial", 19, FontStyle.Bold);
            this.btn_CheckCon.ForeColor = System.Drawing.Color.White;
            this.btn_CheckCon.Location = new System.Drawing.Point(881, 6);
            this.btn_CheckCon.Name = "btn_CheckCon";
            this.btn_CheckCon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_CheckCon.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btn_CheckCon.Size = new System.Drawing.Size(309, 43);
            this.btn_CheckCon.TabIndex = 2;
            this.btn_CheckCon.Text = "CHECK CONNECTION";
            this.btn_CheckCon.UseVisualStyleBackColor = false;
            this.btn_CheckCon.Click += btn_CheckCon_Click;
            this.btn_CheckCon.MouseEnter += FocusOnButton;
            this.btn_CheckCon.MouseLeave += LeaveButton;
            // 
            // tablepnl_LeftPanel
            // 
            this.tablepnl_LeftPanel.BackColor = color6;
            this.tablepnl_LeftPanel.ColumnCount = 1;
            this.tablepnl_LeftPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablepnl_LeftPanel.Controls.Add(this.btn_Profiles, 0, 3);
            this.tablepnl_LeftPanel.Controls.Add(this.btn_Other, 0, 2);
            this.tablepnl_LeftPanel.Controls.Add(this.btn_Tools, 0, 1);
            this.tablepnl_LeftPanel.Controls.Add(this.btn_Apps, 0, 0);
            this.tablepnl_LeftPanel.Controls.Add(this.btn_Download, 0, 4);
            this.tablepnl_LeftPanel.Location = new System.Drawing.Point(14, 93);
            this.tablepnl_LeftPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tablepnl_LeftPanel.Name = "tablepnl_LeftPanel";
            this.tablepnl_LeftPanel.RowCount = 5;
            this.tablepnl_LeftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablepnl_LeftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablepnl_LeftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablepnl_LeftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablepnl_LeftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablepnl_LeftPanel.Size = new System.Drawing.Size(260, 421);
            this.tablepnl_LeftPanel.TabIndex = 1;
            // 
            // btn_Profiles
            // 
            this.btn_Profiles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Profiles.Font = font2;
            this.btn_Profiles.Location = new System.Drawing.Point(16, 264);
            this.btn_Profiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Profiles.Name = "btn_Profiles";
            this.btn_Profiles.Size = new System.Drawing.Size(227, 60);
            this.btn_Profiles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Profiles.TabIndex = 3;
            this.btn_Profiles.Text = "PROFILES";
            this.btn_Profiles.UseVisualStyleBackColor = true;
            this.btn_Profiles.Click += btn_Profiles_Click;
            this.btn_Profiles.BackColor = color4;
            this.btn_Profiles.ForeColor = color1;
            this.btn_Profiles.MouseEnter += FocusOnButton;
            this.btn_Profiles.MouseLeave += LeaveButton;
            // 
            // btn_Other
            // 
            this.btn_Other.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Other.Font = font2;
            this.btn_Other.Location = new System.Drawing.Point(16, 180);
            this.btn_Other.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Other.Name = "btn_Other";
            this.btn_Other.Size = new System.Drawing.Size(227, 60);
            this.btn_Other.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Other.TabIndex = 2;
            this.btn_Other.Text = "OTHER";
            this.btn_Other.UseVisualStyleBackColor = true;
            this.btn_Other.Click += btn_Other_apps_Click;
            this.btn_Other.BackColor = color4;
            this.btn_Other.ForeColor = color1;
            this.btn_Other.MouseEnter += FocusOnButton;
            this.btn_Other.MouseLeave += LeaveButton;
            // 
            // btn_Tools
            // 
            this.btn_Tools.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Tools.Font = font2;
            this.btn_Tools.Location = new System.Drawing.Point(16, 96);
            this.btn_Tools.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tools.Name = "btn_Tools";
            this.btn_Tools.Size = new System.Drawing.Size(227, 60);
            this.btn_Tools.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Tools.TabIndex = 1;
            this.btn_Tools.Text = "TOOLS";
            this.btn_Tools.UseVisualStyleBackColor = true;
            this.btn_Tools.Click += btn_Tools_Click;
            this.btn_Tools.BackColor = color4;
            this.btn_Tools.ForeColor = color1;
            this.btn_Tools.MouseEnter += FocusOnButton;
            this.btn_Tools.MouseLeave += LeaveButton;
            // 
            // btn_Apps
            // 
            this.btn_Apps.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Apps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Apps.Font = font2;
            this.btn_Apps.Location = new System.Drawing.Point(16, 12);
            this.btn_Apps.Name = "btn_Apps";
            this.btn_Apps.Size = new System.Drawing.Size(227, 60);
            this.btn_Apps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Apps.TabIndex = 0;
            this.btn_Apps.Text = "APPS";
            this.btn_Apps.UseVisualStyleBackColor = true;
            this.btn_Apps.Click += btn_Apps_Click;
            this.btn_Apps.BackColor = color4;
            this.btn_Apps.ForeColor = color1;
            this.btn_Apps.MouseEnter += FocusOnButton;
            this.btn_Apps.MouseLeave += LeaveButton;
            // 
            // btn_Download
            // 
            this.btn_Download.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Download.Font = font2;
            this.btn_Download.Location = new System.Drawing.Point(16, 348);
            this.btn_Download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(227, 60);
            this.btn_Download.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Download.TabIndex = 4;
            this.btn_Download.Text = "DOWNLOAD";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += btn_Download_Click;
            this.btn_Download.BackColor = color4;
            this.btn_Download.ForeColor = color1;
            this.btn_Download.MouseEnter += FocusOnButton;
            this.btn_Download.MouseLeave += LeaveButton;
         
            // 
            // tablepnl_Console
            // 
            this.tablepnl_Console.BackColor = color4;
            this.tablepnl_Console.ColumnCount = 1;
            this.tablepnl_Console.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablepnl_Console.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablepnl_Console.Controls.Add(richtxtbox_Console, 0, 1);
            this.tablepnl_Console.Controls.Add(lbl_CurApps, 0, 0);
            this.tablepnl_Console.Location = new System.Drawing.Point(14, 531);
            this.tablepnl_Console.Margin = new System.Windows.Forms.Padding(4);
            this.tablepnl_Console.Name = "tablepnl_Console";
            this.tablepnl_Console.RowCount = 2;
            this.tablepnl_Console.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.83502F));
            this.tablepnl_Console.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.16499F));
            this.tablepnl_Console.Size = new System.Drawing.Size(260, 268);
            this.tablepnl_Console.TabIndex = 2;
            // 
            // richtxtbox_Console
            // 
            richtxtbox_Console.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            richtxtbox_Console.Location = new System.Drawing.Point(4, 48);
            richtxtbox_Console.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            richtxtbox_Console.Name = "richtxtbox_Console";
            richtxtbox_Console.ReadOnly = true;
            richtxtbox_Console.Size = new System.Drawing.Size(252, 217);
            richtxtbox_Console.TabIndex = 1;
            richtxtbox_Console.BackColor = color6;
            richtxtbox_Console.ForeColor = color1;
            richtxtbox_Console.Text = "";
            richtxtbox_Console.BorderStyle = BorderStyle.Fixed3D;
            richtxtbox_Console.Font = new Font("Arial", 9, FontStyle.Regular);
            // 
            // lbl_CurApps
            // 
            lbl_CurApps.Anchor = System.Windows.Forms.AnchorStyles.None;
            lbl_CurApps.AutoSize = false;
            lbl_CurApps.BackColor = color6;
            lbl_CurApps.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lbl_CurApps.ForeColor = System.Drawing.Color.White;
            lbl_CurApps.Location = new System.Drawing.Point(0, 1);
            lbl_CurApps.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            lbl_CurApps.Name = "lbl_CurApps";
            lbl_CurApps.Padding = new System.Windows.Forms.Padding(29, 7, 29, 7);
            lbl_CurApps.Size = new System.Drawing.Size(259, 42);
            lbl_CurApps.TabIndex = 0;
            lbl_CurApps.Text = "Selected apps: 0";
            lbl_CurApps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lbl_CurApps.Paint += label_Paint;
            // 
            // tabpage_Apps
            // 
            this.tabpage_Apps.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabpage_Apps.Controls.Add(this.tab_Browsers);
            this.tabpage_Apps.Controls.Add(this.tab_Launchers);
            this.tabpage_Apps.Controls.Add(this.tab_Media);
            this.tabpage_Apps.Controls.Add(this.tab_Communication);
            this.tabpage_Apps.Controls.Add(this.tab_Programming);
            this.tabpage_Apps.Location = new System.Drawing.Point(295, 93);
            this.tabpage_Apps.Name = "tabpage_Apps";
            this.tabpage_Apps.SelectedIndex = 0;
            this.tabpage_Apps.Size = new System.Drawing.Size(976, 706);
            this.tabpage_Apps.TabIndex = 3;
            this.tabpage_Apps.Visible = false;
            // 
            // tab_Browsers
            // 
            this.tab_Browsers.Controls.Add(this.flowpnl_Browsers);
            this.tab_Browsers.Location = new System.Drawing.Point(4, 27);
            this.tab_Browsers.Name = "tab_Browsers";
            this.tab_Browsers.BackColor = color5;
            this.tab_Browsers.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Browsers.Size = new System.Drawing.Size(968, 675);
            this.tab_Browsers.TabIndex = 0;
            this.tab_Browsers.Text = "Browsers";
            this.tab_Browsers.UseVisualStyleBackColor = true;
            // 
            // flowpnl_Browsers
            // 
            this.flowpnl_Browsers.Location = new System.Drawing.Point(6, 6);
            this.flowpnl_Browsers.Name = "flowpnl_Browsers";
            this.flowpnl_Browsers.BackColor = color4;
            this.flowpnl_Browsers.Padding = new System.Windows.Forms.Padding(5);
            this.flowpnl_Browsers.Size = new System.Drawing.Size(956, 663);
            this.flowpnl_Browsers.TabIndex = 0;
            // 
            // tab_Launchers
            // 
            this.tab_Launchers.Controls.Add(this.flowpnl_Launchers);
            this.tab_Launchers.Location = new System.Drawing.Point(4, 27);
            this.tab_Launchers.Name = "tab_Launchers";
            this.tab_Launchers.BackColor = color5;
            this.tab_Launchers.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Launchers.Size = new System.Drawing.Size(968, 675);
            this.tab_Launchers.TabIndex = 1;
            this.tab_Launchers.Text = "Launchers";
            this.tab_Launchers.UseVisualStyleBackColor = true;
            // 
            // flowpnl_Launchers
            // 
            this.flowpnl_Launchers.Location = new System.Drawing.Point(6, 6);
            this.flowpnl_Launchers.Name = "flowpnl_Launchers";
            this.flowpnl_Launchers.BackColor = color4;
            this.flowpnl_Launchers.Padding = new System.Windows.Forms.Padding(5);
            this.flowpnl_Launchers.Size = new System.Drawing.Size(956, 663);
            this.flowpnl_Launchers.TabIndex = 1;
            // 
            // tab_Media
            // 
            this.tab_Media.Controls.Add(this.flowpnl_Media);
            this.tab_Media.Location = new System.Drawing.Point(4, 27);
            this.tab_Media.Name = "tab_Media";
            this.tab_Media.BackColor = color5;
            this.tab_Media.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Media.Size = new System.Drawing.Size(968, 675);
            this.tab_Media.TabIndex = 2;
            this.tab_Media.Text = "Media";
            this.tab_Media.UseVisualStyleBackColor = true;
            // 
            // flowpnl_Media
            // 
            this.flowpnl_Media.Location = new System.Drawing.Point(6, 6);
            this.flowpnl_Media.Name = "flowpnl_Media";
            this.flowpnl_Media.BackColor = color4;
            this.flowpnl_Media.Padding = new System.Windows.Forms.Padding(5);
            this.flowpnl_Media.Size = new System.Drawing.Size(956, 663);
            this.flowpnl_Media.TabIndex = 1;
            // 
            // tab_Communication
            // 
            this.tab_Communication.Controls.Add(this.flowpnl_Communication);
            this.tab_Communication.Location = new System.Drawing.Point(4, 27);
            this.tab_Communication.Name = "tab_Communication";
            this.tab_Communication.BackColor = color5;
            this.tab_Communication.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Communication.Size = new System.Drawing.Size(968, 675);
            this.tab_Communication.TabIndex = 3;
            this.tab_Communication.Text = "Communication";
            this.tab_Communication.UseVisualStyleBackColor = true;
            // 
            // flowpnl_Communication
            // 
            this.flowpnl_Communication.Location = new System.Drawing.Point(6, 6);
            this.flowpnl_Communication.Name = "flowpnl_Communication";
            this.flowpnl_Communication.BackColor = color4;
            this.flowpnl_Communication.Padding = new System.Windows.Forms.Padding(5);
            this.flowpnl_Communication.Size = new System.Drawing.Size(956, 663);
            this.flowpnl_Communication.TabIndex = 1;
            // 
            // tab_Programming
            // 
            this.tab_Programming.Controls.Add(this.flowpnl_Programming);
            this.tab_Programming.Location = new System.Drawing.Point(4, 27);
            this.tab_Programming.Name = "tab_Programming";
            this.tab_Programming.BackColor = color5;
            this.tab_Programming.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Programming.Size = new System.Drawing.Size(968, 675);
            this.tab_Programming.TabIndex = 4;
            this.tab_Programming.Text = "Programming";
            this.tab_Programming.UseVisualStyleBackColor = true;
            // 
            // flowpnl_Programming
            // 
            this.flowpnl_Programming.Location = new System.Drawing.Point(6, 6);
            this.flowpnl_Programming.Name = "flowpnl_Programming";
            this.flowpnl_Programming.BackColor = color4;
            this.flowpnl_Programming.Padding = new System.Windows.Forms.Padding(5);
            this.flowpnl_Programming.Size = new System.Drawing.Size(956, 663);
            this.flowpnl_Programming.TabIndex = 1;
            // 
            // tab_Overview
            // 
            this.tab_Overview.Controls.Add(this.flowpnl_Overview);
            this.tab_Overview.Location = new System.Drawing.Point(4, 27);
            this.tab_Overview.Name = "tab_Overview";
            this.tab_Overview.BackColor = color5;
            this.tab_Overview.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Overview.Size = new System.Drawing.Size(968, 675);
            this.tab_Overview.TabIndex = 0;
            this.tab_Overview.Text = "Overview";
            this.tab_Overview.UseVisualStyleBackColor = true;
            // 
            // flowpnl_Overview
            // 
            this.flowpnl_Overview.Location = new System.Drawing.Point(6, 6);
            this.flowpnl_Overview.Name = "flowpnl_Overview";
            this.flowpnl_Overview.BackColor = color4;
            this.flowpnl_Overview.Padding = new System.Windows.Forms.Padding(5);
            this.flowpnl_Overview.Size = new System.Drawing.Size(956, 663);
            this.flowpnl_Overview.TabIndex = 1;
            // 
            // tab_Tests
            // 
            this.tab_Tests.Controls.Add(this.flowpnl_Tests);
            this.tab_Tests.Location = new System.Drawing.Point(4, 27);
            this.tab_Tests.Name = "tab_Tests";
            this.tab_Tests.BackColor = color5;
            this.tab_Tests.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Tests.Size = new System.Drawing.Size(968, 675);
            this.tab_Tests.TabIndex = 1;
            this.tab_Tests.Text = "Tests";
            this.tab_Tests.UseVisualStyleBackColor = true;
            // 
            // flowpnl_Tests
            // 
            this.flowpnl_Tests.Location = new System.Drawing.Point(6, 6);
            this.flowpnl_Tests.Name = "flowpnl_Tests";
            this.flowpnl_Tests.BackColor = color4;
            this.flowpnl_Tests.Padding = new System.Windows.Forms.Padding(5);
            this.flowpnl_Tests.Size = new System.Drawing.Size(956, 663);
            this.flowpnl_Tests.TabIndex = 1;
            // 
            // tab_Network
            // 
            this.tab_Network.Controls.Add(this.flowpnl_Network);
            this.tab_Network.Location = new System.Drawing.Point(4, 27);
            this.tab_Network.Name = "tab_Network";
            this.tab_Network.BackColor = color5;
            this.tab_Network.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Network.Size = new System.Drawing.Size(968, 675);
            this.tab_Network.TabIndex = 2;
            this.tab_Network.Text = "Network";
            this.tab_Network.UseVisualStyleBackColor = true;
            // 
            // flowpnl_Network
            // 
            this.flowpnl_Network.Location = new System.Drawing.Point(6, 6);
            this.flowpnl_Network.Name = "flowpnl_Network";
            this.flowpnl_Network.BackColor = color4;
            this.flowpnl_Network.Padding = new System.Windows.Forms.Padding(5);
            this.flowpnl_Network.Size = new System.Drawing.Size(956, 663);
            this.flowpnl_Network.TabIndex = 1;
            // 
            // tab_OSsAndISOs
            // 
            this.tab_OSsAndISOs.Controls.Add(this.flowpnl_OSsAndISOs);
            this.tab_OSsAndISOs.Location = new System.Drawing.Point(4, 27);
            this.tab_OSsAndISOs.Name = "tab_OSsAndISOs";
            this.tab_OSsAndISOs.BackColor = color5;
            this.tab_OSsAndISOs.Padding = new System.Windows.Forms.Padding(3);
            this.tab_OSsAndISOs.Size = new System.Drawing.Size(968, 675);
            this.tab_OSsAndISOs.TabIndex = 3;
            this.tab_OSsAndISOs.Text = "OSs & ISOs";
            this.tab_OSsAndISOs.UseVisualStyleBackColor = true;
            // 
            // flowpnl_OSsAndISOs
            // 
            this.flowpnl_OSsAndISOs.Location = new System.Drawing.Point(6, 6);
            this.flowpnl_OSsAndISOs.Name = "flowpnl_OSsAndISOs";
            this.flowpnl_OSsAndISOs.BackColor = color4;
            this.flowpnl_OSsAndISOs.Padding = new System.Windows.Forms.Padding(5);
            this.flowpnl_OSsAndISOs.Size = new System.Drawing.Size(956, 663);
            this.flowpnl_OSsAndISOs.TabIndex = 1;
            // 
            // tab_Disk
            // 
            this.tab_Disk.Controls.Add(this.flowpnl_Disk);
            this.tab_Disk.Location = new System.Drawing.Point(4, 27);
            this.tab_Disk.Name = "tab_Disk";
            this.tab_Disk.BackColor = color5;
            this.tab_Disk.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Disk.Size = new System.Drawing.Size(968, 675);
            this.tab_Disk.TabIndex = 4;
            this.tab_Disk.Text = "Disk";
            this.tab_Disk.UseVisualStyleBackColor = true;
            // 
            // flowpnl_Disk
            // 
            this.flowpnl_Disk.Location = new System.Drawing.Point(6, 6);
            this.flowpnl_Disk.Name = "flowpnl_Disk";
            this.flowpnl_Disk.BackColor = color4;
            this.flowpnl_Disk.Padding = new System.Windows.Forms.Padding(5);
            this.flowpnl_Disk.Size = new System.Drawing.Size(956, 663);
            this.flowpnl_Disk.TabIndex = 1;
            // 
            // tab_Protection
            // 
            this.tab_Protection.Controls.Add(this.flowpnl_Protection);
            this.tab_Protection.Location = new System.Drawing.Point(4, 27);
            this.tab_Protection.Name = "tab_Protection";
            this.tab_Protection.BackColor = color5;
            this.tab_Protection.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Protection.Size = new System.Drawing.Size(968, 675);
            this.tab_Protection.TabIndex = 5;
            this.tab_Protection.Text = "Protection";
            this.tab_Protection.UseVisualStyleBackColor = true;
            // 
            // flowpnl_Protection
            // 
            this.flowpnl_Protection.Location = new System.Drawing.Point(6, 6);
            this.flowpnl_Protection.Name = "flowpnl_Protection";
            this.flowpnl_Protection.BackColor = color4;
            this.flowpnl_Protection.Padding = new System.Windows.Forms.Padding(5);
            this.flowpnl_Protection.Size = new System.Drawing.Size(956, 663);
            this.flowpnl_Protection.TabIndex = 1;
            // 
            // tab_OtherApps
            // 
            this.tab_OtherApps.Controls.Add(this.flowpnl_OtherApps);
            this.tab_OtherApps.Location = new System.Drawing.Point(4, 27);
            this.tab_OtherApps.Name = "tab_OtherApps";
            this.tab_OtherApps.BackColor = color5;
            this.tab_OtherApps.Padding = new System.Windows.Forms.Padding(3);
            this.tab_OtherApps.Size = new System.Drawing.Size(968, 675);
            this.tab_OtherApps.TabIndex = 0;
            this.tab_OtherApps.Text = "Other apps";
            this.tab_OtherApps.UseVisualStyleBackColor = true;
            // 
            // flowpnl_OtherApps
            // 
            this.flowpnl_OtherApps.Location = new System.Drawing.Point(6, 6);
            this.flowpnl_OtherApps.Name = "flowpnl_OtherApps";
            this.flowpnl_OtherApps.BackColor = color4;
            this.flowpnl_OtherApps.Padding = new System.Windows.Forms.Padding(5);
            this.flowpnl_OtherApps.Size = new System.Drawing.Size(956, 663);
            this.flowpnl_OtherApps.TabIndex = 1;
            // 
            // tab_Archives
            // 
            this.tab_Archives.Controls.Add(this.flowpnl_Archives);
            this.tab_Archives.Location = new System.Drawing.Point(4, 27);
            this.tab_Archives.Name = "tab_Archives";
            this.tab_Archives.BackColor = color5;
            this.tab_Archives.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Archives.Size = new System.Drawing.Size(968, 675);
            this.tab_Archives.TabIndex = 1;
            this.tab_Archives.Text = "Archives";
            this.tab_Archives.UseVisualStyleBackColor = true;
            // 
            // flowpnl_Archives
            // 
            this.flowpnl_Archives.Location = new System.Drawing.Point(6, 6);
            this.flowpnl_Archives.Name = "flowpnl_Archives";
            this.flowpnl_Archives.BackColor = color4;
            this.flowpnl_Archives.Padding = new System.Windows.Forms.Padding(5);
            this.flowpnl_Archives.Size = new System.Drawing.Size(956, 663);
            this.flowpnl_Archives.TabIndex = 1;
            // 
            // tabpage_Tools
            // 
            this.tabpage_Tools.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabpage_Tools.Controls.Add(this.tab_Overview);
            this.tabpage_Tools.Controls.Add(this.tab_Tests);
            this.tabpage_Tools.Controls.Add(this.tab_Network);
            this.tabpage_Tools.Controls.Add(this.tab_OSsAndISOs);
            this.tabpage_Tools.Controls.Add(this.tab_Disk);
            this.tabpage_Tools.Controls.Add(this.tab_Protection);
            this.tabpage_Tools.Location = new System.Drawing.Point(295, 93);
            this.tabpage_Tools.Name = "tabpage_Tools";
            this.tabpage_Tools.SelectedIndex = 0;
            this.tabpage_Tools.Size = new System.Drawing.Size(976, 706);
            this.tabpage_Tools.TabIndex = 0;
            this.tabpage_Tools.Visible = false;
            // 
            // tabpage_Other
            // 
            this.tabpage_Other.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabpage_Other.Controls.Add(this.tab_OtherApps);
            this.tabpage_Other.Controls.Add(this.tab_Archives);
            this.tabpage_Other.Location = new System.Drawing.Point(295, 93);
            this.tabpage_Other.Name = "tabpage_Other";
            this.tabpage_Other.SelectedIndex = 0;
            this.tabpage_Other.Size = new System.Drawing.Size(976, 706);
            this.tabpage_Other.TabIndex = 3;
            this.tabpage_Other.Visible = false;
            // 
            // pnl_Profiles
            // 
            this.pnl_Profiles.BackColor = System.Drawing.Color.White;
            this.pnl_Profiles.Controls.Add(this.btn_AddProfile);
            this.pnl_Profiles.Controls.Add(this.flowpnl_YourProfiles);
            this.pnl_Profiles.Controls.Add(this.lbl_YourProfiles);
            this.pnl_Profiles.Location = new System.Drawing.Point(295, 93);
            this.pnl_Profiles.Name = "pnl_Profiles";
            this.pnl_Profiles.BackColor = color6;
            this.pnl_Profiles.Size = new System.Drawing.Size(976, 706);
            this.pnl_Profiles.TabIndex = 0;
            this.pnl_Profiles.Visible = false;
            // 
            // btn_AddProfile
            // 
            this.btn_AddProfile.Location = new System.Drawing.Point(661, 7);
            this.btn_AddProfile.Name = "btn_AddProfile";
            this.btn_AddProfile.Font = font1;
            this.btn_AddProfile.Size = new System.Drawing.Size(300, 50);
            this.btn_AddProfile.TabIndex = 5;
            this.btn_AddProfile.UseVisualStyleBackColor = true;
            this.btn_AddProfile.Text = "ADD NEW PROFILE";
            this.btn_AddProfile.BackColor = color4;
            this.btn_AddProfile.ForeColor = color1;
            this.btn_AddProfile.Click += AddProfile_btn_Click;
            this.btn_AddProfile.MouseEnter += FocusOnButton;
            this.btn_AddProfile.MouseLeave += LeaveButton;

            // 
            // flowpnl_YourProfiles
            // 
            this.flowpnl_YourProfiles.BackColor = color4;
            this.flowpnl_YourProfiles.Location = new System.Drawing.Point(12, 67);
            this.flowpnl_YourProfiles.Name = "flowpnl_YourProfiles";
            this.flowpnl_YourProfiles.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.flowpnl_YourProfiles.Size = new System.Drawing.Size(949, 625);
            this.flowpnl_YourProfiles.TabIndex = 1;
            // 
            // lbl_YourProfiles
            // 
            this.lbl_YourProfiles.BackColor = color3;
            this.lbl_YourProfiles.Location = new System.Drawing.Point(12, 11);
            this.lbl_YourProfiles.Font = font2;
            this.lbl_YourProfiles.ForeColor = color6;
            this.lbl_YourProfiles.Name = "lbl_YourProfiles";
            this.lbl_YourProfiles.Size = new System.Drawing.Size(420, 43);
            this.lbl_YourProfiles.TabIndex = 0;
            this.lbl_YourProfiles.Text = "YOUR PROFILES";
            this.lbl_YourProfiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_YourProfiles.Paint += label_Paint;
            // 
            // pnl_Download
            // 
            this.pnl_Download.BackColor = color6;
            this.pnl_Download.Controls.Add(this.pnl_DownloadProc);
            this.pnl_Download.Controls.Add(this.pnl_DestFolder);
            this.pnl_Download.Controls.Add(this.pnl_SelectedApps);
            this.pnl_Download.Location = new System.Drawing.Point(295, 93);
            this.pnl_Download.Name = "pnl_Download";
            this.pnl_Download.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.pnl_Download.Size = new System.Drawing.Size(976, 706);
            this.pnl_Download.TabIndex = 0;
            this.pnl_Download.Visible = false;
            // 
            // pnl_SelectedApps
            // 
            this.pnl_SelectedApps.BackColor = color4;
            this.pnl_SelectedApps.Controls.Add(this.txtbox_SelectedApps);
            this.pnl_SelectedApps.Controls.Add(this.flowpnl_SelectedApps);
            this.pnl_SelectedApps.Controls.Add(this.btn_ClearAll);
            this.pnl_SelectedApps.Location = new System.Drawing.Point(13, 13);
            this.pnl_SelectedApps.Name = "pnl_SelectedApps";
            this.pnl_SelectedApps.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_SelectedApps.Size = new System.Drawing.Size(950, 216);
            this.pnl_SelectedApps.TabIndex = 0;
            // 
            // txtbox_SelectedApps
            // 
            this.txtbox_SelectedApps.BackColor = color1;
            this.txtbox_SelectedApps.BorderColor = color5;
            this.txtbox_SelectedApps.Font = font4;
            this.txtbox_SelectedApps.Location = new System.Drawing.Point(477, 10);
            this.txtbox_SelectedApps.Name = "txtbox_SelectedApps";
            this.txtbox_SelectedApps.Size = new System.Drawing.Size(200, 25);
            this.txtbox_SelectedApps.TabIndex = 3;
            this.txtbox_SelectedApps.Texts = "Selected apps:";
            // 
            // flowpnl_SelectedApps
            // 
            this.flowpnl_SelectedApps.BackColor = color2;
            this.flowpnl_SelectedApps.Location = new System.Drawing.Point(207, 60);
            this.flowpnl_SelectedApps.Name = "flowpnl_SelectedApps";
            this.flowpnl_SelectedApps.Size = new System.Drawing.Size(728, 130);
            this.flowpnl_SelectedApps.TabIndex = 2;
            this.flowpnl_SelectedApps.Paint += panel_Paint;
            // 
            // btn_ClearAll
            // 
            this.btn_ClearAll.BackColor = color5;
            this.btn_ClearAll.ForeColor = color1;
            this.btn_ClearAll.FlatAppearance.BorderSize = 0;
            this.btn_ClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClearAll.Font = font1;
            this.btn_ClearAll.ForeColor = System.Drawing.Color.White;
            this.btn_ClearAll.Location = new System.Drawing.Point(11, 92);
            this.btn_ClearAll.Name = "btn_ClearAll";
            this.btn_ClearAll.Size = new System.Drawing.Size(185, 63);
            this.btn_ClearAll.TabIndex = 1;
            this.btn_ClearAll.Text = "CLEAR ALL";
            this.btn_ClearAll.TextAlign = ContentAlignment.MiddleCenter;
            this.btn_ClearAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ClearAll.FlatAppearance.BorderColor = color1;
            this.btn_ClearAll.FlatAppearance.BorderSize = 2;
            this.btn_ClearAll.Click += btn_ClearAll_Click;
            // 
            // txtbox_TryInstall
            // 
            this.txtbox_TryInstall.BackColor = color1;
            this.txtbox_TryInstall.BorderColor = color5;
            this.txtbox_TryInstall.Font = font4;
            this.txtbox_TryInstall.Location = new System.Drawing.Point(13, 100);
            this.txtbox_TryInstall.Name = "txtbox_TryInstall";
            this.txtbox_TryInstall.Size = new System.Drawing.Size(600, 1);
            this.txtbox_TryInstall.TabIndex = 7;
            this.txtbox_TryInstall.Texts = "Do you wish to automatically install selected apps?\r\n";
            // 
            // chkbox_TryInstall
            // 
            this.chkbox_TryInstall.AutoSize = true;
            this.chkbox_TryInstall.Location = new System.Drawing.Point(660, 102);
            this.chkbox_TryInstall.MinimumSize = new System.Drawing.Size(90, 40);
            this.chkbox_TryInstall.Name = "chkbox_TryInstall";
            this.chkbox_TryInstall.OffBackColor = color6;
            this.chkbox_TryInstall.OffToggleColor = color3;
            this.chkbox_TryInstall.OnBackColor = color3;
            this.chkbox_TryInstall.OnToggleColor = color6;
            this.chkbox_TryInstall.Size = new System.Drawing.Size(105, 40);
            this.chkbox_TryInstall.TabIndex = 5;
            this.chkbox_TryInstall.UseVisualStyleBackColor = true;
            // 
            // btn_BrowseFolder
            // 
            this.btn_BrowseFolder.BackColor = color5;
            this.btn_BrowseFolder.ForeColor = color1;
            this.btn_BrowseFolder.FlatAppearance.BorderSize = 0;
            this.btn_BrowseFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BrowseFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BrowseFolder.Font = font1;
            this.btn_BrowseFolder.Location = new System.Drawing.Point(13, 20);
            this.btn_BrowseFolder.Name = "btn_BrowseFolder";
            this.btn_BrowseFolder.Size = new System.Drawing.Size(172, 50);
            this.btn_BrowseFolder.TabIndex = 3;
            this.btn_BrowseFolder.Text = "BROWSE";
            this.btn_BrowseFolder.FlatAppearance.BorderColor = color1;
            this.btn_BrowseFolder.FlatAppearance.BorderSize = 2;
            // 
            // txtbox_DestFolder
            // 
            this.txtbox_DestFolder.BackColor = color1;
            this.txtbox_DestFolder.BorderColor = color5;
            this.txtbox_DestFolder.BorderSize = 2;
            this.txtbox_DestFolder.Font = font4;
            this.txtbox_DestFolder.Location = new System.Drawing.Point(215, 26);
            this.txtbox_DestFolder.Multiline = false;
            this.txtbox_DestFolder.Name = "txtbox_DestFolder";
            this.txtbox_DestFolder.Padding = new System.Windows.Forms.Padding(7);
            this.txtbox_DestFolder.PasswordChar = false;
            this.txtbox_DestFolder.Size = new System.Drawing.Size(721, 39);
            this.txtbox_DestFolder.TabIndex = 3;
            this.txtbox_DestFolder.Texts = "";
            this.txtbox_DestFolder.UnderlinedStyle = false;
            // 
            // pnl_DestFolder
            // 
            this.pnl_DestFolder.BackColor = color4;
            this.pnl_DestFolder.Controls.Add(this.txtbox_TryInstall);
            this.pnl_DestFolder.Controls.Add(this.chkbox_TryInstall);
            this.pnl_DestFolder.Controls.Add(this.btn_BrowseFolder);
            this.pnl_DestFolder.Controls.Add(this.txtbox_DestFolder);
            this.pnl_DestFolder.Location = new System.Drawing.Point(13, 244);
            this.pnl_DestFolder.Name = "pnl_DestFolder";
            this.pnl_DestFolder.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_DestFolder.Size = new System.Drawing.Size(950, 165);
            this.pnl_DestFolder.TabIndex = 1;
            this.btn_BrowseFolder.Click += btn_BrowseFolder_Click;
            // 
            // btn_StartDownload
            // 
            btn_StartDownload.BackColor = color5;
            btn_StartDownload.ForeColor = color1;
            btn_StartDownload.FlatAppearance.BorderSize = 0;
            btn_StartDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_StartDownload.Font = font2;
            btn_StartDownload.ForeColor = System.Drawing.Color.White;
            btn_StartDownload.Location = new System.Drawing.Point(350, 185);
            btn_StartDownload.Name = "btn_StartDownload";
            btn_StartDownload.Size = new System.Drawing.Size(250, 70);
            btn_StartDownload.TabIndex = 8;
            btn_StartDownload.Text = "DOWNLOAD";
            btn_StartDownload.TextAlign = ContentAlignment.MiddleCenter;
            btn_StartDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_StartDownload.FlatAppearance.BorderColor = color1;
            btn_StartDownload.FlatAppearance.BorderSize = 2;
            btn_StartDownload.Click += btn_StartDownload_Click;
            // 
            // lbl_ProgPer
            // 
            lbl_ProgPer.ForeColor = color1;
            lbl_ProgPer.Font = new Font("Arial", 12, FontStyle.Regular);
            lbl_ProgPer.Location = new System.Drawing.Point(442, 140);
            lbl_ProgPer.Name = "lbl_ProgPer";
            lbl_ProgPer.Size = new System.Drawing.Size(70, 23);
            lbl_ProgPer.TabIndex = 9;
            lbl_ProgPer.Text = "0%";
            lbl_ProgPer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbox_DownloadFile
            // 
            txtbox_DownloadFile.BackColor = color1;
            txtbox_DownloadFile.BorderColor = color5;
            txtbox_DownloadFile.Enabled = false;
            txtbox_DownloadFile.Font = font4;
            txtbox_DownloadFile.Location = new System.Drawing.Point(220, 15);
            txtbox_DownloadFile.Name = "txtbox_DownloadFile";
            txtbox_DownloadFile.Size = new System.Drawing.Size(480, 36);
            txtbox_DownloadFile.TabIndex = 8;
            txtbox_DownloadFile.Texts = "Now downloading: \r\n";
            // 
            // progbar_DownloadPrc
            // 
            progbar_DownloadPrc.Location = new System.Drawing.Point(13, 85);
            progbar_DownloadPrc.Name = "progbar_DownloadPrc";
            progbar_DownloadPrc.Size = new System.Drawing.Size(924, 48);
            progbar_DownloadPrc.TabIndex = 0;
            // 
            // pnl_DownloadProc
            // 
            this.pnl_DownloadProc.BackColor = color4;
            this.pnl_DownloadProc.Controls.Add(btn_StartDownload);
            this.pnl_DownloadProc.Controls.Add(lbl_ProgPer);
            this.pnl_DownloadProc.Controls.Add(txtbox_DownloadFile);
            this.pnl_DownloadProc.Controls.Add(progbar_DownloadPrc);
            this.pnl_DownloadProc.Location = new System.Drawing.Point(13, 424);
            this.pnl_DownloadProc.Name = "pnl_DownloadProc";
            this.pnl_DownloadProc.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.pnl_DownloadProc.Size = new System.Drawing.Size(950, 269);
            this.pnl_DownloadProc.TabIndex = 1;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = color2;
            this.ClientSize = new System.Drawing.Size(1284, 811);
            this.Controls.Add(this.tabpage_Apps);
            this.Controls.Add(this.tabpage_Tools);
            this.Controls.Add(this.tabpage_Other);
            this.Controls.Add(this.tablepnl_Console);
            this.Controls.Add(this.tablepnl_LeftPanel);
            this.Controls.Add(this.tablepnl_TopPanel);
            this.Controls.Add(this.pnl_Profiles);
            this.Controls.Add(this.pnl_Download);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Downloader";
            this.Icon = Icon.ExtractAssociatedIcon("E:\\Загрузки\\downloading.ico");
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.FormClosing += MainFrame_FormClosing;
            this.tablepnl_TopPanel.ResumeLayout(false);
            this.tablepnl_TopPanel.PerformLayout();
            this.tablepnl_LeftPanel.ResumeLayout(false);
            this.tablepnl_Console.ResumeLayout(false);
            this.tablepnl_Console.PerformLayout();
            this.tabpage_Apps.ResumeLayout(false);
            this.tab_Browsers.ResumeLayout(false);
            this.tab_Launchers.ResumeLayout(false);
            this.tab_Media.ResumeLayout(false);
            this.tab_Communication.ResumeLayout(false);
            this.tab_Programming.ResumeLayout(false);
            this.tab_Overview.ResumeLayout(false);
            this.tab_Tests.ResumeLayout(false);
            this.tab_Network.ResumeLayout(false);
            this.tab_OSsAndISOs.ResumeLayout(false);
            this.tab_Disk.ResumeLayout(false);
            this.tab_Protection.ResumeLayout(false);
            this.tab_OtherApps.ResumeLayout(false);
            this.tab_Archives.ResumeLayout(false);
            this.tabpage_Tools.ResumeLayout(false);
            this.tabpage_Other.ResumeLayout(false);
            this.pnl_Profiles.ResumeLayout(false);
            this.pnl_Download.ResumeLayout(false);
            this.pnl_DownloadProc.ResumeLayout(false);
            this.pnl_DestFolder.ResumeLayout(false);
            this.pnl_DestFolder.PerformLayout();
            this.pnl_SelectedApps.ResumeLayout(false);
            this.pnl_SelectedApps.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btn_ClearAll;
        private MyToggleButton chkbox_TryInstall;
        private System.Windows.Forms.Button btn_BrowseFolder;
        private MyTextBox txtbox_SelectedApps;
        private MyTextBox txtbox_TryInstall;
        public static System.Windows.Forms.Button btn_StartDownload;
        public static MyTextBox txtbox_DownloadFile;
        public static Label lbl_CurApps;
        public static Label lbl_ImageStatus;
        public static System.Windows.Forms.ProgressBar progbar_DownloadPrc;
        public static Label lbl_ProgPer;
        public static RichTextBox richtxtbox_Console;
    }
}

