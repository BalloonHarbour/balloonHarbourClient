using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace balloonHarbourClientV2.MVVM.V {
    /// <summary>
    /// Interaction logic for PageAccountCreation.xaml
    /// </summary>
    public partial class PageAccountCreation : Page, IPageMain {
        private string pageHeader = "Greetings!";
        public PageAccountCreation() {
            InitializeComponent();
        }

        public string PageHeader { get => pageHeader; set => pageHeader = value; }
    }
}
