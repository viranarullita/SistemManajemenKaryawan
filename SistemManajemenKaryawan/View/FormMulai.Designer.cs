namespace SistemManajemenKaryawan.View
{
    partial class FormMulai
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
            this.panel_bawah = new System.Windows.Forms.Panel();
            this.Button_keluar = new Guna.UI2.WinForms.Guna2Button();
            this.CircleProgressBar_lingkar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.PictureBox_logodepan = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Button_start = new Guna.UI2.WinForms.Guna2Button();
            this.panel_besarkanan = new System.Windows.Forms.Panel();
            this.panel_sedangkanan = new System.Windows.Forms.Panel();
            this.panel_kecilkanan = new System.Windows.Forms.Panel();
            this.panel_besarkiri = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel_sedangkiri = new System.Windows.Forms.Panel();
            this.panel_kecilkiri = new System.Windows.Forms.Panel();
            this.label_judul = new System.Windows.Forms.Label();
            this.panel_bawah.SuspendLayout();
            this.CircleProgressBar_lingkar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_logodepan)).BeginInit();
            this.panel_besarkanan.SuspendLayout();
            this.panel_sedangkanan.SuspendLayout();
            this.panel_besarkiri.SuspendLayout();
            this.panel_sedangkiri.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bawah
            // 
            this.panel_bawah.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_bawah.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_bawah.Controls.Add(this.Button_keluar);
            this.panel_bawah.Location = new System.Drawing.Point(-13, 577);
            this.panel_bawah.Name = "panel_bawah";
            this.panel_bawah.Size = new System.Drawing.Size(1103, 35);
            this.panel_bawah.TabIndex = 15;
            // 
            // Button_keluar
            // 
            this.Button_keluar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_keluar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_keluar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_keluar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_keluar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_keluar.FillColor = System.Drawing.Color.White;
            this.Button_keluar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_keluar.ForeColor = System.Drawing.Color.Red;
            this.Button_keluar.Location = new System.Drawing.Point(979, 0);
            this.Button_keluar.Name = "Button_keluar";
            this.Button_keluar.Size = new System.Drawing.Size(110, 27);
            this.Button_keluar.TabIndex = 23;
            this.Button_keluar.Text = "EXIT";
            this.Button_keluar.Click += new System.EventHandler(this.Button_keluar_Click);
            // 
            // CircleProgressBar_lingkar
            // 
            this.CircleProgressBar_lingkar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CircleProgressBar_lingkar.Animated = true;
            this.CircleProgressBar_lingkar.Controls.Add(this.PictureBox_logodepan);
            this.CircleProgressBar_lingkar.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.CircleProgressBar_lingkar.FillThickness = 20;
            this.CircleProgressBar_lingkar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CircleProgressBar_lingkar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CircleProgressBar_lingkar.Location = new System.Drawing.Point(410, 139);
            this.CircleProgressBar_lingkar.Minimum = 0;
            this.CircleProgressBar_lingkar.Name = "CircleProgressBar_lingkar";
            this.CircleProgressBar_lingkar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CircleProgressBar_lingkar.ProgressColor2 = System.Drawing.Color.Turquoise;
            this.CircleProgressBar_lingkar.ProgressThickness = 20;
            this.CircleProgressBar_lingkar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CircleProgressBar_lingkar.Size = new System.Drawing.Size(263, 263);
            this.CircleProgressBar_lingkar.TabIndex = 17;
            this.CircleProgressBar_lingkar.Text = "Load";
            this.CircleProgressBar_lingkar.Value = 75;
            // 
            // PictureBox_logodepan
            // 
            this.PictureBox_logodepan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureBox_logodepan.Image = global::SistemManajemenKaryawan.Properties.Resources.logoDepan;
            this.PictureBox_logodepan.ImageRotate = 0F;
            this.PictureBox_logodepan.Location = new System.Drawing.Point(68, 60);
            this.PictureBox_logodepan.Name = "PictureBox_logodepan";
            this.PictureBox_logodepan.Size = new System.Drawing.Size(132, 141);
            this.PictureBox_logodepan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_logodepan.TabIndex = 18;
            this.PictureBox_logodepan.TabStop = false;
            // 
            // Button_start
            // 
            this.Button_start.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button_start.BorderRadius = 15;
            this.Button_start.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_start.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_start.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_start.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_start.FillColor = System.Drawing.Color.AliceBlue;
            this.Button_start.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_start.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Button_start.Location = new System.Drawing.Point(428, 441);
            this.Button_start.Name = "Button_start";
            this.Button_start.Size = new System.Drawing.Size(233, 53);
            this.Button_start.TabIndex = 16;
            this.Button_start.Text = "START";
            this.Button_start.Click += new System.EventHandler(this.Button_start_Click);
            // 
            // panel_besarkanan
            // 
            this.panel_besarkanan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_besarkanan.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_besarkanan.Controls.Add(this.panel_sedangkanan);
            this.panel_besarkanan.Location = new System.Drawing.Point(963, -27);
            this.panel_besarkanan.Name = "panel_besarkanan";
            this.panel_besarkanan.Size = new System.Drawing.Size(128, 636);
            this.panel_besarkanan.TabIndex = 14;
            // 
            // panel_sedangkanan
            // 
            this.panel_sedangkanan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_sedangkanan.BackColor = System.Drawing.Color.LightBlue;
            this.panel_sedangkanan.Controls.Add(this.panel_kecilkanan);
            this.panel_sedangkanan.Location = new System.Drawing.Point(21, 34);
            this.panel_sedangkanan.Name = "panel_sedangkanan";
            this.panel_sedangkanan.Size = new System.Drawing.Size(79, 569);
            this.panel_sedangkanan.TabIndex = 4;
            // 
            // panel_kecilkanan
            // 
            this.panel_kecilkanan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_kecilkanan.BackColor = System.Drawing.Color.CadetBlue;
            this.panel_kecilkanan.Location = new System.Drawing.Point(15, 22);
            this.panel_kecilkanan.Name = "panel_kecilkanan";
            this.panel_kecilkanan.Size = new System.Drawing.Size(49, 235);
            this.panel_kecilkanan.TabIndex = 5;
            // 
            // panel_besarkiri
            // 
            this.panel_besarkiri.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_besarkiri.Controls.Add(this.panel7);
            this.panel_besarkiri.Controls.Add(this.panel_sedangkiri);
            this.panel_besarkiri.Location = new System.Drawing.Point(-12, -27);
            this.panel_besarkiri.Name = "panel_besarkiri";
            this.panel_besarkiri.Size = new System.Drawing.Size(128, 636);
            this.panel_besarkiri.TabIndex = 13;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SteelBlue;
            this.panel7.Location = new System.Drawing.Point(138, 608);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(755, 28);
            this.panel7.TabIndex = 6;
            // 
            // panel_sedangkiri
            // 
            this.panel_sedangkiri.BackColor = System.Drawing.Color.LightBlue;
            this.panel_sedangkiri.Controls.Add(this.panel_kecilkiri);
            this.panel_sedangkiri.Location = new System.Drawing.Point(21, 34);
            this.panel_sedangkiri.Name = "panel_sedangkiri";
            this.panel_sedangkiri.Size = new System.Drawing.Size(79, 569);
            this.panel_sedangkiri.TabIndex = 4;
            // 
            // panel_kecilkiri
            // 
            this.panel_kecilkiri.BackColor = System.Drawing.Color.CadetBlue;
            this.panel_kecilkiri.Location = new System.Drawing.Point(15, 22);
            this.panel_kecilkiri.Name = "panel_kecilkiri";
            this.panel_kecilkiri.Size = new System.Drawing.Size(49, 234);
            this.panel_kecilkiri.TabIndex = 5;
            // 
            // label_judul
            // 
            this.label_judul.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_judul.AutoSize = true;
            this.label_judul.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_judul.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_judul.Location = new System.Drawing.Point(242, 40);
            this.label_judul.Name = "label_judul";
            this.label_judul.Size = new System.Drawing.Size(597, 48);
            this.label_judul.TabIndex = 12;
            this.label_judul.Text = "SISTEM MANAJEMEN KARYAWAN";
            // 
            // FormMulai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1079, 609);
            this.Controls.Add(this.panel_bawah);
            this.Controls.Add(this.CircleProgressBar_lingkar);
            this.Controls.Add(this.Button_start);
            this.Controls.Add(this.panel_besarkanan);
            this.Controls.Add(this.panel_besarkiri);
            this.Controls.Add(this.label_judul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMulai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMulai";
            this.panel_bawah.ResumeLayout(false);
            this.CircleProgressBar_lingkar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_logodepan)).EndInit();
            this.panel_besarkanan.ResumeLayout(false);
            this.panel_sedangkanan.ResumeLayout(false);
            this.panel_besarkiri.ResumeLayout(false);
            this.panel_sedangkiri.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_bawah;
        private Guna.UI2.WinForms.Guna2Button Button_keluar;
        private Guna.UI2.WinForms.Guna2CircleProgressBar CircleProgressBar_lingkar;
        private Guna.UI2.WinForms.Guna2Button Button_start;
        private System.Windows.Forms.Panel panel_besarkanan;
        private System.Windows.Forms.Panel panel_sedangkanan;
        private System.Windows.Forms.Panel panel_kecilkanan;
        private System.Windows.Forms.Panel panel_besarkiri;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel_sedangkiri;
        private System.Windows.Forms.Panel panel_kecilkiri;
        private System.Windows.Forms.Label label_judul;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBox_logodepan;
    }
}