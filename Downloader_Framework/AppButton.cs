using System;
using System.Drawing;
using System.Windows.Forms;

namespace Downloader_Framework
{
    public class AppButton : Button
    {
        public AppToDownload appToDownload;

        public AppButton(AppToDownload appToDownload)
        {
            this.appToDownload = appToDownload;
            this.Size = new Size(115, 80);
            this.Image = appToDownload.GetIcon();
            this.Text = appToDownload.appName;
            this.Margin = new Padding(10);
            this.TextAlign = ContentAlignment.BottomCenter;
            this.ImageAlign = ContentAlignment.TopCenter;
            this.Click += appButton_Click;
            this.FlatStyle = FlatStyle.Flat;
            this.BackColor = MainFrame.color2;
            this.Cursor = Cursors.Hand;
            this.FlatAppearance.BorderColor = MainFrame.color1;
            this.FlatAppearance.BorderSize = 2;
        }

        //Adds app to selected apps list unless it was already pressed or was copied from profile's list.
        //In those cases app will be removed from the list.
        private void appButton_Click(object sender, EventArgs e)
        {
            if (this.Tag == "copied")
            {
                this.BackColor = MainFrame.color2;
                this.Tag = "";
                MainFrame.CompareButtonAndApp(appToDownload.appName);
                MainFrame.UpdateSelectedApps();

            }
            else if (!MainFrame.list_SelectedApps.Contains(this.appToDownload))
            {
                MainFrame.list_SelectedApps.Add(this.appToDownload);
                this.BackColor = MainFrame.color7;
                MainFrame.UpdateSelectedApps();
            }

            else
            {
                MainFrame.list_SelectedApps.Remove(this.appToDownload);
                this.BackColor = MainFrame.color2;
                MainFrame.UpdateSelectedApps();
            }
        }
    }
}
