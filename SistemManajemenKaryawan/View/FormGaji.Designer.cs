namespace SistemManajemenKaryawan.View
{
    partial class FormGaji
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
            this.label_judulsistem = new System.Windows.Forms.Label();
            this.ShadowPanel_gaji = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.ComboBox_idKaryawan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TextBox_gaji = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_gaji = new System.Windows.Forms.Label();
            this.ComboBox_status = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TextBox_idgaji = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_idgaji = new System.Windows.Forms.Label();
            this.label_idKaryawan = new System.Windows.Forms.Label();
            this.label_tglmenerima = new System.Windows.Forms.Label();
            this.DateTimePicker_penerimaan = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label_status = new System.Windows.Forms.Label();
            this.Panel_kiri = new Guna.UI2.WinForms.Guna2Panel();
            this.DataGridView_datagaji = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label_judul = new System.Windows.Forms.Label();
            this.Button_clear = new Guna.UI2.WinForms.Guna2Button();
            this.Button_delete = new Guna.UI2.WinForms.Guna2Button();
            this.Button_update = new Guna.UI2.WinForms.Guna2Button();
            this.Button_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.Button_add = new Guna.UI2.WinForms.Guna2Button();
            this.GradientPanel_atas.SuspendLayout();
            this.ShadowPanel_gaji.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_datagaji)).BeginInit();
            this.SuspendLayout();
            // 
            // GradientPanel_atas
            // 
            this.GradientPanel_atas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GradientPanel_atas.BackColor = System.Drawing.Color.CadetBlue;
            this.GradientPanel_atas.BorderColor = System.Drawing.Color.Black;
            this.GradientPanel_atas.Controls.Add(this.Button_keluar);
            this.GradientPanel_atas.Controls.Add(this.label_judulsistem);
            this.GradientPanel_atas.FillColor = System.Drawing.Color.SkyBlue;
            this.GradientPanel_atas.Location = new System.Drawing.Point(-3, -3);
            this.GradientPanel_atas.Name = "GradientPanel_atas";
            this.GradientPanel_atas.Size = new System.Drawing.Size(1106, 54);
            this.GradientPanel_atas.TabIndex = 30;
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
            // label_judulsistem
            // 
            this.label_judulsistem.AutoSize = true;
            this.label_judulsistem.BackColor = System.Drawing.Color.Transparent;
            this.label_judulsistem.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_judulsistem.ForeColor = System.Drawing.Color.White;
            this.label_judulsistem.Location = new System.Drawing.Point(12, 12);
            this.label_judulsistem.Name = "label_judulsistem";
            this.label_judulsistem.Size = new System.Drawing.Size(341, 25);
            this.label_judulsistem.TabIndex = 0;
            this.label_judulsistem.Text = "Sistem Manajemen Karyawan\r\n";
            // 
            // ShadowPanel_gaji
            // 
            this.ShadowPanel_gaji.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShadowPanel_gaji.BackColor = System.Drawing.Color.White;
            this.ShadowPanel_gaji.Controls.Add(this.ComboBox_idKaryawan);
            this.ShadowPanel_gaji.Controls.Add(this.TextBox_gaji);
            this.ShadowPanel_gaji.Controls.Add(this.label_gaji);
            this.ShadowPanel_gaji.Controls.Add(this.ComboBox_status);
            this.ShadowPanel_gaji.Controls.Add(this.TextBox_idgaji);
            this.ShadowPanel_gaji.Controls.Add(this.label_idgaji);
            this.ShadowPanel_gaji.Controls.Add(this.label_idKaryawan);
            this.ShadowPanel_gaji.Controls.Add(this.label_tglmenerima);
            this.ShadowPanel_gaji.Controls.Add(this.DateTimePicker_penerimaan);
            this.ShadowPanel_gaji.Controls.Add(this.label_status);
            this.ShadowPanel_gaji.FillColor = System.Drawing.Color.White;
            this.ShadowPanel_gaji.Location = new System.Drawing.Point(56, 406);
            this.ShadowPanel_gaji.Name = "ShadowPanel_gaji";
            this.ShadowPanel_gaji.ShadowColor = System.Drawing.Color.Black;
            this.ShadowPanel_gaji.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.ShadowPanel_gaji.Size = new System.Drawing.Size(1025, 203);
            this.ShadowPanel_gaji.TabIndex = 29;
            // 
            // ComboBox_idKaryawan
            // 
            this.ComboBox_idKaryawan.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_idKaryawan.BorderColor = System.Drawing.Color.Black;
            this.ComboBox_idKaryawan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_idKaryawan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_idKaryawan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_idKaryawan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_idKaryawan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox_idKaryawan.ForeColor = System.Drawing.Color.Black;
            this.ComboBox_idKaryawan.ItemHeight = 30;
            this.ComboBox_idKaryawan.Location = new System.Drawing.Point(176, 66);
            this.ComboBox_idKaryawan.Name = "ComboBox_idKaryawan";
            this.ComboBox_idKaryawan.Size = new System.Drawing.Size(257, 36);
            this.ComboBox_idKaryawan.TabIndex = 28;
            // 
            // TextBox_gaji
            // 
            this.TextBox_gaji.BorderColor = System.Drawing.Color.Black;
            this.TextBox_gaji.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_gaji.DefaultText = "";
            this.TextBox_gaji.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_gaji.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_gaji.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_gaji.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_gaji.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_gaji.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_gaji.ForeColor = System.Drawing.Color.Black;
            this.TextBox_gaji.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_gaji.Location = new System.Drawing.Point(176, 134);
            this.TextBox_gaji.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_gaji.Name = "TextBox_gaji";
            this.TextBox_gaji.PasswordChar = '\0';
            this.TextBox_gaji.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TextBox_gaji.PlaceholderText = "";
            this.TextBox_gaji.SelectedText = "";
            this.TextBox_gaji.Size = new System.Drawing.Size(257, 38);
            this.TextBox_gaji.TabIndex = 27;
            // 
            // label_gaji
            // 
            this.label_gaji.AutoSize = true;
            this.label_gaji.Location = new System.Drawing.Point(39, 145);
            this.label_gaji.Name = "label_gaji";
            this.label_gaji.Size = new System.Drawing.Size(37, 20);
            this.label_gaji.TabIndex = 26;
            this.label_gaji.Text = "Gaji";
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
            "Belum",
            "Diterima"});
            this.ComboBox_status.Location = new System.Drawing.Point(680, 24);
            this.ComboBox_status.Name = "ComboBox_status";
            this.ComboBox_status.Size = new System.Drawing.Size(286, 36);
            this.ComboBox_status.TabIndex = 25;
            // 
            // TextBox_idgaji
            // 
            this.TextBox_idgaji.BorderColor = System.Drawing.Color.Black;
            this.TextBox_idgaji.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_idgaji.DefaultText = "";
            this.TextBox_idgaji.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_idgaji.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_idgaji.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_idgaji.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_idgaji.Enabled = false;
            this.TextBox_idgaji.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_idgaji.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_idgaji.ForeColor = System.Drawing.Color.Black;
            this.TextBox_idgaji.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_idgaji.Location = new System.Drawing.Point(176, 18);
            this.TextBox_idgaji.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_idgaji.Name = "TextBox_idgaji";
            this.TextBox_idgaji.PasswordChar = '\0';
            this.TextBox_idgaji.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TextBox_idgaji.PlaceholderText = "";
            this.TextBox_idgaji.SelectedText = "";
            this.TextBox_idgaji.Size = new System.Drawing.Size(257, 36);
            this.TextBox_idgaji.TabIndex = 24;
            // 
            // label_idgaji
            // 
            this.label_idgaji.AutoSize = true;
            this.label_idgaji.Location = new System.Drawing.Point(39, 24);
            this.label_idgaji.Name = "label_idgaji";
            this.label_idgaji.Size = new System.Drawing.Size(58, 20);
            this.label_idgaji.TabIndex = 23;
            this.label_idgaji.Text = "ID Gaji";
            // 
            // label_idKaryawan
            // 
            this.label_idKaryawan.AutoSize = true;
            this.label_idKaryawan.Location = new System.Drawing.Point(39, 75);
            this.label_idKaryawan.Name = "label_idKaryawan";
            this.label_idKaryawan.Size = new System.Drawing.Size(99, 20);
            this.label_idKaryawan.TabIndex = 21;
            this.label_idKaryawan.Text = "ID Karyawan";
            // 
            // label_tglmenerima
            // 
            this.label_tglmenerima.AutoSize = true;
            this.label_tglmenerima.Location = new System.Drawing.Point(501, 97);
            this.label_tglmenerima.Name = "label_tglmenerima";
            this.label_tglmenerima.Size = new System.Drawing.Size(155, 20);
            this.label_tglmenerima.TabIndex = 19;
            this.label_tglmenerima.Text = "Tanggal Penerimaan";
            // 
            // DateTimePicker_penerimaan
            // 
            this.DateTimePicker_penerimaan.Checked = true;
            this.DateTimePicker_penerimaan.FillColor = System.Drawing.Color.WhiteSmoke;
            this.DateTimePicker_penerimaan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePicker_penerimaan.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePicker_penerimaan.Location = new System.Drawing.Point(680, 95);
            this.DateTimePicker_penerimaan.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker_penerimaan.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker_penerimaan.Name = "DateTimePicker_penerimaan";
            this.DateTimePicker_penerimaan.Size = new System.Drawing.Size(286, 36);
            this.DateTimePicker_penerimaan.TabIndex = 18;
            this.DateTimePicker_penerimaan.Value = new System.DateTime(2024, 11, 23, 7, 41, 29, 618);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(501, 29);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(56, 20);
            this.label_status.TabIndex = 4;
            this.label_status.Text = "Status";
            // 
            // Panel_kiri
            // 
            this.Panel_kiri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Panel_kiri.BackColor = System.Drawing.Color.SkyBlue;
            this.Panel_kiri.Location = new System.Drawing.Point(-3, 51);
            this.Panel_kiri.Name = "Panel_kiri";
            this.Panel_kiri.Size = new System.Drawing.Size(36, 644);
            this.Panel_kiri.TabIndex = 21;
            // 
            // DataGridView_datagaji
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.DataGridView_datagaji.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_datagaji.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_datagaji.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_datagaji.ColumnHeadersHeight = 30;
            this.DataGridView_datagaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_datagaji.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_datagaji.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.DataGridView_datagaji.Location = new System.Drawing.Point(56, 93);
            this.DataGridView_datagaji.Name = "DataGridView_datagaji";
            this.DataGridView_datagaji.RowHeadersVisible = false;
            this.DataGridView_datagaji.RowHeadersWidth = 62;
            this.DataGridView_datagaji.RowTemplate.Height = 28;
            this.DataGridView_datagaji.Size = new System.Drawing.Size(1025, 296);
            this.DataGridView_datagaji.TabIndex = 28;
            this.DataGridView_datagaji.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.DataGridView_datagaji.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.DataGridView_datagaji.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_datagaji.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_datagaji.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_datagaji.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_datagaji.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_datagaji.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.DataGridView_datagaji.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.DataGridView_datagaji.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_datagaji.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_datagaji.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_datagaji.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_datagaji.ThemeStyle.HeaderStyle.Height = 30;
            this.DataGridView_datagaji.ThemeStyle.ReadOnly = false;
            this.DataGridView_datagaji.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.DataGridView_datagaji.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_datagaji.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_datagaji.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridView_datagaji.ThemeStyle.RowsStyle.Height = 28;
            this.DataGridView_datagaji.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.DataGridView_datagaji.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridView_datagaji.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_datagaji_CellClick);
            // 
            // label_judul
            // 
            this.label_judul.AutoSize = true;
            this.label_judul.BackColor = System.Drawing.Color.Transparent;
            this.label_judul.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_judul.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_judul.Location = new System.Drawing.Point(63, 59);
            this.label_judul.Name = "label_judul";
            this.label_judul.Size = new System.Drawing.Size(143, 28);
            this.label_judul.TabIndex = 27;
            this.label_judul.Text = "DATA GAJI";
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
            this.Button_clear.Location = new System.Drawing.Point(423, 624);
            this.Button_clear.Name = "Button_clear";
            this.Button_clear.Size = new System.Drawing.Size(102, 45);
            this.Button_clear.TabIndex = 26;
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
            this.Button_delete.Location = new System.Drawing.Point(294, 624);
            this.Button_delete.Name = "Button_delete";
            this.Button_delete.Size = new System.Drawing.Size(107, 45);
            this.Button_delete.TabIndex = 25;
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
            this.Button_update.Location = new System.Drawing.Point(170, 624);
            this.Button_update.Name = "Button_update";
            this.Button_update.Size = new System.Drawing.Size(103, 45);
            this.Button_update.TabIndex = 24;
            this.Button_update.Text = "Update";
            this.Button_update.Click += new System.EventHandler(this.Button_update_Click);
            // 
            // Button_cancel
            // 
            this.Button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_cancel.BackColor = System.Drawing.Color.Transparent;
            this.Button_cancel.BorderColor = System.Drawing.Color.Transparent;
            this.Button_cancel.BorderRadius = 10;
            this.Button_cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_cancel.FillColor = System.Drawing.Color.DimGray;
            this.Button_cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_cancel.ForeColor = System.Drawing.Color.White;
            this.Button_cancel.Location = new System.Drawing.Point(926, 624);
            this.Button_cancel.Name = "Button_cancel";
            this.Button_cancel.Size = new System.Drawing.Size(155, 45);
            this.Button_cancel.TabIndex = 22;
            this.Button_cancel.Text = "Cancel";
            this.Button_cancel.Click += new System.EventHandler(this.Button_cancel_Click);
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
            this.Button_add.Location = new System.Drawing.Point(56, 624);
            this.Button_add.Name = "Button_add";
            this.Button_add.Size = new System.Drawing.Size(94, 45);
            this.Button_add.TabIndex = 23;
            this.Button_add.Text = "Add";
            this.Button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // FormGaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1101, 693);
            this.Controls.Add(this.GradientPanel_atas);
            this.Controls.Add(this.ShadowPanel_gaji);
            this.Controls.Add(this.Panel_kiri);
            this.Controls.Add(this.DataGridView_datagaji);
            this.Controls.Add(this.label_judul);
            this.Controls.Add(this.Button_clear);
            this.Controls.Add(this.Button_delete);
            this.Controls.Add(this.Button_update);
            this.Controls.Add(this.Button_cancel);
            this.Controls.Add(this.Button_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGaji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGaji";
            this.Load += new System.EventHandler(this.FormGaji_Load);
            this.GradientPanel_atas.ResumeLayout(false);
            this.GradientPanel_atas.PerformLayout();
            this.ShadowPanel_gaji.ResumeLayout(false);
            this.ShadowPanel_gaji.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_datagaji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel GradientPanel_atas;
        private Guna.UI2.WinForms.Guna2Button Button_keluar;
        private System.Windows.Forms.Label label_judulsistem;
        private Guna.UI2.WinForms.Guna2ShadowPanel ShadowPanel_gaji;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_idKaryawan;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_gaji;
        private System.Windows.Forms.Label label_gaji;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_status;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_idgaji;
        private System.Windows.Forms.Label label_idgaji;
        private System.Windows.Forms.Label label_idKaryawan;
        private System.Windows.Forms.Label label_tglmenerima;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker_penerimaan;
        private System.Windows.Forms.Label label_status;
        private Guna.UI2.WinForms.Guna2Panel Panel_kiri;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_datagaji;
        private System.Windows.Forms.Label label_judul;
        private Guna.UI2.WinForms.Guna2Button Button_clear;
        private Guna.UI2.WinForms.Guna2Button Button_delete;
        private Guna.UI2.WinForms.Guna2Button Button_update;
        private Guna.UI2.WinForms.Guna2Button Button_cancel;
        private Guna.UI2.WinForms.Guna2Button Button_add;
    }
}