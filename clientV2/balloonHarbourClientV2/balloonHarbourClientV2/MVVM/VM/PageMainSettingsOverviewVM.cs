using balloonHarbourClientV2.MVVM.V.MainFieldPages;
using balloonHarbourClientV2.MVVM.V.MainPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balloonHarbourClientV2.MVVM.VM.Commands {


    class PageMainSettingsOverviewVM {
        private PageMainSettingsOverview pageMainSettingsOverview;
        private ButtonSettingsExitClickCommand buttonSettingsExitClickCommand;
        private PageInProgram pageInProgram;
        private PageMainChatOverview pageMainChatOverview;
        private string pageHeaderName = "Settings";
        public PageMainSettingsOverviewVM(PageMainSettingsOverview pageMainSettingsOverview, PageInProgram pageInProgram, PageMainChatOverview pageMainChatOverview) {
            this.pageMainSettingsOverview = pageMainSettingsOverview;
            this.pageInProgram = pageInProgram;
            this.pageMainChatOverview = pageMainChatOverview;
            buttonSettingsExitClickCommand = new ButtonSettingsExitClickCommand(pageInProgram, pageMainChatOverview);
        }
        public PageMainSettingsOverview PageMainSettingsOverview { get => pageMainSettingsOverview;}
        public string PageHeaderName { get => pageHeaderName;}
        public ButtonSettingsExitClickCommand ButtonSettingsExitClickCommand { get => buttonSettingsExitClickCommand; set => buttonSettingsExitClickCommand = value; }
    }
}
