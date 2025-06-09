using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.FlatAppearance.BorderColor = Color.Green;
            this.FlatAppearance.BorderSize = 1;

        }
        private void appButton_Click(object sender, EventArgs e)
        {
            if (this.Tag == "copied")
            {
                this.FlatAppearance.BorderColor = Color.Green;
                this.Tag = "";
                MainFrame.CompareButtonAndApp(appToDownload.appName);
                MainFrame.UpdateSelectedApps();

            }
            else if (!MainFrame.list_SelectedApps.Contains(this.appToDownload))
            {
                MainFrame.list_SelectedApps.Add(this.appToDownload);
                this.FlatAppearance.BorderColor = Color.Red;
                MainFrame.UpdateSelectedApps();
            }

            else
            {
                MainFrame.list_SelectedApps.Remove(this.appToDownload);
                this.FlatAppearance.BorderColor = Color.Green;
                MainFrame.UpdateSelectedApps();
            }
        }
    }
}
