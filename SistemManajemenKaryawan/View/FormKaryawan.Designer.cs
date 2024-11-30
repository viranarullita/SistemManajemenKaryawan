namespace SistemManajemenKaryawan.View
{
    partial class FormKaryawan
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
            this.DataGridView_karyawan = new System.Windows.Forms.DataGridView();
            this.Button_keluar = new Guna.UI2.WinForms.Guna2Button();
            this.Panel_kanan = new Guna.UI2.WinForms.Guna2Panel();
            this.Button_clear = new Guna.UI2.WinForms.Guna2Button();
            this.Button_delete = new Guna.UI2.WinForms.Guna2Button();
            this.Button_update = new Guna.UI2.WinForms.Guna2Button();
            this.Button_add = new Guna.UI2.WinForms.Guna2Button();
            this.Button_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.Panel_kiri = new Guna.UI2.WinForms.Guna2Panel();
            this.ShadowPanel_karyawan = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.ComboBox_status = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TextBox_idKaryawan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_idKaryawan = new System.Windows.Forms.Label();
            this.ComboBox_idDept = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label_bergabung = new System.Windows.Forms.Label();
            this.DateTimePicker_bergabung = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ComboBox_jeniskel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TextBox_posisi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_status = new System.Windows.Forms.Label();
            this.TextBox_nohp = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_nama = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_iddept = new System.Windows.Forms.Label();
            this.label_posisi = new System.Windows.Forms.Label();
            this.label_nohp = new System.Windows.Forms.Label();
            this.label_jeniskelamin = new System.Windows.Forms.Label();
            this.label_nama = new System.Windows.Forms.Label();
            this.label_judul = new System.Windows.Forms.Label();
            this.TextBox_cari = new Guna.UI2.WinForms.Guna2TextBox();
            this.Button_refresh = new Guna.UI2.WinForms.Guna2Button();
            this.ImageButton_search = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_karyawan)).BeginInit();
            this.ShadowPanel_karyawan.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView_karyawan
            // 
            this.DataGridView_karyawan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_karyawan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridView_karyawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_karyawan.Location = new System.Drawing.Point(46, 83);
            this.DataGridView_karyawan.Name = "DataGridView_karyawan";
            this.DataGridView_karyawan.RowHeadersWidth = 62;
            this.DataGridView_karyawan.RowTemplate.Height = 28;
            this.DataGridView_karyawan.Size = new System.Drawing.Size(1007, 258);
            this.DataGridView_karyawan.TabIndex = 48;
            this.DataGridView_karyawan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_karyawan_CellClick);
            // 
            // Button_keluar
            // 
            this.Button_keluar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_keluar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_keluar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_keluar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_keluar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_keluar.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Button_keluar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_keluar.ForeColor = System.Drawing.Color.Red;
            this.Button_keluar.Location = new System.Drawing.Point(1009, -6);
            this.Button_keluar.Name = "Button_keluar";
            this.Button_keluar.Size = new System.Drawing.Size(58, 53);
            this.Button_keluar.TabIndex = 47;
            this.Button_keluar.Text = "X";
            this.Button_keluar.Click += new System.EventHandler(this.Button_keluar_Click);
            // 
            // Panel_kanan
            // 
            this.Panel_kanan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_kanan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Panel_kanan.Location = new System.Drawing.Point(1073, -6);
            this.Panel_kanan.Name = "Panel_kanan";
            this.Panel_kanan.Size = new System.Drawing.Size(39, 703);
            this.Panel_kanan.TabIndex = 41;
            // 
            // Button_clear
            // 
            this.Button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_clear.BackColor = System.Drawing.Color.Transparent;
            this.Button_clear.BorderRadius = 8;
            this.Button_clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_clear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_clear.ForeColor = System.Drawing.Color.White;
            this.Button_clear.Location = new System.Drawing.Point(405, 634);
            this.Button_clear.Name = "Button_clear";
            this.Button_clear.Size = new System.Drawing.Size(103, 45);
            this.Button_clear.TabIndex = 46;
            this.Button_clear.Text = "Clear";
            this.Button_clear.Click += new System.EventHandler(this.Button_clear_Click);
            // 
            // Button_delete
            // 
            this.Button_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_delete.BackColor = System.Drawing.Color.Transparent;
            this.Button_delete.BorderRadius = 8;
            this.Button_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_delete.FillColor = System.Drawing.Color.Red;
            this.Button_delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_delete.ForeColor = System.Drawing.Color.White;
            this.Button_delete.Location = new System.Drawing.Point(284, 634);
            this.Button_delete.Name = "Button_delete";
            this.Button_delete.Size = new System.Drawing.Size(103, 45);
            this.Button_delete.TabIndex = 45;
            this.Button_delete.Text = "Delete";
            this.Button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // Button_update
            // 
            this.Button_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_update.BackColor = System.Drawing.Color.Transparent;
            this.Button_update.BorderRadius = 8;
            this.Button_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_update.FillColor = System.Drawing.Color.Peru;
            this.Button_update.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_update.ForeColor = System.Drawing.Color.White;
            this.Button_update.Location = new System.Drawing.Point(162, 634);
            this.Button_update.Name = "Button_update";
            this.Button_update.Size = new System.Drawing.Size(105, 45);
            this.Button_update.TabIndex = 44;
            this.Button_update.Text = "Update";
            this.Button_update.Click += new System.EventHandler(this.Button_update_Click);
            // 
            // Button_add
            // 
            this.Button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_add.BackColor = System.Drawing.Color.Transparent;
            this.Button_add.BorderRadius = 8;
            this.Button_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_add.FillColor = System.Drawing.Color.CadetBlue;
            this.Button_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_add.ForeColor = System.Drawing.Color.White;
            this.Button_add.Location = new System.Drawing.Point(46, 634);
            this.Button_add.Name = "Button_add";
            this.Button_add.Size = new System.Drawing.Size(98, 45);
            this.Button_add.TabIndex = 43;
            this.Button_add.Text = "Add";
            this.Button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // Button_cancel
            // 
            this.Button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_cancel.BackColor = System.Drawing.Color.Transparent;
            this.Button_cancel.BorderRadius = 8;
            this.Button_cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_cancel.FillColor = System.Drawing.Color.DimGray;
            this.Button_cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_cancel.ForeColor = System.Drawing.Color.White;
            this.Button_cancel.Location = new System.Drawing.Point(930, 634);
            this.Button_cancel.Name = "Button_cancel";
            this.Button_cancel.Size = new System.Drawing.Size(123, 45);
            this.Button_cancel.TabIndex = 42;
            this.Button_cancel.Text = "Cancel";
            this.Button_cancel.Click += new System.EventHandler(this.Button_cancel_Click);
            // 
            // Panel_kiri
            // 
            this.Panel_kiri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Panel_kiri.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Panel_kiri.Location = new System.Drawing.Point(-12, -6);
            this.Panel_kiri.Name = "Panel_kiri";
            this.Panel_kiri.Size = new System.Drawing.Size(39, 703);
            this.Panel_kiri.TabIndex = 40;
            // 
            // ShadowPanel_karyawan
            // 
            this.ShadowPanel_karyawan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShadowPanel_karyawan.BackColor = System.Drawing.Color.White;
            this.ShadowPanel_karyawan.Controls.Add(this.ComboBox_status);
            this.ShadowPanel_karyawan.Controls.Add(this.TextBox_idKaryawan);
            this.ShadowPanel_karyawan.Controls.Add(this.label_idKaryawan);
            this.ShadowPanel_karyawan.Controls.Add(this.ComboBox_idDept);
            this.ShadowPanel_karyawan.Controls.Add(this.label_bergabung);
            this.ShadowPanel_karyawan.Controls.Add(this.DateTimePicker_bergabung);
            this.ShadowPanel_karyawan.Controls.Add(this.ComboBox_jeniskel);
            this.ShadowPanel_karyawan.Controls.Add(this.TextBox_posisi);
            this.ShadowPanel_karyawan.Controls.Add(this.label_status);
            this.ShadowPanel_karyawan.Controls.Add(this.TextBox_nohp);
            this.ShadowPanel_karyawan.Controls.Add(this.TextBox_nama);
            this.ShadowPanel_karyawan.Controls.Add(this.label_iddept);
            this.ShadowPanel_karyawan.Controls.Add(this.label_posisi);
            this.ShadowPanel_karyawan.Controls.Add(this.label_nohp);
            this.ShadowPanel_karyawan.Controls.Add(this.label_jeniskelamin);
            this.ShadowPanel_karyawan.Controls.Add(this.label_nama);
            this.ShadowPanel_karyawan.FillColor = System.Drawing.Color.White;
            this.ShadowPanel_karyawan.Location = new System.Drawing.Point(46, 354);
            this.ShadowPanel_karyawan.Name = "ShadowPanel_karyawan";
            this.ShadowPanel_karyawan.ShadowColor = System.Drawing.Color.Black;
            this.ShadowPanel_karyawan.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.ShadowPanel_karyawan.Size = new System.Drawing.Size(1007, 269);
            this.ShadowPanel_karyawan.TabIndex = 38;
            // 
            // ComboBox_status
            // 
            this.ComboBox_status.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_status.BorderColor = System.Drawing.Color.Black;
            this.ComboBox_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_status.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_status.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_status.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox_status.ForeColor = System.Drawing.Color.Black;
            this.ComboBox_status.ItemHeight = 30;
            this.ComboBox_status.Items.AddRange(new object[] {
            "Aktif",
            "Nonaktif"});
            this.ComboBox_status.Location = new System.Drawing.Point(684, 133);
            this.ComboBox_status.Name = "ComboBox_status";
            this.ComboBox_status.Size = new System.Drawing.Size(244, 36);
            this.ComboBox_status.TabIndex = 23;
            // 
            // TextBox_idKaryawan
            // 
            this.TextBox_idKaryawan.BorderColor = System.Drawing.Color.Black;
            this.TextBox_idKaryawan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_idKaryawan.DefaultText = "";
            this.TextBox_idKaryawan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_idKaryawan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_idKaryawan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_idKaryawan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_idKaryawan.Enabled = false;
            this.TextBox_idKaryawan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_idKaryawan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_idKaryawan.ForeColor = System.Drawing.Color.Black;
            this.TextBox_idKaryawan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_idKaryawan.Location = new System.Drawing.Point(143, 14);
            this.TextBox_idKaryawan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_idKaryawan.Name = "TextBox_idKaryawan";
            this.TextBox_idKaryawan.PasswordChar = '\0';
            this.TextBox_idKaryawan.PlaceholderText = "";
            this.TextBox_idKaryawan.SelectedText = "";
            this.TextBox_idKaryawan.Size = new System.Drawing.Size(244, 38);
            this.TextBox_idKaryawan.TabIndex = 22;
            // 
            // label_idKaryawan
            // 
            this.label_idKaryawan.AutoSize = true;
            this.label_idKaryawan.Location = new System.Drawing.Point(23, 23);
            this.label_idKaryawan.Name = "label_idKaryawan";
            this.label_idKaryawan.Size = new System.Drawing.Size(96, 20);
            this.label_idKaryawan.TabIndex = 21;
            this.label_idKaryawan.Text = "Id Karyawan";
            // 
            // ComboBox_idDept
            // 
            this.ComboBox_idDept.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_idDept.BorderColor = System.Drawing.Color.Black;
            this.ComboBox_idDept.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_idDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_idDept.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_idDept.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_idDept.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox_idDept.ForeColor = System.Drawing.Color.Black;
            this.ComboBox_idDept.ItemHeight = 30;
            this.ComboBox_idDept.Location = new System.Drawing.Point(684, 66);
            this.ComboBox_idDept.Name = "ComboBox_idDept";
            this.ComboBox_idDept.Size = new System.Drawing.Size(244, 36);
            this.ComboBox_idDept.TabIndex = 20;
            // 
            // label_bergabung
            // 
            this.label_bergabung.AutoSize = true;
            this.label_bergabung.Location = new System.Drawing.Point(502, 210);
            this.label_bergabung.Name = "label_bergabung";
            this.label_bergabung.Size = new System.Drawing.Size(149, 20);
            this.label_bergabung.TabIndex = 19;
            this.label_bergabung.Text = "Tanggal Bergabung";
            // 
            // DateTimePicker_bergabung
            // 
            this.DateTimePicker_bergabung.Checked = true;
            this.DateTimePicker_bergabung.FillColor = System.Drawing.Color.WhiteSmoke;
            this.DateTimePicker_bergabung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePicker_bergabung.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePicker_bergabung.Location = new System.Drawing.Point(684, 203);
            this.DateTimePicker_bergabung.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker_bergabung.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker_bergabung.Name = "DateTimePicker_bergabung";
            this.DateTimePicker_bergabung.Size = new System.Drawing.Size(282, 36);
            this.DateTimePicker_bergabung.TabIndex = 18;
            this.DateTimePicker_bergabung.Value = new System.DateTime(2024, 11, 23, 7, 41, 29, 618);
            // 
            // ComboBox_jeniskel
            // 
            this.ComboBox_jeniskel.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_jeniskel.BorderColor = System.Drawing.Color.Black;
            this.ComboBox_jeniskel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_jeniskel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_jeniskel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_jeniskel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_jeniskel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox_jeniskel.ForeColor = System.Drawing.Color.Black;
            this.ComboBox_jeniskel.ItemHeight = 30;
            this.ComboBox_jeniskel.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.ComboBox_jeniskel.Location = new System.Drawing.Point(143, 133);
            this.ComboBox_jeniskel.Name = "ComboBox_jeniskel";
            this.ComboBox_jeniskel.Size = new System.Drawing.Size(244, 36);
            this.ComboBox_jeniskel.TabIndex = 16;
            // 
            // TextBox_posisi
            // 
            this.TextBox_posisi.BorderColor = System.Drawing.Color.Black;
            this.TextBox_posisi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_posisi.DefaultText = "";
            this.TextBox_posisi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_posisi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_posisi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_posisi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_posisi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_posisi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_posisi.ForeColor = System.Drawing.Color.Black;
            this.TextBox_posisi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_posisi.Location = new System.Drawing.Point(684, 14);
            this.TextBox_posisi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_posisi.Name = "TextBox_posisi";
            this.TextBox_posisi.PasswordChar = '\0';
            this.TextBox_posisi.PlaceholderText = "";
            this.TextBox_posisi.SelectedText = "";
            this.TextBox_posisi.Size = new System.Drawing.Size(244, 38);
            this.TextBox_posisi.TabIndex = 12;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(502, 141);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(56, 20);
            this.label_status.TabIndex = 11;
            this.label_status.Text = "Status";
            // 
            // TextBox_nohp
            // 
            this.TextBox_nohp.BorderColor = System.Drawing.Color.Black;
            this.TextBox_nohp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_nohp.DefaultText = "";
            this.TextBox_nohp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_nohp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_nohp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_nohp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_nohp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_nohp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_nohp.ForeColor = System.Drawing.Color.Black;
            this.TextBox_nohp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_nohp.Location = new System.Drawing.Point(143, 201);
            this.TextBox_nohp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_nohp.Name = "TextBox_nohp";
            this.TextBox_nohp.PasswordChar = '\0';
            this.TextBox_nohp.PlaceholderText = "";
            this.TextBox_nohp.SelectedText = "";
            this.TextBox_nohp.Size = new System.Drawing.Size(244, 38);
            this.TextBox_nohp.TabIndex = 10;
            // 
            // TextBox_nama
            // 
            this.TextBox_nama.BorderColor = System.Drawing.Color.Black;
            this.TextBox_nama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_nama.DefaultText = "";
            this.TextBox_nama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_nama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_nama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_nama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_nama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_nama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_nama.ForeColor = System.Drawing.Color.Black;
            this.TextBox_nama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_nama.Location = new System.Drawing.Point(143, 66);
            this.TextBox_nama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_nama.Name = "TextBox_nama";
            this.TextBox_nama.PasswordChar = '\0';
            this.TextBox_nama.PlaceholderText = "";
            this.TextBox_nama.SelectedText = "";
            this.TextBox_nama.Size = new System.Drawing.Size(244, 38);
            this.TextBox_nama.TabIndex = 8;
            // 
            // label_iddept
            // 
            this.label_iddept.AutoSize = true;
            this.label_iddept.Location = new System.Drawing.Point(502, 74);
            this.label_iddept.Name = "label_iddept";
            this.label_iddept.Size = new System.Drawing.Size(119, 20);
            this.label_iddept.TabIndex = 7;
            this.label_iddept.Text = "ID Departemen";
            // 
            // label_posisi
            // 
            this.label_posisi.AutoSize = true;
            this.label_posisi.Location = new System.Drawing.Point(502, 23);
            this.label_posisi.Name = "label_posisi";
            this.label_posisi.Size = new System.Drawing.Size(50, 20);
            this.label_posisi.TabIndex = 6;
            this.label_posisi.Text = "Posisi";
            // 
            // label_nohp
            // 
            this.label_nohp.AutoSize = true;
            this.label_nohp.Location = new System.Drawing.Point(20, 210);
            this.label_nohp.Name = "label_nohp";
            this.label_nohp.Size = new System.Drawing.Size(54, 20);
            this.label_nohp.TabIndex = 5;
            this.label_nohp.Text = "No Hp";
            // 
            // label_jeniskelamin
            // 
            this.label_jeniskelamin.AutoSize = true;
            this.label_jeniskelamin.Location = new System.Drawing.Point(20, 141);
            this.label_jeniskelamin.Name = "label_jeniskelamin";
            this.label_jeniskelamin.Size = new System.Drawing.Size(106, 20);
            this.label_jeniskelamin.TabIndex = 4;
            this.label_jeniskelamin.Text = "Jenis Kelamin";
            // 
            // label_nama
            // 
            this.label_nama.AutoSize = true;
            this.label_nama.Location = new System.Drawing.Point(23, 74);
            this.label_nama.Name = "label_nama";
            this.label_nama.Size = new System.Drawing.Size(51, 20);
            this.label_nama.TabIndex = 2;
            this.label_nama.Text = "Nama";
            // 
            // label_judul
            // 
            this.label_judul.AutoSize = true;
            this.label_judul.BackColor = System.Drawing.Color.Transparent;
            this.label_judul.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_judul.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_judul.Location = new System.Drawing.Point(51, 29);
            this.label_judul.Name = "label_judul";
            this.label_judul.Size = new System.Drawing.Size(266, 32);
            this.label_judul.TabIndex = 39;
            this.label_judul.Text = "DATA KARYAWAN";
            // 
            // TextBox_cari
            // 
            this.TextBox_cari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_cari.BorderRadius = 20;
            this.TextBox_cari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_cari.DefaultText = "";
            this.TextBox_cari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_cari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_cari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_cari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_cari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_cari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_cari.ForeColor = System.Drawing.Color.Black;
            this.TextBox_cari.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_cari.Location = new System.Drawing.Point(552, 21);
            this.TextBox_cari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_cari.Name = "TextBox_cari";
            this.TextBox_cari.PasswordChar = '\0';
            this.TextBox_cari.PlaceholderText = "";
            this.TextBox_cari.SelectedText = "";
            this.TextBox_cari.Size = new System.Drawing.Size(360, 51);
            this.TextBox_cari.TabIndex = 50;
            // 
            // Button_refresh
            // 
            this.Button_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_refresh.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Button_refresh.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F);
            this.Button_refresh.ForeColor = System.Drawing.Color.Red;
            this.Button_refresh.Image = global::SistemManajemenKaryawan.Properties.Resources.refresh;
            this.Button_refresh.ImageSize = new System.Drawing.Size(28, 28);
            this.Button_refresh.Location = new System.Drawing.Point(943, -6);
            this.Button_refresh.Name = "Button_refresh";
            this.Button_refresh.Size = new System.Drawing.Size(58, 53);
            this.Button_refresh.TabIndex = 52;
            this.Button_refresh.Click += new System.EventHandler(this.Button_refresh_Click);
            // 
            // ImageButton_search
            // 
            this.ImageButton_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageButton_search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ImageButton_search.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButton_search.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.ImageButton_search.Image = global::SistemManajemenKaryawan.Properties.Resources.search;
            this.ImageButton_search.ImageOffset = new System.Drawing.Point(0, 0);
            this.ImageButton_search.ImageRotate = 0F;
            this.ImageButton_search.ImageSize = new System.Drawing.Size(30, 30);
            this.ImageButton_search.Location = new System.Drawing.Point(834, 24);
            this.ImageButton_search.Name = "ImageButton_search";
            this.ImageButton_search.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.ImageButton_search.Size = new System.Drawing.Size(58, 45);
            this.ImageButton_search.TabIndex = 51;
            this.ImageButton_search.Click += new System.EventHandler(this.ImageButton_search_Click);
            // 
            // FormKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1101, 693);
            this.Controls.Add(this.Button_refresh);
            this.Controls.Add(this.ImageButton_search);
            this.Controls.Add(this.TextBox_cari);
            this.Controls.Add(this.DataGridView_karyawan);
            this.Controls.Add(this.Button_keluar);
            this.Controls.Add(this.Panel_kanan);
            this.Controls.Add(this.Button_clear);
            this.Controls.Add(this.Button_delete);
            this.Controls.Add(this.Button_update);
            this.Controls.Add(this.Button_add);
            this.Controls.Add(this.Button_cancel);
            this.Controls.Add(this.Panel_kiri);
            this.Controls.Add(this.ShadowPanel_karyawan);
            this.Controls.Add(this.label_judul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKaryawan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKaryawan";
            this.Load += new System.EventHandler(this.FormKaryawan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_karyawan)).EndInit();
            this.ShadowPanel_karyawan.ResumeLayout(false);
            this.ShadowPanel_karyawan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_karyawan;
        private Guna.UI2.WinForms.Guna2Button Button_keluar;
        private Guna.UI2.WinForms.Guna2Panel Panel_kanan;
        private Guna.UI2.WinForms.Guna2Button Button_clear;
        private Guna.UI2.WinForms.Guna2Button Button_delete;
        private Guna.UI2.WinForms.Guna2Button Button_update;
        private Guna.UI2.WinForms.Guna2Button Button_add;
        private Guna.UI2.WinForms.Guna2Button Button_cancel;
        private Guna.UI2.WinForms.Guna2Panel Panel_kiri;
        private Guna.UI2.WinForms.Guna2ShadowPanel ShadowPanel_karyawan;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_idKaryawan;
        private System.Windows.Forms.Label label_idKaryawan;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_idDept;
        private System.Windows.Forms.Label label_bergabung;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker_bergabung;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_jeniskel;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_posisi;
        private System.Windows.Forms.Label label_status;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_nohp;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_nama;
        private System.Windows.Forms.Label label_iddept;
        private System.Windows.Forms.Label label_posisi;
        private System.Windows.Forms.Label label_nohp;
        private System.Windows.Forms.Label label_jeniskelamin;
        private System.Windows.Forms.Label label_nama;
        private System.Windows.Forms.Label label_judul;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_cari;
        private Guna.UI2.WinForms.Guna2ImageButton ImageButton_search;
        private Guna.UI2.WinForms.Guna2Button Button_refresh;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_status;
    }
}