
namespace InterfaceDesign
{
    partial class form_baocaosudungthuoc
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
            this.lv_BCSuDungThuoc = new System.Windows.Forms.ListView();
            this.cl_ThangSDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_NamSDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_TenThuoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_SoLuongDung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_SoLanDung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.btn_Xuat_BCSDT = new System.Windows.Forms.Button();
            this.lb_BCSuDungThuoc = new System.Windows.Forms.Label();
            this.btn_TroVe_BCSDT = new System.Windows.Forms.Button();
            this.btn_TrangChu_BCSDT = new System.Windows.Forms.Button();
            this.btn_KetXuat_BCSDT = new System.Windows.Forms.Button();
            this.lb_locthongtin = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.cbx_Thuoc = new System.Windows.Forms.ComboBox();
            this.rdbtn_Thang = new System.Windows.Forms.RadioButton();
            this.rdbtn_TenThuoc = new System.Windows.Forms.RadioButton();
            this.rdbtn_Nam = new System.Windows.Forms.RadioButton();
            this.cbx_Thang = new System.Windows.Forms.ComboBox();
            this.cbx_Nam = new System.Windows.Forms.ComboBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_BCSuDungThuoc
            // 
            this.lv_BCSuDungThuoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_ThangSDT,
            this.cl_NamSDT,
            this.cl_TenThuoc,
            this.cl_SoLuongDung,
            this.cl_SoLanDung});
            this.lv_BCSuDungThuoc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_BCSuDungThuoc.FullRowSelect = true;
            this.lv_BCSuDungThuoc.GridLines = true;
            this.lv_BCSuDungThuoc.HideSelection = false;
            this.lv_BCSuDungThuoc.Location = new System.Drawing.Point(599, 118);
            this.lv_BCSuDungThuoc.Name = "lv_BCSuDungThuoc";
            this.lv_BCSuDungThuoc.Size = new System.Drawing.Size(694, 570);
            this.lv_BCSuDungThuoc.TabIndex = 20;
            this.lv_BCSuDungThuoc.UseCompatibleStateImageBehavior = false;
            this.lv_BCSuDungThuoc.View = System.Windows.Forms.View.Details;
            // 
            // cl_ThangSDT
            // 
            this.cl_ThangSDT.Text = "Tháng";
            this.cl_ThangSDT.Width = 86;
            // 
            // cl_NamSDT
            // 
            this.cl_NamSDT.Text = "Năm";
            this.cl_NamSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_NamSDT.Width = 124;
            // 
            // cl_TenThuoc
            // 
            this.cl_TenThuoc.Text = "Tên thuốc";
            this.cl_TenThuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_TenThuoc.Width = 174;
            // 
            // cl_SoLuongDung
            // 
            this.cl_SoLuongDung.Text = "Số Lượng Dùng";
            this.cl_SoLuongDung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_SoLuongDung.Width = 166;
            // 
            // cl_SoLanDung
            // 
            this.cl_SoLanDung.Text = "Số Lần Dùng";
            this.cl_SoLanDung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_SoLanDung.Width = 141;
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox14.Enabled = false;
            this.textBox14.Location = new System.Drawing.Point(570, 29);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(746, 675);
            this.textBox14.TabIndex = 21;
            // 
            // btn_Xuat_BCSDT
            // 
            this.btn_Xuat_BCSDT.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Xuat_BCSDT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xuat_BCSDT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Xuat_BCSDT.Location = new System.Drawing.Point(1128, 46);
            this.btn_Xuat_BCSDT.Name = "btn_Xuat_BCSDT";
            this.btn_Xuat_BCSDT.Size = new System.Drawing.Size(165, 45);
            this.btn_Xuat_BCSDT.TabIndex = 19;
            this.btn_Xuat_BCSDT.Text = "Xuất File";
            this.btn_Xuat_BCSDT.UseVisualStyleBackColor = false;
            this.btn_Xuat_BCSDT.Click += new System.EventHandler(this.btn_Xuat_BCSDT_Click);
            // 
            // lb_BCSuDungThuoc
            // 
            this.lb_BCSuDungThuoc.AutoSize = true;
            this.lb_BCSuDungThuoc.BackColor = System.Drawing.SystemColors.Control;
            this.lb_BCSuDungThuoc.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BCSuDungThuoc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_BCSuDungThuoc.Location = new System.Drawing.Point(632, 11);
            this.lb_BCSuDungThuoc.Name = "lb_BCSuDungThuoc";
            this.lb_BCSuDungThuoc.Size = new System.Drawing.Size(419, 35);
            this.lb_BCSuDungThuoc.TabIndex = 22;
            this.lb_BCSuDungThuoc.Text = "BÁO CÁO SỬ DỤNG THUỐC";
            // 
            // btn_TroVe_BCSDT
            // 
            this.btn_TroVe_BCSDT.BackgroundImage = global::InterfaceDesign.Properties.Resources.back;
            this.btn_TroVe_BCSDT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TroVe_BCSDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TroVe_BCSDT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TroVe_BCSDT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TroVe_BCSDT.Location = new System.Drawing.Point(18, 73);
            this.btn_TroVe_BCSDT.Name = "btn_TroVe_BCSDT";
            this.btn_TroVe_BCSDT.Size = new System.Drawing.Size(52, 48);
            this.btn_TroVe_BCSDT.TabIndex = 25;
            this.btn_TroVe_BCSDT.UseVisualStyleBackColor = true;
            this.btn_TroVe_BCSDT.Click += new System.EventHandler(this.btn_TroVe_BCSDT_Click);
            // 
            // btn_TrangChu_BCSDT
            // 
            this.btn_TrangChu_BCSDT.BackgroundImage = global::InterfaceDesign.Properties.Resources.home;
            this.btn_TrangChu_BCSDT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TrangChu_BCSDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TrangChu_BCSDT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrangChu_BCSDT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TrangChu_BCSDT.Location = new System.Drawing.Point(18, 12);
            this.btn_TrangChu_BCSDT.Name = "btn_TrangChu_BCSDT";
            this.btn_TrangChu_BCSDT.Size = new System.Drawing.Size(52, 48);
            this.btn_TrangChu_BCSDT.TabIndex = 24;
            this.btn_TrangChu_BCSDT.UseVisualStyleBackColor = true;
            this.btn_TrangChu_BCSDT.Click += new System.EventHandler(this.btn_TrangChu_BCSDT_Click);
            // 
            // btn_KetXuat_BCSDT
            // 
            this.btn_KetXuat_BCSDT.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_KetXuat_BCSDT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KetXuat_BCSDT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_KetXuat_BCSDT.Location = new System.Drawing.Point(317, 457);
            this.btn_KetXuat_BCSDT.Name = "btn_KetXuat_BCSDT";
            this.btn_KetXuat_BCSDT.Size = new System.Drawing.Size(151, 46);
            this.btn_KetXuat_BCSDT.TabIndex = 39;
            this.btn_KetXuat_BCSDT.Text = "Kết Xuất";
            this.btn_KetXuat_BCSDT.UseVisualStyleBackColor = false;
            this.btn_KetXuat_BCSDT.Click += new System.EventHandler(this.btn_KetXuat_BCSDT_Click);
            // 
            // lb_locthongtin
            // 
            this.lb_locthongtin.AutoSize = true;
            this.lb_locthongtin.BackColor = System.Drawing.SystemColors.Control;
            this.lb_locthongtin.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_locthongtin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_locthongtin.Location = new System.Drawing.Point(146, 128);
            this.lb_locthongtin.Name = "lb_locthongtin";
            this.lb_locthongtin.Size = new System.Drawing.Size(185, 35);
            this.lb_locthongtin.TabIndex = 35;
            this.lb_locthongtin.Text = "Lọc thông tin";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(91, 149);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(436, 390);
            this.textBox1.TabIndex = 34;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.White;
            this.btn_Thoat.BackgroundImage = global::InterfaceDesign.Properties.Resources.thoat;
            this.btn_Thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Thoat.Location = new System.Drawing.Point(18, 136);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(52, 48);
            this.btn_Thoat.TabIndex = 94;
            this.btn_Thoat.Text = " ";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // cbx_Thuoc
            // 
            this.cbx_Thuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Thuoc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Thuoc.FormattingEnabled = true;
            this.cbx_Thuoc.Location = new System.Drawing.Point(303, 379);
            this.cbx_Thuoc.Name = "cbx_Thuoc";
            this.cbx_Thuoc.Size = new System.Drawing.Size(184, 34);
            this.cbx_Thuoc.TabIndex = 95;
            // 
            // rdbtn_Thang
            // 
            this.rdbtn_Thang.AutoSize = true;
            this.rdbtn_Thang.BackColor = System.Drawing.SystemColors.Window;
            this.rdbtn_Thang.Checked = true;
            this.rdbtn_Thang.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.rdbtn_Thang.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rdbtn_Thang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbtn_Thang.Location = new System.Drawing.Point(132, 245);
            this.rdbtn_Thang.Name = "rdbtn_Thang";
            this.rdbtn_Thang.Size = new System.Drawing.Size(99, 31);
            this.rdbtn_Thang.TabIndex = 98;
            this.rdbtn_Thang.TabStop = true;
            this.rdbtn_Thang.Text = "Tháng:";
            this.rdbtn_Thang.UseVisualStyleBackColor = false;
            // 
            // rdbtn_TenThuoc
            // 
            this.rdbtn_TenThuoc.AutoSize = true;
            this.rdbtn_TenThuoc.BackColor = System.Drawing.SystemColors.Window;
            this.rdbtn_TenThuoc.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.rdbtn_TenThuoc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rdbtn_TenThuoc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbtn_TenThuoc.Location = new System.Drawing.Point(132, 382);
            this.rdbtn_TenThuoc.Name = "rdbtn_TenThuoc";
            this.rdbtn_TenThuoc.Size = new System.Drawing.Size(143, 31);
            this.rdbtn_TenThuoc.TabIndex = 99;
            this.rdbtn_TenThuoc.Text = "Tên Thuốc:";
            this.rdbtn_TenThuoc.UseVisualStyleBackColor = false;
            // 
            // rdbtn_Nam
            // 
            this.rdbtn_Nam.AutoSize = true;
            this.rdbtn_Nam.BackColor = System.Drawing.SystemColors.Window;
            this.rdbtn_Nam.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.rdbtn_Nam.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rdbtn_Nam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbtn_Nam.Location = new System.Drawing.Point(132, 313);
            this.rdbtn_Nam.Name = "rdbtn_Nam";
            this.rdbtn_Nam.Size = new System.Drawing.Size(85, 31);
            this.rdbtn_Nam.TabIndex = 100;
            this.rdbtn_Nam.Text = "Năm:";
            this.rdbtn_Nam.UseVisualStyleBackColor = false;
            // 
            // cbx_Thang
            // 
            this.cbx_Thang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Thang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Thang.FormattingEnabled = true;
            this.cbx_Thang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbx_Thang.Location = new System.Drawing.Point(303, 242);
            this.cbx_Thang.Name = "cbx_Thang";
            this.cbx_Thang.Size = new System.Drawing.Size(184, 34);
            this.cbx_Thang.TabIndex = 101;
            // 
            // cbx_Nam
            // 
            this.cbx_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Nam.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Nam.FormattingEnabled = true;
            this.cbx_Nam.Location = new System.Drawing.Point(303, 310);
            this.cbx_Nam.Name = "cbx_Nam";
            this.cbx_Nam.Size = new System.Drawing.Size(184, 34);
            this.cbx_Nam.TabIndex = 101;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_reset.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_reset.Location = new System.Drawing.Point(132, 457);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(151, 46);
            this.btn_reset.TabIndex = 102;
            this.btn_reset.Text = "Đặt Lại";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // form_baocaosudungthuoc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1338, 716);
            this.ControlBox = false;
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.cbx_Nam);
            this.Controls.Add(this.cbx_Thang);
            this.Controls.Add(this.rdbtn_Nam);
            this.Controls.Add(this.rdbtn_TenThuoc);
            this.Controls.Add(this.rdbtn_Thang);
            this.Controls.Add(this.cbx_Thuoc);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_KetXuat_BCSDT);
            this.Controls.Add(this.lb_locthongtin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_TroVe_BCSDT);
            this.Controls.Add(this.btn_TrangChu_BCSDT);
            this.Controls.Add(this.lb_BCSuDungThuoc);
            this.Controls.Add(this.btn_Xuat_BCSDT);
            this.Controls.Add(this.lv_BCSuDungThuoc);
            this.Controls.Add(this.textBox14);
            this.DoubleBuffered = true;
            this.Name = "form_baocaosudungthuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Sử Dụng Thuốc";
            this.Load += new System.EventHandler(this.form_baocaosudungthuoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_BCSuDungThuoc;
        private System.Windows.Forms.ColumnHeader cl_ThangSDT;
        private System.Windows.Forms.ColumnHeader cl_NamSDT;
        private System.Windows.Forms.ColumnHeader cl_TenThuoc;
        private System.Windows.Forms.ColumnHeader cl_SoLuongDung;
        private System.Windows.Forms.ColumnHeader cl_SoLanDung;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Button btn_Xuat_BCSDT;
        private System.Windows.Forms.Label lb_BCSuDungThuoc;
        private System.Windows.Forms.Button btn_TrangChu_BCSDT;
        private System.Windows.Forms.Button btn_TroVe_BCSDT;
        private System.Windows.Forms.Button btn_KetXuat_BCSDT;
        private System.Windows.Forms.Label lb_locthongtin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.ComboBox cbx_Thuoc;
        private System.Windows.Forms.RadioButton rdbtn_Thang;
        private System.Windows.Forms.RadioButton rdbtn_TenThuoc;
        private System.Windows.Forms.RadioButton rdbtn_Nam;
        private System.Windows.Forms.ComboBox cbx_Thang;
        private System.Windows.Forms.ComboBox cbx_Nam;
        private System.Windows.Forms.Button btn_reset;
    }
}