using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using balloonHarbourClientV2.MVVM.V;
using balloonHarbourClientV2.MVVM.V.MainPages;

namespace balloonHarbourClientV2.MVVM.VM {
    class MainWindowVM {
        private MainWindow _View;
        public MainWindowVM( MainWindow view) {
            this.View = view;
            PageChatOverview pageChatOverview = new PageChatOverview();
            PageContactBar pageContactBar = new PageContactBar();
            PageAccountCreation pageAccountCreation = new PageAccountCreation();
            pageChatOverview.FrameContactBar.Content = pageContactBar;


            view.FrameMain.Content = pageAccountCreation;
        }

        private MainWindow View { get => _View; set => _View = value; }
    }
}
