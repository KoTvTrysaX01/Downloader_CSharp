using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Downloader_Framework
{

    //Contains information to write JSON file and create ProfilePanel
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
