using balloonHarbour.StaticClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace balloonHarbour.MVVM.M {
    class AccountModel {
        private string _username;
        private string _password;
        private AvatarImage _avi;
        private ObservableCollection<ContactModel> _contactList;

        public AccountModel(string username) {
            this.Username = username;
            Avi = new AvatarImage(Username);
        }
        public AccountModel() {
            SetDefaultUsername();
            Avi = new AvatarImage(Username);
        }
        public void SetDefaultUsername() {
            
        }

        public string Username { get => _username; set => _username = value; }
        public AvatarImage Avi { get => _avi; set => _avi = value; }
        public ObservableCollection<ContactModel> ContactList { get => _contactList; set => _contactList = value; }
    }
}
