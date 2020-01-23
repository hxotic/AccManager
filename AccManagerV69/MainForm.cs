using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccManagerV69
{
    public partial class MainForm : Form
    {
        string s = "\\|/";

        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Settings.nicknamesloc))
            {
                File.Create(Settings.nicknamesloc).Dispose();
            }

            if (!File.Exists(Settings.usernamesloc))
            {
                File.Create(Settings.usernamesloc).Dispose();
            }
            
            if (!File.Exists(Settings.passwordsloc))
            {
                File.Create(Settings.passwordsloc).Dispose();
            }

            RefreshListbox();
            titleTimer.Start();
        }

        private void RefreshListbox()
        {
            accountslistBox.Items.Clear();
            object[] items2 = File.ReadAllLines(Settings.nicknamesloc);
            accountslistBox.Items.AddRange(items2);
            if (accountslistBox.Items.Count == 0)
            {
                 deleteaccountButton.Enabled = false;
                 loginButton.Enabled = false;
                 editaccountbutton.Enabled = false;
            }
            if (accountslistBox.SelectedIndex == -1)
            {
                deleteaccountButton.Enabled = false;
                loginButton.Enabled = false;
                editaccountbutton.Enabled = false;
                usernametextBox.Text = "";
                nicknametextBox.Text = "";
                passwordtextBox.Text = "";
            }
        }

        private static void LineChanger(string fileName, string newText, int line_to_edit)
        {
            string[] array = File.ReadAllLines(fileName);
            array[line_to_edit] = newText;
            File.WriteAllLines(fileName, array);
        }

        public static bool IsProcessRunning(string name)
        {
            Process[] processes = Process.GetProcesses();
            for (int i = 0; i < processes.Length; i++)
            {
                if (processes[i].ProcessName.StartsWith(name))
                {
                    return true;
                }
            }
            return false;
        }

        private void titleTimer_Tick(object sender, EventArgs e)
        {
            int lengthOfMovingPart = 1;
            s = string.Format("{0}{1}", s.Substring(s.Length - lengthOfMovingPart), s.Substring(0, s.Length - lengthOfMovingPart));
            Text = s + "-  Acc Manager - " + s;
        }

        public static string ReadLine(string fileAndPath, int lineNumber)
        {
            string result = null;
            checked
            {
                try
                {
                    using (StreamReader streamReader = new StreamReader(fileAndPath))
                    {
                        int num = 0;
                        while (streamReader.Peek() >= 0 & num < lineNumber)
                        {
                            streamReader.ReadLine();
                            num++;
                        }
                        if (streamReader.Peek() >= 0)
                        {
                            result = streamReader.ReadLine();
                        }
                    }
                }
                catch
                {
                }
                return result;
            }
        }

        private void accountslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = accountslistBox.SelectedIndex;
            if (index == -1)
            {
                deleteaccountButton.Enabled = false;
                loginButton.Enabled = false;
                editaccountbutton.Enabled = false;
                usernametextBox.Text = "";
                nicknametextBox.Text = "";
                passwordtextBox.Text = "";
            }
            else
            {
                deleteaccountButton.Enabled = true;
                loginButton.Enabled = true;
                editaccountbutton.Enabled = true;
                usernametextBox.Text = ReadLine(Settings.usernamesloc, index);
                nicknametextBox.Text = ReadLine(Settings.nicknamesloc, index);
                passwordtextBox.Text = Crypto.Dec(ReadLine(Settings.passwordsloc, index), Settings.encryption_key);
            }
        }

        private void editaccountbutton_Click(object sender, EventArgs e)
        {
            LineChanger(Settings.nicknamesloc, nicknametextBox.Text, accountslistBox.SelectedIndex);
            LineChanger(Settings.usernamesloc, usernametextBox.Text, accountslistBox.SelectedIndex);
            LineChanger(Settings.passwordsloc, Crypto.Enc(passwordtextBox.Text, Settings.encryption_key), accountslistBox.SelectedIndex);
            RefreshListbox();
        }

        public static void DeleteLine(string fileAndPath, int line)
        {
            List<string> list = new List<string>();
            list.AddRange(File.ReadAllLines(fileAndPath));
            if (line < list.Count)
            {
                list.RemoveAt(line);
                File.WriteAllLines(fileAndPath, list.ToArray());
            }
        }

        public void Login_steam(string steam_location, string username, string password)
        {
            Process.Start(steam_location, " -login " + username + " " + password);
            statuspendinglabel.Text = "Logged in!";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            statuspendinglabel.Text = "Logging in...";
            if (IsProcessRunning("Steam"))
            {
                Process.GetProcessesByName("Steam")[0].Kill();
            }
            Login_steam($@"{Settings.steamdir}\Steam.exe", usernametextBox.Text, passwordtextBox.Text);
        }

        private void deleteaccountButton_Click(object sender, EventArgs e)
        {
            string username = nicknametextBox.Text;
            if (username.Length > 4)
            {
                username = nicknametextBox.Text.Substring(0, 4);
            }
            Confirm confirmation = new Confirm
            {
                Message = $"Are you sure you want to delete account '{username}'?"
            };
            DialogResult confresult = confirmation.ShowDialog(this);
            if (confresult == DialogResult.Cancel)
            {
                confirmation.Close();
            }
            else if (confresult == DialogResult.OK)
            {
                DeleteLine(Settings.nicknamesloc, accountslistBox.SelectedIndex);
                DeleteLine(Settings.usernamesloc, accountslistBox.SelectedIndex);
                DeleteLine(Settings.passwordsloc, accountslistBox.SelectedIndex);
                RefreshListbox();
                confirmation.Close();
            }
            confirmation.Dispose();
        }

        private void createaccountbutton_Click(object sender, EventArgs e)
        {
            if (usernametextBox.Text == "" || nicknametextBox.Text == "" || passwordtextBox.Text == "")
            {
                MessageBox.Show("Not all textbox's filled in!");
            }
            else
            {
                statuspendinglabel.Text = "Making Account!";
                try
                {
                    using (StreamWriter writer = new StreamWriter(Settings.nicknamesloc, true))
                    {
                        writer.WriteLine(nicknametextBox.Text);
                    }
                    using (StreamWriter writer = new StreamWriter(Settings.usernamesloc, true))
                    {
                        writer.WriteLine(usernametextBox.Text);
                    }
                    using (StreamWriter writer = new StreamWriter(Settings.passwordsloc, true))
                    {
                        writer.WriteLine(Crypto.Enc(passwordtextBox.Text, Settings.encryption_key));
                    }
                    RefreshListbox();
                    nicknametextBox.Text = "";
                    usernametextBox.Text = "";
                    passwordtextBox.Text = "";
                    statuspendinglabel.Text = "Made Accounts!";
                    loginButton.Enabled = true;
                    return;
                }
                catch
                {
                    statuspendinglabel.Text = "Error Occured!";
                    return;
                }

            }
            RefreshListbox();

        }

        private void settingsbutton_Click(object sender, EventArgs e)
        {
            var settingsform = new SettingsForm();
            settingsform.Closed += (s, args) => { settingsbutton.Enabled = true; settingsform.Dispose(); passwordtextBox.Text += "."; passwordtextBox.Text = passwordtextBox.Text.Substring(0, passwordtextBox.Text.Length - 1);; };
            settingsform.Show();
            settingsbutton.Enabled = false;
        }

        private async void passwordtextBox_TextChanged(object sender, EventArgs e)
        {
            if (Settings.hidepassword == true)
            {
                passwordtextBox.PasswordChar = Convert.ToChar("\0");
                await Task.Delay(Settings.hidepassworddelay);
                passwordtextBox.PasswordChar = Convert.ToChar("*");
            }
            else
            {
                passwordtextBox.PasswordChar = Convert.ToChar("\0");
            }
        }

    }
}
