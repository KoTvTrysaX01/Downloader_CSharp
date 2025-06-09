using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Downloader_Framework
{
    public class PorfilePanel : Panel
    {
        private TextBox txtbox_ProfileName = new TextBox();
        private Button btn_CopyProfile = new Button();
        private Button btn_DeleteProfile = new Button();
        private FlowLayoutPanel flowpnl_ProfilesApps = new FlowLayoutPanel();
        public List<AppToDownload> list_ProfileApps = new List<AppToDownload>();
        public string name_Profile;
        public int id_Number;
        public PorfilePanel(string nameProfile, List<AppToDownload> listApps)
        {
            try
            {
                foreach (AppToDownload app in listApps)
                {
                    if (app != null)
                    {
                        var a = (AppToDownload)app.Clone();
                        list_ProfileApps.Add(a);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            this.id_Number = MainFrame.list_UsersProfiles.Any() ? MainFrame.list_UsersProfiles.Max(item => item.id_Number) + 1 : 0;
            this.name_Profile = string.IsNullOrWhiteSpace(nameProfile) ? "#Profile " + id_Number : nameProfile;

            this.BackColor = SystemColors.MenuHighlight;
            this.Controls.Add(txtbox_ProfileName);
            this.Controls.Add(btn_CopyProfile);
            this.Controls.Add(btn_DeleteProfile);
            this.Controls.Add(flowpnl_ProfilesApps);
            this.Location = new Point(13, 13);
            this.Name = "ProfilesPanel";
            this.Padding = new Padding(5);
            this.Size = new Size(923, 115);
            this.TabIndex = 0;

            txtbox_ProfileName.Location = new Point(8, 8);
            txtbox_ProfileName.Name = "txtbox_ProfileName";
            txtbox_ProfileName.Size = new Size(170, 23);
            txtbox_ProfileName.TabIndex = 0;
            txtbox_ProfileName.Text = this.name_Profile;
            txtbox_ProfileName.TextChanged += Profile_name_TextChanged;

            btn_CopyProfile.Location = new Point(190, 8);
            btn_CopyProfile.Name = "btn_CopyProfile";
            btn_CopyProfile.Size = new Size(95, 23);
            btn_CopyProfile.TabIndex = 3;
            btn_CopyProfile.Text = "Copy profile";
            btn_CopyProfile.UseVisualStyleBackColor = true;
            btn_CopyProfile.Click += CopyPrf_btn_Click;

            btn_DeleteProfile.Location = new Point(820, 8);
            btn_DeleteProfile.Name = "btn_DeleteProfile";
            btn_DeleteProfile.Size = new Size(95, 23);
            btn_DeleteProfile.TabIndex = 4;
            btn_DeleteProfile.Text = "Delete";
            btn_DeleteProfile.UseVisualStyleBackColor = true;
            btn_DeleteProfile.Tag = id_Number;
            btn_DeleteProfile.Click += MainFrame.DeleteProfile_Click;

            flowpnl_ProfilesApps.Location = new Point(5, 33);
            flowpnl_ProfilesApps.Name = "flowpnl_ProfilesApps";
            flowpnl_ProfilesApps.Size = new Size(910, 78);
            flowpnl_ProfilesApps.FlowDirection = FlowDirection.LeftToRight;

            flowpnl_ProfilesApps.TabIndex = 5;
            flowpnl_ProfilesApps.BackColor = Color.Green;

            foreach (AppToDownload app in list_ProfileApps)
            {
                Label lbl = new Label();
                lbl.AutoSize = false;
                lbl.Size = new Size(20, 20);
                lbl.FlatStyle = FlatStyle.Standard;
                lbl.BackColor = Color.Red;
                lbl.Image = MainFrame.ResizeImage(app.GetIcon(), 20, 20);
                lbl.Margin = new Padding(3);

                flowpnl_ProfilesApps.Controls.Add(lbl);
            }
            flowpnl_ProfilesApps.ResumeLayout();
        }

        private void Profile_name_TextChanged(object sender, EventArgs e)
        {
            TextBox texbox = (TextBox)sender;
            this.name_Profile = texbox.Text;
        }

        private void CopyPrf_btn_Click(object sender, EventArgs e)
        {
            MainFrame.list_SelectedApps.Clear();

            foreach (AppButton appButton in MainFrame.list_AppButtons)
            {
                appButton.Tag = "";
            }

            foreach (AppToDownload app in list_ProfileApps)
            {
                var a = (AppToDownload)app.Clone();
                MainFrame.list_SelectedApps.Add(a);

                foreach (AppButton appButton in MainFrame.list_AppButtons)
                {
                    if (appButton.appToDownload.appName == a.appName || appButton.Tag == "copied")
                    {
                        appButton.FlatAppearance.BorderColor = Color.Yellow;
                        appButton.Tag = "copied";

                    }
                    else
                    {
                        appButton.FlatAppearance.BorderColor = Color.Green;
                    }
                }
            }
            MainFrame.UpdateSelectedApps();
            MainFrame.AppendTextToConsole("Copied profile's apps.");
        }
    }
}
