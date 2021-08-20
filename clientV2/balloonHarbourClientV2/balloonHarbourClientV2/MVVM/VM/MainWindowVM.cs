using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using balloonHarbourClientV2.Cryptography;
using balloonHarbourClientV2.Cryptography.hashes;
using balloonHarbourClientV2.Cryptography.methods;
using balloonHarbourClientV2.MVVM.V;
using balloonHarbourClientV2.MVVM.V.MainPages;

namespace balloonHarbourClientV2.MVVM.VM {
    class MainWindowVM {
        private MainWindow _View;
        public MainWindowVM( MainWindow view) {

            EncryptionMethod enc_method = new secp521r1();
            ECC ecc1 = new ECC(enc_method);
            ECC ecc2 = new ECC(enc_method);
            BigInteger[] keys_1 = ecc1.genKeys();
            BigInteger[] keys_2 = ecc2.genKeys();

            MessageBox.Show(BigInteger.Parse("5").ToString() + " * " + ecc1.mod_inv(BigInteger.Parse("5"), BigInteger.Parse("21"))[1].ToString() + " = 1 mod " + BigInteger.Parse("21").ToString());

            //MessageBox.Show("PrK_1: " + BitConverter.ToString(keys_1[0].ToByteArray()).Replace("-", "").ToLower() + "\nPuK_1: (" + BitConverter.ToString(keys_1[1].ToByteArray()).Replace("-", "").ToLower() + ", " + BitConverter.ToString(keys_1[2].ToByteArray()).Replace("-", "").ToLower() + ")\n\nPrK_2: " + BitConverter.ToString(keys_2[0].ToByteArray()).Replace("-", "").ToLower() + "\nPuK_2: (" + BitConverter.ToString(keys_2[1].ToByteArray()).Replace("-", "").ToLower() + ", " + BitConverter.ToString(keys_2[2].ToByteArray()).Replace("-", "").ToLower() + ")");
            //MessageBox.Show("PrK_1: " + keys_1[0] + "\nPuK_1: (" + keys_1[1] + ", " + keys_1[2] + ")\n\nPrK_2: " + keys_2[0] + "\nPuK_2: (" + keys_2[1] + ", " + keys_2[2] + ")");

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
