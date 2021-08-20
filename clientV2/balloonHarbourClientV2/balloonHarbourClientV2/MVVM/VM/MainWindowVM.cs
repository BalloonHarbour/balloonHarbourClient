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

            EncryptionMethod enc_method = new secp256r1();
            ECC ecc1 = new ECC(enc_method);
            ECC ecc2 = new ECC(enc_method);
            BigInteger[] keys_1 = ecc1.genKeys("be11435322fe1e1d9cc866e090d47277182f7181cff7a0a7671af1cd5067a03d");
            BigInteger[] keys_2 = ecc2.genKeys("37613dc20b9949c4ce72584cdc86046f2b9ecbc5be984ffb602e9aea32735aed");

            BigInteger[] pub_key_1 = new BigInteger[2];
            BigInteger[] pub_key_2 = new BigInteger[2];

            pub_key_1[0] = keys_1[1];
            pub_key_1[1] = keys_1[2];

            pub_key_2[0] = keys_2[1];
            pub_key_2[1] = keys_2[2];

            //MessageBox.Show("PrK_1: " + BitConverter.ToString(keys_1[0].ToByteArray()).Replace("-", "").ToLower() + "\nPuK_1: (" + BitConverter.ToString(keys_1[1].ToByteArray()).Replace("-", "").ToLower() + ", " + BitConverter.ToString(keys_1[2].ToByteArray()).Replace("-", "").ToLower() + ")\n\nPrK_2: " + BitConverter.ToString(keys_2[0].ToByteArray()).Replace("-", "").ToLower() + "\nPuK_2: (" + BitConverter.ToString(keys_2[1].ToByteArray()).Replace("-", "").ToLower() + ", " + BitConverter.ToString(keys_2[2].ToByteArray()).Replace("-", "").ToLower() + ")");
            //MessageBox.Show("PrK_1: " + keys_1[0] + "\nPuK_1: (" + keys_1[1] + ", " + keys_1[2] + ")\n\nPrK_2: " + keys_2[0] + "\nPuK_2: (" + keys_2[1] + ", " + keys_2[2] + ")");

            MessageBox.Show(keys_1[0].ToString() + "\n" + keys_1[1] + "\n" + keys_1[2] + "\n\n" + keys_2[0].ToString() + "\n" + keys_2[1] + "\n" + keys_2[2] + "\n\nSec1: " + ecc1.point_mult(keys_1[0], pub_key_2)[0].ToString() + "\n\nSec2: " + ecc2.point_mult(keys_2[0], pub_key_1)[0].ToString());
            
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
