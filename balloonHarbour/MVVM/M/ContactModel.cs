using System.Collections.ObjectModel;

namespace balloonHarbour.MVVM.M {
    internal class ContactModel {
        private string _username;
        private string _adress;
        private string _imageColor;
        private ObservableCollection<MessageModel> _Messages;
        private string _LastMessage => _Messages[^1].Message;
        public string Username { get => _username; set => _username = value; }
        public string ImageColor { get => _imageColor; set => _imageColor = value; }
        public ObservableCollection<MessageModel> Messages { get => _Messages; set => _Messages = value; }
        public string LastMessage => _LastMessage;
        public string Adress { get => _adress; set => _adress = value; }
    }
}
