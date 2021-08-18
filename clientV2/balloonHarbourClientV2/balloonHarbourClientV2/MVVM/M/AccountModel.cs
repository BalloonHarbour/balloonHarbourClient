using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using balloonHarbourClientV2.Classes;

namespace balloonHarbourClientV2.MVVM.M {
    class AccountModel {

        private string _username;
        private string _passwordHash;
        private int _accountNumber;
        private Color _AccountColor;
        private AvatarImage _Avi;

        #region ctor
        public AccountModel(string username, string passwordhash) {
            Avi = new AvatarImage(username);
            AccountColor = Avi.Color;
            this.Username = username;
        }
        #endregion
        #region methods
        public string Username { get => _username;
            set {
               _username = value;
               Avi.Username = value;             
            }
        }
        #endregion
        #region properties
        public int AccountNumber { get => _accountNumber; }

        public Color AccountColor { get => _AccountColor; 
            set {
                Avi.Color = value;
                _AccountColor = value; 
            } 
        }

        private AvatarImage Avi { get => _Avi; set => _Avi = value; }
        #endregion
    }
}
