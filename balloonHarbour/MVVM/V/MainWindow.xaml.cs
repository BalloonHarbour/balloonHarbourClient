﻿using balloonHarbour.MVVM.VM;
using System.Windows;
using System.Windows.Input;

namespace balloonHarbour {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = new MainWindowVM(this);
        }
        private void MainWindow_Border_MouseDown(object sender, MouseButtonEventArgs e) {
            if (e.LeftButton == MouseButtonState.Pressed) {
                DragMove();
            }
        }
    }
}
