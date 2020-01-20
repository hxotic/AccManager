using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccManagerV69
{
    public class Settings
    {
        public static string encryption_key = "J!IUDIUHIUERIUFIERFUOERUHFEOROWPED(&^&*()";

        private static string folderdirname = "pastedv2";

        public static string settingsdir = $"C:/{folderdirname}";
        public static string nicknamesloc = $"{settingsdir}/Nicknames.txt";
        public static string usernamesloc = $"{settingsdir}/Usernames.txt";
        public static string passwordsloc = $"{settingsdir}/Passwords.txt";
        public static string settingsfile = $"{settingsdir}/Settings.txt";

        public static string steamdir = GetSteamDir();
        public static bool hidepassword = GetHidePassword();
        public static int hidepassworddelay = GetHidePasswordDelay();

        static bool GetHidePassword()
        {
            if (File.Exists(settingsfile))
            {
                string hidepasswordcontents = File.ReadAllLines(settingsfile)[0];
                return Convert.ToBoolean(hidepasswordcontents);
            }
            else
            {
                File.WriteAllLines(settingsfile, new string[] { "false", "500" } );
                return false;
            }
        }

        static int GetHidePasswordDelay()
        {
            if (File.Exists(settingsfile))
            {
                return Convert.ToInt16(File.ReadAllLines(settingsfile)[1]);
            }
            else
            {
                File.WriteAllLines(settingsfile, new string[] { "false", "500" });
                return 500;
            }
        }

        static string GetSteamDir()
        {
            string steamdirsetting = $"{settingsdir}/dir.txt";
            if (File.Exists(steamdirsetting))
            {
                string steamfiledir = File.ReadAllLines(steamdirsetting)[0];
                if (!File.Exists($"{steamfiledir}/Steam.exe"))
                {
                    return "";
                }
                else
                {
                    return steamfiledir;
                }
            }
            else
            {
                Directory.CreateDirectory(settingsdir);
                return "";
            }
        }

    }
}
