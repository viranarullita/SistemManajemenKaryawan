namespace SistemManajemenKaryawan.View
{
    partial class FormDepartemen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GradientPanel_atas = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Button_keluar = new Guna.UI2.WinForms.Guna2Button();
            this.label_judulapliksi = new System.Windows.Forms.Label();
            this.Panel_kiri = new Guna.UI2.WinForms.Guna2Panel();
            this.PictureBox_dept = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ShadowPanel_karyawan = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label_iddept = new System.Windows.Forms.Label();
            this.TextBox_namadept = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_iddept = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_nama = new System.Windows.Forms.Label();
            this.Button_add = new Guna.UI2.WinForms.Guna2Button();
            this.Button_clear = new Guna.UI2.WinForms.Guna2Button();
            this.Button_update = new Guna.UI2.WinForms.Guna2Button();
            this.label_judul = new System.Windows.Forms.Label();
            this.DataGridView_departemen = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Button_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.GradientPanel_atas.SuspendLayout();
            this.Panel_kiri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_dept)).BeginInit();
            this.ShadowPanel_karyawan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_departemen)).BeginInit();
            this.SuspendLayout();
            // 
            // GradientPanel_atas
            // 
            this.GradientPanel_atas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GradientPanel_atas.BackColor = System.Drawing.Color.CadetBlue;
            this.GradientPanel_atas.BorderColor = System.Drawing.Color.Black;
            this.GradientPanel_atas.Controls.Add(this.Button_keluar);
            this.GradientPanel_atas.Controls.Add(this.label_judulapliksi);
            this.GradientPanel_atas.FillColor = System.Drawing.Color.SkyBlue;
            this.GradientPanel_atas.Location = new System.Drawing.Point(-3, -3);
            this.GradientPanel_atas.Name = "GradientPanel_atas";
            this.GradientPanel_atas.Size = new System.Drawing.Size(1106, 54);
            this.GradientPanel_atas.TabIndex = 19;
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
            this.Button_keluar.Location = new System.Drawing.Point(1045, 0);
            this.Button_keluar.Name = "Button_keluar";
            this.Button_keluar.Size = new System.Drawing.Size(58, 54);
            this.Button_keluar.TabIndex = 35;
            this.Button_keluar.Text = "X";
            this.Button_keluar.Click += new System.EventHandler(this.Button_keluar_Click);
            // 
            // label_judulapliksi
            // 
            this.label_judulapliksi.AutoSize = true;
            this.label_judulapliksi.BackColor = System.Drawing.Color.Transparent;
            this.label_judulapliksi.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_judulapliksi.ForeColor = System.Drawing.Color.White;
            this.label_judulapliksi.Location = new System.Drawing.Point(12, 12);
            this.label_judulapliksi.Name = "label_judulapliksi";
            this.label_judulapliksi.Size = new System.Drawing.Size(341, 25);
            this.label_judulapliksi.TabIndex = 0;
            this.label_judulapliksi.Text = "Sistem Manajemen Karyawan\r\n";
            // 
            // Panel_kiri
            // 
            this.Panel_kiri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Panel_kiri.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Panel_kiri.Controls.Add(this.PictureBox_dept);
            this.Panel_kiri.Controls.Add(this.ShadowPanel_karyawan);
            this.Panel_kiri.Location = new System.Drawing.Point(-2, 40);
            this.Panel_kiri.Name = "Panel_kiri";
            this.Panel_kiri.Size = new System.Drawing.Size(458, 656);
            this.Panel_kiri.TabIndex = 17;
            // 
            // PictureBox_dept
            // 
            this.PictureBox_dept.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PictureBox_dept.Image = global::SistemManajemenKaryawan.Properties.Resources.Bangunan;
            this.PictureBox_dept.ImageRotate = 0F;
            this.PictureBox_dept.Location = new System.Drawing.Point(16, 22);
            this.PictureBox_dept.Name = "PictureBox_dept";
            this.PictureBox_dept.Size = new System.Drawing.Size(421, 342);
            this.PictureBox_dept.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_dept.TabIndex = 11;
            this.PictureBox_dept.TabStop = false;
            // 
            // ShadowPanel_karyawan
            // 
            this.ShadowPanel_karyawan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShadowPanel_karyawan.BackColor = System.Drawing.Color.Gainsboro;
            this.ShadowPanel_karyawan.Controls.Add(this.label_iddept);
            this.ShadowPanel_karyawan.Controls.Add(this.TextBox_namadept);
            this.ShadowPanel_karyawan.Controls.Add(this.TextBox_iddept);
            this.ShadowPanel_karyawan.Controls.Add(this.label_nama);
            this.ShadowPanel_karyawan.Controls.Add(this.Button_add);
            this.ShadowPanel_karyawan.Controls.Add(this.Button_clear);
            this.ShadowPanel_karyawan.Controls.Add(this.Button_update);
            this.ShadowPanel_karyawan.FillColor = System.Drawing.Color.Gainsboro;
            this.ShadowPanel_karyawan.Location = new System.Drawing.Point(13, 375);
            this.ShadowPanel_karyawan.Name = "ShadowPanel_karyawan";
            this.ShadowPanel_karyawan.ShadowColor = System.Drawing.Color.Black;
            this.ShadowPanel_karyawan.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.ShadowPanel_karyawan.Size = new System.Drawing.Size(424, 232);
            this.ShadowPanel_karyawan.TabIndex = 10;
            // 
            // label_iddept
            // 
            this.label_iddept.AutoSize = true;
            this.label_iddept.Location = new System.Drawing.Point(28, 30);
            this.label_iddept.Name = "label_iddept";
            this.label_iddept.Size = new System.Drawing.Size(116, 20);
            this.label_iddept.TabIndex = 19;
            this.label_iddept.Text = "Id Departemen";
            // 
            // TextBox_namadept
            // 
            this.TextBox_namadept.BorderColor = System.Drawing.Color.Black;
            this.TextBox_namadept.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_namadept.DefaultText = "";
            this.TextBox_namadept.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_namadept.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_namadept.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_namadept.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_namadept.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_namadept.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_namadept.ForeColor = System.Drawing.Color.Black;
            this.TextBox_namadept.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_namadept.Location = new System.Drawing.Point(151, 75);
            this.TextBox_namadept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_namadept.Name = "TextBox_namadept";
            this.TextBox_namadept.PasswordChar = '\0';
            this.TextBox_namadept.PlaceholderText = "";
            this.TextBox_namadept.SelectedText = "";
            this.TextBox_namadept.Size = new System.Drawing.Size(244, 38);
            this.TextBox_namadept.TabIndex = 18;
            // 
            // TextBox_iddept
            // 
            this.TextBox_iddept.BorderColor = System.Drawing.Color.Black;
            this.TextBox_iddept.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_iddept.DefaultText = "";
            this.TextBox_iddept.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_iddept.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_iddept.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_iddept.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_iddept.Enabled = false;
            this.TextBox_iddept.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_iddept.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_iddept.ForeColor = System.Drawing.Color.Black;
            this.TextBox_iddept.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_iddept.Location = new System.Drawing.Point(151, 20);
            this.TextBox_iddept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_iddept.Name = "TextBox_iddept";
            this.TextBox_iddept.PasswordChar = '\0';
            this.TextBox_iddept.PlaceholderText = "";
            this.TextBox_iddept.SelectedText = "";
            this.TextBox_iddept.Size = new System.Drawing.Size(244, 38);
            this.TextBox_iddept.TabIndex = 8;
            // 
            // label_nama
            // 
            this.label_nama.AutoSize = true;
            this.label_nama.Location = new System.Drawing.Point(28, 83);
            this.label_nama.Name = "label_nama";
            this.label_nama.Size = new System.Drawing.Size(51, 20);
            this.label_nama.TabIndex = 2;
            this.label_nama.Text = "Nama";
            // 
            // Button_add
            // 
            this.Button_add.BackColor = System.Drawing.Color.Transparent;
            this.Button_add.BorderRadius = 8;
            this.Button_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_add.FillColor = System.Drawing.Color.CadetBlue;
            this.Button_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_add.ForeColor = System.Drawing.Color.White;
            this.Button_add.Location = new System.Drawing.Point(32, 155);
            this.Button_add.Name = "Button_add";
            this.Button_add.Size = new System.Drawing.Size(98, 45);
            this.Button_add.TabIndex = 14;
            this.Button_add.Text = "Add";
            this.Button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // Button_clear
            // 
            this.Button_clear.BackColor = System.Drawing.Color.Transparent;
            this.Button_clear.BorderRadius = 8;
            this.Button_clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_clear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_clear.ForeColor = System.Drawing.Color.White;
            this.Button_clear.Location = new System.Drawing.Point(301, 155);
            this.Button_clear.Name = "Button_clear";
            this.Button_clear.Size = new System.Drawing.Size(94, 45);
            this.Button_clear.TabIndex = 17;
            this.Button_clear.Text = "Clear";
            this.Button_clear.Click += new System.EventHandler(this.Button_clear_Click);
            // 
            // Button_update
            // 
            this.Button_update.BackColor = System.Drawing.Color.Transparent;
            this.Button_update.BorderRadius = 8;
            this.Button_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_update.FillColor = System.Drawing.Color.Peru;
            this.Button_update.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_update.ForeColor = System.Drawing.Color.White;
            this.Button_update.Location = new System.Drawing.Point(163, 155);
            this.Button_update.Name = "Button_update";
            this.Button_update.Size = new System.Drawing.Size(113, 45);
            this.Button_update.TabIndex = 15;
            this.Button_update.Text = "Update";
            this.Button_update.Click += new System.EventHandler(this.Button_update_Click);
            // 
            // label_judul
            // 
            this.label_judul.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_judul.AutoSize = true;
            this.label_judul.BackColor = System.Drawing.Color.Transparent;
            this.label_judul.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_judul.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_judul.Location = new System.Drawing.Point(494, 71);
            this.label_judul.Name = "label_judul";
            this.label_judul.Size = new System.Drawing.Size(254, 28);
            this.label_judul.TabIndex = 16;
            this.label_judul.Text = "DATA DEPARTEMEN";
            // 
            // DataGridView_departemen
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_departemen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_departemen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_departemen.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataGridView_departemen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_departemen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_departemen.ColumnHeadersHeight = 20;
            this.DataGridView_departemen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_departemen.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_departemen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_departemen.Location = new System.Drawing.Point(499, 111);
            this.DataGridView_departemen.Name = "DataGridView_departemen";
            this.DataGridView_departemen.RowHeadersVisible = false;
            this.DataGridView_departemen.RowHeadersWidth = 62;
            this.DataGridView_departemen.RowTemplate.Height = 28;
            this.DataGridView_departemen.Size = new System.Drawing.Size(563, 521);
            this.DataGridView_departemen.TabIndex = 15;
            this.DataGridView_departemen.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_departemen.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_departemen.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_departemen.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_departemen.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_departemen.ThemeStyle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataGridView_departemen.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_departemen.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_departemen.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_departemen.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_departemen.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_departemen.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_departemen.ThemeStyle.HeaderStyle.Height = 20;
            this.DataGridView_departemen.ThemeStyle.ReadOnly = false;
            this.DataGridView_departemen.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_departemen.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_departemen.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_departemen.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_departemen.ThemeStyle.RowsStyle.Height = 28;
            this.DataGridView_departemen.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_departemen.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_departemen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_departemen_CellClick);
            // 
            // Button_cancel
            // 
            this.Button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_cancel.BackColor = System.Drawing.Color.Transparent;
            this.Button_cancel.BorderRadius = 10;
            this.Button_cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_cancel.FillColor = System.Drawing.Color.IndianRed;
            this.Button_cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_cancel.ForeColor = System.Drawing.Color.White;
            this.Button_cancel.Location = new System.Drawing.Point(907, 641);
            this.Button_cancel.Name = "Button_cancel";
            this.Button_cancel.Size = new System.Drawing.Size(155, 41);
            this.Button_cancel.TabIndex = 18;
            this.Button_cancel.Text = "Cancel";
            this.Button_cancel.Click += new System.EventHandler(this.Button_cancel_Click);
            // 
            // FormDepartemen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 693);
            this.Controls.Add(this.GradientPanel_atas);
            this.Controls.Add(this.Panel_kiri);
            this.Controls.Add(this.label_judul);
            this.Controls.Add(this.DataGridView_departemen);
            this.Controls.Add(this.Button_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDepartemen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDepartemen";
            this.Load += new System.EventHandler(this.FormDepartemen_Load);
            this.GradientPanel_atas.ResumeLayout(false);
            this.GradientPanel_atas.PerformLayout();
            this.Panel_kiri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_dept)).EndInit();
            this.ShadowPanel_karyawan.ResumeLayout(false);
            this.ShadowPanel_karyawan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_departemen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel GradientPanel_atas;
        private Guna.UI2.WinForms.Guna2Button Button_keluar;
        private System.Windows.Forms.Label label_judulapliksi;
        private Guna.UI2.WinForms.Guna2Panel Panel_kiri;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBox_dept;
        private Guna.UI2.WinForms.Guna2ShadowPanel ShadowPanel_karyawan;
        private System.Windows.Forms.Label label_iddept;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_namadept;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_iddept;
        private System.Windows.Forms.Label label_nama;
        private Guna.UI2.WinForms.Guna2Button Button_add;
        private Guna.UI2.WinForms.Guna2Button Button_clear;
        private Guna.UI2.WinForms.Guna2Button Button_update;
        private System.Windows.Forms.Label label_judul;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_departemen;
        private Guna.UI2.WinForms.Guna2Button Button_cancel;
    }
}