using balloonHarbour.Commands;
using balloonHarbour.MVVM.M;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Input;


namespace balloonHarbour.MVVM.VM {
    public class MainWindowVM {
        private readonly MainWindow _View;
        private ProfileModel _CurrentProfile;
        public MainWindowVM(MainWindow view) {
            _View = view;
            CloseMainWindowCommand = new CloseMainWindowCommand(view);
            MaximizeMainWindowCommand = new MaximizeMainWindowCommand(view);
            MinimizeMainWindowCommand = new MinimizeMainWindowCommand(view);

            CurrentProfile = new ProfileModel("Username");

            string name = "a";
            for (int i = 0; i < 100; i++) {
                name += "a";
                var avi = new AvatarImage(name);
            }
        }
        #region Commands
        public ICommand CloseMainWindowCommand {
            get; private set;
        }
        public ICommand MaximizeMainWindowCommand {
            get; private set;
        }
        public ICommand MinimizeMainWindowCommand {
            get; private set;
        }
        #endregion
        internal ProfileModel CurrentProfile { get => _CurrentProfile; set => _CurrentProfile = value; }
    }
}
