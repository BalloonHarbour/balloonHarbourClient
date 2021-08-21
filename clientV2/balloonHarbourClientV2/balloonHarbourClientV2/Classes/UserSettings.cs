using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balloonHarbourClientV2.Classes {
    public class UserSettings {
        //Client Interface
        private string theme;
        //Client
        private string clientActualVersion;
        private string autoUpdate;
        private string operatingSystemLast;
        private string[] operatingSystems;

        public UserSettings() {

        }

        public string Theme { get => theme; set => theme = value; }
        public string ClientActualVersion { get => clientActualVersion; set => clientActualVersion = value; }
        public string AutoUpdate { get => autoUpdate; set => autoUpdate = value; }
        public string OperatingSystemLast { get => operatingSystemLast; set => operatingSystemLast = value; }
    }
}
