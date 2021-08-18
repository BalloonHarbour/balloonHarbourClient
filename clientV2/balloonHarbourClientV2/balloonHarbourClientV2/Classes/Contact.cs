using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balloonHarbourClientV2.Classes {
    class Contact {
        private string _username;
        private Color _Color;
        private AvatarImage _Avi;


        public Color Color { get => _Color;}
        public string Username { get => _username;}
        internal AvatarImage Avi { get => _Avi;}
    }
}
