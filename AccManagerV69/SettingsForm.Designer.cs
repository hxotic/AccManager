namespace AccManagerV69
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.hidepasswordcheckBox = new System.Windows.Forms.CheckBox();
            this.delaytextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.delaylabel = new System.Windows.Forms.Label();
            this.encryptionpasswordlabel = new System.Windows.Forms.Label();
            this.encryptionpasswordtextBox = new System.Windows.Forms.TextBox();
            this.defaultsettingsbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hidepasswordcheckBox
            // 
            this.hidepasswordcheckBox.AutoSize = true;
            this.hidepasswordcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.hidepasswordcheckBox.ForeColor = System.Drawing.Color.White;
            this.hidepasswordcheckBox.Location = new System.Drawing.Point(15, 12);
            this.hidepasswordcheckBox.Name = "hidepasswordcheckBox";
            this.hidepasswordcheckBox.Size = new System.Drawing.Size(130, 19);
            this.hidepasswordcheckBox.TabIndex = 23;
            this.hidepasswordcheckBox.Text = "Hide Password?";
            this.hidepasswordcheckBox.UseVisualStyleBackColor = true;
            this.hidepasswordcheckBox.CheckedChanged += new System.EventHandler(this.hidepasswordcheckBox_CheckedChanged);
            // 
            // delaytextBox
            // 
            this.delaytextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.delaytextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.delaytextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delaytextBox.ForeColor = System.Drawing.Color.White;
            this.delaytextBox.Location = new System.Drawing.Point(12, 51);
            this.delaytextBox.Name = "delaytextBox";
            this.delaytextBox.Size = new System.Drawing.Size(153, 20);
            this.delaytextBox.TabIndex = 27;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.PaleGreen;
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.ForeColor = System.Drawing.Color.Green;
            this.okButton.Location = new System.Drawing.Point(88, 128);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(48, 23);
            this.okButton.TabIndex = 29;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // delaylabel
            // 
            this.delaylabel.AutoSize = true;
            this.delaylabel.BackColor = System.Drawing.Color.Transparent;
            this.delaylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delaylabel.ForeColor = System.Drawing.Color.White;
            this.delaylabel.Location = new System.Drawing.Point(6, 33);
            this.delaylabel.Name = "delaylabel";
            this.delaylabel.Size = new System.Drawing.Size(76, 15);
            this.delaylabel.TabIndex = 30;
            this.delaylabel.Text = "Delay (ms)";
            // 
            // encryptionpasswordlabel
            // 
            this.encryptionpasswordlabel.AutoSize = true;
            this.encryptionpasswordlabel.BackColor = System.Drawing.Color.Transparent;
            this.encryptionpasswordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptionpasswordlabel.ForeColor = System.Drawing.Color.White;
            this.encryptionpasswordlabel.Location = new System.Drawing.Point(6, 83);
            this.encryptionpasswordlabel.Name = "encryptionpasswordlabel";
            this.encryptionpasswordlabel.Size = new System.Drawing.Size(140, 15);
            this.encryptionpasswordlabel.TabIndex = 32;
            this.encryptionpasswordlabel.Text = "Encryption Password";
            // 
            // encryptionpasswordtextBox
            // 
            this.encryptionpasswordtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.encryptionpasswordtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.encryptionpasswordtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptionpasswordtextBox.ForeColor = System.Drawing.Color.White;
            this.encryptionpasswordtextBox.Location = new System.Drawing.Point(12, 101);
            this.encryptionpasswordtextBox.Name = "encryptionpasswordtextBox";
            this.encryptionpasswordtextBox.Size = new System.Drawing.Size(153, 20);
            this.encryptionpasswordtextBox.TabIndex = 31;
            // 
            // defaultsettingsbutton
            // 
            this.defaultsettingsbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.defaultsettingsbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.defaultsettingsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaultsettingsbutton.ForeColor = System.Drawing.Color.White;
            this.defaultsettingsbutton.Location = new System.Drawing.Point(25, 128);
            this.defaultsettingsbutton.Name = "defaultsettingsbutton";
            this.defaultsettingsbutton.Size = new System.Drawing.Size(57, 23);
            this.defaultsettingsbutton.TabIndex = 34;
            this.defaultsettingsbutton.Text = "Default";
            this.defaultsettingsbutton.UseVisualStyleBackColor = false;
            this.defaultsettingsbutton.Click += new System.EventHandler(this.defaultsettingsbutton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(174, 163);
            this.Controls.Add(this.defaultsettingsbutton);
            this.Controls.Add(this.encryptionpasswordlabel);
            this.Controls.Add(this.encryptionpasswordtextBox);
            this.Controls.Add(this.delaylabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.delaytextBox);
            this.Controls.Add(this.hidepasswordcheckBox);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "...";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox hidepasswordcheckBox;
        private System.Windows.Forms.TextBox delaytextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label delaylabel;
        private System.Windows.Forms.Label encryptionpasswordlabel;
        private System.Windows.Forms.TextBox encryptionpasswordtextBox;
        private System.Windows.Forms.Button defaultsettingsbutton;
    }
}