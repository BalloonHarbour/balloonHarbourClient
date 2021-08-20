using balloonHarbourClientV2.MVVM.V.MainPages;
using balloonHarbourClientV2.MVVM.VM.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balloonHarbourClientV2.MVVM.VM {
    class PageInProgramVM {
        private PageInProgram pageInProgram;
        private ButtonProfileClickCommand buttonProfileClickCommand;

        public PageInProgramVM(PageInProgram pageInProgram) {
            this.pageInProgram = pageInProgram;

            buttonProfileClickCommand = new ButtonProfileClickCommand(pageInProgram, pageInProgram.PageMainSettingsOverview);
        }

        public ButtonProfileClickCommand ButtonProfileClickCommand { get => buttonProfileClickCommand; set => buttonProfileClickCommand = value; }
    }
}
