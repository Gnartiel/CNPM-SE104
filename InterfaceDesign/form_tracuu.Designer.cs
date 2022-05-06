
namespace InterfaceDesign
{
    partial class form_tracuu
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
            this.lb_TraCuuBN = new System.Windows.Forms.Label();
            this.txtb_HoTen = new System.Windows.Forms.TextBox();
            this.ckb_HoTen = new System.Windows.Forms.CheckBox();
            this.ckb_NgayKham = new System.Windows.Forms.CheckBox();
            this.dtbx_NgayKham = new System.Windows.Forms.DateTimePicker();
            this.cbx_LoaiBenh = new System.Windows.Forms.ComboBox();
            this.ckb_LoaiBenh = new System.Windows.Forms.CheckBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.lv_TraCuuBN = new System.Windows.Forms.ListView();
            this.cl_STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_HoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_NgayKham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_LoaiBenh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_TrieuChung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_TrangChu_TraCuu = new System.Windows.Forms.Button();
            this.btn_TroVe_TraCuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_TraCuuBN
            // 
            this.lb_TraCuuBN.AutoSize = true;
            this.lb_TraCuuBN.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TraCuuBN.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_TraCuuBN.Location = new System.Drawing.Point(466, 35);
            this.lb_TraCuuBN.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lb_TraCuuBN.Name = "lb_TraCuuBN";
            this.lb_TraCuuBN.Size = new System.Drawing.Size(343, 35);
            this.lb_TraCuuBN.TabIndex = 1;
            this.lb_TraCuuBN.Text = "TRA CỨU BỆNH NHÂN";
            this.lb_TraCuuBN.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtb_HoTen
            // 
            this.txtb_HoTen.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_HoTen.Location = new System.Drawing.Point(141, 152);
            this.txtb_HoTen.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtb_HoTen.Multiline = true;
            this.txtb_HoTen.Name = "txtb_HoTen";
            this.txtb_HoTen.Size = new System.Drawing.Size(335, 34);
            this.txtb_HoTen.TabIndex = 6;
            // 
            // ckb_HoTen
            // 
            this.ckb_HoTen.AutoSize = true;
            this.ckb_HoTen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ckb_HoTen.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_HoTen.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ckb_HoTen.Location = new System.Drawing.Point(141, 103);
            this.ckb_HoTen.Name = "ckb_HoTen";
            this.ckb_HoTen.Size = new System.Drawing.Size(105, 31);
            this.ckb_HoTen.TabIndex = 7;
            this.ckb_HoTen.Text = "Họ tên:";
            this.ckb_HoTen.UseVisualStyleBackColor = false;
            // 
            // ckb_NgayKham
            // 
            this.ckb_NgayKham.AutoSize = true;
            this.ckb_NgayKham.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ckb_NgayKham.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_NgayKham.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ckb_NgayKham.Location = new System.Drawing.Point(558, 103);
            this.ckb_NgayKham.Name = "ckb_NgayKham";
            this.ckb_NgayKham.Size = new System.Drawing.Size(150, 31);
            this.ckb_NgayKham.TabIndex = 8;
            this.ckb_NgayKham.Text = "Ngày khám:";
            this.ckb_NgayKham.UseVisualStyleBackColor = false;
            // 
            // dtbx_NgayKham
            // 
            this.dtbx_NgayKham.CustomFormat = "dd/MM/yyyy";
            this.dtbx_NgayKham.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbx_NgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbx_NgayKham.Location = new System.Drawing.Point(558, 152);
            this.dtbx_NgayKham.Name = "dtbx_NgayKham";
            this.dtbx_NgayKham.Size = new System.Drawing.Size(251, 34);
            this.dtbx_NgayKham.TabIndex = 7;
            // 
            // cbx_LoaiBenh
            // 
            this.cbx_LoaiBenh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_LoaiBenh.FormattingEnabled = true;
            this.cbx_LoaiBenh.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d"});
            this.cbx_LoaiBenh.Location = new System.Drawing.Point(884, 152);
            this.cbx_LoaiBenh.Name = "cbx_LoaiBenh";
            this.cbx_LoaiBenh.Size = new System.Drawing.Size(357, 34);
            this.cbx_LoaiBenh.TabIndex = 14;
            this.cbx_LoaiBenh.SelectedIndexChanged += new System.EventHandler(this.cbx_LoaiBenh_SelectedIndexChanged);
            // 
            // ckb_LoaiBenh
            // 
            this.ckb_LoaiBenh.AutoSize = true;
            this.ckb_LoaiBenh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ckb_LoaiBenh.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_LoaiBenh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ckb_LoaiBenh.Location = new System.Drawing.Point(884, 101);
            this.ckb_LoaiBenh.Name = "ckb_LoaiBenh";
            this.ckb_LoaiBenh.Size = new System.Drawing.Size(137, 31);
            this.ckb_LoaiBenh.TabIndex = 8;
            this.ckb_LoaiBenh.Text = "Loại bệnh:";
            this.ckb_LoaiBenh.UseVisualStyleBackColor = false;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.SystemColors.Control;
            this.btn_TimKiem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_TimKiem.Location = new System.Drawing.Point(613, 269);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(143, 48);
            this.btn_TimKiem.TabIndex = 0;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // lv_TraCuuBN
            // 
            this.lv_TraCuuBN.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_STT,
            this.cl_HoTen,
            this.cl_NgayKham,
            this.cl_LoaiBenh,
            this.cl_TrieuChung});
            this.lv_TraCuuBN.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_TraCuuBN.GridLines = true;
            this.lv_TraCuuBN.HideSelection = false;
            this.lv_TraCuuBN.Location = new System.Drawing.Point(69, 330);
            this.lv_TraCuuBN.Name = "lv_TraCuuBN";
            this.lv_TraCuuBN.Size = new System.Drawing.Size(1221, 350);
            this.lv_TraCuuBN.TabIndex = 13;
            this.lv_TraCuuBN.UseCompatibleStateImageBehavior = false;
            this.lv_TraCuuBN.View = System.Windows.Forms.View.Details;
            // 
            // cl_STT
            // 
            this.cl_STT.Text = "STT";
            this.cl_STT.Width = 59;
            // 
            // cl_HoTen
            // 
            this.cl_HoTen.Text = "Họ tên";
            this.cl_HoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_HoTen.Width = 266;
            // 
            // cl_NgayKham
            // 
            this.cl_NgayKham.Text = "Ngày khám";
            this.cl_NgayKham.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_NgayKham.Width = 191;
            // 
            // cl_LoaiBenh
            // 
            this.cl_LoaiBenh.Text = "Loại bệnh";
            this.cl_LoaiBenh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_LoaiBenh.Width = 217;
            // 
            // cl_TrieuChung
            // 
            this.cl_TrieuChung.Text = "Triệu chứng";
            this.cl_TrieuChung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_TrieuChung.Width = 582;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(119, 92);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(383, 126);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(536, 92);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(292, 126);
            this.textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(861, 92);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(398, 126);
            this.textBox3.TabIndex = 17;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(81, 52);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(1209, 198);
            this.textBox4.TabIndex = 19;
            // 
            // btn_TrangChu_TraCuu
            // 
            this.btn_TrangChu_TraCuu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TrangChu_TraCuu.BackgroundImage = global::InterfaceDesign.Properties.Resources.home;
            this.btn_TrangChu_TraCuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TrangChu_TraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TrangChu_TraCuu.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrangChu_TraCuu.Location = new System.Drawing.Point(12, 12);
            this.btn_TrangChu_TraCuu.Name = "btn_TrangChu_TraCuu";
            this.btn_TrangChu_TraCuu.Size = new System.Drawing.Size(39, 39);
            this.btn_TrangChu_TraCuu.TabIndex = 18;
            this.btn_TrangChu_TraCuu.Text = " ";
            this.btn_TrangChu_TraCuu.UseVisualStyleBackColor = false;
            this.btn_TrangChu_TraCuu.Click += new System.EventHandler(this.btn_TrangChu_TraCuu_Click);
            // 
            // btn_TroVe_TraCuu
            // 
            this.btn_TroVe_TraCuu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TroVe_TraCuu.BackgroundImage = global::InterfaceDesign.Properties.Resources.back;
            this.btn_TroVe_TraCuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TroVe_TraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TroVe_TraCuu.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TroVe_TraCuu.Location = new System.Drawing.Point(12, 72);
            this.btn_TroVe_TraCuu.Name = "btn_TroVe_TraCuu";
            this.btn_TroVe_TraCuu.Size = new System.Drawing.Size(35, 35);
            this.btn_TroVe_TraCuu.TabIndex = 21;
            this.btn_TroVe_TraCuu.Text = " ";
            this.btn_TroVe_TraCuu.UseVisualStyleBackColor = false;
            this.btn_TroVe_TraCuu.Click += new System.EventHandler(this.btn_TroVe_TraCuu_Click);
            // 
            // form_tracuu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1344, 712);
            this.ControlBox = false;
            this.Controls.Add(this.btn_TroVe_TraCuu);
            this.Controls.Add(this.btn_TrangChu_TraCuu);
            this.Controls.Add(this.cbx_LoaiBenh);
            this.Controls.Add(this.ckb_LoaiBenh);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.ckb_NgayKham);
            this.Controls.Add(this.dtbx_NgayKham);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtb_HoTen);
            this.Controls.Add(this.ckb_HoTen);
            this.Controls.Add(this.lv_TraCuuBN);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.lb_TraCuuBN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "form_tracuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu bệnh nhân";
            this.Load += new System.EventHandler(this.form_tracuu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_TraCuuBN;
        private System.Windows.Forms.TextBox txtb_HoTen;
        private System.Windows.Forms.CheckBox ckb_HoTen;
        private System.Windows.Forms.CheckBox ckb_NgayKham;
        private System.Windows.Forms.DateTimePicker dtbx_NgayKham;
        private System.Windows.Forms.CheckBox ckb_LoaiBenh;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.ListView lv_TraCuuBN;
        private System.Windows.Forms.ColumnHeader cl_STT;
        private System.Windows.Forms.ColumnHeader cl_HoTen;
        private System.Windows.Forms.ColumnHeader cl_NgayKham;
        private System.Windows.Forms.ColumnHeader cl_LoaiBenh;
        private System.Windows.Forms.ColumnHeader cl_TrieuChung;
        private System.Windows.Forms.ComboBox cbx_LoaiBenh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_TrangChu_TraCuu;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_TroVe_TraCuu;
    }
}
