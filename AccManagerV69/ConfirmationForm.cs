using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccManagerV69
{
    public partial class Confirm : Form
    {
        public Confirm()
        {
            InitializeComponent();
        }
        public string Message { get; set; }

        private void ConfirmationForm_Load(object sender, EventArgs e)
        {
            confirmationlabel.Text = Message;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Confirm_FormClosing(object sender, FormClosingEventArgs e)
        {
  
        }

    }
}
