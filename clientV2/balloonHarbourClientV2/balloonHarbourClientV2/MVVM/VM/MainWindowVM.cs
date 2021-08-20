using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using balloonHarbourClientV2.MVVM.V;
using balloonHarbourClientV2.MVVM.V.MainPages;

namespace balloonHarbourClientV2.MVVM.VM {
    public class MainWindowVM {
        private MainWindow _View;
        private PageChatOverview pageChatOverview;
        private PageContactBar pageContactBar;
        private PageAccountCreation pageAccountCreation;
        public MainWindowVM( MainWindow view) {
            this.View = view;

            pageChatOverview = new PageChatOverview();
            pageContactBar = new PageContactBar();
            pageAccountCreation = new PageAccountCreation(this);
            pageChatOverview.FrameContactBar.Content = pageContactBar;


            view.FrameMain.Content = pageAccountCreation;
        }

        public MainWindow View { get => _View; set => _View = value; }
        public PageChatOverview PageChatOverview { get => pageChatOverview; set => pageChatOverview = value; }
        public PageContactBar PageContactBar { get => pageContactBar; set => pageContactBar = value; }
        public PageAccountCreation PageAccountCreation { get => pageAccountCreation; set => pageAccountCreation = value; }
    }
}
