using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Xamarin.Forms;

namespace Downloader_Framework
{
    public class ProfilePanel : Panel
    {
        private TextBox txtbox_ProfileName = new TextBox();
        private System.Windows.Forms.Button btn_CopyProfile = new System.Windows.Forms.Button();
        private System.Windows.Forms.Button btn_DeleteProfile = new System.Windows.Forms.Button();
        private FlowLayoutPanel flowpnl_ProfilesApps = new FlowLayoutPanel();
        public List<AppToDownload> list_ProfileApps = new List<AppToDownload>();
        public string name_Profile;
        public int id_Number;
        public ProfilePanel(string nameProfile, List<AppToDownload> listApps)
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
            this.BackColor = MainFrame.color6;
            this.Controls.Add(txtbox_ProfileName);
            this.Controls.Add(btn_CopyProfile);
            this.Controls.Add(btn_DeleteProfile);
            this.Controls.Add(flowpnl_ProfilesApps);
            this.Location = new System.Drawing.Point(13, 13);
            this.Name = "ProfilesPanel";
            this.Padding = new Padding(5);
            this.Tag = id_Number + Int32.Parse(MainFrame.GenerateRandomNumbersForID());
            this.Size = new System.Drawing.Size(923, 115);
            this.TabIndex = 0;

            txtbox_ProfileName.Location = new System.Drawing.Point(6, 7);
            txtbox_ProfileName.Name = "txtbox_ProfileName";
            txtbox_ProfileName.Size = new System.Drawing.Size(170, 24);
            txtbox_ProfileName.TabIndex = 0;
            txtbox_ProfileName.Text = this.name_Profile;
            txtbox_ProfileName.TextChanged += Profile_name_TextChanged;
            txtbox_ProfileName.BackColor = MainFrame.color4;
            txtbox_ProfileName.ForeColor = MainFrame.color1;
            txtbox_ProfileName.Font = MainFrame.font3;

            btn_CopyProfile.Location = new System.Drawing.Point(190, 5);
            btn_CopyProfile.Name = "btn_CopyProfile";
            btn_CopyProfile.Size = new System.Drawing.Size(95, 23);
            btn_CopyProfile.TabIndex = 3;
            btn_CopyProfile.Text = "Copy profile";
            btn_CopyProfile.UseVisualStyleBackColor = true;
            btn_CopyProfile.Click += CopyPrf_btn_Click;
            btn_CopyProfile.BackColor = MainFrame.color4;
            btn_CopyProfile.ForeColor = MainFrame.color1;
            btn_CopyProfile.FlatStyle = FlatStyle.Flat;
            btn_CopyProfile.FlatAppearance.BorderSize = 1;
            btn_CopyProfile.MouseEnter += FocusOnButton;
            btn_CopyProfile.MouseLeave += LeaveButton;
            btn_CopyProfile.Font = MainFrame.font3;

            btn_DeleteProfile.Location = new System.Drawing.Point(820, 5);
            btn_DeleteProfile.Name = "btn_DeleteProfile";
            btn_DeleteProfile.Size = new System.Drawing.Size(95, 23);
            btn_DeleteProfile.TabIndex = 4;
            btn_DeleteProfile.Text = "Delete";
            btn_DeleteProfile.UseVisualStyleBackColor = true;
            btn_DeleteProfile.Tag = this.Tag;
            btn_DeleteProfile.Click += MainFrame.DeleteProfile_Click;
            btn_DeleteProfile.BackColor = MainFrame.color4;
            btn_DeleteProfile.ForeColor = MainFrame.color1;
            btn_DeleteProfile.FlatStyle = FlatStyle.Flat;
            btn_DeleteProfile.FlatAppearance.BorderSize = 1;
            btn_DeleteProfile.MouseEnter += FocusOnButton;
            btn_DeleteProfile.MouseLeave += LeaveButton;
            btn_DeleteProfile.Font = MainFrame.font3;

            flowpnl_ProfilesApps.Location = new System.Drawing.Point(5, 33);
            flowpnl_ProfilesApps.Name = "flowpnl_ProfilesApps";
            flowpnl_ProfilesApps.Size = new System.Drawing.Size(910, 78);
            flowpnl_ProfilesApps.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;

            flowpnl_ProfilesApps.TabIndex = 5;
            flowpnl_ProfilesApps.BackColor = MainFrame.color2;

            foreach (AppToDownload app in list_ProfileApps)
            {
                System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
                lbl.AutoSize = false;
                lbl.Size = new System.Drawing.Size(20, 20);
                lbl.FlatStyle = FlatStyle.Standard;
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
                        appButton.BackColor = MainFrame.color7;
                        appButton.Tag = "copied";

                    }
                    else
                    {
                        appButton.BackColor = MainFrame.color2;
                    }
                }
            }
            MainFrame.UpdateSelectedApps();
            MainFrame.AppendTextToConsole("Copied profile's apps.");
        }

        private void FocusOnButton(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            button.BackColor = MainFrame.color2;
        }
        private void LeaveButton(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            button.BackColor = MainFrame.color4;
        }
    }
}
