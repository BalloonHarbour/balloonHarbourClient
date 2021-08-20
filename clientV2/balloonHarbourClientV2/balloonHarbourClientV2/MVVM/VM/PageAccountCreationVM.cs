using balloonHarbourClientV2.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamlAnimatedGif;
using balloonHarbourClientV2.MVVM.V;
using balloonHarbourClientV2.MVVM.VM.Commands;

namespace balloonHarbourClientV2.MVVM.VM {
    class PageAccountCreationVM {

        private PageAccountCreation View;
        private MainWindowVM MainWindowVM;
        private ButtonLoginClickCommand buttonLoginClick;

        public PageAccountCreationVM(PageAccountCreation view, MainWindowVM mainWindowVM) {
            this.View = view;
            this.MainWindowVM = mainWindowVM;

            buttonLoginClick = new ButtonLoginClickCommand(MainWindowVM);
        }


        public void SetLoginGif() {
            Uri loginImageUri = new Uri(LoginGif.GetRandomLoginGif());
            AnimationBehavior.SetSourceUri(View.ImageLoginGIf, loginImageUri);
        }
        public ButtonLoginClickCommand ButtonLoginClick { get => buttonLoginClick; set => buttonLoginClick = value; }
    }
}
