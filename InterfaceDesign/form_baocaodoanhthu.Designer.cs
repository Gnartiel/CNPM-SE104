
namespace InterfaceDesign
{
    partial class form_baocaodoanhthu
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
            this.lv_CTBCDoanhThu = new System.Windows.Forms.ListView();
            this.cl_NgayCTDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_ThangCTDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_NamCTDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_DoanhThu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_SoBenhNhan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_TyLe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_BCDoanhThu = new System.Windows.Forms.ListView();
            this.cl_ThangBCDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_NamBCDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_TongDoanhThu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtb_NamCTBC = new System.Windows.Forms.TextBox();
            this.txtb_ThangCTBC = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.btn_KetXuat_CTBC = new System.Windows.Forms.Button();
            this.lb_NamCTBC = new System.Windows.Forms.Label();
            this.lb_ThangCTBC = new System.Windows.Forms.Label();
            this.lb_CTBCDoanhThu = new System.Windows.Forms.Label();
            this.lb_BCDoanhThu = new System.Windows.Forms.Label();
            this.btn_TrangChu_BCDT = new System.Windows.Forms.Button();
            this.btn_TroVe_BCDT = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_KetXuat_BCDT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Xuat_BCDT = new System.Windows.Forms.Button();
            this.btn_Xuat_CTBCDT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_CTBCDoanhThu
            // 
            this.lv_CTBCDoanhThu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_NgayCTDT,
            this.cl_ThangCTDT,
            this.cl_NamCTDT,
            this.cl_DoanhThu,
            this.cl_SoBenhNhan,
            this.cl_TyLe});
            this.lv_CTBCDoanhThu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_CTBCDoanhThu.GridLines = true;
            this.lv_CTBCDoanhThu.HideSelection = false;
            this.lv_CTBCDoanhThu.Location = new System.Drawing.Point(677, 259);
            this.lv_CTBCDoanhThu.Name = "lv_CTBCDoanhThu";
            this.lv_CTBCDoanhThu.Size = new System.Drawing.Size(604, 431);
            this.lv_CTBCDoanhThu.TabIndex = 38;
            this.lv_CTBCDoanhThu.UseCompatibleStateImageBehavior = false;
            this.lv_CTBCDoanhThu.View = System.Windows.Forms.View.Details;
            this.lv_CTBCDoanhThu.VirtualMode = true;
            // 
            // cl_NgayCTDT
            // 
            this.cl_NgayCTDT.Text = "Ngày";
            this.cl_NgayCTDT.Width = 87;
            // 
            // cl_ThangCTDT
            // 
            this.cl_ThangCTDT.Text = "Tháng";
            this.cl_ThangCTDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_ThangCTDT.Width = 104;
            // 
            // cl_NamCTDT
            // 
            this.cl_NamCTDT.Text = "Năm";
            this.cl_NamCTDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_NamCTDT.Width = 87;
            // 
            // cl_DoanhThu
            // 
            this.cl_DoanhThu.Text = "Doanh Thu";
            this.cl_DoanhThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_DoanhThu.Width = 145;
            // 
            // cl_SoBenhNhan
            // 
            this.cl_SoBenhNhan.Text = "Số Bệnh Nhân";
            this.cl_SoBenhNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_SoBenhNhan.Width = 128;
            // 
            // cl_TyLe
            // 
            this.cl_TyLe.Text = "Tỷ Lệ";
            this.cl_TyLe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_TyLe.Width = 100;
            // 
            // lv_BCDoanhThu
            // 
            this.lv_BCDoanhThu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_ThangBCDT,
            this.cl_NamBCDT,
            this.cl_TongDoanhThu});
            this.lv_BCDoanhThu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_BCDoanhThu.GridLines = true;
            this.lv_BCDoanhThu.HideSelection = false;
            this.lv_BCDoanhThu.Location = new System.Drawing.Point(95, 259);
            this.lv_BCDoanhThu.Name = "lv_BCDoanhThu";
            this.lv_BCDoanhThu.Size = new System.Drawing.Size(508, 431);
            this.lv_BCDoanhThu.TabIndex = 37;
            this.lv_BCDoanhThu.UseCompatibleStateImageBehavior = false;
            this.lv_BCDoanhThu.View = System.Windows.Forms.View.Details;
            this.lv_BCDoanhThu.VirtualMode = true;
            // 
            // cl_ThangBCDT
            // 
            this.cl_ThangBCDT.Text = "Tháng";
            this.cl_ThangBCDT.Width = 108;
            // 
            // cl_NamBCDT
            // 
            this.cl_NamBCDT.Text = "Năm";
            this.cl_NamBCDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_NamBCDT.Width = 118;
            // 
            // cl_TongDoanhThu
            // 
            this.cl_TongDoanhThu.Text = "Tổng Doanh Thu";
            this.cl_TongDoanhThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_TongDoanhThu.Width = 292;
            // 
            // txtb_NamCTBC
            // 
            this.txtb_NamCTBC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_NamCTBC.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_NamCTBC.Location = new System.Drawing.Point(838, 156);
            this.txtb_NamCTBC.Multiline = true;
            this.txtb_NamCTBC.Name = "txtb_NamCTBC";
            this.txtb_NamCTBC.Size = new System.Drawing.Size(104, 34);
            this.txtb_NamCTBC.TabIndex = 30;
            this.txtb_NamCTBC.TextChanged += new System.EventHandler(this.textBox16_TextChanged);
            // 
            // txtb_ThangCTBC
            // 
            this.txtb_ThangCTBC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_ThangCTBC.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_ThangCTBC.Location = new System.Drawing.Point(838, 92);
            this.txtb_ThangCTBC.Multiline = true;
            this.txtb_ThangCTBC.Name = "txtb_ThangCTBC";
            this.txtb_ThangCTBC.Size = new System.Drawing.Size(104, 34);
            this.txtb_ThangCTBC.TabIndex = 28;
            // 
            // textBox20
            // 
            this.textBox20.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox20.Enabled = false;
            this.textBox20.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox20.Location = new System.Drawing.Point(77, 31);
            this.textBox20.Multiline = true;
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(549, 678);
            this.textBox20.TabIndex = 39;
            // 
            // textBox21
            // 
            this.textBox21.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox21.Enabled = false;
            this.textBox21.Location = new System.Drawing.Point(653, 31);
            this.textBox21.Multiline = true;
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(639, 678);
            this.textBox21.TabIndex = 40;
            // 
            // btn_KetXuat_CTBC
            // 
            this.btn_KetXuat_CTBC.BackColor = System.Drawing.SystemColors.Control;
            this.btn_KetXuat_CTBC.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KetXuat_CTBC.Location = new System.Drawing.Point(1053, 79);
            this.btn_KetXuat_CTBC.Name = "btn_KetXuat_CTBC";
            this.btn_KetXuat_CTBC.Size = new System.Drawing.Size(130, 45);
            this.btn_KetXuat_CTBC.TabIndex = 36;
            this.btn_KetXuat_CTBC.Text = "Kết Xuất";
            this.btn_KetXuat_CTBC.UseVisualStyleBackColor = false;
            // 
            // lb_NamCTBC
            // 
            this.lb_NamCTBC.AutoSize = true;
            this.lb_NamCTBC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_NamCTBC.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NamCTBC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_NamCTBC.Location = new System.Drawing.Point(754, 156);
            this.lb_NamCTBC.Name = "lb_NamCTBC";
            this.lb_NamCTBC.Size = new System.Drawing.Size(64, 27);
            this.lb_NamCTBC.TabIndex = 29;
            this.lb_NamCTBC.Text = "Năm:";
            this.lb_NamCTBC.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_ThangCTBC
            // 
            this.lb_ThangCTBC.AutoSize = true;
            this.lb_ThangCTBC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_ThangCTBC.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThangCTBC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_ThangCTBC.Location = new System.Drawing.Point(754, 94);
            this.lb_ThangCTBC.Name = "lb_ThangCTBC";
            this.lb_ThangCTBC.Size = new System.Drawing.Size(78, 27);
            this.lb_ThangCTBC.TabIndex = 27;
            this.lb_ThangCTBC.Text = "Tháng:";
            // 
            // lb_CTBCDoanhThu
            // 
            this.lb_CTBCDoanhThu.AutoSize = true;
            this.lb_CTBCDoanhThu.BackColor = System.Drawing.SystemColors.Control;
            this.lb_CTBCDoanhThu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CTBCDoanhThu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_CTBCDoanhThu.Location = new System.Drawing.Point(744, 15);
            this.lb_CTBCDoanhThu.Name = "lb_CTBCDoanhThu";
            this.lb_CTBCDoanhThu.Size = new System.Drawing.Size(490, 35);
            this.lb_CTBCDoanhThu.TabIndex = 22;
            this.lb_CTBCDoanhThu.Text = "CHI TIẾT BÁO CÁO DOANH THU";
            // 
            // lb_BCDoanhThu
            // 
            this.lb_BCDoanhThu.AutoSize = true;
            this.lb_BCDoanhThu.BackColor = System.Drawing.SystemColors.Control;
            this.lb_BCDoanhThu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BCDoanhThu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_BCDoanhThu.Location = new System.Drawing.Point(113, 10);
            this.lb_BCDoanhThu.Name = "lb_BCDoanhThu";
            this.lb_BCDoanhThu.Size = new System.Drawing.Size(464, 35);
            this.lb_BCDoanhThu.TabIndex = 21;
            this.lb_BCDoanhThu.Text = "BÁO CÁO DOANH THU THÁNG";
            // 
            // btn_TrangChu_BCDT
            // 
            this.btn_TrangChu_BCDT.BackgroundImage = global::InterfaceDesign.Properties.Resources.home;
            this.btn_TrangChu_BCDT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TrangChu_BCDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TrangChu_BCDT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrangChu_BCDT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TrangChu_BCDT.Location = new System.Drawing.Point(18, 12);
            this.btn_TrangChu_BCDT.Name = "btn_TrangChu_BCDT";
            this.btn_TrangChu_BCDT.Size = new System.Drawing.Size(39, 39);
            this.btn_TrangChu_BCDT.TabIndex = 41;
            this.btn_TrangChu_BCDT.UseVisualStyleBackColor = true;
            this.btn_TrangChu_BCDT.Click += new System.EventHandler(this.btn_TrangChu_BCDT_Click);
            // 
            // btn_TroVe_BCDT
            // 
            this.btn_TroVe_BCDT.BackgroundImage = global::InterfaceDesign.Properties.Resources.back;
            this.btn_TroVe_BCDT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TroVe_BCDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TroVe_BCDT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TroVe_BCDT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TroVe_BCDT.Location = new System.Drawing.Point(18, 60);
            this.btn_TroVe_BCDT.Name = "btn_TroVe_BCDT";
            this.btn_TroVe_BCDT.Size = new System.Drawing.Size(35, 35);
            this.btn_TroVe_BCDT.TabIndex = 42;
            this.btn_TroVe_BCDT.UseVisualStyleBackColor = true;
            this.btn_TroVe_BCDT.Click += new System.EventHandler(this.btn_TroVe_BCDT_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(200, 126);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 34);
            this.textBox1.TabIndex = 44;
            // 
            // btn_KetXuat_BCDT
            // 
            this.btn_KetXuat_BCDT.BackColor = System.Drawing.SystemColors.Control;
            this.btn_KetXuat_BCDT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KetXuat_BCDT.Location = new System.Drawing.Point(376, 79);
            this.btn_KetXuat_BCDT.Name = "btn_KetXuat_BCDT";
            this.btn_KetXuat_BCDT.Size = new System.Drawing.Size(130, 45);
            this.btn_KetXuat_BCDT.TabIndex = 45;
            this.btn_KetXuat_BCDT.Text = "Kết Xuất";
            this.btn_KetXuat_BCDT.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(128, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 27);
            this.label1.TabIndex = 43;
            this.label1.Text = "Năm:";
            // 
            // btn_Xuat_BCDT
            // 
            this.btn_Xuat_BCDT.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Xuat_BCDT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xuat_BCDT.Location = new System.Drawing.Point(376, 161);
            this.btn_Xuat_BCDT.Name = "btn_Xuat_BCDT";
            this.btn_Xuat_BCDT.Size = new System.Drawing.Size(130, 45);
            this.btn_Xuat_BCDT.TabIndex = 46;
            this.btn_Xuat_BCDT.Text = "Xuất File";
            this.btn_Xuat_BCDT.UseVisualStyleBackColor = false;
            // 
            // btn_Xuat_CTBCDT
            // 
            this.btn_Xuat_CTBCDT.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Xuat_CTBCDT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xuat_CTBCDT.Location = new System.Drawing.Point(1053, 161);
            this.btn_Xuat_CTBCDT.Name = "btn_Xuat_CTBCDT";
            this.btn_Xuat_CTBCDT.Size = new System.Drawing.Size(130, 45);
            this.btn_Xuat_CTBCDT.TabIndex = 47;
            this.btn_Xuat_CTBCDT.Text = "Xuất File";
            this.btn_Xuat_CTBCDT.UseVisualStyleBackColor = false;
            // 
            // form_baocaodoanhthu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Xuat_CTBCDT);
            this.Controls.Add(this.btn_Xuat_BCDT);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_KetXuat_BCDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_TroVe_BCDT);
            this.Controls.Add(this.btn_TrangChu_BCDT);
            this.Controls.Add(this.lv_CTBCDoanhThu);
            this.Controls.Add(this.lv_BCDoanhThu);
            this.Controls.Add(this.txtb_NamCTBC);
            this.Controls.Add(this.txtb_ThangCTBC);
            this.Controls.Add(this.btn_KetXuat_CTBC);
            this.Controls.Add(this.lb_NamCTBC);
            this.Controls.Add(this.lb_ThangCTBC);
            this.Controls.Add(this.lb_CTBCDoanhThu);
            this.Controls.Add(this.lb_BCDoanhThu);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.textBox21);
            this.Name = "form_baocaodoanhthu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaoCaoDoanhThu";
            this.Load += new System.EventHandler(this.form_baocaodoanhthu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_CTBCDoanhThu;
        private System.Windows.Forms.ColumnHeader cl_NgayCTDT;
        private System.Windows.Forms.ColumnHeader cl_ThangCTDT;
        private System.Windows.Forms.ColumnHeader cl_NamCTDT;
        private System.Windows.Forms.ColumnHeader cl_DoanhThu;
        private System.Windows.Forms.ColumnHeader cl_SoBenhNhan;
        private System.Windows.Forms.ColumnHeader cl_TyLe;
        private System.Windows.Forms.ListView lv_BCDoanhThu;
        private System.Windows.Forms.ColumnHeader cl_ThangBCDT;
        private System.Windows.Forms.ColumnHeader cl_NamBCDT;
        private System.Windows.Forms.ColumnHeader cl_TongDoanhThu;
        private System.Windows.Forms.TextBox txtb_NamCTBC;
        private System.Windows.Forms.TextBox txtb_ThangCTBC;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.Button btn_KetXuat_CTBC;
        private System.Windows.Forms.Label lb_NamCTBC;
        private System.Windows.Forms.Label lb_ThangCTBC;
        private System.Windows.Forms.Label lb_CTBCDoanhThu;
        private System.Windows.Forms.Label lb_BCDoanhThu;
        private System.Windows.Forms.Button btn_TrangChu_BCDT;
        private System.Windows.Forms.Button btn_TroVe_BCDT;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_KetXuat_BCDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Xuat_BCDT;
        private System.Windows.Forms.Button btn_Xuat_CTBCDT;
    }
}