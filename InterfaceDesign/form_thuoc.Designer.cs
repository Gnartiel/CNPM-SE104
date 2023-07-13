
namespace InterfaceDesign
{
    partial class form_thuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_thuoc));
            this.btn_XoaThuoc = new System.Windows.Forms.Button();
            this.btn_SuaThuoc = new System.Windows.Forms.Button();
            this.lb_DanhSachCacThuoc = new System.Windows.Forms.Label();
            this.lv_Thuoc = new System.Windows.Forms.ListView();
            this.cl_MaThuoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_TenThuoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_DonVi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_CachDung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_CongDung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_HDSD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_SoLuongTon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_DonGiaBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbx_TenDonVi = new System.Windows.Forms.ComboBox();
            this.cbx_TenCachDung = new System.Windows.Forms.ComboBox();
            this.btn_ThemThuoc = new System.Windows.Forms.Button();
            this.txtb_MaThuoc = new System.Windows.Forms.TextBox();
            this.lb_CongDung = new System.Windows.Forms.Label();
            this.lb_HDSD = new System.Windows.Forms.Label();
            this.lb_TenCachDung = new System.Windows.Forms.Label();
            this.lb_TenDonVi = new System.Windows.Forms.Label();
            this.lb_Thuoc = new System.Windows.Forms.Label();
            this.lb_TenThuoc = new System.Windows.Forms.Label();
            this.lb_MaThuoc = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_TrangChu_Thuoc = new System.Windows.Forms.Button();
            this.btn_TroVe_Thuoc = new System.Windows.Forms.Button();
            this.txtb_HDSD = new System.Windows.Forms.TextBox();
            this.txtb_CongDung = new System.Windows.Forms.TextBox();
            this.txtb_TenThuoc = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_XoaThuoc
            // 
            this.btn_XoaThuoc.BackColor = System.Drawing.SystemColors.Control;
            this.btn_XoaThuoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaThuoc.Location = new System.Drawing.Point(1143, 217);
            this.btn_XoaThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XoaThuoc.Name = "btn_XoaThuoc";
            this.btn_XoaThuoc.Size = new System.Drawing.Size(121, 43);
            this.btn_XoaThuoc.TabIndex = 17;
            this.btn_XoaThuoc.Text = "Xoá";
            this.btn_XoaThuoc.UseVisualStyleBackColor = false;
            this.btn_XoaThuoc.Click += new System.EventHandler(this.btn_XoaThuoc_Click);
            // 
            // btn_SuaThuoc
            // 
            this.btn_SuaThuoc.BackColor = System.Drawing.SystemColors.Control;
            this.btn_SuaThuoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaThuoc.Location = new System.Drawing.Point(1143, 140);
            this.btn_SuaThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SuaThuoc.Name = "btn_SuaThuoc";
            this.btn_SuaThuoc.Size = new System.Drawing.Size(121, 43);
            this.btn_SuaThuoc.TabIndex = 16;
            this.btn_SuaThuoc.Text = "Sửa";
            this.btn_SuaThuoc.UseVisualStyleBackColor = false;
            this.btn_SuaThuoc.Click += new System.EventHandler(this.btn_SuaThuoc_Click);
            // 
            // lb_DanhSachCacThuoc
            // 
            this.lb_DanhSachCacThuoc.AutoSize = true;
            this.lb_DanhSachCacThuoc.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DanhSachCacThuoc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_DanhSachCacThuoc.Location = new System.Drawing.Point(168, 348);
            this.lb_DanhSachCacThuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_DanhSachCacThuoc.Name = "lb_DanhSachCacThuoc";
            this.lb_DanhSachCacThuoc.Size = new System.Drawing.Size(312, 35);
            this.lb_DanhSachCacThuoc.TabIndex = 3;
            this.lb_DanhSachCacThuoc.Text = "DANH SÁCH THUỐC";
            // 
            // lv_Thuoc
            // 
            this.lv_Thuoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_MaThuoc,
            this.cl_TenThuoc,
            this.cl_DonVi,
            this.cl_CachDung,
            this.cl_CongDung,
            this.cl_HDSD,
            this.cl_SoLuongTon,
            this.cl_DonGiaBan});
            this.lv_Thuoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Thuoc.FullRowSelect = true;
            this.lv_Thuoc.GridLines = true;
            this.lv_Thuoc.HideSelection = false;
            this.lv_Thuoc.Location = new System.Drawing.Point(108, 410);
            this.lv_Thuoc.Margin = new System.Windows.Forms.Padding(4);
            this.lv_Thuoc.Name = "lv_Thuoc";
            this.lv_Thuoc.Size = new System.Drawing.Size(1179, 272);
            this.lv_Thuoc.TabIndex = 4;
            this.lv_Thuoc.UseCompatibleStateImageBehavior = false;
            this.lv_Thuoc.View = System.Windows.Forms.View.Details;
            this.lv_Thuoc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_Thuoc_MouseClick);
            this.lv_Thuoc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_Thuoc_MouseDoubleClick);
            // 
            // cl_MaThuoc
            // 
            this.cl_MaThuoc.Text = "Mã thuốc";
            this.cl_MaThuoc.Width = 99;
            // 
            // cl_TenThuoc
            // 
            this.cl_TenThuoc.Text = "Tên thuốc";
            this.cl_TenThuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_TenThuoc.Width = 140;
            // 
            // cl_DonVi
            // 
            this.cl_DonVi.Text = "Đơn vị";
            this.cl_DonVi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_DonVi.Width = 104;
            // 
            // cl_CachDung
            // 
            this.cl_CachDung.Text = "Cách dùng";
            this.cl_CachDung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_CachDung.Width = 120;
            // 
            // cl_CongDung
            // 
            this.cl_CongDung.Text = "Công dụng";
            this.cl_CongDung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_CongDung.Width = 195;
            // 
            // cl_HDSD
            // 
            this.cl_HDSD.Text = "HDSD";
            this.cl_HDSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_HDSD.Width = 326;
            // 
            // cl_SoLuongTon
            // 
            this.cl_SoLuongTon.Text = "Số lượng tồn";
            this.cl_SoLuongTon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_SoLuongTon.Width = 116;
            // 
            // cl_DonGiaBan
            // 
            this.cl_DonGiaBan.Text = "Đơn giá bán";
            this.cl_DonGiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_DonGiaBan.Width = 106;
            // 
            // cbx_TenDonVi
            // 
            this.cbx_TenDonVi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_TenDonVi.FormattingEnabled = true;
            this.cbx_TenDonVi.Location = new System.Drawing.Point(283, 231);
            this.cbx_TenDonVi.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_TenDonVi.Name = "cbx_TenDonVi";
            this.cbx_TenDonVi.Size = new System.Drawing.Size(211, 34);
            this.cbx_TenDonVi.TabIndex = 37;
            // 
            // cbx_TenCachDung
            // 
            this.cbx_TenCachDung.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_TenCachDung.FormattingEnabled = true;
            this.cbx_TenCachDung.Location = new System.Drawing.Point(283, 154);
            this.cbx_TenCachDung.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_TenCachDung.Name = "cbx_TenCachDung";
            this.cbx_TenCachDung.Size = new System.Drawing.Size(211, 34);
            this.cbx_TenCachDung.TabIndex = 36;
            // 
            // btn_ThemThuoc
            // 
            this.btn_ThemThuoc.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ThemThuoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemThuoc.Location = new System.Drawing.Point(1143, 69);
            this.btn_ThemThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThemThuoc.Name = "btn_ThemThuoc";
            this.btn_ThemThuoc.Size = new System.Drawing.Size(121, 47);
            this.btn_ThemThuoc.TabIndex = 35;
            this.btn_ThemThuoc.Text = "Thêm";
            this.btn_ThemThuoc.UseVisualStyleBackColor = false;
            this.btn_ThemThuoc.Click += new System.EventHandler(this.btn_ThemThuoc_Click);
            // 
            // txtb_MaThuoc
            // 
            this.txtb_MaThuoc.Enabled = false;
            this.txtb_MaThuoc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_MaThuoc.Location = new System.Drawing.Point(283, 81);
            this.txtb_MaThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_MaThuoc.Multiline = true;
            this.txtb_MaThuoc.Name = "txtb_MaThuoc";
            this.txtb_MaThuoc.Size = new System.Drawing.Size(211, 33);
            this.txtb_MaThuoc.TabIndex = 30;
            // 
            // lb_CongDung
            // 
            this.lb_CongDung.AutoSize = true;
            this.lb_CongDung.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_CongDung.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CongDung.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_CongDung.Location = new System.Drawing.Point(513, 156);
            this.lb_CongDung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CongDung.Name = "lb_CongDung";
            this.lb_CongDung.Size = new System.Drawing.Size(122, 27);
            this.lb_CongDung.TabIndex = 23;
            this.lb_CongDung.Text = "Công dụng:";
            // 
            // lb_HDSD
            // 
            this.lb_HDSD.AutoSize = true;
            this.lb_HDSD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_HDSD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HDSD.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_HDSD.Location = new System.Drawing.Point(528, 233);
            this.lb_HDSD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_HDSD.Name = "lb_HDSD";
            this.lb_HDSD.Size = new System.Drawing.Size(81, 27);
            this.lb_HDSD.TabIndex = 29;
            this.lb_HDSD.Text = "HDSD:";
            // 
            // lb_TenCachDung
            // 
            this.lb_TenCachDung.AutoSize = true;
            this.lb_TenCachDung.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_TenCachDung.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenCachDung.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_TenCachDung.Location = new System.Drawing.Point(122, 156);
            this.lb_TenCachDung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_TenCachDung.Name = "lb_TenCachDung";
            this.lb_TenCachDung.Size = new System.Drawing.Size(121, 27);
            this.lb_TenCachDung.TabIndex = 28;
            this.lb_TenCachDung.Text = "Cách dùng:";
            // 
            // lb_TenDonVi
            // 
            this.lb_TenDonVi.AutoSize = true;
            this.lb_TenDonVi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_TenDonVi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenDonVi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_TenDonVi.Location = new System.Drawing.Point(122, 233);
            this.lb_TenDonVi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_TenDonVi.Name = "lb_TenDonVi";
            this.lb_TenDonVi.Size = new System.Drawing.Size(84, 27);
            this.lb_TenDonVi.TabIndex = 26;
            this.lb_TenDonVi.Text = "Đơn vị:";
            // 
            // lb_Thuoc
            // 
            this.lb_Thuoc.AutoSize = true;
            this.lb_Thuoc.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Thuoc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_Thuoc.Location = new System.Drawing.Point(277, 27);
            this.lb_Thuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Thuoc.Name = "lb_Thuoc";
            this.lb_Thuoc.Size = new System.Drawing.Size(217, 35);
            this.lb_Thuoc.TabIndex = 27;
            this.lb_Thuoc.Text = "Thông tin thuốc";
            // 
            // lb_TenThuoc
            // 
            this.lb_TenThuoc.AutoSize = true;
            this.lb_TenThuoc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_TenThuoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenThuoc.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_TenThuoc.Location = new System.Drawing.Point(513, 83);
            this.lb_TenThuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_TenThuoc.Name = "lb_TenThuoc";
            this.lb_TenThuoc.Size = new System.Drawing.Size(115, 27);
            this.lb_TenThuoc.TabIndex = 25;
            this.lb_TenThuoc.Text = "Tên thuốc:";
            // 
            // lb_MaThuoc
            // 
            this.lb_MaThuoc.AutoSize = true;
            this.lb_MaThuoc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_MaThuoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaThuoc.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_MaThuoc.Location = new System.Drawing.Point(122, 83);
            this.lb_MaThuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_MaThuoc.Name = "lb_MaThuoc";
            this.lb_MaThuoc.Size = new System.Drawing.Size(110, 27);
            this.lb_MaThuoc.TabIndex = 22;
            this.lb_MaThuoc.Text = "Mã thuốc:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(108, 43);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1179, 255);
            this.textBox2.TabIndex = 38;
            // 
            // btn_TrangChu_Thuoc
            // 
            this.btn_TrangChu_Thuoc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TrangChu_Thuoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_TrangChu_Thuoc.BackgroundImage")));
            this.btn_TrangChu_Thuoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TrangChu_Thuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TrangChu_Thuoc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TrangChu_Thuoc.Location = new System.Drawing.Point(13, 14);
            this.btn_TrangChu_Thuoc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TrangChu_Thuoc.Name = "btn_TrangChu_Thuoc";
            this.btn_TrangChu_Thuoc.Size = new System.Drawing.Size(52, 48);
            this.btn_TrangChu_Thuoc.TabIndex = 39;
            this.btn_TrangChu_Thuoc.UseVisualStyleBackColor = false;
            this.btn_TrangChu_Thuoc.Click += new System.EventHandler(this.btn_TrangChu_Thuoc_Click);
            // 
            // btn_TroVe_Thuoc
            // 
            this.btn_TroVe_Thuoc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TroVe_Thuoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_TroVe_Thuoc.BackgroundImage")));
            this.btn_TroVe_Thuoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TroVe_Thuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TroVe_Thuoc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TroVe_Thuoc.Location = new System.Drawing.Point(13, 70);
            this.btn_TroVe_Thuoc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TroVe_Thuoc.Name = "btn_TroVe_Thuoc";
            this.btn_TroVe_Thuoc.Size = new System.Drawing.Size(52, 48);
            this.btn_TroVe_Thuoc.TabIndex = 40;
            this.btn_TroVe_Thuoc.UseVisualStyleBackColor = false;
            this.btn_TroVe_Thuoc.Click += new System.EventHandler(this.btn_TroVe_Thuoc_Click);
            // 
            // txtb_HDSD
            // 
            this.txtb_HDSD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_HDSD.Location = new System.Drawing.Point(653, 217);
            this.txtb_HDSD.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_HDSD.Multiline = true;
            this.txtb_HDSD.Name = "txtb_HDSD";
            this.txtb_HDSD.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtb_HDSD.Size = new System.Drawing.Size(437, 61);
            this.txtb_HDSD.TabIndex = 33;
            // 
            // txtb_CongDung
            // 
            this.txtb_CongDung.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_CongDung.Location = new System.Drawing.Point(653, 140);
            this.txtb_CongDung.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_CongDung.Multiline = true;
            this.txtb_CongDung.Name = "txtb_CongDung";
            this.txtb_CongDung.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtb_CongDung.Size = new System.Drawing.Size(437, 54);
            this.txtb_CongDung.TabIndex = 31;
            // 
            // txtb_TenThuoc
            // 
            this.txtb_TenThuoc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_TenThuoc.Location = new System.Drawing.Point(653, 81);
            this.txtb_TenThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_TenThuoc.Multiline = true;
            this.txtb_TenThuoc.Name = "txtb_TenThuoc";
            this.txtb_TenThuoc.Size = new System.Drawing.Size(437, 34);
            this.txtb_TenThuoc.TabIndex = 32;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(64, 360);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1245, 347);
            this.textBox3.TabIndex = 41;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.White;
            this.btn_Thoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.BackgroundImage")));
            this.btn_Thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Thoat.Location = new System.Drawing.Point(13, 129);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(52, 48);
            this.btn_Thoat.TabIndex = 96;
            this.btn_Thoat.Text = " ";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // form_thuoc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1338, 716);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_TroVe_Thuoc);
            this.Controls.Add(this.btn_TrangChu_Thuoc);
            this.Controls.Add(this.cbx_TenDonVi);
            this.Controls.Add(this.cbx_TenCachDung);
            this.Controls.Add(this.btn_ThemThuoc);
            this.Controls.Add(this.txtb_HDSD);
            this.Controls.Add(this.txtb_CongDung);
            this.Controls.Add(this.txtb_TenThuoc);
            this.Controls.Add(this.txtb_MaThuoc);
            this.Controls.Add(this.lb_CongDung);
            this.Controls.Add(this.lb_HDSD);
            this.Controls.Add(this.lb_TenCachDung);
            this.Controls.Add(this.lb_TenDonVi);
            this.Controls.Add(this.lb_Thuoc);
            this.Controls.Add(this.lb_TenThuoc);
            this.Controls.Add(this.lb_MaThuoc);
            this.Controls.Add(this.lv_Thuoc);
            this.Controls.Add(this.lb_DanhSachCacThuoc);
            this.Controls.Add(this.btn_XoaThuoc);
            this.Controls.Add(this.btn_SuaThuoc);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_thuoc";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách thuốc";
            this.Load += new System.EventHandler(this.form_thuoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_XoaThuoc;
        private System.Windows.Forms.Button btn_SuaThuoc;
        private System.Windows.Forms.Label lb_DanhSachCacThuoc;
        private System.Windows.Forms.ListView lv_Thuoc;
        private System.Windows.Forms.ColumnHeader cl_MaThuoc;
        private System.Windows.Forms.ColumnHeader cl_CachDung;
        private System.Windows.Forms.ColumnHeader cl_DonVi;
        private System.Windows.Forms.ColumnHeader cl_TenThuoc;
        private System.Windows.Forms.ColumnHeader cl_DonGiaBan;
        private System.Windows.Forms.ColumnHeader cl_SoLuongTon;
        private System.Windows.Forms.ColumnHeader cl_CongDung;
        private System.Windows.Forms.ColumnHeader cl_HDSD;
        private System.Windows.Forms.ComboBox cbx_TenDonVi;
        private System.Windows.Forms.ComboBox cbx_TenCachDung;
        private System.Windows.Forms.Button btn_ThemThuoc;
        private System.Windows.Forms.TextBox txtb_MaThuoc;
        private System.Windows.Forms.Label lb_CongDung;
        private System.Windows.Forms.Label lb_HDSD;
        private System.Windows.Forms.Label lb_TenCachDung;
        private System.Windows.Forms.Label lb_TenDonVi;
        private System.Windows.Forms.Label lb_Thuoc;
        private System.Windows.Forms.Label lb_TenThuoc;
        private System.Windows.Forms.Label lb_MaThuoc;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_TrangChu_Thuoc;
        private System.Windows.Forms.Button btn_TroVe_Thuoc;
        private System.Windows.Forms.TextBox txtb_HDSD;
        private System.Windows.Forms.TextBox txtb_CongDung;
        private System.Windows.Forms.TextBox txtb_TenThuoc;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_Thoat;
    }
}