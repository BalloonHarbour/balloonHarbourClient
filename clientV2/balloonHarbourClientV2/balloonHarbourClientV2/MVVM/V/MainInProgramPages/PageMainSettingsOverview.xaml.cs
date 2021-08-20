using balloonHarbourClientV2.MVVM.V.MainPages;
using balloonHarbourClientV2.MVVM.VM.Commands;
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

namespace balloonHarbourClientV2.MVVM.V.MainFieldPages {
    /// <summary>
    /// Interaction logic for MainSettingsPage.xaml
    /// </summary>
    public partial class PageMainSettingsOverview : Page {
        public PageMainSettingsOverview(PageInProgram pageInProgram, PageMainChatOverview pageMainChatOverview) {
            InitializeComponent();
            DataContext = new PageMainSettingsOverviewVM(this, pageInProgram , pageMainChatOverview);
        }
    }
}
