using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace balloonHarbourClientV2.MVVM.VM.Commands {
    class ButtonLoginClickCommand : ICommand {

        private MainWindowVM MainWindowVM;

        public ButtonLoginClickCommand(MainWindowVM mainWindowVM) {
            this.MainWindowVM = mainWindowVM;
        }

        public bool CanExecute(object parameter) {
            return true;
        }

        public void Execute(object parameter) {
            MainWindowVM.View.FrameMain.NavigationService.Navigate(MainWindowVM.PageChatOverview);
        }
        public event EventHandler CanExecuteChanged;
    }
}
