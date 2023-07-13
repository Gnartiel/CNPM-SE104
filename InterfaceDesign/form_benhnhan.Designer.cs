
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_benhnhan));
            this.lb_ThongTinBenhNhan = new System.Windows.Forms.Label();
            this.lb_MaBenhNhan = new System.Windows.Forms.Label();
            this.txtb_MaBenhNhan = new System.Windows.Forms.TextBox();
            this.txtb_HoTen = new System.Windows.Forms.TextBox();
            this.lb_HoTen = new System.Windows.Forms.Label();
            this.txtb_DiaChi = new System.Windows.Forms.TextBox();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.lb_NamSinh = new System.Windows.Forms.Label();
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
            this.btn_Xuat_DSBN = new System.Windows.Forms.Button();
            this.lb_GioiTinh = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_TroVe_BenhNhan = new System.Windows.Forms.Button();
            this.btn_TrangChu_BenhNhan = new System.Windows.Forms.Button();
            this.txtb_NamSinh = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_ThongTinBenhNhan
            // 
            resources.ApplyResources(this.lb_ThongTinBenhNhan, "lb_ThongTinBenhNhan");
            this.lb_ThongTinBenhNhan.BackColor = System.Drawing.SystemColors.Control;
            this.lb_ThongTinBenhNhan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_ThongTinBenhNhan.Name = "lb_ThongTinBenhNhan";
            // 
            // lb_MaBenhNhan
            // 
            resources.ApplyResources(this.lb_MaBenhNhan, "lb_MaBenhNhan");
            this.lb_MaBenhNhan.BackColor = System.Drawing.SystemColors.Window;
            this.lb_MaBenhNhan.Name = "lb_MaBenhNhan";
            // 
            // txtb_MaBenhNhan
            // 
            this.txtb_MaBenhNhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtb_MaBenhNhan, "txtb_MaBenhNhan");
            this.txtb_MaBenhNhan.Name = "txtb_MaBenhNhan";
            // 
            // txtb_HoTen
            // 
            this.txtb_HoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtb_HoTen, "txtb_HoTen");
            this.txtb_HoTen.Name = "txtb_HoTen";
            // 
            // lb_HoTen
            // 
            resources.ApplyResources(this.lb_HoTen, "lb_HoTen");
            this.lb_HoTen.BackColor = System.Drawing.SystemColors.Window;
            this.lb_HoTen.Name = "lb_HoTen";
            // 
            // txtb_DiaChi
            // 
            resources.ApplyResources(this.txtb_DiaChi, "txtb_DiaChi");
            this.txtb_DiaChi.Name = "txtb_DiaChi";
            // 
            // lb_DiaChi
            // 
            resources.ApplyResources(this.lb_DiaChi, "lb_DiaChi");
            this.lb_DiaChi.BackColor = System.Drawing.SystemColors.Window;
            this.lb_DiaChi.Name = "lb_DiaChi";
            // 
            // lb_NamSinh
            // 
            resources.ApplyResources(this.lb_NamSinh, "lb_NamSinh");
            this.lb_NamSinh.BackColor = System.Drawing.SystemColors.Window;
            this.lb_NamSinh.Name = "lb_NamSinh";
            // 
            // rbtn_Nam
            // 
            resources.ApplyResources(this.rbtn_Nam, "rbtn_Nam");
            this.rbtn_Nam.BackColor = System.Drawing.SystemColors.Window;
            this.rbtn_Nam.Name = "rbtn_Nam";
            this.rbtn_Nam.UseVisualStyleBackColor = false;
            // 
            // rbtn_Nu
            // 
            resources.ApplyResources(this.rbtn_Nu, "rbtn_Nu");
            this.rbtn_Nu.BackColor = System.Drawing.SystemColors.Window;
            this.rbtn_Nu.Checked = true;
            this.rbtn_Nu.Name = "rbtn_Nu";
            this.rbtn_Nu.TabStop = true;
            this.rbtn_Nu.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // lv_DSBenhNhan
            // 
            this.lv_DSBenhNhan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_MaBenhNhan,
            this.cl_HoTen,
            this.cl_GioiTinh,
            this.cl_NamSinh,
            this.cl_DiaChi});
            resources.ApplyResources(this.lv_DSBenhNhan, "lv_DSBenhNhan");
            this.lv_DSBenhNhan.FullRowSelect = true;
            this.lv_DSBenhNhan.GridLines = true;
            this.lv_DSBenhNhan.HideSelection = false;
            this.lv_DSBenhNhan.Name = "lv_DSBenhNhan";
            this.lv_DSBenhNhan.UseCompatibleStateImageBehavior = false;
            this.lv_DSBenhNhan.View = System.Windows.Forms.View.Details;
            this.lv_DSBenhNhan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_DSBenhNhan_MouseClick);
            this.lv_DSBenhNhan.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_DSBenhNhan_MouseDoubleClick);
            // 
            // cl_MaBenhNhan
            // 
            resources.ApplyResources(this.cl_MaBenhNhan, "cl_MaBenhNhan");
            // 
            // cl_HoTen
            // 
            resources.ApplyResources(this.cl_HoTen, "cl_HoTen");
            // 
            // cl_GioiTinh
            // 
            resources.ApplyResources(this.cl_GioiTinh, "cl_GioiTinh");
            // 
            // cl_NamSinh
            // 
            resources.ApplyResources(this.cl_NamSinh, "cl_NamSinh");
            // 
            // cl_DiaChi
            // 
            resources.ApplyResources(this.cl_DiaChi, "cl_DiaChi");
            // 
            // btn_Them_BN
            // 
            this.btn_Them_BN.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btn_Them_BN, "btn_Them_BN");
            this.btn_Them_BN.Name = "btn_Them_BN";
            this.btn_Them_BN.UseVisualStyleBackColor = false;
            this.btn_Them_BN.Click += new System.EventHandler(this.btn_Them_BN_Click);
            // 
            // btn_Sua_BN
            // 
            this.btn_Sua_BN.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btn_Sua_BN, "btn_Sua_BN");
            this.btn_Sua_BN.Name = "btn_Sua_BN";
            this.btn_Sua_BN.UseVisualStyleBackColor = false;
            this.btn_Sua_BN.Click += new System.EventHandler(this.btn_Sua_BN_Click);
            // 
            // btn_Xoa_BN
            // 
            this.btn_Xoa_BN.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btn_Xoa_BN, "btn_Xoa_BN");
            this.btn_Xoa_BN.Name = "btn_Xoa_BN";
            this.btn_Xoa_BN.UseVisualStyleBackColor = false;
            this.btn_Xoa_BN.Click += new System.EventHandler(this.btn_Xoa_BN_Click);
            // 
            // lb_DanhSachBenhNhan
            // 
            resources.ApplyResources(this.lb_DanhSachBenhNhan, "lb_DanhSachBenhNhan");
            this.lb_DanhSachBenhNhan.BackColor = System.Drawing.SystemColors.Control;
            this.lb_DanhSachBenhNhan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_DanhSachBenhNhan.Name = "lb_DanhSachBenhNhan";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            // 
            // btn_Xuat_DSBN
            // 
            this.btn_Xuat_DSBN.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btn_Xuat_DSBN, "btn_Xuat_DSBN");
            this.btn_Xuat_DSBN.Name = "btn_Xuat_DSBN";
            this.btn_Xuat_DSBN.UseVisualStyleBackColor = false;
            this.btn_Xuat_DSBN.Click += new System.EventHandler(this.btn_Xuat_DSBN_Click);
            // 
            // lb_GioiTinh
            // 
            resources.ApplyResources(this.lb_GioiTinh, "lb_GioiTinh");
            this.lb_GioiTinh.BackColor = System.Drawing.SystemColors.Window;
            this.lb_GioiTinh.Name = "lb_GioiTinh";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btn_Thoat, "btn_Thoat");
            this.btn_Thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_TroVe_BenhNhan
            // 
            resources.ApplyResources(this.btn_TroVe_BenhNhan, "btn_TroVe_BenhNhan");
            this.btn_TroVe_BenhNhan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TroVe_BenhNhan.Name = "btn_TroVe_BenhNhan";
            this.btn_TroVe_BenhNhan.UseVisualStyleBackColor = true;
            this.btn_TroVe_BenhNhan.Click += new System.EventHandler(this.btn_TroVe_BenhNhan_Click);
            // 
            // btn_TrangChu_BenhNhan
            // 
            resources.ApplyResources(this.btn_TrangChu_BenhNhan, "btn_TrangChu_BenhNhan");
            this.btn_TrangChu_BenhNhan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TrangChu_BenhNhan.Name = "btn_TrangChu_BenhNhan";
            this.btn_TrangChu_BenhNhan.UseVisualStyleBackColor = true;
            this.btn_TrangChu_BenhNhan.Click += new System.EventHandler(this.btn_TrangChu_Click);
            // 
            // txtb_NamSinh
            // 
            this.txtb_NamSinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtb_NamSinh, "txtb_NamSinh");
            this.txtb_NamSinh.Name = "txtb_NamSinh";
            // 
            // form_benhnhan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.txtb_NamSinh);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xuat_DSBN);
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
            this.DoubleBuffered = true;
            this.Name = "form_benhnhan";
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
        private System.Windows.Forms.Button btn_Xuat_DSBN;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label lb_GioiTinh;
        private System.Windows.Forms.TextBox txtb_NamSinh;
    }
}