using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace balloonHarbourClientV2.Classes {
    static class LoginGif {
        
        static public string GetRandomLoginGif() {
            string filepath = "./Resources/Image/Gif/Login/";
            Directory.CreateDirectory(filepath);

            Properties.Resources.LoginCat3.Save(filepath + "LoginCat3.gif");
            Properties.Resources.LoginCat2.Save(filepath + "LoginCat2.gif");

            DirectoryInfo d = new DirectoryInfo(filepath);

            List<FileInfo> loginGifFiles = new List<FileInfo>();

            foreach (var file in d.GetFiles("*.gif")) {
                loginGifFiles.Add(file);
            }

            Random rnd = new Random();
            return loginGifFiles[rnd.Next(0, loginGifFiles.Count)].FullName;
        }
    }
}
