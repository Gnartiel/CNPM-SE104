
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_tracuu));
            this.lb_TraCuuBN = new System.Windows.Forms.Label();
            this.dtbx_NgayKham = new System.Windows.Forms.DateTimePicker();
            this.cbx_LoaiBenh = new System.Windows.Forms.ComboBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.lv_TraCuuBN = new System.Windows.Forms.ListView();
            this.cl_HoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_NgayKham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_TrieuChung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_TrangChu_TraCuu = new System.Windows.Forms.Button();
            this.btn_TroVe_TraCuu = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.rdbtn_HoTen = new System.Windows.Forms.RadioButton();
            this.rdbtn_NgayKham = new System.Windows.Forms.RadioButton();
            this.rdbtn_LoaiBenh = new System.Windows.Forms.RadioButton();
            this.cbx_HoTen = new System.Windows.Forms.ComboBox();
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
            this.cl_HoTen,
            this.cl_NgayKham,
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
            // cl_HoTen
            // 
            this.cl_HoTen.Text = "Họ tên";
            this.cl_HoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_HoTen.Width = 406;
            // 
            // cl_NgayKham
            // 
            this.cl_NgayKham.Text = "Ngày khám";
            this.cl_NgayKham.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_NgayKham.Width = 224;
            // 
            // cl_TrieuChung
            // 
            this.cl_TrieuChung.Text = "Triệu chứng";
            this.cl_TrieuChung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_TrieuChung.Width = 582;
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
            this.btn_TrangChu_TraCuu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_TrangChu_TraCuu.BackgroundImage")));
            this.btn_TrangChu_TraCuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TrangChu_TraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TrangChu_TraCuu.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrangChu_TraCuu.Location = new System.Drawing.Point(12, 12);
            this.btn_TrangChu_TraCuu.Name = "btn_TrangChu_TraCuu";
            this.btn_TrangChu_TraCuu.Size = new System.Drawing.Size(52, 48);
            this.btn_TrangChu_TraCuu.TabIndex = 18;
            this.btn_TrangChu_TraCuu.Text = " ";
            this.btn_TrangChu_TraCuu.UseVisualStyleBackColor = false;
            this.btn_TrangChu_TraCuu.Click += new System.EventHandler(this.btn_TrangChu_TraCuu_Click);
            // 
            // btn_TroVe_TraCuu
            // 
            this.btn_TroVe_TraCuu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TroVe_TraCuu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_TroVe_TraCuu.BackgroundImage")));
            this.btn_TroVe_TraCuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TroVe_TraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TroVe_TraCuu.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TroVe_TraCuu.Location = new System.Drawing.Point(12, 72);
            this.btn_TroVe_TraCuu.Name = "btn_TroVe_TraCuu";
            this.btn_TroVe_TraCuu.Size = new System.Drawing.Size(52, 48);
            this.btn_TroVe_TraCuu.TabIndex = 21;
            this.btn_TroVe_TraCuu.Text = " ";
            this.btn_TroVe_TraCuu.UseVisualStyleBackColor = false;
            this.btn_TroVe_TraCuu.Click += new System.EventHandler(this.btn_TroVe_TraCuu_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.White;
            this.btn_Thoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.BackgroundImage")));
            this.btn_Thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Thoat.Location = new System.Drawing.Point(12, 141);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(52, 48);
            this.btn_Thoat.TabIndex = 96;
            this.btn_Thoat.Text = " ";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // rdbtn_HoTen
            // 
            this.rdbtn_HoTen.AutoSize = true;
            this.rdbtn_HoTen.BackColor = System.Drawing.SystemColors.Window;
            this.rdbtn_HoTen.Checked = true;
            this.rdbtn_HoTen.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.rdbtn_HoTen.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rdbtn_HoTen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbtn_HoTen.Location = new System.Drawing.Point(141, 102);
            this.rdbtn_HoTen.Name = "rdbtn_HoTen";
            this.rdbtn_HoTen.Size = new System.Drawing.Size(104, 31);
            this.rdbtn_HoTen.TabIndex = 97;
            this.rdbtn_HoTen.TabStop = true;
            this.rdbtn_HoTen.Text = "Họ tên:";
            this.rdbtn_HoTen.UseVisualStyleBackColor = false;
            // 
            // rdbtn_NgayKham
            // 
            this.rdbtn_NgayKham.AutoSize = true;
            this.rdbtn_NgayKham.BackColor = System.Drawing.SystemColors.Window;
            this.rdbtn_NgayKham.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.rdbtn_NgayKham.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rdbtn_NgayKham.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbtn_NgayKham.Location = new System.Drawing.Point(558, 102);
            this.rdbtn_NgayKham.Name = "rdbtn_NgayKham";
            this.rdbtn_NgayKham.Size = new System.Drawing.Size(154, 31);
            this.rdbtn_NgayKham.TabIndex = 98;
            this.rdbtn_NgayKham.Text = "Ngày Khám:";
            this.rdbtn_NgayKham.UseVisualStyleBackColor = false;
            // 
            // rdbtn_LoaiBenh
            // 
            this.rdbtn_LoaiBenh.AutoSize = true;
            this.rdbtn_LoaiBenh.BackColor = System.Drawing.SystemColors.Window;
            this.rdbtn_LoaiBenh.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.rdbtn_LoaiBenh.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rdbtn_LoaiBenh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbtn_LoaiBenh.Location = new System.Drawing.Point(884, 102);
            this.rdbtn_LoaiBenh.Name = "rdbtn_LoaiBenh";
            this.rdbtn_LoaiBenh.Size = new System.Drawing.Size(140, 31);
            this.rdbtn_LoaiBenh.TabIndex = 99;
            this.rdbtn_LoaiBenh.Text = "Loại Bệnh:";
            this.rdbtn_LoaiBenh.UseVisualStyleBackColor = false;
            // 
            // cbx_HoTen
            // 
            this.cbx_HoTen.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_HoTen.FormattingEnabled = true;
            this.cbx_HoTen.Location = new System.Drawing.Point(141, 152);
            this.cbx_HoTen.Name = "cbx_HoTen";
            this.cbx_HoTen.Size = new System.Drawing.Size(337, 34);
            this.cbx_HoTen.TabIndex = 100;
            // 
            // form_tracuu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1338, 716);
            this.ControlBox = false;
            this.Controls.Add(this.cbx_HoTen);
            this.Controls.Add(this.rdbtn_LoaiBenh);
            this.Controls.Add(this.rdbtn_NgayKham);
            this.Controls.Add(this.rdbtn_HoTen);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_TroVe_TraCuu);
            this.Controls.Add(this.btn_TrangChu_TraCuu);
            this.Controls.Add(this.cbx_LoaiBenh);
            this.Controls.Add(this.dtbx_NgayKham);
            this.Controls.Add(this.lv_TraCuuBN);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.lb_TraCuuBN);
            this.Controls.Add(this.textBox4);
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.DateTimePicker dtbx_NgayKham;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.ListView lv_TraCuuBN;
        private System.Windows.Forms.ColumnHeader cl_HoTen;
        private System.Windows.Forms.ColumnHeader cl_NgayKham;
        private System.Windows.Forms.ColumnHeader cl_TrieuChung;
        private System.Windows.Forms.ComboBox cbx_LoaiBenh;
        private System.Windows.Forms.Button btn_TrangChu_TraCuu;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_TroVe_TraCuu;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.RadioButton rdbtn_HoTen;
        private System.Windows.Forms.RadioButton rdbtn_NgayKham;
        private System.Windows.Forms.RadioButton rdbtn_LoaiBenh;
        private System.Windows.Forms.ComboBox cbx_HoTen;
    }
}
