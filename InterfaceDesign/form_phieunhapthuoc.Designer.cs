
namespace InterfaceDesign
{
    partial class form_phieunhapthuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_phieunhapthuoc));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lb_DSPNT = new System.Windows.Forms.Label();
            this.lb_CTPNT = new System.Windows.Forms.Label();
            this.lv_CTPNT = new System.Windows.Forms.ListView();
            this.cl_CTPNT_STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_CTPNT_TenThuoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_CTPNT_DonVi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_CTPNT_SLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_CTPNT_DonGiaNhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_CTPNT_DonGiaVAT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_CTPNT_ThanhTienVAT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_DSPNT = new System.Windows.Forms.ListView();
            this.cl_DSPNT_MaPN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_DSPNT_NgayNhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_DSPNT_LanNhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_DSPNT_SLNhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_DSPNT_TongTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_ChiTiet_DSPNT = new System.Windows.Forms.Button();
            this.lb_MaPN_CTPNT = new System.Windows.Forms.Label();
            this.txtb_MaPN_CTPNT = new System.Windows.Forms.TextBox();
            this.btn_Them_ThongTinThuocNhap = new System.Windows.Forms.Button();
            this.btn_Xoa_CTPNT = new System.Windows.Forms.Button();
            this.btn_Sua_CTPNT = new System.Windows.Forms.Button();
            this.btn_Luu_CTPNT = new System.Windows.Forms.Button();
            this.btn_Luu_DSPNT = new System.Windows.Forms.Button();
            this.btn_Sua_DSPNT = new System.Windows.Forms.Button();
            this.btn_Xoa_DSPNT = new System.Windows.Forms.Button();
            this.btn_Them_ThongTinPNT = new System.Windows.Forms.Button();
            this.btn_Xuat_DSPNT = new System.Windows.Forms.Button();
            this.lb_ThongTinThuocNhap = new System.Windows.Forms.Label();
            this.cbx_TenThuoc = new System.Windows.Forms.ComboBox();
            this.txtb_SLuong = new System.Windows.Forms.TextBox();
            this.txtb_DonGiaNhap = new System.Windows.Forms.TextBox();
            this.lb_SLuong = new System.Windows.Forms.Label();
            this.lb_DonGiaNhap = new System.Windows.Forms.Label();
            this.lb_TenThuoc = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtb_MaPN_TTPNT = new System.Windows.Forms.TextBox();
            this.lb_ThongTinPNT = new System.Windows.Forms.Label();
            this.txtb_LanNhap = new System.Windows.Forms.TextBox();
            this.lb_LanNhap = new System.Windows.Forms.Label();
            this.dtbx_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.btn_TrangChu_PNT = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lb_MaPN_TTPNT = new System.Windows.Forms.Label();
            this.lb_NgayNhap = new System.Windows.Forms.Label();
            this.btn_Xuat_CTPNT = new System.Windows.Forms.Button();
            this.btn_TroVe_PNT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(66, 283);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(620, 428);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(711, 283);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(610, 428);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lb_DSPNT
            // 
            this.lb_DSPNT.AutoSize = true;
            this.lb_DSPNT.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DSPNT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_DSPNT.Location = new System.Drawing.Point(86, 261);
            this.lb_DSPNT.Name = "lb_DSPNT";
            this.lb_DSPNT.Size = new System.Drawing.Size(507, 35);
            this.lb_DSPNT.TabIndex = 2;
            this.lb_DSPNT.Text = "DANH SÁCH PHIẾU NHẬP THUỐC";
            // 
            // lb_CTPNT
            // 
            this.lb_CTPNT.AutoSize = true;
            this.lb_CTPNT.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CTPNT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_CTPNT.Location = new System.Drawing.Point(750, 261);
            this.lb_CTPNT.Name = "lb_CTPNT";
            this.lb_CTPNT.Size = new System.Drawing.Size(462, 35);
            this.lb_CTPNT.TabIndex = 3;
            this.lb_CTPNT.Text = "CHI TIẾT PHIẾU NHẬP THUỐC";
            this.lb_CTPNT.Click += new System.EventHandler(this.label2_Click);
            // 
            // lv_CTPNT
            // 
            this.lv_CTPNT.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lv_CTPNT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_CTPNT_STT,
            this.cl_CTPNT_TenThuoc,
            this.cl_CTPNT_DonVi,
            this.cl_CTPNT_SLuong,
            this.cl_CTPNT_DonGiaNhap,
            this.cl_CTPNT_DonGiaVAT,
            this.cl_CTPNT_ThanhTienVAT});
            this.lv_CTPNT.FullRowSelect = true;
            this.lv_CTPNT.GridLines = true;
            this.lv_CTPNT.HideSelection = false;
            this.lv_CTPNT.Location = new System.Drawing.Point(723, 382);
            this.lv_CTPNT.Name = "lv_CTPNT";
            this.lv_CTPNT.Size = new System.Drawing.Size(461, 315);
            this.lv_CTPNT.TabIndex = 5;
            this.lv_CTPNT.UseCompatibleStateImageBehavior = false;
            this.lv_CTPNT.View = System.Windows.Forms.View.Details;
            this.lv_CTPNT.VirtualMode = true;
            this.lv_CTPNT.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // cl_CTPNT_STT
            // 
            this.cl_CTPNT_STT.Text = "STT";
            this.cl_CTPNT_STT.Width = 40;
            // 
            // cl_CTPNT_TenThuoc
            // 
            this.cl_CTPNT_TenThuoc.Text = "Tên Thuôc";
            this.cl_CTPNT_TenThuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_CTPNT_TenThuoc.Width = 122;
            // 
            // cl_CTPNT_DonVi
            // 
            this.cl_CTPNT_DonVi.Text = "Đơn Vị";
            this.cl_CTPNT_DonVi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_CTPNT_DonVi.Width = 100;
            // 
            // cl_CTPNT_SLuong
            // 
            this.cl_CTPNT_SLuong.Text = "Số Lượng";
            this.cl_CTPNT_SLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_CTPNT_SLuong.Width = 100;
            // 
            // cl_CTPNT_DonGiaNhap
            // 
            this.cl_CTPNT_DonGiaNhap.Text = "Đơn Giá Nhập";
            this.cl_CTPNT_DonGiaNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_CTPNT_DonGiaNhap.Width = 100;
            // 
            // cl_CTPNT_DonGiaVAT
            // 
            this.cl_CTPNT_DonGiaVAT.Text = "Đơn Giá VAT";
            this.cl_CTPNT_DonGiaVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_CTPNT_DonGiaVAT.Width = 100;
            // 
            // cl_CTPNT_ThanhTienVAT
            // 
            this.cl_CTPNT_ThanhTienVAT.Text = "Thành Tiền VAT";
            this.cl_CTPNT_ThanhTienVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_CTPNT_ThanhTienVAT.Width = 100;
            // 
            // lv_DSPNT
            // 
            this.lv_DSPNT.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lv_DSPNT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_DSPNT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_DSPNT_MaPN,
            this.cl_DSPNT_NgayNhap,
            this.cl_DSPNT_LanNhap,
            this.cl_DSPNT_SLNhap,
            this.cl_DSPNT_TongTien});
            this.lv_DSPNT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_DSPNT.FullRowSelect = true;
            this.lv_DSPNT.GridLines = true;
            this.lv_DSPNT.HideSelection = false;
            this.lv_DSPNT.Location = new System.Drawing.Point(192, 382);
            this.lv_DSPNT.Name = "lv_DSPNT";
            this.lv_DSPNT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lv_DSPNT.Size = new System.Drawing.Size(484, 315);
            this.lv_DSPNT.TabIndex = 6;
            this.lv_DSPNT.UseCompatibleStateImageBehavior = false;
            this.lv_DSPNT.View = System.Windows.Forms.View.Details;
            this.lv_DSPNT.VirtualMode = true;
            this.lv_DSPNT.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // cl_DSPNT_MaPN
            // 
            this.cl_DSPNT_MaPN.Text = "Mã Phiếu Nhập";
            this.cl_DSPNT_MaPN.Width = 127;
            // 
            // cl_DSPNT_NgayNhap
            // 
            this.cl_DSPNT_NgayNhap.Text = "Ngày Nhập";
            this.cl_DSPNT_NgayNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_DSPNT_NgayNhap.Width = 123;
            // 
            // cl_DSPNT_LanNhap
            // 
            this.cl_DSPNT_LanNhap.Text = "Lần Nhập";
            this.cl_DSPNT_LanNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_DSPNT_LanNhap.Width = 86;
            // 
            // cl_DSPNT_SLNhap
            // 
            this.cl_DSPNT_SLNhap.Text = "Số Lượng Nhập";
            this.cl_DSPNT_SLNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_DSPNT_SLNhap.Width = 125;
            // 
            // cl_DSPNT_TongTien
            // 
            this.cl_DSPNT_TongTien.Text = "Tổng Tiền";
            this.cl_DSPNT_TongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_DSPNT_TongTien.Width = 112;
            // 
            // btn_ChiTiet_DSPNT
            // 
            this.btn_ChiTiet_DSPNT.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ChiTiet_DSPNT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChiTiet_DSPNT.Location = new System.Drawing.Point(565, 322);
            this.btn_ChiTiet_DSPNT.Name = "btn_ChiTiet_DSPNT";
            this.btn_ChiTiet_DSPNT.Size = new System.Drawing.Size(97, 39);
            this.btn_ChiTiet_DSPNT.TabIndex = 7;
            this.btn_ChiTiet_DSPNT.Text = "Chi Tiết";
            this.btn_ChiTiet_DSPNT.UseVisualStyleBackColor = false;
            this.btn_ChiTiet_DSPNT.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_MaPN_CTPNT
            // 
            this.lb_MaPN_CTPNT.AutoSize = true;
            this.lb_MaPN_CTPNT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_MaPN_CTPNT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaPN_CTPNT.Location = new System.Drawing.Point(751, 325);
            this.lb_MaPN_CTPNT.Name = "lb_MaPN_CTPNT";
            this.lb_MaPN_CTPNT.Size = new System.Drawing.Size(169, 27);
            this.lb_MaPN_CTPNT.TabIndex = 8;
            this.lb_MaPN_CTPNT.Text = "Mã Phiếu Nhập:";
            this.lb_MaPN_CTPNT.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtb_MaPN_CTPNT
            // 
            this.txtb_MaPN_CTPNT.Enabled = false;
            this.txtb_MaPN_CTPNT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_MaPN_CTPNT.Location = new System.Drawing.Point(949, 322);
            this.txtb_MaPN_CTPNT.Multiline = true;
            this.txtb_MaPN_CTPNT.Name = "txtb_MaPN_CTPNT";
            this.txtb_MaPN_CTPNT.Size = new System.Drawing.Size(132, 30);
            this.txtb_MaPN_CTPNT.TabIndex = 9;
            this.txtb_MaPN_CTPNT.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btn_Them_ThongTinThuocNhap
            // 
            this.btn_Them_ThongTinThuocNhap.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Them_ThongTinThuocNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them_ThongTinThuocNhap.Location = new System.Drawing.Point(1153, 173);
            this.btn_Them_ThongTinThuocNhap.Name = "btn_Them_ThongTinThuocNhap";
            this.btn_Them_ThongTinThuocNhap.Size = new System.Drawing.Size(95, 42);
            this.btn_Them_ThongTinThuocNhap.TabIndex = 25;
            this.btn_Them_ThongTinThuocNhap.Text = "Thêm";
            this.btn_Them_ThongTinThuocNhap.UseVisualStyleBackColor = false;
            this.btn_Them_ThongTinThuocNhap.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_Xoa_CTPNT
            // 
            this.btn_Xoa_CTPNT.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Xoa_CTPNT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_CTPNT.Location = new System.Drawing.Point(1205, 416);
            this.btn_Xoa_CTPNT.Name = "btn_Xoa_CTPNT";
            this.btn_Xoa_CTPNT.Size = new System.Drawing.Size(95, 42);
            this.btn_Xoa_CTPNT.TabIndex = 26;
            this.btn_Xoa_CTPNT.Text = "Xóa";
            this.btn_Xoa_CTPNT.UseVisualStyleBackColor = false;
            this.btn_Xoa_CTPNT.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Sua_CTPNT
            // 
            this.btn_Sua_CTPNT.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Sua_CTPNT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua_CTPNT.Location = new System.Drawing.Point(1205, 491);
            this.btn_Sua_CTPNT.Name = "btn_Sua_CTPNT";
            this.btn_Sua_CTPNT.Size = new System.Drawing.Size(95, 42);
            this.btn_Sua_CTPNT.TabIndex = 27;
            this.btn_Sua_CTPNT.Text = "Sửa";
            this.btn_Sua_CTPNT.UseVisualStyleBackColor = false;
            this.btn_Sua_CTPNT.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Luu_CTPNT
            // 
            this.btn_Luu_CTPNT.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Luu_CTPNT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu_CTPNT.Location = new System.Drawing.Point(1205, 622);
            this.btn_Luu_CTPNT.Name = "btn_Luu_CTPNT";
            this.btn_Luu_CTPNT.Size = new System.Drawing.Size(95, 42);
            this.btn_Luu_CTPNT.TabIndex = 28;
            this.btn_Luu_CTPNT.Text = "Lưu";
            this.btn_Luu_CTPNT.UseVisualStyleBackColor = false;
            this.btn_Luu_CTPNT.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_Luu_DSPNT
            // 
            this.btn_Luu_DSPNT.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Luu_DSPNT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu_DSPNT.Location = new System.Drawing.Point(80, 634);
            this.btn_Luu_DSPNT.Name = "btn_Luu_DSPNT";
            this.btn_Luu_DSPNT.Size = new System.Drawing.Size(95, 42);
            this.btn_Luu_DSPNT.TabIndex = 33;
            this.btn_Luu_DSPNT.Text = "Lưu";
            this.btn_Luu_DSPNT.UseVisualStyleBackColor = false;
            this.btn_Luu_DSPNT.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_Sua_DSPNT
            // 
            this.btn_Sua_DSPNT.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Sua_DSPNT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua_DSPNT.Location = new System.Drawing.Point(80, 491);
            this.btn_Sua_DSPNT.Name = "btn_Sua_DSPNT";
            this.btn_Sua_DSPNT.Size = new System.Drawing.Size(95, 42);
            this.btn_Sua_DSPNT.TabIndex = 32;
            this.btn_Sua_DSPNT.Text = "Sửa";
            this.btn_Sua_DSPNT.UseVisualStyleBackColor = false;
            this.btn_Sua_DSPNT.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_Xoa_DSPNT
            // 
            this.btn_Xoa_DSPNT.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Xoa_DSPNT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_DSPNT.Location = new System.Drawing.Point(80, 416);
            this.btn_Xoa_DSPNT.Name = "btn_Xoa_DSPNT";
            this.btn_Xoa_DSPNT.Size = new System.Drawing.Size(95, 42);
            this.btn_Xoa_DSPNT.TabIndex = 31;
            this.btn_Xoa_DSPNT.Text = "Xóa";
            this.btn_Xoa_DSPNT.UseVisualStyleBackColor = false;
            this.btn_Xoa_DSPNT.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_Them_ThongTinPNT
            // 
            this.btn_Them_ThongTinPNT.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Them_ThongTinPNT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them_ThongTinPNT.Location = new System.Drawing.Point(524, 184);
            this.btn_Them_ThongTinPNT.Name = "btn_Them_ThongTinPNT";
            this.btn_Them_ThongTinPNT.Size = new System.Drawing.Size(95, 42);
            this.btn_Them_ThongTinPNT.TabIndex = 30;
            this.btn_Them_ThongTinPNT.Text = "Thêm";
            this.btn_Them_ThongTinPNT.UseVisualStyleBackColor = false;
            this.btn_Them_ThongTinPNT.Click += new System.EventHandler(this.btn_Them_ThongTinPNK_Click);
            // 
            // btn_Xuat_DSPNT
            // 
            this.btn_Xuat_DSPNT.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Xuat_DSPNT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xuat_DSPNT.Location = new System.Drawing.Point(80, 324);
            this.btn_Xuat_DSPNT.Name = "btn_Xuat_DSPNT";
            this.btn_Xuat_DSPNT.Size = new System.Drawing.Size(125, 37);
            this.btn_Xuat_DSPNT.TabIndex = 34;
            this.btn_Xuat_DSPNT.Text = "Xuất File";
            this.btn_Xuat_DSPNT.UseVisualStyleBackColor = false;
            this.btn_Xuat_DSPNT.Click += new System.EventHandler(this.button9_Click);
            // 
            // lb_ThongTinThuocNhap
            // 
            this.lb_ThongTinThuocNhap.AutoSize = true;
            this.lb_ThongTinThuocNhap.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThongTinThuocNhap.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_ThongTinThuocNhap.Location = new System.Drawing.Point(865, 30);
            this.lb_ThongTinThuocNhap.Name = "lb_ThongTinThuocNhap";
            this.lb_ThongTinThuocNhap.Size = new System.Drawing.Size(288, 35);
            this.lb_ThongTinThuocNhap.TabIndex = 51;
            this.lb_ThongTinThuocNhap.Text = "Thông tin thuốc nhập";
            // 
            // cbx_TenThuoc
            // 
            this.cbx_TenThuoc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_TenThuoc.FormattingEnabled = true;
            this.cbx_TenThuoc.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "Khác"});
            this.cbx_TenThuoc.Location = new System.Drawing.Point(933, 92);
            this.cbx_TenThuoc.Name = "cbx_TenThuoc";
            this.cbx_TenThuoc.Size = new System.Drawing.Size(197, 34);
            this.cbx_TenThuoc.TabIndex = 50;
            this.cbx_TenThuoc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // txtb_SLuong
            // 
            this.txtb_SLuong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_SLuong.Location = new System.Drawing.Point(933, 137);
            this.txtb_SLuong.Multiline = true;
            this.txtb_SLuong.Name = "txtb_SLuong";
            this.txtb_SLuong.Size = new System.Drawing.Size(132, 30);
            this.txtb_SLuong.TabIndex = 49;
            // 
            // txtb_DonGiaNhap
            // 
            this.txtb_DonGiaNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_DonGiaNhap.Location = new System.Drawing.Point(933, 185);
            this.txtb_DonGiaNhap.Multiline = true;
            this.txtb_DonGiaNhap.Name = "txtb_DonGiaNhap";
            this.txtb_DonGiaNhap.Size = new System.Drawing.Size(132, 30);
            this.txtb_DonGiaNhap.TabIndex = 48;
            // 
            // lb_SLuong
            // 
            this.lb_SLuong.AutoSize = true;
            this.lb_SLuong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_SLuong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SLuong.Location = new System.Drawing.Point(770, 140);
            this.lb_SLuong.Name = "lb_SLuong";
            this.lb_SLuong.Size = new System.Drawing.Size(112, 27);
            this.lb_SLuong.TabIndex = 47;
            this.lb_SLuong.Text = "Số Lượng:";
            // 
            // lb_DonGiaNhap
            // 
            this.lb_DonGiaNhap.AutoSize = true;
            this.lb_DonGiaNhap.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_DonGiaNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DonGiaNhap.Location = new System.Drawing.Point(770, 188);
            this.lb_DonGiaNhap.Name = "lb_DonGiaNhap";
            this.lb_DonGiaNhap.Size = new System.Drawing.Size(158, 27);
            this.lb_DonGiaNhap.TabIndex = 46;
            this.lb_DonGiaNhap.Text = "Đơn Giá Nhập:";
            // 
            // lb_TenThuoc
            // 
            this.lb_TenThuoc.AutoSize = true;
            this.lb_TenThuoc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_TenThuoc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenThuoc.Location = new System.Drawing.Point(770, 95);
            this.lb_TenThuoc.Name = "lb_TenThuoc";
            this.lb_TenThuoc.Size = new System.Drawing.Size(122, 27);
            this.lb_TenThuoc.TabIndex = 45;
            this.lb_TenThuoc.Text = "Tên Thuốc:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(756, 42);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(537, 197);
            this.textBox4.TabIndex = 44;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtb_MaPN_TTPNT
            // 
            this.txtb_MaPN_TTPNT.Enabled = false;
            this.txtb_MaPN_TTPNT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_MaPN_TTPNT.Location = new System.Drawing.Point(329, 93);
            this.txtb_MaPN_TTPNT.Multiline = true;
            this.txtb_MaPN_TTPNT.Name = "txtb_MaPN_TTPNT";
            this.txtb_MaPN_TTPNT.Size = new System.Drawing.Size(132, 30);
            this.txtb_MaPN_TTPNT.TabIndex = 59;
            // 
            // lb_ThongTinPNT
            // 
            this.lb_ThongTinPNT.AutoSize = true;
            this.lb_ThongTinPNT.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThongTinPNT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_ThongTinPNT.Location = new System.Drawing.Point(170, 30);
            this.lb_ThongTinPNT.Name = "lb_ThongTinPNT";
            this.lb_ThongTinPNT.Size = new System.Drawing.Size(366, 35);
            this.lb_ThongTinPNT.TabIndex = 58;
            this.lb_ThongTinPNT.Text = "Thông tin phiếu nhập thuốc";
            // 
            // txtb_LanNhap
            // 
            this.txtb_LanNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_LanNhap.Location = new System.Drawing.Point(329, 186);
            this.txtb_LanNhap.Multiline = true;
            this.txtb_LanNhap.Name = "txtb_LanNhap";
            this.txtb_LanNhap.Size = new System.Drawing.Size(132, 30);
            this.txtb_LanNhap.TabIndex = 56;
            // 
            // lb_LanNhap
            // 
            this.lb_LanNhap.AutoSize = true;
            this.lb_LanNhap.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_LanNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LanNhap.Location = new System.Drawing.Point(136, 189);
            this.lb_LanNhap.Name = "lb_LanNhap";
            this.lb_LanNhap.Size = new System.Drawing.Size(114, 27);
            this.lb_LanNhap.TabIndex = 54;
            this.lb_LanNhap.Text = "Lần Nhập:";
            // 
            // dtbx_NgayNhap
            // 
            this.dtbx_NgayNhap.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbx_NgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtbx_NgayNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbx_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbx_NgayNhap.Location = new System.Drawing.Point(329, 135);
            this.dtbx_NgayNhap.Name = "dtbx_NgayNhap";
            this.dtbx_NgayNhap.Size = new System.Drawing.Size(132, 34);
            this.dtbx_NgayNhap.TabIndex = 60;
            // 
            // btn_TrangChu_PNT
            // 
            this.btn_TrangChu_PNT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_TrangChu_PNT.BackgroundImage")));
            this.btn_TrangChu_PNT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TrangChu_PNT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TrangChu_PNT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrangChu_PNT.Location = new System.Drawing.Point(10, 12);
            this.btn_TrangChu_PNT.Name = "btn_TrangChu_PNT";
            this.btn_TrangChu_PNT.Size = new System.Drawing.Size(39, 39);
            this.btn_TrangChu_PNT.TabIndex = 61;
            this.btn_TrangChu_PNT.UseVisualStyleBackColor = true;
            this.btn_TrangChu_PNT.Click += new System.EventHandler(this.btn_TrangChu_PNT_Click);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(113, 42);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(535, 198);
            this.textBox7.TabIndex = 62;
            // 
            // lb_MaPN_TTPNT
            // 
            this.lb_MaPN_TTPNT.AutoSize = true;
            this.lb_MaPN_TTPNT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_MaPN_TTPNT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaPN_TTPNT.Location = new System.Drawing.Point(136, 96);
            this.lb_MaPN_TTPNT.Name = "lb_MaPN_TTPNT";
            this.lb_MaPN_TTPNT.Size = new System.Drawing.Size(169, 27);
            this.lb_MaPN_TTPNT.TabIndex = 53;
            this.lb_MaPN_TTPNT.Text = "Mã Phiếu Nhập:";
            // 
            // lb_NgayNhap
            // 
            this.lb_NgayNhap.AutoSize = true;
            this.lb_NgayNhap.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_NgayNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayNhap.Location = new System.Drawing.Point(136, 141);
            this.lb_NgayNhap.Name = "lb_NgayNhap";
            this.lb_NgayNhap.Size = new System.Drawing.Size(127, 27);
            this.lb_NgayNhap.TabIndex = 55;
            this.lb_NgayNhap.Text = "Ngày Nhập:";
            // 
            // btn_Xuat_CTPNT
            // 
            this.btn_Xuat_CTPNT.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Xuat_CTPNT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xuat_CTPNT.Location = new System.Drawing.Point(1183, 324);
            this.btn_Xuat_CTPNT.Name = "btn_Xuat_CTPNT";
            this.btn_Xuat_CTPNT.Size = new System.Drawing.Size(117, 37);
            this.btn_Xuat_CTPNT.TabIndex = 63;
            this.btn_Xuat_CTPNT.Text = "Xuất File";
            this.btn_Xuat_CTPNT.UseVisualStyleBackColor = false;
            // 
            // btn_TroVe_PNT
            // 
            this.btn_TroVe_PNT.BackgroundImage = global::InterfaceDesign.Properties.Resources.back;
            this.btn_TroVe_PNT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TroVe_PNT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TroVe_PNT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TroVe_PNT.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_TroVe_PNT.Location = new System.Drawing.Point(10, 57);
            this.btn_TroVe_PNT.Name = "btn_TroVe_PNT";
            this.btn_TroVe_PNT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_TroVe_PNT.Size = new System.Drawing.Size(39, 39);
            this.btn_TroVe_PNT.TabIndex = 64;
            this.btn_TroVe_PNT.Text = " ";
            this.btn_TroVe_PNT.UseVisualStyleBackColor = true;
            this.btn_TroVe_PNT.Click += new System.EventHandler(this.btn_TroVe_PNT_Click);
            // 
            // form_phieunhapthuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.ControlBox = false;
            this.Controls.Add(this.btn_TroVe_PNT);
            this.Controls.Add(this.btn_Xuat_CTPNT);
            this.Controls.Add(this.btn_TrangChu_PNT);
            this.Controls.Add(this.dtbx_NgayNhap);
            this.Controls.Add(this.txtb_MaPN_TTPNT);
            this.Controls.Add(this.lb_ThongTinPNT);
            this.Controls.Add(this.txtb_LanNhap);
            this.Controls.Add(this.lb_NgayNhap);
            this.Controls.Add(this.lb_LanNhap);
            this.Controls.Add(this.lb_MaPN_TTPNT);
            this.Controls.Add(this.lb_ThongTinThuocNhap);
            this.Controls.Add(this.cbx_TenThuoc);
            this.Controls.Add(this.txtb_SLuong);
            this.Controls.Add(this.txtb_DonGiaNhap);
            this.Controls.Add(this.lb_SLuong);
            this.Controls.Add(this.lb_DonGiaNhap);
            this.Controls.Add(this.lb_TenThuoc);
            this.Controls.Add(this.btn_Them_ThongTinPNT);
            this.Controls.Add(this.btn_Xuat_DSPNT);
            this.Controls.Add(this.btn_Luu_DSPNT);
            this.Controls.Add(this.btn_Sua_DSPNT);
            this.Controls.Add(this.btn_Xoa_DSPNT);
            this.Controls.Add(this.btn_Luu_CTPNT);
            this.Controls.Add(this.btn_Sua_CTPNT);
            this.Controls.Add(this.btn_Xoa_CTPNT);
            this.Controls.Add(this.btn_Them_ThongTinThuocNhap);
            this.Controls.Add(this.txtb_MaPN_CTPNT);
            this.Controls.Add(this.lb_MaPN_CTPNT);
            this.Controls.Add(this.btn_ChiTiet_DSPNT);
            this.Controls.Add(this.lv_DSPNT);
            this.Controls.Add(this.lv_CTPNT);
            this.Controls.Add(this.lb_CTPNT);
            this.Controls.Add(this.lb_DSPNT);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "form_phieunhapthuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Nhập Thuốc";
            this.Load += new System.EventHandler(this.form_phieunhapthuoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lb_DSPNT;
        private System.Windows.Forms.Label lb_CTPNT;
        private System.Windows.Forms.ListView lv_CTPNT;
        private System.Windows.Forms.ListView lv_DSPNT;
        private System.Windows.Forms.ColumnHeader cl_DSPNT_MaPN;
        private System.Windows.Forms.ColumnHeader cl_DSPNT_NgayNhap;
        private System.Windows.Forms.ColumnHeader cl_DSPNT_LanNhap;
        private System.Windows.Forms.ColumnHeader cl_DSPNT_SLNhap;
        private System.Windows.Forms.ColumnHeader cl_DSPNT_TongTien;
        private System.Windows.Forms.Button btn_ChiTiet_DSPNT;
        private System.Windows.Forms.Label lb_MaPN_CTPNT;
        private System.Windows.Forms.TextBox txtb_MaPN_CTPNT;
        private System.Windows.Forms.ColumnHeader cl_CTPNT_STT;
        private System.Windows.Forms.ColumnHeader cl_CTPNT_TenThuoc;
        private System.Windows.Forms.ColumnHeader cl_CTPNT_DonVi;
        private System.Windows.Forms.ColumnHeader cl_CTPNT_SLuong;
        private System.Windows.Forms.ColumnHeader cl_CTPNT_DonGiaNhap;
        private System.Windows.Forms.ColumnHeader cl_CTPNT_DonGiaVAT;
        private System.Windows.Forms.ColumnHeader cl_CTPNT_ThanhTienVAT;
        private System.Windows.Forms.Button btn_Them_ThongTinThuocNhap;
        private System.Windows.Forms.Button btn_Xoa_CTPNT;
        private System.Windows.Forms.Button btn_Sua_CTPNT;
        private System.Windows.Forms.Button btn_Luu_CTPNT;
        private System.Windows.Forms.Button btn_Luu_DSPNT;
        private System.Windows.Forms.Button btn_Sua_DSPNT;
        private System.Windows.Forms.Button btn_Xoa_DSPNT;
        private System.Windows.Forms.Button btn_Them_ThongTinPNT;
        private System.Windows.Forms.Button btn_Xuat_DSPNT;
        private System.Windows.Forms.Label lb_ThongTinThuocNhap;
        private System.Windows.Forms.ComboBox cbx_TenThuoc;
        private System.Windows.Forms.TextBox txtb_SLuong;
        private System.Windows.Forms.TextBox txtb_DonGiaNhap;
        private System.Windows.Forms.Label lb_SLuong;
        private System.Windows.Forms.Label lb_DonGiaNhap;
        private System.Windows.Forms.Label lb_TenThuoc;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtb_MaPN_TTPNT;
        private System.Windows.Forms.Label lb_ThongTinPNT;
        private System.Windows.Forms.TextBox txtb_LanNhap;
        private System.Windows.Forms.Label lb_LanNhap;
        private System.Windows.Forms.DateTimePicker dtbx_NgayNhap;
        private System.Windows.Forms.Button btn_TrangChu_PNT;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lb_MaPN_TTPNT;
        private System.Windows.Forms.Label lb_NgayNhap;
        private System.Windows.Forms.Button btn_Xuat_CTPNT;
        private System.Windows.Forms.Button btn_TroVe_PNT;
    }
}