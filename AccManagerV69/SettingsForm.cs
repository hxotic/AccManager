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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            hidepasswordcheckBox.Checked = Settings.hidepassword;
            delaytextBox.Text = Settings.hidepassworddelay.ToString();
            delaytextBox.Enabled = hidepasswordcheckBox.Checked;
            encryptionpasswordtextBox.Text = Settings.encryption_key;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Settings.hidepassword = hidepasswordcheckBox.Checked;
            Settings.hidepassworddelay = Convert.ToInt16(delaytextBox.Text);
            Settings.encryption_key = encryptionpasswordtextBox.Text;
            File.WriteAllLines(Settings.settingsfile, new string[] { hidepasswordcheckBox.Checked.ToString(), Settings.hidepassworddelay.ToString(), Settings.encryption_key });
            Close();
        }

        private void hidepasswordcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            delaytextBox.Enabled = hidepasswordcheckBox.Checked;
        }

        private void defaultsettingsbutton_Click(object sender, EventArgs e)
        {
            hidepasswordcheckBox.Checked = Convert.ToBoolean(Settings.DefaultSettings[0]);
            delaytextBox.Text = Settings.DefaultSettings[1];
            encryptionpasswordtextBox.Text = Settings.DefaultSettings[2];
        }

    }
}
