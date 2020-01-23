namespace AccManagerV69
{
    partial class SteamDirForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SteamDirForm));
            this.steamdirectorytextBox = new System.Windows.Forms.TextBox();
            this.steamdirectorylabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // steamdirectorytextBox
            // 
            this.steamdirectorytextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.steamdirectorytextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.steamdirectorytextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steamdirectorytextBox.ForeColor = System.Drawing.Color.White;
            this.steamdirectorytextBox.Location = new System.Drawing.Point(12, 19);
            this.steamdirectorytextBox.Name = "steamdirectorytextBox";
            this.steamdirectorytextBox.Size = new System.Drawing.Size(214, 21);
            this.steamdirectorytextBox.TabIndex = 21;
            // 
            // steamdirectorylabel
            // 
            this.steamdirectorylabel.AutoSize = true;
            this.steamdirectorylabel.BackColor = System.Drawing.Color.Transparent;
            this.steamdirectorylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steamdirectorylabel.ForeColor = System.Drawing.Color.White;
            this.steamdirectorylabel.Location = new System.Drawing.Point(9, 1);
            this.steamdirectorylabel.Name = "steamdirectorylabel";
            this.steamdirectorylabel.Size = new System.Drawing.Size(113, 15);
            this.steamdirectorylabel.TabIndex = 24;
            this.steamdirectorylabel.Text = "Steam Directory:";
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.PaleGreen;
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.ForeColor = System.Drawing.Color.Green;
            this.okButton.Location = new System.Drawing.Point(93, 46);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(48, 23);
            this.okButton.TabIndex = 25;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // SteamDir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(238, 77);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.steamdirectorylabel);
            this.Controls.Add(this.steamdirectorytextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SteamDir";
            this.Text = "...";
            this.Load += new System.EventHandler(this.SteamDir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox steamdirectorytextBox;
        private System.Windows.Forms.Label steamdirectorylabel;
        private System.Windows.Forms.Button okButton;
    }
}