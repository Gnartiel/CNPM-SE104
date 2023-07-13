
namespace InterfaceDesign
{
    partial class form_donvicachdung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_donvicachdung));
            this.btn_Xoa_XoaDonVi = new System.Windows.Forms.Button();
            this.btn_Sua_SuaDonVi = new System.Windows.Forms.Button();
            this.btn_Them_ThemDonVi = new System.Windows.Forms.Button();
            this.txtb_TenDV = new System.Windows.Forms.TextBox();
            this.txtb_MaDV = new System.Windows.Forms.TextBox();
            this.lb_TenDonVi = new System.Windows.Forms.Label();
            this.lb_MaDonVi = new System.Windows.Forms.Label();
            this.lb_DonVi = new System.Windows.Forms.Label();
            this.lb_CachDung = new System.Windows.Forms.Label();
            this.lb_DanhSachDonVi = new System.Windows.Forms.Label();
            this.lb_DanhSachCachDung = new System.Windows.Forms.Label();
            this.lv_DonVi = new System.Windows.Forms.ListView();
            this.cl_MaDonVi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_TenDonVi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_CachDung = new System.Windows.Forms.ListView();
            this.cl_MaCachDung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_TenCachDung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_TrangChu_DonViCachDung = new System.Windows.Forms.Button();
            this.lb_MaCachDung = new System.Windows.Forms.Label();
            this.lb_TenCachDung = new System.Windows.Forms.Label();
            this.txtb_MaCD = new System.Windows.Forms.TextBox();
            this.btn_Them_ThemCachDung = new System.Windows.Forms.Button();
            this.txtb_TenCD = new System.Windows.Forms.TextBox();
            this.btn_Sua_SuaCachDung = new System.Windows.Forms.Button();
            this.btn_Xoa_XoaCachDung = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textbox5 = new System.Windows.Forms.TextBox();
            this.btn_Trove_DonViCachDung = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Xoa_XoaDonVi
            // 
            this.btn_Xoa_XoaDonVi.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Xoa_XoaDonVi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_XoaDonVi.Location = new System.Drawing.Point(453, 212);
            this.btn_Xoa_XoaDonVi.Name = "btn_Xoa_XoaDonVi";
            this.btn_Xoa_XoaDonVi.Size = new System.Drawing.Size(94, 43);
            this.btn_Xoa_XoaDonVi.TabIndex = 20;
            this.btn_Xoa_XoaDonVi.Text = "Xoá";
            this.btn_Xoa_XoaDonVi.UseVisualStyleBackColor = false;
            this.btn_Xoa_XoaDonVi.Click += new System.EventHandler(this.btn_Xoa_XoaDonVi_Click);
            // 
            // btn_Sua_SuaDonVi
            // 
            this.btn_Sua_SuaDonVi.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Sua_SuaDonVi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua_SuaDonVi.Location = new System.Drawing.Point(322, 212);
            this.btn_Sua_SuaDonVi.Name = "btn_Sua_SuaDonVi";
            this.btn_Sua_SuaDonVi.Size = new System.Drawing.Size(95, 43);
            this.btn_Sua_SuaDonVi.TabIndex = 19;
            this.btn_Sua_SuaDonVi.Text = "Sửa";
            this.btn_Sua_SuaDonVi.UseVisualStyleBackColor = false;
            this.btn_Sua_SuaDonVi.Click += new System.EventHandler(this.btn_Sua_SuaDonVi_Click);
            // 
            // btn_Them_ThemDonVi
            // 
            this.btn_Them_ThemDonVi.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Them_ThemDonVi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them_ThemDonVi.Location = new System.Drawing.Point(199, 212);
            this.btn_Them_ThemDonVi.Name = "btn_Them_ThemDonVi";
            this.btn_Them_ThemDonVi.Size = new System.Drawing.Size(95, 43);
            this.btn_Them_ThemDonVi.TabIndex = 18;
            this.btn_Them_ThemDonVi.Text = "Thêm";
            this.btn_Them_ThemDonVi.UseVisualStyleBackColor = false;
            this.btn_Them_ThemDonVi.Click += new System.EventHandler(this.btn_Them_ThemDonVi_Click);
            // 
            // txtb_TenDV
            // 
            this.txtb_TenDV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_TenDV.Location = new System.Drawing.Point(322, 146);
            this.txtb_TenDV.Multiline = true;
            this.txtb_TenDV.Name = "txtb_TenDV";
            this.txtb_TenDV.Size = new System.Drawing.Size(240, 37);
            this.txtb_TenDV.TabIndex = 3;
            // 
            // txtb_MaDV
            // 
            this.txtb_MaDV.Enabled = false;
            this.txtb_MaDV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_MaDV.Location = new System.Drawing.Point(322, 86);
            this.txtb_MaDV.Multiline = true;
            this.txtb_MaDV.Name = "txtb_MaDV";
            this.txtb_MaDV.Size = new System.Drawing.Size(240, 37);
            this.txtb_MaDV.TabIndex = 2;
            // 
            // lb_TenDonVi
            // 
            this.lb_TenDonVi.AutoSize = true;
            this.lb_TenDonVi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_TenDonVi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenDonVi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_TenDonVi.Location = new System.Drawing.Point(194, 148);
            this.lb_TenDonVi.Name = "lb_TenDonVi";
            this.lb_TenDonVi.Size = new System.Drawing.Size(116, 27);
            this.lb_TenDonVi.TabIndex = 1;
            this.lb_TenDonVi.Text = "Tên đơn vị";
            // 
            // lb_MaDonVi
            // 
            this.lb_MaDonVi.AutoSize = true;
            this.lb_MaDonVi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_MaDonVi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaDonVi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_MaDonVi.Location = new System.Drawing.Point(194, 86);
            this.lb_MaDonVi.Name = "lb_MaDonVi";
            this.lb_MaDonVi.Size = new System.Drawing.Size(111, 27);
            this.lb_MaDonVi.TabIndex = 0;
            this.lb_MaDonVi.Text = "Mã đơn vị";
            // 
            // lb_DonVi
            // 
            this.lb_DonVi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_DonVi.AutoSize = true;
            this.lb_DonVi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DonVi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_DonVi.Location = new System.Drawing.Point(162, 22);
            this.lb_DonVi.Name = "lb_DonVi";
            this.lb_DonVi.Size = new System.Drawing.Size(100, 35);
            this.lb_DonVi.TabIndex = 3;
            this.lb_DonVi.Text = "Đơn vị";
            // 
            // lb_CachDung
            // 
            this.lb_CachDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_CachDung.AutoSize = true;
            this.lb_CachDung.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CachDung.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_CachDung.Location = new System.Drawing.Point(725, 22);
            this.lb_CachDung.Name = "lb_CachDung";
            this.lb_CachDung.Size = new System.Drawing.Size(154, 35);
            this.lb_CachDung.TabIndex = 4;
            this.lb_CachDung.Text = "Cách dùng";
            // 
            // lb_DanhSachDonVi
            // 
            this.lb_DanhSachDonVi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_DanhSachDonVi.AutoSize = true;
            this.lb_DanhSachDonVi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DanhSachDonVi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_DanhSachDonVi.Location = new System.Drawing.Point(150, 286);
            this.lb_DanhSachDonVi.Name = "lb_DanhSachDonVi";
            this.lb_DanhSachDonVi.Size = new System.Drawing.Size(310, 35);
            this.lb_DanhSachDonVi.TabIndex = 7;
            this.lb_DanhSachDonVi.Text = "DANH SÁCH ĐƠN VỊ";
            // 
            // lb_DanhSachCachDung
            // 
            this.lb_DanhSachCachDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_DanhSachCachDung.AutoSize = true;
            this.lb_DanhSachCachDung.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DanhSachCachDung.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_DanhSachCachDung.Location = new System.Drawing.Point(754, 286);
            this.lb_DanhSachCachDung.Name = "lb_DanhSachCachDung";
            this.lb_DanhSachCachDung.Size = new System.Drawing.Size(389, 35);
            this.lb_DanhSachCachDung.TabIndex = 8;
            this.lb_DanhSachCachDung.Text = "DANH SÁCH CÁCH DÙNG";
            // 
            // lv_DonVi
            // 
            this.lv_DonVi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_DonVi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_MaDonVi,
            this.cl_TenDonVi});
            this.lv_DonVi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_DonVi.FullRowSelect = true;
            this.lv_DonVi.GridLines = true;
            this.lv_DonVi.HideSelection = false;
            this.lv_DonVi.Location = new System.Drawing.Point(134, 324);
            this.lv_DonVi.Name = "lv_DonVi";
            this.lv_DonVi.Size = new System.Drawing.Size(485, 315);
            this.lv_DonVi.TabIndex = 9;
            this.lv_DonVi.UseCompatibleStateImageBehavior = false;
            this.lv_DonVi.View = System.Windows.Forms.View.Details;
            this.lv_DonVi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_DonVi_MouseClick);
            this.lv_DonVi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_DonVi_MouseDoubleClick);
            // 
            // cl_MaDonVi
            // 
            this.cl_MaDonVi.Text = "Mã đơn vị";
            this.cl_MaDonVi.Width = 210;
            // 
            // cl_TenDonVi
            // 
            this.cl_TenDonVi.Text = "Tên đơn vị";
            this.cl_TenDonVi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_TenDonVi.Width = 272;
            // 
            // lv_CachDung
            // 
            this.lv_CachDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_CachDung.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_MaCachDung,
            this.cl_TenCachDung});
            this.lv_CachDung.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_CachDung.FullRowSelect = true;
            this.lv_CachDung.GridLines = true;
            this.lv_CachDung.HideSelection = false;
            this.lv_CachDung.Location = new System.Drawing.Point(695, 324);
            this.lv_CachDung.Name = "lv_CachDung";
            this.lv_CachDung.Size = new System.Drawing.Size(550, 315);
            this.lv_CachDung.TabIndex = 10;
            this.lv_CachDung.UseCompatibleStateImageBehavior = false;
            this.lv_CachDung.View = System.Windows.Forms.View.Details;
            this.lv_CachDung.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_CachDung_MouseClick);
            this.lv_CachDung.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_CachDung_MouseDoubleClick);
            // 
            // cl_MaCachDung
            // 
            this.cl_MaCachDung.Text = "Mã cách dùng";
            this.cl_MaCachDung.Width = 241;
            // 
            // cl_TenCachDung
            // 
            this.cl_TenCachDung.Text = "Tên cách dùng";
            this.cl_TenCachDung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_TenCachDung.Width = 306;
            // 
            // btn_TrangChu_DonViCachDung
            // 
            this.btn_TrangChu_DonViCachDung.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_TrangChu_DonViCachDung.BackgroundImage")));
            this.btn_TrangChu_DonViCachDung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TrangChu_DonViCachDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TrangChu_DonViCachDung.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrangChu_DonViCachDung.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TrangChu_DonViCachDung.Location = new System.Drawing.Point(12, 12);
            this.btn_TrangChu_DonViCachDung.Name = "btn_TrangChu_DonViCachDung";
            this.btn_TrangChu_DonViCachDung.Size = new System.Drawing.Size(52, 48);
            this.btn_TrangChu_DonViCachDung.TabIndex = 11;
            this.btn_TrangChu_DonViCachDung.UseVisualStyleBackColor = true;
            this.btn_TrangChu_DonViCachDung.Click += new System.EventHandler(this.btn_TrangChu_DonViCachDung_Click);
            // 
            // lb_MaCachDung
            // 
            this.lb_MaCachDung.AutoSize = true;
            this.lb_MaCachDung.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_MaCachDung.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaCachDung.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_MaCachDung.Location = new System.Drawing.Point(746, 86);
            this.lb_MaCachDung.Name = "lb_MaCachDung";
            this.lb_MaCachDung.Size = new System.Drawing.Size(148, 27);
            this.lb_MaCachDung.TabIndex = 0;
            this.lb_MaCachDung.Text = "Mã cách dùng";
            // 
            // lb_TenCachDung
            // 
            this.lb_TenCachDung.AutoSize = true;
            this.lb_TenCachDung.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_TenCachDung.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenCachDung.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_TenCachDung.Location = new System.Drawing.Point(746, 144);
            this.lb_TenCachDung.Name = "lb_TenCachDung";
            this.lb_TenCachDung.Size = new System.Drawing.Size(153, 27);
            this.lb_TenCachDung.TabIndex = 1;
            this.lb_TenCachDung.Text = "Tên cách dùng";
            // 
            // txtb_MaCD
            // 
            this.txtb_MaCD.Enabled = false;
            this.txtb_MaCD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_MaCD.Location = new System.Drawing.Point(906, 86);
            this.txtb_MaCD.Multiline = true;
            this.txtb_MaCD.Name = "txtb_MaCD";
            this.txtb_MaCD.Size = new System.Drawing.Size(290, 37);
            this.txtb_MaCD.TabIndex = 4;
            // 
            // btn_Them_ThemCachDung
            // 
            this.btn_Them_ThemCachDung.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Them_ThemCachDung.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them_ThemCachDung.Location = new System.Drawing.Point(799, 215);
            this.btn_Them_ThemCachDung.Name = "btn_Them_ThemCachDung";
            this.btn_Them_ThemCachDung.Size = new System.Drawing.Size(95, 43);
            this.btn_Them_ThemCachDung.TabIndex = 21;
            this.btn_Them_ThemCachDung.Text = "Thêm";
            this.btn_Them_ThemCachDung.UseVisualStyleBackColor = false;
            this.btn_Them_ThemCachDung.Click += new System.EventHandler(this.btn_Them_ThemCachDung_Click);
            // 
            // txtb_TenCD
            // 
            this.txtb_TenCD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_TenCD.Location = new System.Drawing.Point(906, 146);
            this.txtb_TenCD.Multiline = true;
            this.txtb_TenCD.Name = "txtb_TenCD";
            this.txtb_TenCD.Size = new System.Drawing.Size(290, 37);
            this.txtb_TenCD.TabIndex = 5;
            // 
            // btn_Sua_SuaCachDung
            // 
            this.btn_Sua_SuaCachDung.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Sua_SuaCachDung.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua_SuaCachDung.Location = new System.Drawing.Point(942, 215);
            this.btn_Sua_SuaCachDung.Name = "btn_Sua_SuaCachDung";
            this.btn_Sua_SuaCachDung.Size = new System.Drawing.Size(95, 40);
            this.btn_Sua_SuaCachDung.TabIndex = 22;
            this.btn_Sua_SuaCachDung.Text = "Sửa";
            this.btn_Sua_SuaCachDung.UseVisualStyleBackColor = false;
            this.btn_Sua_SuaCachDung.Click += new System.EventHandler(this.btn_Sua_SuaCachDung_Click);
            // 
            // btn_Xoa_XoaCachDung
            // 
            this.btn_Xoa_XoaCachDung.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Xoa_XoaCachDung.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_XoaCachDung.Location = new System.Drawing.Point(1085, 215);
            this.btn_Xoa_XoaCachDung.Name = "btn_Xoa_XoaCachDung";
            this.btn_Xoa_XoaCachDung.Size = new System.Drawing.Size(95, 40);
            this.btn_Xoa_XoaCachDung.TabIndex = 23;
            this.btn_Xoa_XoaCachDung.Text = "Xoá";
            this.btn_Xoa_XoaCachDung.UseVisualStyleBackColor = false;
            this.btn_Xoa_XoaCachDung.Click += new System.EventHandler(this.btn_Xoa_XoaCachDung_Click);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(695, 41);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(550, 227);
            this.textBox6.TabIndex = 22;
            // 
            // textbox5
            // 
            this.textbox5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textbox5.Enabled = false;
            this.textbox5.Location = new System.Drawing.Point(134, 41);
            this.textbox5.Multiline = true;
            this.textbox5.Name = "textbox5";
            this.textbox5.Size = new System.Drawing.Size(485, 227);
            this.textbox5.TabIndex = 24;
            // 
            // btn_Trove_DonViCachDung
            // 
            this.btn_Trove_DonViCachDung.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Trove_DonViCachDung.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Trove_DonViCachDung.BackgroundImage")));
            this.btn_Trove_DonViCachDung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Trove_DonViCachDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Trove_DonViCachDung.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Trove_DonViCachDung.Location = new System.Drawing.Point(12, 75);
            this.btn_Trove_DonViCachDung.Name = "btn_Trove_DonViCachDung";
            this.btn_Trove_DonViCachDung.Size = new System.Drawing.Size(52, 48);
            this.btn_Trove_DonViCachDung.TabIndex = 25;
            this.btn_Trove_DonViCachDung.UseVisualStyleBackColor = false;
            this.btn_Trove_DonViCachDung.Click += new System.EventHandler(this.btn_Trove_DonViCachDung_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.White;
            this.btn_Thoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.BackgroundImage")));
            this.btn_Thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Thoat.Location = new System.Drawing.Point(12, 138);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(52, 48);
            this.btn_Thoat.TabIndex = 96;
            this.btn_Thoat.Text = " ";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // form_donvicachdung
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1338, 716);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Trove_DonViCachDung);
            this.Controls.Add(this.btn_Xoa_XoaDonVi);
            this.Controls.Add(this.btn_TrangChu_DonViCachDung);
            this.Controls.Add(this.btn_Sua_SuaDonVi);
            this.Controls.Add(this.btn_Xoa_XoaCachDung);
            this.Controls.Add(this.btn_Them_ThemDonVi);
            this.Controls.Add(this.lv_CachDung);
            this.Controls.Add(this.txtb_TenDV);
            this.Controls.Add(this.txtb_MaDV);
            this.Controls.Add(this.btn_Sua_SuaCachDung);
            this.Controls.Add(this.lb_TenDonVi);
            this.Controls.Add(this.lv_DonVi);
            this.Controls.Add(this.lb_MaDonVi);
            this.Controls.Add(this.txtb_TenCD);
            this.Controls.Add(this.lb_DanhSachCachDung);
            this.Controls.Add(this.btn_Them_ThemCachDung);
            this.Controls.Add(this.lb_DanhSachDonVi);
            this.Controls.Add(this.txtb_MaCD);
            this.Controls.Add(this.lb_TenCachDung);
            this.Controls.Add(this.lb_CachDung);
            this.Controls.Add(this.lb_MaCachDung);
            this.Controls.Add(this.lb_DonVi);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textbox5);
            this.DoubleBuffered = true;
            this.Name = "form_donvicachdung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Đơn Vị & Cách Dùng";
            this.Load += new System.EventHandler(this.form_donvicachdung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtb_TenDV;
        private System.Windows.Forms.TextBox txtb_MaDV;
        private System.Windows.Forms.Label lb_TenDonVi;
        private System.Windows.Forms.Label lb_MaDonVi;
        private System.Windows.Forms.Button btn_Xoa_XoaDonVi;
        private System.Windows.Forms.Button btn_Sua_SuaDonVi;
        private System.Windows.Forms.Button btn_Them_ThemDonVi;
        private System.Windows.Forms.Label lb_DonVi;
        private System.Windows.Forms.Label lb_CachDung;
        private System.Windows.Forms.Label lb_DanhSachDonVi;
        private System.Windows.Forms.Label lb_DanhSachCachDung;
        private System.Windows.Forms.ListView lv_DonVi;
        private System.Windows.Forms.ColumnHeader cl_MaDonVi;
        private System.Windows.Forms.ColumnHeader cl_TenDonVi;
        private System.Windows.Forms.ListView lv_CachDung;
        private System.Windows.Forms.ColumnHeader cl_MaCachDung;
        private System.Windows.Forms.ColumnHeader cl_TenCachDung;
        private System.Windows.Forms.Button btn_TrangChu_DonViCachDung;
        private System.Windows.Forms.Label lb_MaCachDung;
        private System.Windows.Forms.Label lb_TenCachDung;
        private System.Windows.Forms.TextBox txtb_MaCD;
        private System.Windows.Forms.Button btn_Them_ThemCachDung;
        private System.Windows.Forms.TextBox txtb_TenCD;
        private System.Windows.Forms.Button btn_Sua_SuaCachDung;
        private System.Windows.Forms.Button btn_Xoa_XoaCachDung;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textbox5;
        private System.Windows.Forms.Button btn_Trove_DonViCachDung;
        private System.Windows.Forms.Button btn_Thoat;
    }
}