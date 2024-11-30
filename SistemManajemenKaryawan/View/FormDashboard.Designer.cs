namespace SistemManajemenKaryawan.View
{
    partial class FormDashboard
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
            this.ShadowPanel_nonaktif = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label_karyawanNonaktif = new System.Windows.Forms.Label();
            this.label_nonaktif = new System.Windows.Forms.Label();
            this.CirclePictureBox_nonaktif = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.ShadowPanel_aktif = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label_karyawanAktif = new System.Windows.Forms.Label();
            this.label_aktif = new System.Windows.Forms.Label();
            this.CirclePictureBox_aktif = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.ShadowPanel_total = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label_totalKaryawan = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.CirclePictureBox_total = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.GradientPanel_atas = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Button_keluar = new Guna.UI2.WinForms.Guna2Button();
            this.label_judul = new System.Windows.Forms.Label();
            this.Button_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.PictureBox_dashboard = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ShadowPanel_nonaktif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CirclePictureBox_nonaktif)).BeginInit();
            this.ShadowPanel_aktif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CirclePictureBox_aktif)).BeginInit();
            this.ShadowPanel_total.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CirclePictureBox_total)).BeginInit();
            this.GradientPanel_atas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_dashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // ShadowPanel_nonaktif
            // 
            this.ShadowPanel_nonaktif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShadowPanel_nonaktif.BackColor = System.Drawing.Color.LightCyan;
            this.ShadowPanel_nonaktif.Controls.Add(this.label_karyawanNonaktif);
            this.ShadowPanel_nonaktif.Controls.Add(this.label_nonaktif);
            this.ShadowPanel_nonaktif.Controls.Add(this.CirclePictureBox_nonaktif);
            this.ShadowPanel_nonaktif.FillColor = System.Drawing.Color.PowderBlue;
            this.ShadowPanel_nonaktif.Location = new System.Drawing.Point(772, 483);
            this.ShadowPanel_nonaktif.Name = "ShadowPanel_nonaktif";
            this.ShadowPanel_nonaktif.ShadowColor = System.Drawing.Color.Black;
            this.ShadowPanel_nonaktif.ShadowShift = 10;
            this.ShadowPanel_nonaktif.Size = new System.Drawing.Size(307, 192);
            this.ShadowPanel_nonaktif.TabIndex = 2;
            // 
            // label_karyawanNonaktif
            // 
            this.label_karyawanNonaktif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_karyawanNonaktif.AutoSize = true;
            this.label_karyawanNonaktif.BackColor = System.Drawing.Color.PowderBlue;
            this.label_karyawanNonaktif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_karyawanNonaktif.Location = new System.Drawing.Point(246, 32);
            this.label_karyawanNonaktif.Name = "label_karyawanNonaktif";
            this.label_karyawanNonaktif.Size = new System.Drawing.Size(24, 25);
            this.label_karyawanNonaktif.TabIndex = 3;
            this.label_karyawanNonaktif.Text = "0";
            // 
            // label_nonaktif
            // 
            this.label_nonaktif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_nonaktif.AutoSize = true;
            this.label_nonaktif.BackColor = System.Drawing.Color.PowderBlue;
            this.label_nonaktif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nonaktif.Location = new System.Drawing.Point(75, 136);
            this.label_nonaktif.Name = "label_nonaktif";
            this.label_nonaktif.Size = new System.Drawing.Size(193, 25);
            this.label_nonaktif.TabIndex = 2;
            this.label_nonaktif.Text = "Karyawan Nonaktif";
            // 
            // CirclePictureBox_nonaktif
            // 
            this.CirclePictureBox_nonaktif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CirclePictureBox_nonaktif.BackColor = System.Drawing.Color.PowderBlue;
            this.CirclePictureBox_nonaktif.Image = global::SistemManajemenKaryawan.Properties.Resources.iconkaryawan;
            this.CirclePictureBox_nonaktif.ImageRotate = 0F;
            this.CirclePictureBox_nonaktif.Location = new System.Drawing.Point(14, 20);
            this.CirclePictureBox_nonaktif.Name = "CirclePictureBox_nonaktif";
            this.CirclePictureBox_nonaktif.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CirclePictureBox_nonaktif.Size = new System.Drawing.Size(117, 113);
            this.CirclePictureBox_nonaktif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CirclePictureBox_nonaktif.TabIndex = 0;
            this.CirclePictureBox_nonaktif.TabStop = false;
            // 
            // ShadowPanel_aktif
            // 
            this.ShadowPanel_aktif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShadowPanel_aktif.BackColor = System.Drawing.Color.LightCyan;
            this.ShadowPanel_aktif.Controls.Add(this.label_karyawanAktif);
            this.ShadowPanel_aktif.Controls.Add(this.label_aktif);
            this.ShadowPanel_aktif.Controls.Add(this.CirclePictureBox_aktif);
            this.ShadowPanel_aktif.FillColor = System.Drawing.Color.PowderBlue;
            this.ShadowPanel_aktif.Location = new System.Drawing.Point(772, 275);
            this.ShadowPanel_aktif.Name = "ShadowPanel_aktif";
            this.ShadowPanel_aktif.ShadowColor = System.Drawing.Color.Black;
            this.ShadowPanel_aktif.ShadowShift = 10;
            this.ShadowPanel_aktif.Size = new System.Drawing.Size(307, 192);
            this.ShadowPanel_aktif.TabIndex = 1;
            // 
            // label_karyawanAktif
            // 
            this.label_karyawanAktif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_karyawanAktif.AutoSize = true;
            this.label_karyawanAktif.BackColor = System.Drawing.Color.PowderBlue;
            this.label_karyawanAktif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_karyawanAktif.Location = new System.Drawing.Point(247, 32);
            this.label_karyawanAktif.Name = "label_karyawanAktif";
            this.label_karyawanAktif.Size = new System.Drawing.Size(24, 25);
            this.label_karyawanAktif.TabIndex = 2;
            this.label_karyawanAktif.Text = "0";
            // 
            // label_aktif
            // 
            this.label_aktif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_aktif.AutoSize = true;
            this.label_aktif.BackColor = System.Drawing.Color.PowderBlue;
            this.label_aktif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_aktif.Location = new System.Drawing.Point(116, 136);
            this.label_aktif.Name = "label_aktif";
            this.label_aktif.Size = new System.Drawing.Size(157, 25);
            this.label_aktif.TabIndex = 1;
            this.label_aktif.Text = "Karyawan Aktif";
            // 
            // CirclePictureBox_aktif
            // 
            this.CirclePictureBox_aktif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CirclePictureBox_aktif.BackColor = System.Drawing.Color.PowderBlue;
            this.CirclePictureBox_aktif.Image = global::SistemManajemenKaryawan.Properties.Resources.iconkaryawan;
            this.CirclePictureBox_aktif.ImageRotate = 0F;
            this.CirclePictureBox_aktif.Location = new System.Drawing.Point(16, 20);
            this.CirclePictureBox_aktif.Name = "CirclePictureBox_aktif";
            this.CirclePictureBox_aktif.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CirclePictureBox_aktif.Size = new System.Drawing.Size(121, 113);
            this.CirclePictureBox_aktif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CirclePictureBox_aktif.TabIndex = 0;
            this.CirclePictureBox_aktif.TabStop = false;
            // 
            // ShadowPanel_total
            // 
            this.ShadowPanel_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShadowPanel_total.BackColor = System.Drawing.Color.LightCyan;
            this.ShadowPanel_total.Controls.Add(this.label_totalKaryawan);
            this.ShadowPanel_total.Controls.Add(this.label_total);
            this.ShadowPanel_total.Controls.Add(this.CirclePictureBox_total);
            this.ShadowPanel_total.FillColor = System.Drawing.Color.PowderBlue;
            this.ShadowPanel_total.Location = new System.Drawing.Point(772, 67);
            this.ShadowPanel_total.Name = "ShadowPanel_total";
            this.ShadowPanel_total.ShadowColor = System.Drawing.Color.Black;
            this.ShadowPanel_total.ShadowShift = 10;
            this.ShadowPanel_total.Size = new System.Drawing.Size(307, 192);
            this.ShadowPanel_total.TabIndex = 0;
            // 
            // label_totalKaryawan
            // 
            this.label_totalKaryawan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_totalKaryawan.AutoSize = true;
            this.label_totalKaryawan.BackColor = System.Drawing.Color.PowderBlue;
            this.label_totalKaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalKaryawan.Location = new System.Drawing.Point(245, 32);
            this.label_totalKaryawan.Name = "label_totalKaryawan";
            this.label_totalKaryawan.Size = new System.Drawing.Size(24, 25);
            this.label_totalKaryawan.TabIndex = 1;
            this.label_totalKaryawan.Text = "0";
            // 
            // label_total
            // 
            this.label_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_total.AutoSize = true;
            this.label_total.BackColor = System.Drawing.Color.PowderBlue;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(111, 135);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(163, 25);
            this.label_total.TabIndex = 0;
            this.label_total.Text = "Total Karyawan";
            // 
            // CirclePictureBox_total
            // 
            this.CirclePictureBox_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CirclePictureBox_total.BackColor = System.Drawing.Color.PowderBlue;
            this.CirclePictureBox_total.Image = global::SistemManajemenKaryawan.Properties.Resources.iconkaryawan;
            this.CirclePictureBox_total.ImageRotate = 0F;
            this.CirclePictureBox_total.Location = new System.Drawing.Point(16, 19);
            this.CirclePictureBox_total.Name = "CirclePictureBox_total";
            this.CirclePictureBox_total.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CirclePictureBox_total.Size = new System.Drawing.Size(115, 113);
            this.CirclePictureBox_total.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CirclePictureBox_total.TabIndex = 0;
            this.CirclePictureBox_total.TabStop = false;
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
            this.GradientPanel_atas.Location = new System.Drawing.Point(-3, -2);
            this.GradientPanel_atas.Name = "GradientPanel_atas";
            this.GradientPanel_atas.Size = new System.Drawing.Size(1107, 53);
            this.GradientPanel_atas.TabIndex = 10;
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
            this.Button_keluar.Location = new System.Drawing.Point(1047, 0);
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
            // Button_cancel
            // 
            this.Button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_cancel.BackColor = System.Drawing.Color.Transparent;
            this.Button_cancel.BorderRadius = 8;
            this.Button_cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_cancel.FillColor = System.Drawing.Color.IndianRed;
            this.Button_cancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_cancel.ForeColor = System.Drawing.Color.White;
            this.Button_cancel.Location = new System.Drawing.Point(15, 630);
            this.Button_cancel.Name = "Button_cancel";
            this.Button_cancel.Size = new System.Drawing.Size(147, 45);
            this.Button_cancel.TabIndex = 23;
            this.Button_cancel.Text = "Cancel";
            this.Button_cancel.Click += new System.EventHandler(this.Button_cancel_Click);
            // 
            // PictureBox_dashboard
            // 
            this.PictureBox_dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox_dashboard.Image = global::SistemManajemenKaryawan.Properties.Resources.data;
            this.PictureBox_dashboard.ImageRotate = 0F;
            this.PictureBox_dashboard.Location = new System.Drawing.Point(15, 72);
            this.PictureBox_dashboard.Name = "PictureBox_dashboard";
            this.PictureBox_dashboard.Size = new System.Drawing.Size(743, 544);
            this.PictureBox_dashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_dashboard.TabIndex = 24;
            this.PictureBox_dashboard.TabStop = false;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1101, 693);
            this.Controls.Add(this.ShadowPanel_total);
            this.Controls.Add(this.ShadowPanel_aktif);
            this.Controls.Add(this.ShadowPanel_nonaktif);
            this.Controls.Add(this.PictureBox_dashboard);
            this.Controls.Add(this.Button_cancel);
            this.Controls.Add(this.GradientPanel_atas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.ShadowPanel_nonaktif.ResumeLayout(false);
            this.ShadowPanel_nonaktif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CirclePictureBox_nonaktif)).EndInit();
            this.ShadowPanel_aktif.ResumeLayout(false);
            this.ShadowPanel_aktif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CirclePictureBox_aktif)).EndInit();
            this.ShadowPanel_total.ResumeLayout(false);
            this.ShadowPanel_total.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CirclePictureBox_total)).EndInit();
            this.GradientPanel_atas.ResumeLayout(false);
            this.GradientPanel_atas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_dashboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ShadowPanel ShadowPanel_total;
        private Guna.UI2.WinForms.Guna2CirclePictureBox CirclePictureBox_total;
        private Guna.UI2.WinForms.Guna2ShadowPanel ShadowPanel_nonaktif;
        private Guna.UI2.WinForms.Guna2CirclePictureBox CirclePictureBox_nonaktif;
        private Guna.UI2.WinForms.Guna2ShadowPanel ShadowPanel_aktif;
        private System.Windows.Forms.Label label_aktif;
        private Guna.UI2.WinForms.Guna2CirclePictureBox CirclePictureBox_aktif;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label_nonaktif;
        private System.Windows.Forms.Label label_karyawanNonaktif;
        private System.Windows.Forms.Label label_karyawanAktif;
        private System.Windows.Forms.Label label_totalKaryawan;
        private Guna.UI2.WinForms.Guna2GradientPanel GradientPanel_atas;
        private Guna.UI2.WinForms.Guna2Button Button_keluar;
        private System.Windows.Forms.Label label_judul;
        private Guna.UI2.WinForms.Guna2Button Button_cancel;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBox_dashboard;
    }
}