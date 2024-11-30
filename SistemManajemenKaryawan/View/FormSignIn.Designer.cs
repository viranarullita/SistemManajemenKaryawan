namespace SistemManajemenKaryawan
{
    partial class FormSignIn
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
            this.panel_judul = new System.Windows.Forms.Panel();
            this.PictureBox_logodepan = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label_register = new System.Windows.Forms.Label();
            this.Button_SignUp = new Guna.UI2.WinForms.Guna2Button();
            this.label_judul = new System.Windows.Forms.Label();
            this.TextBox_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_LoginAccount = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.Button_login = new Guna.UI2.WinForms.Guna2Button();
            this.label_password = new System.Windows.Forms.Label();
            this.Button_keluar = new Guna.UI2.WinForms.Guna2Button();
            this.CheckBox_show = new Guna.UI2.WinForms.Guna2CheckBox();
            this.panel_judul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_logodepan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_judul
            // 
            this.panel_judul.BackColor = System.Drawing.Color.CadetBlue;
            this.panel_judul.Controls.Add(this.PictureBox_logodepan);
            this.panel_judul.Controls.Add(this.label_register);
            this.panel_judul.Controls.Add(this.Button_SignUp);
            this.panel_judul.Controls.Add(this.label_judul);
            this.panel_judul.Location = new System.Drawing.Point(-9, -14);
            this.panel_judul.Name = "panel_judul";
            this.panel_judul.Size = new System.Drawing.Size(535, 666);
            this.panel_judul.TabIndex = 32;
            // 
            // PictureBox_logodepan
            // 
            this.PictureBox_logodepan.Image = global::SistemManajemenKaryawan.Properties.Resources.logoDepan;
            this.PictureBox_logodepan.ImageRotate = 0F;
            this.PictureBox_logodepan.Location = new System.Drawing.Point(189, 80);
            this.PictureBox_logodepan.Name = "PictureBox_logodepan";
            this.PictureBox_logodepan.Size = new System.Drawing.Size(168, 177);
            this.PictureBox_logodepan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_logodepan.TabIndex = 9;
            this.PictureBox_logodepan.TabStop = false;
            // 
            // label_register
            // 
            this.label_register.AutoSize = true;
            this.label_register.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_register.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_register.Location = new System.Drawing.Point(127, 483);
            this.label_register.Name = "label_register";
            this.label_register.Size = new System.Drawing.Size(264, 28);
            this.label_register.TabIndex = 7;
            this.label_register.Text = "Register your account";
            // 
            // Button_SignUp
            // 
            this.Button_SignUp.BackColor = System.Drawing.Color.Transparent;
            this.Button_SignUp.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Button_SignUp.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.Button_SignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_SignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_SignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_SignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_SignUp.FillColor = System.Drawing.Color.SteelBlue;
            this.Button_SignUp.Font = new System.Drawing.Font("Leelawadee UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_SignUp.ForeColor = System.Drawing.Color.White;
            this.Button_SignUp.Location = new System.Drawing.Point(54, 527);
            this.Button_SignUp.Name = "Button_SignUp";
            this.Button_SignUp.Size = new System.Drawing.Size(425, 65);
            this.Button_SignUp.TabIndex = 3;
            this.Button_SignUp.Text = "SIGN UP";
            this.Button_SignUp.Click += new System.EventHandler(this.Button_SignUp_Click);
            // 
            // label_judul
            // 
            this.label_judul.AutoSize = true;
            this.label_judul.BackColor = System.Drawing.Color.Transparent;
            this.label_judul.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_judul.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_judul.Location = new System.Drawing.Point(28, 251);
            this.label_judul.Name = "label_judul";
            this.label_judul.Size = new System.Drawing.Size(481, 61);
            this.label_judul.TabIndex = 0;
            this.label_judul.Text = "Sistem Manajemen Karyawan";
            // 
            // TextBox_password
            // 
            this.TextBox_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_password.BorderColor = System.Drawing.Color.Black;
            this.TextBox_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_password.DefaultText = "";
            this.TextBox_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_password.ForeColor = System.Drawing.Color.Black;
            this.TextBox_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_password.Location = new System.Drawing.Point(588, 325);
            this.TextBox_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_password.Name = "TextBox_password";
            this.TextBox_password.PasswordChar = '*';
            this.TextBox_password.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TextBox_password.PlaceholderText = "";
            this.TextBox_password.SelectedText = "";
            this.TextBox_password.Size = new System.Drawing.Size(447, 72);
            this.TextBox_password.TabIndex = 38;
            // 
            // TextBox_username
            // 
            this.TextBox_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_username.BorderColor = System.Drawing.Color.Black;
            this.TextBox_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_username.DefaultText = "";
            this.TextBox_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_username.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_username.ForeColor = System.Drawing.Color.Black;
            this.TextBox_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_username.Location = new System.Drawing.Point(588, 188);
            this.TextBox_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_username.Name = "TextBox_username";
            this.TextBox_username.PasswordChar = '\0';
            this.TextBox_username.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TextBox_username.PlaceholderText = "";
            this.TextBox_username.SelectedText = "";
            this.TextBox_username.Size = new System.Drawing.Size(447, 72);
            this.TextBox_username.TabIndex = 37;
            // 
            // label_LoginAccount
            // 
            this.label_LoginAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_LoginAccount.AutoSize = true;
            this.label_LoginAccount.BackColor = System.Drawing.Color.Transparent;
            this.label_LoginAccount.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LoginAccount.Location = new System.Drawing.Point(580, 62);
            this.label_LoginAccount.Name = "label_LoginAccount";
            this.label_LoginAccount.Size = new System.Drawing.Size(263, 48);
            this.label_LoginAccount.TabIndex = 33;
            this.label_LoginAccount.Text = "Login Account";
            // 
            // label_username
            // 
            this.label_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(583, 154);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(134, 29);
            this.label_username.TabIndex = 34;
            this.label_username.Text = "Username";
            // 
            // Button_login
            // 
            this.Button_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_login.BackColor = System.Drawing.Color.Transparent;
            this.Button_login.BorderRadius = 20;
            this.Button_login.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Button_login.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 2, 4);
            this.Button_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_login.FillColor = System.Drawing.Color.SteelBlue;
            this.Button_login.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_login.ForeColor = System.Drawing.Color.White;
            this.Button_login.Location = new System.Drawing.Point(588, 482);
            this.Button_login.Name = "Button_login";
            this.Button_login.Size = new System.Drawing.Size(182, 60);
            this.Button_login.TabIndex = 35;
            this.Button_login.Text = "LOGIN";
            this.Button_login.Click += new System.EventHandler(this.Button_login_Click);
            // 
            // label_password
            // 
            this.label_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(583, 291);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(127, 29);
            this.label_password.TabIndex = 36;
            this.label_password.Text = "Password";
            // 
            // Button_keluar
            // 
            this.Button_keluar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_keluar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_keluar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_keluar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_keluar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_keluar.FillColor = System.Drawing.Color.White;
            this.Button_keluar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_keluar.ForeColor = System.Drawing.Color.Red;
            this.Button_keluar.Location = new System.Drawing.Point(1003, -1);
            this.Button_keluar.Name = "Button_keluar";
            this.Button_keluar.Size = new System.Drawing.Size(92, 61);
            this.Button_keluar.TabIndex = 31;
            this.Button_keluar.Text = "X";
            this.Button_keluar.Click += new System.EventHandler(this.Button_keluar_Click);
            // 
            // CheckBox_show
            // 
            this.CheckBox_show.AutoSize = true;
            this.CheckBox_show.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBox_show.CheckedState.BorderRadius = 0;
            this.CheckBox_show.CheckedState.BorderThickness = 0;
            this.CheckBox_show.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBox_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_show.Location = new System.Drawing.Point(588, 414);
            this.CheckBox_show.Name = "CheckBox_show";
            this.CheckBox_show.Size = new System.Drawing.Size(192, 30);
            this.CheckBox_show.TabIndex = 44;
            this.CheckBox_show.Text = "Show password";
            this.CheckBox_show.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckBox_show.UncheckedState.BorderRadius = 0;
            this.CheckBox_show.UncheckedState.BorderThickness = 0;
            this.CheckBox_show.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckBox_show.CheckedChanged += new System.EventHandler(this.CheckBox_show_CheckedChanged);
            // 
            // FormSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1079, 609);
            this.Controls.Add(this.CheckBox_show);
            this.Controls.Add(this.panel_judul);
            this.Controls.Add(this.TextBox_password);
            this.Controls.Add(this.TextBox_username);
            this.Controls.Add(this.label_LoginAccount);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.Button_login);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.Button_keluar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSignIn";
            this.panel_judul.ResumeLayout(false);
            this.panel_judul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_logodepan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox PictureBox_logodepan;
        private System.Windows.Forms.Panel panel_judul;
        private System.Windows.Forms.Label label_register;
        private Guna.UI2.WinForms.Guna2Button Button_SignUp;
        private System.Windows.Forms.Label label_judul;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_password;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_username;
        private System.Windows.Forms.Label label_LoginAccount;
        private System.Windows.Forms.Label label_username;
        private Guna.UI2.WinForms.Guna2Button Button_login;
        private System.Windows.Forms.Label label_password;
        private Guna.UI2.WinForms.Guna2Button Button_keluar;
        private Guna.UI2.WinForms.Guna2CheckBox CheckBox_show;
    }
}

