using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balloonHarbourClientV2.Classes {
    public class User {
        private int id;
        private string username;
        private Color color;
        private DateTime lastOnline;
        private DateTime creationDate;
        private UserSettings settings;

        public User(int id, string username, Color color, DateTime lastOnline, DateTime creationDate, UserSettings settings) {
            this.id = id;
            this.username = username;
            this.color = color;
            this.lastOnline = lastOnline;
            this.creationDate = creationDate;
            this.settings = settings;
        }

        public int Id { get => id;}
        public string Username { get => username; set => username = value; }
        public Color Color { get => color; set => color = value; }
        public DateTime LastOnline { get => lastOnline; set => lastOnline = value; }
        public DateTime CreationDate { get => creationDate;}
        internal UserSettings Settings { get => settings; set => settings = value; }
    }
}
