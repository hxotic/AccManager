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
        private static string folderdirname = "pastedv2";

        public static string[] DefaultSettings = { "false", "500", "J!IUDIUHIUERIUFIERFUOERUHFEOROWPED(&^&*()" };

        public static string settingsdir = $"C:/{folderdirname}";
        public static string nicknamesloc = $"{settingsdir}/Nicknames.txt";
        public static string usernamesloc = $"{settingsdir}/Usernames.txt";
        public static string passwordsloc = $"{settingsdir}/Passwords.txt";
        public static string settingsfile = $"{settingsdir}/Settings.txt";

        public static string steamdir = GetSteamDir();
        public static bool hidepassword = GetHidePassword();
        public static int hidepassworddelay = GetHidePasswordDelay();
        public static string encryption_key = GetEncryptionKey();


        static void CheckSettings()
        {
            if (File.Exists(settingsfile))
            {
                string[] file = File.ReadAllLines(settingsfile);
                if (file.Length != 3)
                {
                    File.WriteAllLines(settingsfile, DefaultSettings);
                }
            }
        }

        static string GetEncryptionKey()
        {
            CheckSettings();
            if (File.Exists(settingsfile))
            {
                string encryptionkey = File.ReadAllLines(settingsfile)[2];
                return encryptionkey;
            }
            else
            {
                File.WriteAllLines(settingsfile, DefaultSettings);
                return GetEncryptionKey();
            }
        }

        static bool GetHidePassword()
        {
            CheckSettings();
            if (File.Exists(settingsfile))
            {
                string hidepasswordcontents = File.ReadAllLines(settingsfile)[0];
                return Convert.ToBoolean(hidepasswordcontents);
            }
            else
            {
                File.WriteAllLines(settingsfile, DefaultSettings);
                return GetHidePassword();
            }
        }

        static int GetHidePasswordDelay()
        {
            CheckSettings();
            if (File.Exists(settingsfile))
            {
                return Convert.ToInt16(File.ReadAllLines(settingsfile)[1]);
            }
            else
            {
                File.WriteAllLines(settingsfile, DefaultSettings);
                return GetHidePasswordDelay();
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
