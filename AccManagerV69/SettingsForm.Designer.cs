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
            this.delaytextBox.Size = new System.Drawing.Size(144, 20);
            this.delaytextBox.TabIndex = 27;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.PaleGreen;
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.ForeColor = System.Drawing.Color.Green;
            this.okButton.Location = new System.Drawing.Point(75, 86);
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
            this.delaylabel.Location = new System.Drawing.Point(12, 34);
            this.delaylabel.Name = "delaylabel";
            this.delaylabel.Size = new System.Drawing.Size(76, 15);
            this.delaylabel.TabIndex = 30;
            this.delaylabel.Text = "Delay (ms)";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(201, 121);
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
    }
}