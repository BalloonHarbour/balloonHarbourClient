using System;
using System.Windows;
using System.Windows.Input;

namespace balloonHarbour.Commands {

    internal class MinimizeMainWindowCommand : ICommand {
        public MinimizeMainWindowCommand(MainWindow view) {
            _View = view;
        }
        private readonly MainWindow _View;

        public event EventHandler CanExecuteChanged {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter) {
            return true;
        }

        public void Execute(object parameter) {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
    }
}
