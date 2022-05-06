
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
            this.btn_XoaThuoc = new System.Windows.Forms.Button();
            this.btn_SuaThuoc = new System.Windows.Forms.Button();
            this.lb_DanhSachCacThuoc = new System.Windows.Forms.Label();
            this.lv_Thuoc = new System.Windows.Forms.ListView();
            this.cl_MaThuoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_MaCachDung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_MaDonVi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_TenThuoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_DonGiaBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_SoLuongTon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_CongDung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_HDSD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cL_NgayHetHan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_LuuThuoc = new System.Windows.Forms.Button();
            this.cbx_TenDonVi = new System.Windows.Forms.ComboBox();
            this.cbx_TenCachDung = new System.Windows.Forms.ComboBox();
            this.btn_ThemThuoc = new System.Windows.Forms.Button();
            this.dtbx_NgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_CongDung = new System.Windows.Forms.Label();
            this.lb_NgayHetHan = new System.Windows.Forms.Label();
            this.lb_HDSD = new System.Windows.Forms.Label();
            this.lb_TenCachDung = new System.Windows.Forms.Label();
            this.lb_TenDonVi = new System.Windows.Forms.Label();
            this.lb_Thuoc = new System.Windows.Forms.Label();
            this.lb_TenThuoc = new System.Windows.Forms.Label();
            this.lb_MaThuoc = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_TrangChu_Thuoc = new System.Windows.Forms.Button();
            this.btn_TroVe_Thuoc = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_XoaThuoc
            // 
            this.btn_XoaThuoc.BackColor = System.Drawing.SystemColors.Control;
            this.btn_XoaThuoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaThuoc.Location = new System.Drawing.Point(791, 382);
            this.btn_XoaThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XoaThuoc.Name = "btn_XoaThuoc";
            this.btn_XoaThuoc.Size = new System.Drawing.Size(107, 43);
            this.btn_XoaThuoc.TabIndex = 17;
            this.btn_XoaThuoc.Text = "Xoá";
            this.btn_XoaThuoc.UseVisualStyleBackColor = false;
            // 
            // btn_SuaThuoc
            // 
            this.btn_SuaThuoc.BackColor = System.Drawing.SystemColors.Control;
            this.btn_SuaThuoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaThuoc.Location = new System.Drawing.Point(633, 382);
            this.btn_SuaThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SuaThuoc.Name = "btn_SuaThuoc";
            this.btn_SuaThuoc.Size = new System.Drawing.Size(97, 43);
            this.btn_SuaThuoc.TabIndex = 16;
            this.btn_SuaThuoc.Text = "Sửa";
            this.btn_SuaThuoc.UseVisualStyleBackColor = false;
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
            this.cl_MaCachDung,
            this.cl_MaDonVi,
            this.cl_TenThuoc,
            this.cl_DonGiaBan,
            this.cl_SoLuongTon,
            this.cl_CongDung,
            this.cl_HDSD,
            this.cL_NgayHetHan});
            this.lv_Thuoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Thuoc.GridLines = true;
            this.lv_Thuoc.HideSelection = false;
            this.lv_Thuoc.Location = new System.Drawing.Point(108, 446);
            this.lv_Thuoc.Margin = new System.Windows.Forms.Padding(4);
            this.lv_Thuoc.Name = "lv_Thuoc";
            this.lv_Thuoc.Size = new System.Drawing.Size(1179, 236);
            this.lv_Thuoc.TabIndex = 4;
            this.lv_Thuoc.UseCompatibleStateImageBehavior = false;
            this.lv_Thuoc.View = System.Windows.Forms.View.Details;
            this.lv_Thuoc.VirtualMode = true;
            // 
            // cl_MaThuoc
            // 
            this.cl_MaThuoc.Text = "Mã thuốc";
            this.cl_MaThuoc.Width = 99;
            // 
            // cl_MaCachDung
            // 
            this.cl_MaCachDung.Text = "Mã cách dùng";
            this.cl_MaCachDung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_MaCachDung.Width = 120;
            // 
            // cl_MaDonVi
            // 
            this.cl_MaDonVi.Text = "Mã đơn vị";
            this.cl_MaDonVi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_MaDonVi.Width = 104;
            // 
            // cl_TenThuoc
            // 
            this.cl_TenThuoc.Text = "Tên thuốc";
            this.cl_TenThuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_TenThuoc.Width = 140;
            // 
            // cl_DonGiaBan
            // 
            this.cl_DonGiaBan.Text = "Đơn giá bán";
            this.cl_DonGiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_DonGiaBan.Width = 106;
            // 
            // cl_SoLuongTon
            // 
            this.cl_SoLuongTon.Text = "Số lượng tồn";
            this.cl_SoLuongTon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_SoLuongTon.Width = 88;
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
            this.cl_HDSD.Width = 195;
            // 
            // cL_NgayHetHan
            // 
            this.cL_NgayHetHan.Text = "Ngày hết hạn";
            this.cL_NgayHetHan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cL_NgayHetHan.Width = 138;
            // 
            // btn_LuuThuoc
            // 
            this.btn_LuuThuoc.BackColor = System.Drawing.SystemColors.Control;
            this.btn_LuuThuoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LuuThuoc.Location = new System.Drawing.Point(1169, 382);
            this.btn_LuuThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LuuThuoc.Name = "btn_LuuThuoc";
            this.btn_LuuThuoc.Size = new System.Drawing.Size(107, 43);
            this.btn_LuuThuoc.TabIndex = 18;
            this.btn_LuuThuoc.Text = "Lưu";
            this.btn_LuuThuoc.UseVisualStyleBackColor = false;
            // 
            // cbx_TenDonVi
            // 
            this.cbx_TenDonVi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_TenDonVi.FormattingEnabled = true;
            this.cbx_TenDonVi.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbx_TenDonVi.Location = new System.Drawing.Point(283, 266);
            this.cbx_TenDonVi.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_TenDonVi.Name = "cbx_TenDonVi";
            this.cbx_TenDonVi.Size = new System.Drawing.Size(243, 34);
            this.cbx_TenDonVi.TabIndex = 37;
            // 
            // cbx_TenCachDung
            // 
            this.cbx_TenCachDung.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_TenCachDung.FormattingEnabled = true;
            this.cbx_TenCachDung.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbx_TenCachDung.Location = new System.Drawing.Point(283, 185);
            this.cbx_TenCachDung.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_TenCachDung.Name = "cbx_TenCachDung";
            this.cbx_TenCachDung.Size = new System.Drawing.Size(243, 34);
            this.cbx_TenCachDung.TabIndex = 36;
            // 
            // btn_ThemThuoc
            // 
            this.btn_ThemThuoc.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ThemThuoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemThuoc.Location = new System.Drawing.Point(1098, 241);
            this.btn_ThemThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThemThuoc.Name = "btn_ThemThuoc";
            this.btn_ThemThuoc.Size = new System.Drawing.Size(121, 47);
            this.btn_ThemThuoc.TabIndex = 35;
            this.btn_ThemThuoc.Text = "Thêm";
            this.btn_ThemThuoc.UseVisualStyleBackColor = false;
            // 
            // dtbx_NgayHetHan
            // 
            this.dtbx_NgayHetHan.CustomFormat = "dd/MM/yyyy";
            this.dtbx_NgayHetHan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbx_NgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbx_NgayHetHan.Location = new System.Drawing.Point(1084, 144);
            this.dtbx_NgayHetHan.Margin = new System.Windows.Forms.Padding(4);
            this.dtbx_NgayHetHan.Name = "dtbx_NgayHetHan";
            this.dtbx_NgayHetHan.Size = new System.Drawing.Size(192, 35);
            this.dtbx_NgayHetHan.TabIndex = 34;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(283, 100);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 33);
            this.textBox1.TabIndex = 30;
            // 
            // lb_CongDung
            // 
            this.lb_CongDung.AutoSize = true;
            this.lb_CongDung.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_CongDung.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CongDung.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_CongDung.Location = new System.Drawing.Point(580, 180);
            this.lb_CongDung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CongDung.Name = "lb_CongDung";
            this.lb_CongDung.Size = new System.Drawing.Size(122, 27);
            this.lb_CongDung.TabIndex = 23;
            this.lb_CongDung.Text = "Công dụng:";
            // 
            // lb_NgayHetHan
            // 
            this.lb_NgayHetHan.AutoSize = true;
            this.lb_NgayHetHan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_NgayHetHan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayHetHan.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_NgayHetHan.Location = new System.Drawing.Point(1000, 102);
            this.lb_NgayHetHan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_NgayHetHan.Name = "lb_NgayHetHan";
            this.lb_NgayHetHan.Size = new System.Drawing.Size(140, 27);
            this.lb_NgayHetHan.TabIndex = 24;
            this.lb_NgayHetHan.Text = "Ngày hết hạn";
            // 
            // lb_HDSD
            // 
            this.lb_HDSD.AutoSize = true;
            this.lb_HDSD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_HDSD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HDSD.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_HDSD.Location = new System.Drawing.Point(580, 261);
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
            this.lb_TenCachDung.Location = new System.Drawing.Point(153, 180);
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
            this.lb_TenDonVi.Location = new System.Drawing.Point(153, 261);
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
            this.lb_Thuoc.Click += new System.EventHandler(this.lb_Thuoc_Click);
            // 
            // lb_TenThuoc
            // 
            this.lb_TenThuoc.AutoSize = true;
            this.lb_TenThuoc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_TenThuoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenThuoc.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_TenThuoc.Location = new System.Drawing.Point(580, 102);
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
            this.lb_MaThuoc.Location = new System.Drawing.Point(153, 102);
            this.lb_MaThuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_MaThuoc.Name = "lb_MaThuoc";
            this.lb_MaThuoc.Size = new System.Drawing.Size(110, 27);
            this.lb_MaThuoc.TabIndex = 22;
            this.lb_MaThuoc.Text = "Mã thuốc:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox2.Location = new System.Drawing.Point(108, 43);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1179, 282);
            this.textBox2.TabIndex = 38;
            // 
            // btn_TrangChu_Thuoc
            // 
            this.btn_TrangChu_Thuoc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TrangChu_Thuoc.BackgroundImage = global::InterfaceDesign.Properties.Resources.home;
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
            this.btn_TroVe_Thuoc.BackgroundImage = global::InterfaceDesign.Properties.Resources.back;
            this.btn_TroVe_Thuoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TroVe_Thuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TroVe_Thuoc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TroVe_Thuoc.Location = new System.Drawing.Point(15, 71);
            this.btn_TroVe_Thuoc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TroVe_Thuoc.Name = "btn_TroVe_Thuoc";
            this.btn_TroVe_Thuoc.Size = new System.Drawing.Size(47, 43);
            this.btn_TroVe_Thuoc.TabIndex = 40;
            this.btn_TroVe_Thuoc.UseVisualStyleBackColor = false;
            this.btn_TroVe_Thuoc.Click += new System.EventHandler(this.btn_TroVe_Thuoc_Click);
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(720, 266);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(243, 33);
            this.textBox8.TabIndex = 33;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(720, 185);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(243, 33);
            this.textBox7.TabIndex = 31;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(720, 100);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(243, 34);
            this.textBox4.TabIndex = 32;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox3.Location = new System.Drawing.Point(64, 360);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1271, 347);
            this.textBox3.TabIndex = 41;
            // 
            // form_thuoc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1348, 720);
            this.ControlBox = false;
            this.Controls.Add(this.btn_TroVe_Thuoc);
            this.Controls.Add(this.btn_TrangChu_Thuoc);
            this.Controls.Add(this.cbx_TenDonVi);
            this.Controls.Add(this.cbx_TenCachDung);
            this.Controls.Add(this.btn_ThemThuoc);
            this.Controls.Add(this.dtbx_NgayHetHan);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_CongDung);
            this.Controls.Add(this.lb_NgayHetHan);
            this.Controls.Add(this.lb_HDSD);
            this.Controls.Add(this.lb_TenCachDung);
            this.Controls.Add(this.lb_TenDonVi);
            this.Controls.Add(this.lb_Thuoc);
            this.Controls.Add(this.lb_TenThuoc);
            this.Controls.Add(this.lb_MaThuoc);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_LuuThuoc);
            this.Controls.Add(this.lv_Thuoc);
            this.Controls.Add(this.lb_DanhSachCacThuoc);
            this.Controls.Add(this.btn_XoaThuoc);
            this.Controls.Add(this.btn_SuaThuoc);
            this.Controls.Add(this.textBox3);
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
        private System.Windows.Forms.ColumnHeader cl_MaCachDung;
        private System.Windows.Forms.ColumnHeader cl_MaDonVi;
        private System.Windows.Forms.ColumnHeader cl_TenThuoc;
        private System.Windows.Forms.ColumnHeader cl_DonGiaBan;
        private System.Windows.Forms.ColumnHeader cl_SoLuongTon;
        private System.Windows.Forms.ColumnHeader cl_CongDung;
        private System.Windows.Forms.ColumnHeader cl_HDSD;
        private System.Windows.Forms.ColumnHeader cL_NgayHetHan;
        private System.Windows.Forms.Button btn_LuuThuoc;
        private System.Windows.Forms.ComboBox cbx_TenDonVi;
        private System.Windows.Forms.ComboBox cbx_TenCachDung;
        private System.Windows.Forms.Button btn_ThemThuoc;
        private System.Windows.Forms.DateTimePicker dtbx_NgayHetHan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_CongDung;
        private System.Windows.Forms.Label lb_NgayHetHan;
        private System.Windows.Forms.Label lb_HDSD;
        private System.Windows.Forms.Label lb_TenCachDung;
        private System.Windows.Forms.Label lb_TenDonVi;
        private System.Windows.Forms.Label lb_Thuoc;
        private System.Windows.Forms.Label lb_TenThuoc;
        private System.Windows.Forms.Label lb_MaThuoc;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_TrangChu_Thuoc;
        private System.Windows.Forms.Button btn_TroVe_Thuoc;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
    }
}