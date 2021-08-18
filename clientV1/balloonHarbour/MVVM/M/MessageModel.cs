using System;

namespace balloonHarbour.MVVM.M {
    internal class MessageModel {
        private DateTime _time;
        private ContactModel _Contact;
        private string _imageSource;
        private string _message;
        private bool _isNativeOrigin;
        private bool? _firstMessage;

        public string ImageSource { get => _imageSource; set => _imageSource = value; }
        public string Message { get => _message; set => _message = value; }
        public DateTime Time { get => _time; set => _time = value; }
        public bool IsNativeOrigin { get => _isNativeOrigin; set => _isNativeOrigin = value; }
        public bool? FirstMessage { get => _firstMessage; set => _firstMessage = value; }
    }
}
