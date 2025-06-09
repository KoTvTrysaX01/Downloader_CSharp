using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Downloader_Framework
{
    public class Profile
    {
        public string name;
        public List<AppToDownload> apps;

        public Profile(string name, List<AppToDownload> apps)
        {
            this.name = name;
            this.apps = apps;
        }
    }
}
