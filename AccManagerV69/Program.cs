using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccManagerV69
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Settings.steamdir == "")
            {
                string steamdirectory = "C:/Program Files (x86)/Steam/";
                if (!Directory.Exists(steamdirectory))
                {
                    Application.Run(new SteamDirForm());
                }
                else
                {
                    Settings.steamdir = steamdirectory;
                    File.WriteAllText($"{Settings.settingsdir}/dir.txt", steamdirectory);
                    Application.Run(new MainForm());
                }
            }
            else
            {
                Application.Run(new MainForm());
            }
        }
    }
}
