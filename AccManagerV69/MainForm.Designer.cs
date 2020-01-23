namespace AccManagerV69
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.accountslistBox = new System.Windows.Forms.ListBox();
            this.deleteaccountButton = new System.Windows.Forms.Button();
            this.nicknametextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.titleTimer = new System.Windows.Forms.Timer(this.components);
            this.nicknamelabel = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.usernametextBox = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.statuslabel = new System.Windows.Forms.Label();
            this.statuspendinglabel = new System.Windows.Forms.Label();
            this.createaccountbutton = new System.Windows.Forms.Button();
            this.editaccountbutton = new System.Windows.Forms.Button();
            this.settingsbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountslistBox
            // 
            this.accountslistBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.accountslistBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountslistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountslistBox.ForeColor = System.Drawing.Color.White;
            this.accountslistBox.FormattingEnabled = true;
            this.accountslistBox.ItemHeight = 15;
            this.accountslistBox.Location = new System.Drawing.Point(158, 12);
            this.accountslistBox.Name = "accountslistBox";
            this.accountslistBox.Size = new System.Drawing.Size(139, 122);
            this.accountslistBox.TabIndex = 2;
            this.accountslistBox.SelectedIndexChanged += new System.EventHandler(this.accountslistBox_SelectedIndexChanged);
            // 
            // deleteaccountButton
            // 
            this.deleteaccountButton.BackColor = System.Drawing.Color.IndianRed;
            this.deleteaccountButton.Enabled = false;
            this.deleteaccountButton.FlatAppearance.BorderSize = 0;
            this.deleteaccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteaccountButton.ForeColor = System.Drawing.Color.DarkRed;
            this.deleteaccountButton.Location = new System.Drawing.Point(236, 169);
            this.deleteaccountButton.Name = "deleteaccountButton";
            this.deleteaccountButton.Size = new System.Drawing.Size(61, 23);
            this.deleteaccountButton.TabIndex = 24;
            this.deleteaccountButton.Text = "Delete";
            this.deleteaccountButton.UseVisualStyleBackColor = false;
            this.deleteaccountButton.Click += new System.EventHandler(this.deleteaccountButton_Click);
            // 
            // nicknametextBox
            // 
            this.nicknametextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.nicknametextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nicknametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicknametextBox.ForeColor = System.Drawing.Color.White;
            this.nicknametextBox.Location = new System.Drawing.Point(12, 30);
            this.nicknametextBox.Name = "nicknametextBox";
            this.nicknametextBox.Size = new System.Drawing.Size(134, 20);
            this.nicknametextBox.TabIndex = 23;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.PaleGreen;
            this.loginButton.Enabled = false;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.ForeColor = System.Drawing.Color.Green;
            this.loginButton.Location = new System.Drawing.Point(236, 140);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(61, 23);
            this.loginButton.TabIndex = 22;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // titleTimer
            // 
            this.titleTimer.Interval = 800;
            this.titleTimer.Tick += new System.EventHandler(this.titleTimer_Tick);
            // 
            // nicknamelabel
            // 
            this.nicknamelabel.AutoSize = true;
            this.nicknamelabel.BackColor = System.Drawing.Color.Transparent;
            this.nicknamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicknamelabel.ForeColor = System.Drawing.Color.White;
            this.nicknamelabel.Location = new System.Drawing.Point(12, 12);
            this.nicknamelabel.Name = "nicknamelabel";
            this.nicknamelabel.Size = new System.Drawing.Size(75, 15);
            this.nicknamelabel.TabIndex = 25;
            this.nicknamelabel.Text = "Nickname:";
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.BackColor = System.Drawing.Color.Transparent;
            this.usernamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.ForeColor = System.Drawing.Color.White;
            this.usernamelabel.Location = new System.Drawing.Point(12, 61);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(77, 15);
            this.usernamelabel.TabIndex = 27;
            this.usernamelabel.Text = "Username:";
            // 
            // usernametextBox
            // 
            this.usernametextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.usernametextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametextBox.ForeColor = System.Drawing.Color.White;
            this.usernametextBox.Location = new System.Drawing.Point(12, 79);
            this.usernametextBox.Name = "usernametextBox";
            this.usernametextBox.Size = new System.Drawing.Size(134, 20);
            this.usernametextBox.TabIndex = 26;
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel.ForeColor = System.Drawing.Color.White;
            this.passwordlabel.Location = new System.Drawing.Point(12, 109);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(69, 15);
            this.passwordlabel.TabIndex = 29;
            this.passwordlabel.Text = "Password";
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.passwordtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtextBox.ForeColor = System.Drawing.Color.White;
            this.passwordtextBox.Location = new System.Drawing.Point(12, 127);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(134, 20);
            this.passwordtextBox.TabIndex = 28;
            this.passwordtextBox.TextChanged += new System.EventHandler(this.passwordtextBox_TextChanged);
            // 
            // statuslabel
            // 
            this.statuslabel.AutoSize = true;
            this.statuslabel.BackColor = System.Drawing.Color.Transparent;
            this.statuslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslabel.ForeColor = System.Drawing.Color.White;
            this.statuslabel.Location = new System.Drawing.Point(9, 180);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(51, 15);
            this.statuslabel.TabIndex = 30;
            this.statuslabel.Text = "Status:";
            // 
            // statuspendinglabel
            // 
            this.statuspendinglabel.AutoSize = true;
            this.statuspendinglabel.BackColor = System.Drawing.Color.Transparent;
            this.statuspendinglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuspendinglabel.ForeColor = System.Drawing.Color.White;
            this.statuspendinglabel.Location = new System.Drawing.Point(55, 180);
            this.statuspendinglabel.Name = "statuspendinglabel";
            this.statuspendinglabel.Size = new System.Drawing.Size(64, 15);
            this.statuspendinglabel.TabIndex = 31;
            this.statuspendinglabel.Text = "Pending!";
            // 
            // createaccountbutton
            // 
            this.createaccountbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.createaccountbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.createaccountbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createaccountbutton.ForeColor = System.Drawing.Color.White;
            this.createaccountbutton.Location = new System.Drawing.Point(169, 140);
            this.createaccountbutton.Name = "createaccountbutton";
            this.createaccountbutton.Size = new System.Drawing.Size(61, 23);
            this.createaccountbutton.TabIndex = 33;
            this.createaccountbutton.Text = "Create";
            this.createaccountbutton.UseVisualStyleBackColor = false;
            this.createaccountbutton.Click += new System.EventHandler(this.createaccountbutton_Click);
            // 
            // editaccountbutton
            // 
            this.editaccountbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.editaccountbutton.Enabled = false;
            this.editaccountbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.editaccountbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editaccountbutton.ForeColor = System.Drawing.Color.White;
            this.editaccountbutton.Location = new System.Drawing.Point(169, 169);
            this.editaccountbutton.Name = "editaccountbutton";
            this.editaccountbutton.Size = new System.Drawing.Size(61, 23);
            this.editaccountbutton.TabIndex = 34;
            this.editaccountbutton.Text = "Edit";
            this.editaccountbutton.UseVisualStyleBackColor = false;
            this.editaccountbutton.Click += new System.EventHandler(this.editaccountbutton_Click);
            // 
            // settingsbutton
            // 
            this.settingsbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.settingsbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.settingsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsbutton.ForeColor = System.Drawing.Color.White;
            this.settingsbutton.Location = new System.Drawing.Point(125, 153);
            this.settingsbutton.Name = "settingsbutton";
            this.settingsbutton.Size = new System.Drawing.Size(32, 23);
            this.settingsbutton.TabIndex = 35;
            this.settingsbutton.Text = "⚙";
            this.settingsbutton.UseVisualStyleBackColor = false;
            this.settingsbutton.Click += new System.EventHandler(this.settingsbutton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(309, 204);
            this.Controls.Add(this.settingsbutton);
            this.Controls.Add(this.editaccountbutton);
            this.Controls.Add(this.createaccountbutton);
            this.Controls.Add(this.statuspendinglabel);
            this.Controls.Add(this.statuslabel);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.usernametextBox);
            this.Controls.Add(this.nicknamelabel);
            this.Controls.Add(this.deleteaccountButton);
            this.Controls.Add(this.nicknametextBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.accountslistBox);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Acc Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox accountslistBox;
        private System.Windows.Forms.Button deleteaccountButton;
        private System.Windows.Forms.TextBox nicknametextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Timer titleTimer;
        private System.Windows.Forms.Label nicknamelabel;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.TextBox usernametextBox;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.Label statuslabel;
        private System.Windows.Forms.Label statuspendinglabel;
        private System.Windows.Forms.Button createaccountbutton;
        private System.Windows.Forms.Button editaccountbutton;
        private System.Windows.Forms.Button settingsbutton;
    }
}

