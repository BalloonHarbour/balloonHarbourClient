using balloonHarbourClientV2.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

// User class not created yet

namespace balloonHarbourClientV2.StaticClasses {
    static public class SettingsManager {
        static public void SaveSettings(User user) {
            string settignsString = JsonSerializer.Serialize(user);
            string settingsDirString = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"BalloonHarbour\" + user.Id + ".user");
            File.WriteAllText(settingsDirString, settignsString);
        }

        static public User GetSettings(int userID) {
            string settingsDirString = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"BalloonHarbour\" + userID + ".user");
            User user = JsonSerializer.Deserialize<User>(settingsDirString);
            return user;
        }

        static public bool CheckIfLocalSettingsExist(int userID) {
            string settingsDirString = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"BalloonHarbour\");
            DirectoryInfo d = new DirectoryInfo(settingsDirString);

            bool userSettingsAvailable = false;

            foreach (var file in d.GetFiles("*.user")) {
                if (file.Name == userID + ".user")
                    userSettingsAvailable = true; break;
            }

            return userSettingsAvailable;
        }
    }
}
