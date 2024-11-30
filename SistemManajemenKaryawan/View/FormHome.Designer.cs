namespace SistemManajemenKaryawan.View
{
    partial class FormHome
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
            this.Panel_kiri = new Guna.UI2.WinForms.Guna2Panel();
            this.Button_logout = new Guna.UI2.WinForms.Guna2Button();
            this.GradientPanel_atas = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Button_keluar = new Guna.UI2.WinForms.Guna2Button();
            this.label_judul = new System.Windows.Forms.Label();
            this.PictureBox_home = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Button_dashboard = new Guna.UI2.WinForms.Guna2Button();
            this.Button_about = new Guna.UI2.WinForms.Guna2Button();
            this.PictureBox_logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Button_gaji = new Guna.UI2.WinForms.Guna2Button();
            this.Button_departemen = new Guna.UI2.WinForms.Guna2Button();
            this.Button_karyawan = new Guna.UI2.WinForms.Guna2Button();
            this.Panel_kiri.SuspendLayout();
            this.GradientPanel_atas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_kiri
            // 
            this.Panel_kiri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Panel_kiri.BackColor = System.Drawing.Color.SteelBlue;
            this.Panel_kiri.Controls.Add(this.Button_dashboard);
            this.Panel_kiri.Controls.Add(this.Button_about);
            this.Panel_kiri.Controls.Add(this.PictureBox_logo);
            this.Panel_kiri.Controls.Add(this.Button_gaji);
            this.Panel_kiri.Controls.Add(this.Button_departemen);
            this.Panel_kiri.Controls.Add(this.Button_karyawan);
            this.Panel_kiri.Location = new System.Drawing.Point(0, 50);
            this.Panel_kiri.Name = "Panel_kiri";
            this.Panel_kiri.Size = new System.Drawing.Size(285, 615);
            this.Panel_kiri.TabIndex = 10;
            // 
            // Button_logout
            // 
            this.Button_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_logout.CustomBorderColor = System.Drawing.Color.CornflowerBlue;
            this.Button_logout.CustomBorderThickness = new System.Windows.Forms.Padding(5);
            this.Button_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_logout.FillColor = System.Drawing.Color.PowderBlue;
            this.Button_logout.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_logout.ForeColor = System.Drawing.Color.IndianRed;
            this.Button_logout.Location = new System.Drawing.Point(927, 606);
            this.Button_logout.Name = "Button_logout";
            this.Button_logout.Size = new System.Drawing.Size(159, 52);
            this.Button_logout.TabIndex = 11;
            this.Button_logout.Text = "LOGOUT";
            this.Button_logout.Click += new System.EventHandler(this.Button_logout_Click);
            // 
            // GradientPanel_atas
            // 
            this.GradientPanel_atas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GradientPanel_atas.BackColor = System.Drawing.Color.CadetBlue;
            this.GradientPanel_atas.BorderColor = System.Drawing.Color.Black;
            this.GradientPanel_atas.Controls.Add(this.Button_keluar);
            this.GradientPanel_atas.Controls.Add(this.label_judul);
            this.GradientPanel_atas.FillColor = System.Drawing.Color.SkyBlue;
            this.GradientPanel_atas.Location = new System.Drawing.Point(0, 0);
            this.GradientPanel_atas.Name = "GradientPanel_atas";
            this.GradientPanel_atas.Size = new System.Drawing.Size(1100, 53);
            this.GradientPanel_atas.TabIndex = 9;
            // 
            // Button_keluar
            // 
            this.Button_keluar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_keluar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_keluar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_keluar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_keluar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_keluar.FillColor = System.Drawing.Color.SteelBlue;
            this.Button_keluar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_keluar.ForeColor = System.Drawing.Color.Red;
            this.Button_keluar.Location = new System.Drawing.Point(1044, 0);
            this.Button_keluar.Name = "Button_keluar";
            this.Button_keluar.Size = new System.Drawing.Size(58, 53);
            this.Button_keluar.TabIndex = 35;
            this.Button_keluar.Text = "X";
            this.Button_keluar.Click += new System.EventHandler(this.Button_keluar_Click);
            // 
            // label_judul
            // 
            this.label_judul.AutoSize = true;
            this.label_judul.BackColor = System.Drawing.Color.Transparent;
            this.label_judul.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_judul.ForeColor = System.Drawing.Color.White;
            this.label_judul.Location = new System.Drawing.Point(12, 12);
            this.label_judul.Name = "label_judul";
            this.label_judul.Size = new System.Drawing.Size(341, 25);
            this.label_judul.TabIndex = 0;
            this.label_judul.Text = "Sistem Manajemen Karyawan\r\n";
            // 
            // PictureBox_home
            // 
            this.PictureBox_home.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox_home.Image = global::SistemManajemenKaryawan.Properties.Resources.Home;
            this.PictureBox_home.ImageRotate = 0F;
            this.PictureBox_home.Location = new System.Drawing.Point(302, 70);
            this.PictureBox_home.Name = "PictureBox_home";
            this.PictureBox_home.Size = new System.Drawing.Size(783, 525);
            this.PictureBox_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_home.TabIndex = 12;
            this.PictureBox_home.TabStop = false;
            // 
            // Button_dashboard
            // 
            this.Button_dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_dashboard.FillColor = System.Drawing.Color.LightBlue;
            this.Button_dashboard.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Button_dashboard.ForeColor = System.Drawing.Color.Black;
            this.Button_dashboard.Image = global::SistemManajemenKaryawan.Properties.Resources.icondashboard;
            this.Button_dashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Button_dashboard.ImageSize = new System.Drawing.Size(35, 35);
            this.Button_dashboard.Location = new System.Drawing.Point(17, 505);
            this.Button_dashboard.Name = "Button_dashboard";
            this.Button_dashboard.Size = new System.Drawing.Size(252, 62);
            this.Button_dashboard.TabIndex = 9;
            this.Button_dashboard.Text = "Dashboard";
            this.Button_dashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_dashboard.Click += new System.EventHandler(this.Button_dashboard_Click);
            // 
            // Button_about
            // 
            this.Button_about.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_about.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_about.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_about.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_about.FillColor = System.Drawing.Color.LightBlue;
            this.Button_about.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_about.ForeColor = System.Drawing.Color.Black;
            this.Button_about.Image = global::SistemManajemenKaryawan.Properties.Resources.logoDepan1;
            this.Button_about.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Button_about.ImageSize = new System.Drawing.Size(37, 37);
            this.Button_about.Location = new System.Drawing.Point(17, 425);
            this.Button_about.Name = "Button_about";
            this.Button_about.Size = new System.Drawing.Size(252, 62);
            this.Button_about.TabIndex = 8;
            this.Button_about.Text = "About";
            this.Button_about.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_about.Click += new System.EventHandler(this.Button_about_Click);
            // 
            // PictureBox_logo
            // 
            this.PictureBox_logo.Image = global::SistemManajemenKaryawan.Properties.Resources.logoDepan;
            this.PictureBox_logo.ImageRotate = 0F;
            this.PictureBox_logo.Location = new System.Drawing.Point(86, 34);
            this.PictureBox_logo.Name = "PictureBox_logo";
            this.PictureBox_logo.Size = new System.Drawing.Size(127, 133);
            this.PictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_logo.TabIndex = 4;
            this.PictureBox_logo.TabStop = false;
            // 
            // Button_gaji
            // 
            this.Button_gaji.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_gaji.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_gaji.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_gaji.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_gaji.FillColor = System.Drawing.Color.LightBlue;
            this.Button_gaji.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_gaji.ForeColor = System.Drawing.Color.Black;
            this.Button_gaji.Image = global::SistemManajemenKaryawan.Properties.Resources.icongaji;
            this.Button_gaji.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Button_gaji.ImageSize = new System.Drawing.Size(40, 40);
            this.Button_gaji.Location = new System.Drawing.Point(17, 346);
            this.Button_gaji.Name = "Button_gaji";
            this.Button_gaji.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_gaji.Size = new System.Drawing.Size(252, 60);
            this.Button_gaji.TabIndex = 6;
            this.Button_gaji.Text = "Gaji";
            this.Button_gaji.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_gaji.Click += new System.EventHandler(this.Button_gaji_Click);
            // 
            // Button_departemen
            // 
            this.Button_departemen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_departemen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_departemen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_departemen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_departemen.FillColor = System.Drawing.Color.LightBlue;
            this.Button_departemen.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_departemen.ForeColor = System.Drawing.Color.Black;
            this.Button_departemen.Image = global::SistemManajemenKaryawan.Properties.Resources.icondept;
            this.Button_departemen.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Button_departemen.ImageSize = new System.Drawing.Size(45, 45);
            this.Button_departemen.Location = new System.Drawing.Point(17, 268);
            this.Button_departemen.Name = "Button_departemen";
            this.Button_departemen.Size = new System.Drawing.Size(252, 60);
            this.Button_departemen.TabIndex = 5;
            this.Button_departemen.Text = "Departemen";
            this.Button_departemen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_departemen.Click += new System.EventHandler(this.Button_departemen_Click);
            // 
            // Button_karyawan
            // 
            this.Button_karyawan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_karyawan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_karyawan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_karyawan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_karyawan.FillColor = System.Drawing.Color.LightBlue;
            this.Button_karyawan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_karyawan.ForeColor = System.Drawing.Color.Black;
            this.Button_karyawan.Image = global::SistemManajemenKaryawan.Properties.Resources.iconkaryawan;
            this.Button_karyawan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Button_karyawan.ImageSize = new System.Drawing.Size(45, 45);
            this.Button_karyawan.Location = new System.Drawing.Point(17, 187);
            this.Button_karyawan.Name = "Button_karyawan";
            this.Button_karyawan.Size = new System.Drawing.Size(252, 63);
            this.Button_karyawan.TabIndex = 0;
            this.Button_karyawan.Text = "Karyawan";
            this.Button_karyawan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_karyawan.Click += new System.EventHandler(this.Button_karyawan_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1101, 665);
            this.Controls.Add(this.PictureBox_home);
            this.Controls.Add(this.Panel_kiri);
            this.Controls.Add(this.Button_logout);
            this.Controls.Add(this.GradientPanel_atas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHome";
            this.Panel_kiri.ResumeLayout(false);
            this.GradientPanel_atas.ResumeLayout(false);
            this.GradientPanel_atas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox PictureBox_home;
        private Guna.UI2.WinForms.Guna2Panel Panel_kiri;
        private Guna.UI2.WinForms.Guna2Button Button_about;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBox_logo;
        private Guna.UI2.WinForms.Guna2Button Button_gaji;
        private Guna.UI2.WinForms.Guna2Button Button_departemen;
        private Guna.UI2.WinForms.Guna2Button Button_karyawan;
        private Guna.UI2.WinForms.Guna2Button Button_logout;
        private Guna.UI2.WinForms.Guna2GradientPanel GradientPanel_atas;
        private Guna.UI2.WinForms.Guna2Button Button_keluar;
        private System.Windows.Forms.Label label_judul;
        private Guna.UI2.WinForms.Guna2Button Button_dashboard;
    }
}