using balloonHarbour.Commands;
using balloonHarbour.MVVM.M;
using System.Collections.ObjectModel;
using System.Windows.Input;


namespace balloonHarbour.MVVM.VM {
    public class MainWindowVM {
        private readonly MainWindow _View;
        private ObservableCollection<ContactModel> _Contacts;
        public MainWindowVM(MainWindow view) {
            _View = view;
            CloseMainWindowCommand = new CloseMainWindowCommand(view);
            MaximizeMainWindowCommand = new MaximizeMainWindowCommand(view);
            MinimizeMainWindowCommand = new MinimizeMainWindowCommand(view);

            //Testing purpose
            
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
    }
}
