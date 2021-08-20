using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using balloonHarbourClientV2.MVVM.V;
using balloonHarbourClientV2.MVVM.V.MainFieldPages;
using balloonHarbourClientV2.MVVM.V.MainPages;

namespace balloonHarbourClientV2.MVVM.VM {
    public class MainWindowVM {
        private MainWindow _View;
        private PageInProgram pageInProgram;
        private PageContactBar pageContactBar;
        private PageAccountCreation pageAccountCreation;
        private PageMainChatOverview pageMainChatOverview;
        private V.MainFieldPages.PageMainSettingsOverview pageMainSettingsOverview;
        public MainWindowVM( MainWindow view) {
            this.View = view;
            pageMainChatOverview = new PageMainChatOverview();
            pageMainSettingsOverview = new PageMainSettingsOverview(pageInProgram, pageMainChatOverview);
            pageInProgram = new PageInProgram(pageMainSettingsOverview);
            pageContactBar = new PageContactBar();
            pageAccountCreation = new PageAccountCreation(this);
            pageMainChatOverview.FrameContactBar.Content = pageContactBar;


            pageInProgram.FrameMainField.Content = pageMainChatOverview;


            view.FrameMain.Content = pageAccountCreation;
        }

        public MainWindow View { get => _View; set => _View = value; }
        public PageInProgram PageInProgram { get => pageInProgram; set => pageInProgram = value; }
        public PageContactBar PageContactBar { get => pageContactBar; set => pageContactBar = value; }
        public PageAccountCreation PageAccountCreation { get => pageAccountCreation; set => pageAccountCreation = value; }
        public PageMainChatOverview PageMainChatOverview { get => pageMainChatOverview; set => pageMainChatOverview = value; }
        public V.MainFieldPages.PageMainSettingsOverview PageMainSettings { get => pageMainSettingsOverview; set => pageMainSettingsOverview = value; }
    }
}
