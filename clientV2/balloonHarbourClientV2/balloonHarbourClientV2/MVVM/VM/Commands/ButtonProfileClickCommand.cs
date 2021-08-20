using balloonHarbourClientV2.MVVM.V.MainFieldPages;
using balloonHarbourClientV2.MVVM.V.MainPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace balloonHarbourClientV2.MVVM.VM.Commands {
    public class ButtonProfileClickCommand : ICommand {
        public event EventHandler CanExecuteChanged;

        private PageInProgram pageInProgram;
        private V.MainFieldPages.PageMainSettingsOverview pageMainSettingsOverview;

        public ButtonProfileClickCommand(PageInProgram pageInProgram, PageMainSettingsOverview pageMainSettingsOverview) {
            this.pageInProgram = pageInProgram;
            this.pageMainSettingsOverview = pageMainSettingsOverview;
        }

        public bool CanExecute(object parameter) {
            return true;
        }

        public void Execute(object parameter) {
            pageInProgram.FrameMainField.Content = pageMainSettingsOverview;
            pageInProgram.LabelChatHeader.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
