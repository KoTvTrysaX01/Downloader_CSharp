using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Downloader_Framework
{
    public class AppToDownload : ICloneable
    {
        public string appName;
        public string fileName;
        public string commandLine;
        public string section;
        private Image icon;



        public AppToDownload(string appName, string fileName, string commandLine, string section)
        {
            this.appName = appName;
            this.fileName = fileName;
            this.commandLine = commandLine;
            this.section = section;
            this.icon = Connection.ConvertSqlToImage(this.appName);
        }

        public Image GetIcon() { return this.icon; }
        public void SetIcon(Image icon) { this.icon = icon; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
