using balloonHarbour.StaticClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace balloonHarbour.MVVM.M {
    class ProfileModel {
        private string _username;
        private string _adress;
        private AvatarImage _avi;
        private ObservableCollection<ContactModel> _contactList;


        public ProfileModel(string username) {
            this.Username = username;
            Avi = new AvatarImage(Username);
            Adress = LocalAdress.GetIPV4();
        }
        public ProfileModel() {
            SetDefaultUsername();
            Avi = new AvatarImage(Username);
            Adress = LocalAdress.GetIPV4();
        }
        public void SetDefaultUsername() {
            
        }

        public string Username { get => _username; set => _username = value; }
        public string Adress { get => _adress; set => _adress = value; }
        public AvatarImage Avi { get => _avi; set => _avi = value; }
        public ObservableCollection<ContactModel> ContactList { get => _contactList; set => _contactList = value; }
    }
}
