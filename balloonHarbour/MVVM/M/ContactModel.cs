using System.Collections.ObjectModel;

namespace balloonHarbour.MVVM.M {
    internal class ContactModel {
        private string _username;
        private string _adress;
        private ObservableCollection<MessageModel> _Messages;
        private AvatarImage _Avi;

        public ContactModel(string username) {
            this.Username = username;
            Avi = new AvatarImage(username);
        }

        public string _LastMessage => _Messages[^1].Message;
        public string Username { get => _username; set => _username = value; }
        public string Adress { get => _adress; set => _adress = value; }
        public string LastMessage => _LastMessage;
        public ObservableCollection<MessageModel> Messages { get => _Messages; set => _Messages = value; }
        public AvatarImage Avi { get => _Avi; set => _Avi = value; }
    }
}
