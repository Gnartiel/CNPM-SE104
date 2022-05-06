
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
            this.cl_MaThuoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_SoLuongDung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_SoLanDung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.btn_Xuat_BCSDT = new System.Windows.Forms.Button();
            this.lb_BCSuDungThuoc = new System.Windows.Forms.Label();
            this.btn_TroVe_BCSDT = new System.Windows.Forms.Button();
            this.btn_TrangChu_BCSDT = new System.Windows.Forms.Button();
            this.btn_KetXuat_BCSDT = new System.Windows.Forms.Button();
            this.cbx_MaThuoc = new System.Windows.Forms.CheckBox();
            this.cbx_Nam = new System.Windows.Forms.CheckBox();
            this.cbx_Thang = new System.Windows.Forms.CheckBox();
            this.lb_locthongtin = new System.Windows.Forms.Label();
            this.txtb_MaThuoc = new System.Windows.Forms.TextBox();
            this.txtb_NamSDT = new System.Windows.Forms.TextBox();
            this.txtb_ThangSDT = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lv_BCSuDungThuoc
            // 
            this.lv_BCSuDungThuoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_ThangSDT,
            this.cl_NamSDT,
            this.cl_MaThuoc,
            this.cl_SoLuongDung,
            this.cl_SoLanDung});
            this.lv_BCSuDungThuoc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_BCSuDungThuoc.FullRowSelect = true;
            this.lv_BCSuDungThuoc.GridLines = true;
            this.lv_BCSuDungThuoc.HideSelection = false;
            this.lv_BCSuDungThuoc.Location = new System.Drawing.Point(619, 123);
            this.lv_BCSuDungThuoc.Name = "lv_BCSuDungThuoc";
            this.lv_BCSuDungThuoc.Size = new System.Drawing.Size(694, 570);
            this.lv_BCSuDungThuoc.TabIndex = 20;
            this.lv_BCSuDungThuoc.UseCompatibleStateImageBehavior = false;
            this.lv_BCSuDungThuoc.View = System.Windows.Forms.View.Details;
            this.lv_BCSuDungThuoc.VirtualMode = true;
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
            // cl_MaThuoc
            // 
            this.cl_MaThuoc.Text = "Mã Thuốc";
            this.cl_MaThuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_MaThuoc.Width = 174;
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
            this.textBox14.Location = new System.Drawing.Point(590, 34);
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
            this.btn_Xuat_BCSDT.Location = new System.Drawing.Point(1148, 51);
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
            this.lb_BCSuDungThuoc.Location = new System.Drawing.Point(652, 16);
            this.lb_BCSuDungThuoc.Name = "lb_BCSuDungThuoc";
            this.lb_BCSuDungThuoc.Size = new System.Drawing.Size(419, 35);
            this.lb_BCSuDungThuoc.TabIndex = 22;
            this.lb_BCSuDungThuoc.Text = "BÁO CÁO SỬ DỤNG THUỐC";
            this.lb_BCSuDungThuoc.Click += new System.EventHandler(this.label7_Click);
            // 
            // btn_TroVe_BCSDT
            // 
            this.btn_TroVe_BCSDT.BackgroundImage = global::InterfaceDesign.Properties.Resources.back;
            this.btn_TroVe_BCSDT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TroVe_BCSDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TroVe_BCSDT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TroVe_BCSDT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TroVe_BCSDT.Location = new System.Drawing.Point(18, 61);
            this.btn_TroVe_BCSDT.Name = "btn_TroVe_BCSDT";
            this.btn_TroVe_BCSDT.Size = new System.Drawing.Size(35, 35);
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
            this.btn_TrangChu_BCSDT.Size = new System.Drawing.Size(39, 39);
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
            // 
            // cbx_MaThuoc
            // 
            this.cbx_MaThuoc.AutoSize = true;
            this.cbx_MaThuoc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbx_MaThuoc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_MaThuoc.Location = new System.Drawing.Point(133, 381);
            this.cbx_MaThuoc.Name = "cbx_MaThuoc";
            this.cbx_MaThuoc.Size = new System.Drawing.Size(139, 31);
            this.cbx_MaThuoc.TabIndex = 38;
            this.cbx_MaThuoc.Text = "Mã Thuốc:";
            this.cbx_MaThuoc.UseVisualStyleBackColor = false;
            // 
            // cbx_Nam
            // 
            this.cbx_Nam.AutoSize = true;
            this.cbx_Nam.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbx_Nam.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Nam.Location = new System.Drawing.Point(133, 313);
            this.cbx_Nam.Name = "cbx_Nam";
            this.cbx_Nam.Size = new System.Drawing.Size(86, 31);
            this.cbx_Nam.TabIndex = 37;
            this.cbx_Nam.Text = "Năm:";
            this.cbx_Nam.UseVisualStyleBackColor = false;
            // 
            // cbx_Thang
            // 
            this.cbx_Thang.AutoSize = true;
            this.cbx_Thang.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbx_Thang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Thang.Location = new System.Drawing.Point(133, 245);
            this.cbx_Thang.Name = "cbx_Thang";
            this.cbx_Thang.Size = new System.Drawing.Size(100, 31);
            this.cbx_Thang.TabIndex = 36;
            this.cbx_Thang.Text = "Tháng:";
            this.cbx_Thang.UseVisualStyleBackColor = false;
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
            // txtb_MaThuoc
            // 
            this.txtb_MaThuoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_MaThuoc.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_MaThuoc.Location = new System.Drawing.Point(303, 376);
            this.txtb_MaThuoc.Multiline = true;
            this.txtb_MaThuoc.Name = "txtb_MaThuoc";
            this.txtb_MaThuoc.Size = new System.Drawing.Size(190, 36);
            this.txtb_MaThuoc.TabIndex = 33;
            // 
            // txtb_NamSDT
            // 
            this.txtb_NamSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_NamSDT.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_NamSDT.Location = new System.Drawing.Point(303, 308);
            this.txtb_NamSDT.Multiline = true;
            this.txtb_NamSDT.Name = "txtb_NamSDT";
            this.txtb_NamSDT.Size = new System.Drawing.Size(100, 36);
            this.txtb_NamSDT.TabIndex = 32;
            // 
            // txtb_ThangSDT
            // 
            this.txtb_ThangSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_ThangSDT.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_ThangSDT.Location = new System.Drawing.Point(303, 240);
            this.txtb_ThangSDT.Multiline = true;
            this.txtb_ThangSDT.Name = "txtb_ThangSDT";
            this.txtb_ThangSDT.Size = new System.Drawing.Size(100, 36);
            this.txtb_ThangSDT.TabIndex = 31;
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
            // form_baocaosudungthuoc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.ControlBox = false;
            this.Controls.Add(this.btn_KetXuat_BCSDT);
            this.Controls.Add(this.cbx_MaThuoc);
            this.Controls.Add(this.cbx_Nam);
            this.Controls.Add(this.cbx_Thang);
            this.Controls.Add(this.lb_locthongtin);
            this.Controls.Add(this.txtb_MaThuoc);
            this.Controls.Add(this.txtb_NamSDT);
            this.Controls.Add(this.txtb_ThangSDT);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_TroVe_BCSDT);
            this.Controls.Add(this.btn_TrangChu_BCSDT);
            this.Controls.Add(this.lb_BCSuDungThuoc);
            this.Controls.Add(this.btn_Xuat_BCSDT);
            this.Controls.Add(this.lv_BCSuDungThuoc);
            this.Controls.Add(this.textBox14);
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
        private System.Windows.Forms.ColumnHeader cl_MaThuoc;
        private System.Windows.Forms.ColumnHeader cl_SoLuongDung;
        private System.Windows.Forms.ColumnHeader cl_SoLanDung;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Button btn_Xuat_BCSDT;
        private System.Windows.Forms.Label lb_BCSuDungThuoc;
        private System.Windows.Forms.Button btn_TrangChu_BCSDT;
        private System.Windows.Forms.Button btn_TroVe_BCSDT;
        private System.Windows.Forms.Button btn_KetXuat_BCSDT;
        private System.Windows.Forms.CheckBox cbx_MaThuoc;
        private System.Windows.Forms.CheckBox cbx_Nam;
        private System.Windows.Forms.CheckBox cbx_Thang;
        private System.Windows.Forms.Label lb_locthongtin;
        private System.Windows.Forms.TextBox txtb_MaThuoc;
        private System.Windows.Forms.TextBox txtb_NamSDT;
        private System.Windows.Forms.TextBox txtb_ThangSDT;
        private System.Windows.Forms.TextBox textBox1;
    }
}