
namespace InterfaceDesign
{
    partial class form_loaibenh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_loaibenh));
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.lv_LoaiBenh = new System.Windows.Forms.ListView();
            this.cl_MaLoaiBenh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_TenBenh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_TrieuChung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_DSLB = new System.Windows.Forms.Label();
            this.lb_ThongTinLB = new System.Windows.Forms.Label();
            this.lb_TrieuChung = new System.Windows.Forms.Label();
            this.txtb_TrieuChung = new System.Windows.Forms.TextBox();
            this.lb_MaLoaiBenh = new System.Windows.Forms.Label();
            this.txtb_MaLoaiBenh = new System.Windows.Forms.TextBox();
            this.lb_TenBenh = new System.Windows.Forms.Label();
            this.txtb_TenBenh = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_TroVe_LoaiBenh = new System.Windows.Forms.Button();
            this.btn_TrangChu_LoaiBenh = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(285, 472);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(108, 54);
            this.btn_Sua.TabIndex = 10;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(435, 472);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(108, 54);
            this.btn_Xoa.TabIndex = 11;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // lv_LoaiBenh
            // 
            this.lv_LoaiBenh.AllowColumnReorder = true;
            this.lv_LoaiBenh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_MaLoaiBenh,
            this.cl_TenBenh,
            this.cl_TrieuChung});
            this.lv_LoaiBenh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_LoaiBenh.FullRowSelect = true;
            this.lv_LoaiBenh.GridLines = true;
            this.lv_LoaiBenh.HideSelection = false;
            this.lv_LoaiBenh.Location = new System.Drawing.Point(669, 115);
            this.lv_LoaiBenh.Name = "lv_LoaiBenh";
            this.lv_LoaiBenh.Size = new System.Drawing.Size(622, 557);
            this.lv_LoaiBenh.TabIndex = 14;
            this.lv_LoaiBenh.UseCompatibleStateImageBehavior = false;
            this.lv_LoaiBenh.View = System.Windows.Forms.View.Details;
            this.lv_LoaiBenh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_LoaiBenh_MouseClick);
            this.lv_LoaiBenh.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_LoaiBenh_MouseDoubleClick);
            // 
            // cl_MaLoaiBenh
            // 
            this.cl_MaLoaiBenh.Text = "Mã loại bệnh";
            this.cl_MaLoaiBenh.Width = 126;
            // 
            // cl_TenBenh
            // 
            this.cl_TenBenh.Text = "Tên bệnh";
            this.cl_TenBenh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_TenBenh.Width = 153;
            // 
            // cl_TrieuChung
            // 
            this.cl_TrieuChung.Text = "Triệu chứng";
            this.cl_TrieuChung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_TrieuChung.Width = 478;
            // 
            // lb_DSLB
            // 
            this.lb_DSLB.AutoSize = true;
            this.lb_DSLB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DSLB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_DSLB.Location = new System.Drawing.Point(796, 34);
            this.lb_DSLB.Name = "lb_DSLB";
            this.lb_DSLB.Size = new System.Drawing.Size(373, 35);
            this.lb_DSLB.TabIndex = 21;
            this.lb_DSLB.Text = "DANH SÁCH LOẠI BỆNH";
            // 
            // lb_ThongTinLB
            // 
            this.lb_ThongTinLB.AutoSize = true;
            this.lb_ThongTinLB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThongTinLB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_ThongTinLB.Location = new System.Drawing.Point(200, 95);
            this.lb_ThongTinLB.Name = "lb_ThongTinLB";
            this.lb_ThongTinLB.Size = new System.Drawing.Size(262, 35);
            this.lb_ThongTinLB.TabIndex = 24;
            this.lb_ThongTinLB.Text = "Thông tin loại bệnh";
            // 
            // lb_TrieuChung
            // 
            this.lb_TrieuChung.AutoSize = true;
            this.lb_TrieuChung.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_TrieuChung.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TrieuChung.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_TrieuChung.Location = new System.Drawing.Point(131, 358);
            this.lb_TrieuChung.Name = "lb_TrieuChung";
            this.lb_TrieuChung.Size = new System.Drawing.Size(133, 27);
            this.lb_TrieuChung.TabIndex = 27;
            this.lb_TrieuChung.Text = "Triệu chứng:";
            // 
            // txtb_TrieuChung
            // 
            this.txtb_TrieuChung.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_TrieuChung.Location = new System.Drawing.Point(302, 355);
            this.txtb_TrieuChung.Multiline = true;
            this.txtb_TrieuChung.Name = "txtb_TrieuChung";
            this.txtb_TrieuChung.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtb_TrieuChung.Size = new System.Drawing.Size(241, 78);
            this.txtb_TrieuChung.TabIndex = 30;
            // 
            // lb_MaLoaiBenh
            // 
            this.lb_MaLoaiBenh.AutoSize = true;
            this.lb_MaLoaiBenh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_MaLoaiBenh.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaLoaiBenh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_MaLoaiBenh.Location = new System.Drawing.Point(131, 196);
            this.lb_MaLoaiBenh.Name = "lb_MaLoaiBenh";
            this.lb_MaLoaiBenh.Size = new System.Drawing.Size(144, 27);
            this.lb_MaLoaiBenh.TabIndex = 25;
            this.lb_MaLoaiBenh.Text = "Mã loại bệnh:";
            // 
            // txtb_MaLoaiBenh
            // 
            this.txtb_MaLoaiBenh.Enabled = false;
            this.txtb_MaLoaiBenh.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_MaLoaiBenh.Location = new System.Drawing.Point(302, 193);
            this.txtb_MaLoaiBenh.Multiline = true;
            this.txtb_MaLoaiBenh.Name = "txtb_MaLoaiBenh";
            this.txtb_MaLoaiBenh.Size = new System.Drawing.Size(241, 40);
            this.txtb_MaLoaiBenh.TabIndex = 28;
            // 
            // lb_TenBenh
            // 
            this.lb_TenBenh.AutoSize = true;
            this.lb_TenBenh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_TenBenh.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenBenh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_TenBenh.Location = new System.Drawing.Point(131, 276);
            this.lb_TenBenh.Name = "lb_TenBenh";
            this.lb_TenBenh.Size = new System.Drawing.Size(108, 27);
            this.lb_TenBenh.TabIndex = 26;
            this.lb_TenBenh.Text = "Tên bệnh:";
            // 
            // txtb_TenBenh
            // 
            this.txtb_TenBenh.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_TenBenh.Location = new System.Drawing.Point(302, 273);
            this.txtb_TenBenh.Multiline = true;
            this.txtb_TenBenh.Name = "txtb_TenBenh";
            this.txtb_TenBenh.Size = new System.Drawing.Size(241, 40);
            this.txtb_TenBenh.TabIndex = 29;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(91, 115);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(479, 443);
            this.textBox1.TabIndex = 32;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.White;
            this.btn_Thoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.BackgroundImage")));
            this.btn_Thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Thoat.Location = new System.Drawing.Point(12, 120);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(52, 48);
            this.btn_Thoat.TabIndex = 96;
            this.btn_Thoat.Text = " ";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_TroVe_LoaiBenh
            // 
            this.btn_TroVe_LoaiBenh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TroVe_LoaiBenh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_TroVe_LoaiBenh.BackgroundImage")));
            this.btn_TroVe_LoaiBenh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TroVe_LoaiBenh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TroVe_LoaiBenh.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TroVe_LoaiBenh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TroVe_LoaiBenh.Location = new System.Drawing.Point(12, 66);
            this.btn_TroVe_LoaiBenh.Name = "btn_TroVe_LoaiBenh";
            this.btn_TroVe_LoaiBenh.Size = new System.Drawing.Size(52, 48);
            this.btn_TroVe_LoaiBenh.TabIndex = 20;
            this.btn_TroVe_LoaiBenh.Text = " ";
            this.btn_TroVe_LoaiBenh.UseVisualStyleBackColor = false;
            this.btn_TroVe_LoaiBenh.Click += new System.EventHandler(this.btn_TroVe_LoaiBenh_Click);
            // 
            // btn_TrangChu_LoaiBenh
            // 
            this.btn_TrangChu_LoaiBenh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TrangChu_LoaiBenh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_TrangChu_LoaiBenh.BackgroundImage")));
            this.btn_TrangChu_LoaiBenh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TrangChu_LoaiBenh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TrangChu_LoaiBenh.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrangChu_LoaiBenh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TrangChu_LoaiBenh.Location = new System.Drawing.Point(12, 12);
            this.btn_TrangChu_LoaiBenh.Name = "btn_TrangChu_LoaiBenh";
            this.btn_TrangChu_LoaiBenh.Size = new System.Drawing.Size(52, 48);
            this.btn_TrangChu_LoaiBenh.TabIndex = 19;
            this.btn_TrangChu_LoaiBenh.Text = " ";
            this.btn_TrangChu_LoaiBenh.UseVisualStyleBackColor = false;
            this.btn_TrangChu_LoaiBenh.Click += new System.EventHandler(this.btn_TrangChu_LoaiBenh_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(131, 472);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(108, 54);
            this.btn_Them.TabIndex = 97;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(648, 46);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(664, 646);
            this.textBox2.TabIndex = 23;
            // 
            // form_loaibenh
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1338, 716);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.lb_ThongTinLB);
            this.Controls.Add(this.lb_TrieuChung);
            this.Controls.Add(this.txtb_TrieuChung);
            this.Controls.Add(this.lb_MaLoaiBenh);
            this.Controls.Add(this.txtb_MaLoaiBenh);
            this.Controls.Add(this.lb_TenBenh);
            this.Controls.Add(this.txtb_TenBenh);
            this.Controls.Add(this.lb_DSLB);
            this.Controls.Add(this.btn_TroVe_LoaiBenh);
            this.Controls.Add(this.btn_TrangChu_LoaiBenh);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.lv_LoaiBenh);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Name = "form_loaibenh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại bệnh";
            this.Load += new System.EventHandler(this.form_loaibenh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.ListView lv_LoaiBenh;
        private System.Windows.Forms.Button btn_TrangChu_LoaiBenh;
        private System.Windows.Forms.Button btn_TroVe_LoaiBenh;
        private System.Windows.Forms.Label lb_DSLB;
        private System.Windows.Forms.Label lb_ThongTinLB;
        private System.Windows.Forms.Label lb_TrieuChung;
        private System.Windows.Forms.TextBox txtb_TrieuChung;
        private System.Windows.Forms.Label lb_MaLoaiBenh;
        private System.Windows.Forms.TextBox txtb_MaLoaiBenh;
        private System.Windows.Forms.Label lb_TenBenh;
        private System.Windows.Forms.TextBox txtb_TenBenh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.ColumnHeader cl_MaLoaiBenh;
        private System.Windows.Forms.ColumnHeader cl_TenBenh;
        private System.Windows.Forms.ColumnHeader cl_TrieuChung;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox textBox2;
    }
}