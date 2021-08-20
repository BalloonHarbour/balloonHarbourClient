using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using balloonHarbourClientV2.Classes;
using balloonHarbourClientV2.MVVM.VM;
using XamlAnimatedGif;

namespace balloonHarbourClientV2.MVVM.V {
    /// <summary>
    /// Interaction logic for PageAccountCreation.xaml
    /// </summary>
    public partial class PageAccountCreation : Page, IPageMain {
        private string pageHeader = "Greetings!";
        public PageAccountCreation(MainWindowVM mainWindowVM) {
            InitializeComponent();
            DataContext = new PageAccountCreationVM(this, mainWindowVM);
        }

        public string PageHeader { get => pageHeader; set => pageHeader = value; }
    }
}
