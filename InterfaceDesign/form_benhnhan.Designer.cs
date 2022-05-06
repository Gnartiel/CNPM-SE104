
namespace InterfaceDesign
{
    partial class form_benhnhan
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
            this.lb_ThongTinBenhNhan = new System.Windows.Forms.Label();
            this.lb_MaBenhNhan = new System.Windows.Forms.Label();
            this.txtb_MaBenhNhan = new System.Windows.Forms.TextBox();
            this.txtb_HoTen = new System.Windows.Forms.TextBox();
            this.lb_HoTen = new System.Windows.Forms.Label();
            this.txtb_DiaChi = new System.Windows.Forms.TextBox();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.lb_NamSinh = new System.Windows.Forms.Label();
            this.dtbx_NamSinh = new System.Windows.Forms.DateTimePicker();
            this.lb_GioiTinh = new System.Windows.Forms.Label();
            this.rbtn_Nam = new System.Windows.Forms.RadioButton();
            this.rbtn_Nu = new System.Windows.Forms.RadioButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lv_DSBenhNhan = new System.Windows.Forms.ListView();
            this.cl_MaBenhNhan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_HoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_GioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_NamSinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_DiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Them_BN = new System.Windows.Forms.Button();
            this.btn_Sua_BN = new System.Windows.Forms.Button();
            this.btn_Xoa_BN = new System.Windows.Forms.Button();
            this.lb_DanhSachBenhNhan = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btn_TrangChu_BenhNhan = new System.Windows.Forms.Button();
            this.btn_TroVe_BenhNhan = new System.Windows.Forms.Button();
            this.btn_Luu_DSBN = new System.Windows.Forms.Button();
            this.btn_Xuat_DSBN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_ThongTinBenhNhan
            // 
            this.lb_ThongTinBenhNhan.AutoSize = true;
            this.lb_ThongTinBenhNhan.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThongTinBenhNhan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_ThongTinBenhNhan.Location = new System.Drawing.Point(475, 35);
            this.lb_ThongTinBenhNhan.Name = "lb_ThongTinBenhNhan";
            this.lb_ThongTinBenhNhan.Size = new System.Drawing.Size(280, 35);
            this.lb_ThongTinBenhNhan.TabIndex = 0;
            this.lb_ThongTinBenhNhan.Text = "Thông tin bệnh nhân";
            this.lb_ThongTinBenhNhan.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_MaBenhNhan
            // 
            this.lb_MaBenhNhan.AutoSize = true;
            this.lb_MaBenhNhan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_MaBenhNhan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaBenhNhan.Location = new System.Drawing.Point(161, 106);
            this.lb_MaBenhNhan.Name = "lb_MaBenhNhan";
            this.lb_MaBenhNhan.Size = new System.Drawing.Size(165, 27);
            this.lb_MaBenhNhan.TabIndex = 1;
            this.lb_MaBenhNhan.Text = "Mã Bệnh Nhân:";
            // 
            // txtb_MaBenhNhan
            // 
            this.txtb_MaBenhNhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_MaBenhNhan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_MaBenhNhan.Location = new System.Drawing.Point(348, 104);
            this.txtb_MaBenhNhan.Multiline = true;
            this.txtb_MaBenhNhan.Name = "txtb_MaBenhNhan";
            this.txtb_MaBenhNhan.Size = new System.Drawing.Size(157, 39);
            this.txtb_MaBenhNhan.TabIndex = 2;
            // 
            // txtb_HoTen
            // 
            this.txtb_HoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_HoTen.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_HoTen.Location = new System.Drawing.Point(348, 159);
            this.txtb_HoTen.Multiline = true;
            this.txtb_HoTen.Name = "txtb_HoTen";
            this.txtb_HoTen.Size = new System.Drawing.Size(279, 39);
            this.txtb_HoTen.TabIndex = 4;
            this.txtb_HoTen.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lb_HoTen
            // 
            this.lb_HoTen.AutoSize = true;
            this.lb_HoTen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_HoTen.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HoTen.Location = new System.Drawing.Point(161, 161);
            this.lb_HoTen.Name = "lb_HoTen";
            this.lb_HoTen.Size = new System.Drawing.Size(90, 27);
            this.lb_HoTen.TabIndex = 3;
            this.lb_HoTen.Text = "Họ Tên:";
            this.lb_HoTen.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtb_DiaChi
            // 
            this.txtb_DiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_DiaChi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_DiaChi.Location = new System.Drawing.Point(348, 215);
            this.txtb_DiaChi.Multiline = true;
            this.txtb_DiaChi.Name = "txtb_DiaChi";
            this.txtb_DiaChi.Size = new System.Drawing.Size(279, 39);
            this.txtb_DiaChi.TabIndex = 6;
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_DiaChi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DiaChi.Location = new System.Drawing.Point(161, 217);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(92, 27);
            this.lb_DiaChi.TabIndex = 5;
            this.lb_DiaChi.Text = "Địa Chỉ:";
            // 
            // lb_NamSinh
            // 
            this.lb_NamSinh.AutoSize = true;
            this.lb_NamSinh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_NamSinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NamSinh.Location = new System.Drawing.Point(796, 185);
            this.lb_NamSinh.Name = "lb_NamSinh";
            this.lb_NamSinh.Size = new System.Drawing.Size(112, 27);
            this.lb_NamSinh.TabIndex = 7;
            this.lb_NamSinh.Text = "Năm Sinh:";
            this.lb_NamSinh.Click += new System.EventHandler(this.lb_NamSinh_Click);
            // 
            // dtbx_NamSinh
            // 
            this.dtbx_NamSinh.CustomFormat = "dd/MM/yyyy";
            this.dtbx_NamSinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbx_NamSinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbx_NamSinh.Location = new System.Drawing.Point(937, 185);
            this.dtbx_NamSinh.Name = "dtbx_NamSinh";
            this.dtbx_NamSinh.Size = new System.Drawing.Size(146, 34);
            this.dtbx_NamSinh.TabIndex = 8;
            // 
            // lb_GioiTinh
            // 
            this.lb_GioiTinh.AutoSize = true;
            this.lb_GioiTinh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_GioiTinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GioiTinh.Location = new System.Drawing.Point(796, 106);
            this.lb_GioiTinh.Name = "lb_GioiTinh";
            this.lb_GioiTinh.Size = new System.Drawing.Size(110, 27);
            this.lb_GioiTinh.TabIndex = 9;
            this.lb_GioiTinh.Text = "Giới Tính:";
            this.lb_GioiTinh.Click += new System.EventHandler(this.label5_Click);
            // 
            // rbtn_Nam
            // 
            this.rbtn_Nam.AutoSize = true;
            this.rbtn_Nam.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtn_Nam.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Nam.Location = new System.Drawing.Point(937, 124);
            this.rbtn_Nam.Name = "rbtn_Nam";
            this.rbtn_Nam.Size = new System.Drawing.Size(79, 31);
            this.rbtn_Nam.TabIndex = 10;
            this.rbtn_Nam.TabStop = true;
            this.rbtn_Nam.Text = "Nam";
            this.rbtn_Nam.UseVisualStyleBackColor = false;
            // 
            // rbtn_Nu
            // 
            this.rbtn_Nu.AutoSize = true;
            this.rbtn_Nu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtn_Nu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Nu.Location = new System.Drawing.Point(1054, 124);
            this.rbtn_Nu.Name = "rbtn_Nu";
            this.rbtn_Nu.Size = new System.Drawing.Size(63, 31);
            this.rbtn_Nu.TabIndex = 11;
            this.rbtn_Nu.TabStop = true;
            this.rbtn_Nu.Text = "Nữ";
            this.rbtn_Nu.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(142, 51);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(1004, 281);
            this.textBox4.TabIndex = 12;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lv_DSBenhNhan
            // 
            this.lv_DSBenhNhan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_MaBenhNhan,
            this.cl_HoTen,
            this.cl_GioiTinh,
            this.cl_NamSinh,
            this.cl_DiaChi});
            this.lv_DSBenhNhan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_DSBenhNhan.FullRowSelect = true;
            this.lv_DSBenhNhan.GridLines = true;
            this.lv_DSBenhNhan.HideSelection = false;
            this.lv_DSBenhNhan.Location = new System.Drawing.Point(101, 461);
            this.lv_DSBenhNhan.Name = "lv_DSBenhNhan";
            this.lv_DSBenhNhan.Size = new System.Drawing.Size(1186, 216);
            this.lv_DSBenhNhan.TabIndex = 13;
            this.lv_DSBenhNhan.UseCompatibleStateImageBehavior = false;
            this.lv_DSBenhNhan.View = System.Windows.Forms.View.Details;
            this.lv_DSBenhNhan.VirtualMode = true;
            this.lv_DSBenhNhan.SelectedIndexChanged += new System.EventHandler(this.lv_MaBenhNhan_BN_SelectedIndexChanged);
            // 
            // cl_MaBenhNhan
            // 
            this.cl_MaBenhNhan.Text = "Mã Bệnh Nhân";
            this.cl_MaBenhNhan.Width = 179;
            // 
            // cl_HoTen
            // 
            this.cl_HoTen.Text = "Họ Tên";
            this.cl_HoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_HoTen.Width = 234;
            // 
            // cl_GioiTinh
            // 
            this.cl_GioiTinh.Text = "Giới Tính";
            this.cl_GioiTinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_GioiTinh.Width = 125;
            // 
            // cl_NamSinh
            // 
            this.cl_NamSinh.Text = "Năm Sinh";
            this.cl_NamSinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_NamSinh.Width = 147;
            // 
            // cl_DiaChi
            // 
            this.cl_DiaChi.Text = "Địa Chỉ";
            this.cl_DiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_DiaChi.Width = 516;
            // 
            // btn_Them_BN
            // 
            this.btn_Them_BN.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Them_BN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them_BN.Location = new System.Drawing.Point(913, 266);
            this.btn_Them_BN.Name = "btn_Them_BN";
            this.btn_Them_BN.Size = new System.Drawing.Size(103, 45);
            this.btn_Them_BN.TabIndex = 14;
            this.btn_Them_BN.Text = "Thêm";
            this.btn_Them_BN.UseVisualStyleBackColor = false;
            this.btn_Them_BN.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Sua_BN
            // 
            this.btn_Sua_BN.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Sua_BN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua_BN.Location = new System.Drawing.Point(602, 400);
            this.btn_Sua_BN.Name = "btn_Sua_BN";
            this.btn_Sua_BN.Size = new System.Drawing.Size(103, 45);
            this.btn_Sua_BN.TabIndex = 15;
            this.btn_Sua_BN.Text = "Sửa";
            this.btn_Sua_BN.UseVisualStyleBackColor = false;
            this.btn_Sua_BN.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Xoa_BN
            // 
            this.btn_Xoa_BN.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Xoa_BN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_BN.Location = new System.Drawing.Point(756, 400);
            this.btn_Xoa_BN.Name = "btn_Xoa_BN";
            this.btn_Xoa_BN.Size = new System.Drawing.Size(103, 45);
            this.btn_Xoa_BN.TabIndex = 16;
            this.btn_Xoa_BN.Text = "Xóa";
            this.btn_Xoa_BN.UseVisualStyleBackColor = false;
            this.btn_Xoa_BN.Click += new System.EventHandler(this.button3_Click);
            // 
            // lb_DanhSachBenhNhan
            // 
            this.lb_DanhSachBenhNhan.AutoSize = true;
            this.lb_DanhSachBenhNhan.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DanhSachBenhNhan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_DanhSachBenhNhan.Location = new System.Drawing.Point(136, 378);
            this.lb_DanhSachBenhNhan.Name = "lb_DanhSachBenhNhan";
            this.lb_DanhSachBenhNhan.Size = new System.Drawing.Size(386, 35);
            this.lb_DanhSachBenhNhan.TabIndex = 17;
            this.lb_DanhSachBenhNhan.Text = "DANH SÁCH BỆNH NHÂN";
            this.lb_DanhSachBenhNhan.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(78, 390);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(1220, 300);
            this.textBox5.TabIndex = 18;
            // 
            // btn_TrangChu_BenhNhan
            // 
            this.btn_TrangChu_BenhNhan.BackgroundImage = global::InterfaceDesign.Properties.Resources.home;
            this.btn_TrangChu_BenhNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TrangChu_BenhNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TrangChu_BenhNhan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrangChu_BenhNhan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TrangChu_BenhNhan.Location = new System.Drawing.Point(18, 12);
            this.btn_TrangChu_BenhNhan.Name = "btn_TrangChu_BenhNhan";
            this.btn_TrangChu_BenhNhan.Size = new System.Drawing.Size(39, 39);
            this.btn_TrangChu_BenhNhan.TabIndex = 19;
            this.btn_TrangChu_BenhNhan.UseVisualStyleBackColor = true;
            this.btn_TrangChu_BenhNhan.Click += new System.EventHandler(this.btn_TrangChu_Click);
            // 
            // btn_TroVe_BenhNhan
            // 
            this.btn_TroVe_BenhNhan.BackgroundImage = global::InterfaceDesign.Properties.Resources.back;
            this.btn_TroVe_BenhNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TroVe_BenhNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TroVe_BenhNhan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TroVe_BenhNhan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TroVe_BenhNhan.Location = new System.Drawing.Point(18, 60);
            this.btn_TroVe_BenhNhan.Name = "btn_TroVe_BenhNhan";
            this.btn_TroVe_BenhNhan.Size = new System.Drawing.Size(35, 35);
            this.btn_TroVe_BenhNhan.TabIndex = 26;
            this.btn_TroVe_BenhNhan.UseVisualStyleBackColor = true;
            this.btn_TroVe_BenhNhan.Click += new System.EventHandler(this.btn_TroVe_BenhNhan_Click);
            // 
            // btn_Luu_DSBN
            // 
            this.btn_Luu_DSBN.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Luu_DSBN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu_DSBN.Location = new System.Drawing.Point(1163, 400);
            this.btn_Luu_DSBN.Name = "btn_Luu_DSBN";
            this.btn_Luu_DSBN.Size = new System.Drawing.Size(103, 45);
            this.btn_Luu_DSBN.TabIndex = 27;
            this.btn_Luu_DSBN.Text = "Lưu";
            this.btn_Luu_DSBN.UseVisualStyleBackColor = false;
            // 
            // btn_Xuat_DSBN
            // 
            this.btn_Xuat_DSBN.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Xuat_DSBN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xuat_DSBN.Location = new System.Drawing.Point(986, 400);
            this.btn_Xuat_DSBN.Name = "btn_Xuat_DSBN";
            this.btn_Xuat_DSBN.Size = new System.Drawing.Size(118, 45);
            this.btn_Xuat_DSBN.TabIndex = 28;
            this.btn_Xuat_DSBN.Text = "Xuất File";
            this.btn_Xuat_DSBN.UseVisualStyleBackColor = false;
            // 
            // form_benhnhan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Xuat_DSBN);
            this.Controls.Add(this.btn_Luu_DSBN);
            this.Controls.Add(this.btn_TroVe_BenhNhan);
            this.Controls.Add(this.btn_TrangChu_BenhNhan);
            this.Controls.Add(this.lb_DanhSachBenhNhan);
            this.Controls.Add(this.btn_Xoa_BN);
            this.Controls.Add(this.btn_Sua_BN);
            this.Controls.Add(this.btn_Them_BN);
            this.Controls.Add(this.lv_DSBenhNhan);
            this.Controls.Add(this.rbtn_Nu);
            this.Controls.Add(this.rbtn_Nam);
            this.Controls.Add(this.lb_GioiTinh);
            this.Controls.Add(this.dtbx_NamSinh);
            this.Controls.Add(this.lb_NamSinh);
            this.Controls.Add(this.txtb_DiaChi);
            this.Controls.Add(this.lb_DiaChi);
            this.Controls.Add(this.txtb_HoTen);
            this.Controls.Add(this.lb_HoTen);
            this.Controls.Add(this.txtb_MaBenhNhan);
            this.Controls.Add(this.lb_MaBenhNhan);
            this.Controls.Add(this.lb_ThongTinBenhNhan);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Name = "form_benhnhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BenhNhan";
            this.Load += new System.EventHandler(this.form_benhnhan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ThongTinBenhNhan;
        private System.Windows.Forms.Label lb_MaBenhNhan;
        private System.Windows.Forms.TextBox txtb_MaBenhNhan;
        private System.Windows.Forms.TextBox txtb_HoTen;
        private System.Windows.Forms.Label lb_HoTen;
        private System.Windows.Forms.TextBox txtb_DiaChi;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.Label lb_NamSinh;
        private System.Windows.Forms.DateTimePicker dtbx_NamSinh;
        private System.Windows.Forms.Label lb_GioiTinh;
        private System.Windows.Forms.RadioButton rbtn_Nam;
        private System.Windows.Forms.RadioButton rbtn_Nu;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListView lv_DSBenhNhan;
        private System.Windows.Forms.Button btn_Them_BN;
        private System.Windows.Forms.Button btn_Sua_BN;
        private System.Windows.Forms.Button btn_Xoa_BN;
        private System.Windows.Forms.ColumnHeader cl_MaBenhNhan;
        private System.Windows.Forms.ColumnHeader cl_HoTen;
        private System.Windows.Forms.ColumnHeader cl_GioiTinh;
        private System.Windows.Forms.ColumnHeader cl_NamSinh;
        private System.Windows.Forms.ColumnHeader cl_DiaChi;
        private System.Windows.Forms.Label lb_DanhSachBenhNhan;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btn_TrangChu_BenhNhan;
        private System.Windows.Forms.Button btn_TroVe_BenhNhan;
        private System.Windows.Forms.Button btn_Luu_DSBN;
        private System.Windows.Forms.Button btn_Xuat_DSBN;
    }
}