using balloonHarbourClientV2.MVVM.V.MainFieldPages;
using balloonHarbourClientV2.MVVM.VM;
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

namespace balloonHarbourClientV2.MVVM.V.MainPages {
    /// <summary>
    /// Interaction logic for PageChatOverview.xaml
    /// </summary>
    public partial class PageInProgram : Page {


        private PageMainSettingsOverview pageMainSettingsOverview;

        public PageInProgram(PageMainSettingsOverview pageMainSettingsOverview) {
            this.pageMainSettingsOverview = pageMainSettingsOverview;
            InitializeComponent();

            DataContext = new PageInProgramVM(this);
        }

        public PageMainSettingsOverview PageMainSettingsOverview { get => pageMainSettingsOverview; set => pageMainSettingsOverview = value; }
    }
}
