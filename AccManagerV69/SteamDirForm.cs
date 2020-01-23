using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccManagerV69
{
    public partial class SteamDirForm : Form
    {
        public SteamDirForm()
        {
            InitializeComponent();
        }

        private void SteamDir_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (steamdirectorytextBox.Text == "")
            {
                MessageBox.Show("TextBox Empty!");
                return;
            }

            if (!Directory.Exists(steamdirectorytextBox.Text))
            {
                MessageBox.Show("Directory doesnt exist!");
                return;
            }

            if (!File.Exists($"{steamdirectorytextBox.Text}/Steam.exe"))
            {
                MessageBox.Show("Sure this is the steam directory?");
                MessageBox.Show("its the directory with folders like steamapps and userdata in it");
                return;
            }

            Settings.steamdir = steamdirectorytextBox.Text;
            File.WriteAllText($"{Settings.settingsdir}/dir.txt", steamdirectorytextBox.Text);

            Hide();
            var mainform = new MainForm();
            mainform.Closed += (s, args) => Close();
            mainform.Show();

        }

    }
}
