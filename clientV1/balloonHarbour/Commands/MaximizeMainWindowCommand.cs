using System;
using System.Windows;
using System.Windows.Input;

namespace balloonHarbour.Commands {

    internal class MaximizeMainWindowCommand : ICommand {
        public MaximizeMainWindowCommand(MainWindow view) {
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
            if (Application.Current.MainWindow.WindowState != WindowState.Maximized) {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            } else {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
        }
    }
}
