using balloonHarbourClientV2.MVVM.V.MainFieldPages;
using balloonHarbourClientV2.MVVM.V.MainPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace balloonHarbourClientV2.MVVM.VM.Commands {
    public class ButtonSettingsExitClickCommand : ICommand {
        public event EventHandler CanExecuteChanged;

        private PageInProgram pageInProgram;
        private PageMainChatOverview pageMainChatOverview;

        public ButtonSettingsExitClickCommand(PageInProgram pageInProgram, PageMainChatOverview pageMainChatOverview) {
            this.pageInProgram = pageInProgram;
            this.pageMainChatOverview = pageMainChatOverview;
        }

        public bool CanExecute(object parameter) {
            return true;
        }

        public void Execute(object parameter) {
            pageInProgram.FrameMainField.Content = pageMainChatOverview;
        }
    }
}
