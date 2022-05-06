
namespace InterfaceDesign
{
    partial class form_caidat
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
            this.lb_TienKham = new System.Windows.Forms.Label();
            this.lb_SoBNToiDa = new System.Windows.Forms.Label();
            this.lb_ThangSoBanLe = new System.Windows.Forms.Label();
            this.lb_CaiDat = new System.Windows.Forms.Label();
            this.lb_VAT = new System.Windows.Forms.Label();
            this.txtb_SoBNToiDa = new System.Windows.Forms.TextBox();
            this.txtb_TienKham = new System.Windows.Forms.TextBox();
            this.txtb_ThangSoBanLe = new System.Windows.Forms.TextBox();
            this.txtb_VAT = new System.Windows.Forms.TextBox();
            this.btn_MacDinh_CaiDat = new System.Windows.Forms.Button();
            this.btn_Luu_CaiDat = new System.Windows.Forms.Button();
            this.btn_TrangChu_CaiDat = new System.Windows.Forms.Button();
            this.btn_TroVe_CaiDat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_TienKham
            // 
            this.lb_TienKham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TienKham.AutoSize = true;
            this.lb_TienKham.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TienKham.Location = new System.Drawing.Point(61, 332);
            this.lb_TienKham.Name = "lb_TienKham";
            this.lb_TienKham.Size = new System.Drawing.Size(157, 34);
            this.lb_TienKham.TabIndex = 18;
            this.lb_TienKham.Text = "Tiền Khám:";
            this.lb_TienKham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_TienKham.Click += new System.EventHandler(this.lb_tienkham_Click);
            // 
            // lb_SoBNToiDa
            // 
            this.lb_SoBNToiDa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_SoBNToiDa.AutoSize = true;
            this.lb_SoBNToiDa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoBNToiDa.Location = new System.Drawing.Point(61, 273);
            this.lb_SoBNToiDa.Name = "lb_SoBNToiDa";
            this.lb_SoBNToiDa.Size = new System.Drawing.Size(290, 34);
            this.lb_SoBNToiDa.TabIndex = 17;
            this.lb_SoBNToiDa.Text = "Số Bệnh Nhân Tối Đa:";
            this.lb_SoBNToiDa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_SoBNToiDa.Click += new System.EventHandler(this.lb_sobenhnhantoida_Click);
            // 
            // lb_ThangSoBanLe
            // 
            this.lb_ThangSoBanLe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_ThangSoBanLe.AutoSize = true;
            this.lb_ThangSoBanLe.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThangSoBanLe.Location = new System.Drawing.Point(61, 396);
            this.lb_ThangSoBanLe.Name = "lb_ThangSoBanLe";
            this.lb_ThangSoBanLe.Size = new System.Drawing.Size(234, 34);
            this.lb_ThangSoBanLe.TabIndex = 16;
            this.lb_ThangSoBanLe.Text = "Thặng Số Bán Lẻ:";
            this.lb_ThangSoBanLe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_ThangSoBanLe.Click += new System.EventHandler(this.lb_thangsobanle_Click);
            // 
            // lb_CaiDat
            // 
            this.lb_CaiDat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_CaiDat.AutoSize = true;
            this.lb_CaiDat.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CaiDat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_CaiDat.Location = new System.Drawing.Point(578, 23);
            this.lb_CaiDat.Name = "lb_CaiDat";
            this.lb_CaiDat.Size = new System.Drawing.Size(152, 45);
            this.lb_CaiDat.TabIndex = 15;
            this.lb_CaiDat.Text = "Cài Đặt";
            this.lb_CaiDat.Click += new System.EventHandler(this.lb_caidat_Click);
            // 
            // lb_VAT
            // 
            this.lb_VAT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_VAT.AutoSize = true;
            this.lb_VAT.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_VAT.Location = new System.Drawing.Point(61, 459);
            this.lb_VAT.Name = "lb_VAT";
            this.lb_VAT.Size = new System.Drawing.Size(77, 34);
            this.lb_VAT.TabIndex = 14;
            this.lb_VAT.Text = "VAT:";
            this.lb_VAT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_VAT.Click += new System.EventHandler(this.lb_vat_Click);
            // 
            // txtb_SoBNToiDa
            // 
            this.txtb_SoBNToiDa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_SoBNToiDa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_SoBNToiDa.Location = new System.Drawing.Point(387, 266);
            this.txtb_SoBNToiDa.Multiline = true;
            this.txtb_SoBNToiDa.Name = "txtb_SoBNToiDa";
            this.txtb_SoBNToiDa.Size = new System.Drawing.Size(659, 41);
            this.txtb_SoBNToiDa.TabIndex = 19;
            this.txtb_SoBNToiDa.Text = "40";
            this.txtb_SoBNToiDa.TextChanged += new System.EventHandler(this.txt_sobenhnhantoida_TextChanged);
            // 
            // txtb_TienKham
            // 
            this.txtb_TienKham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_TienKham.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_TienKham.Location = new System.Drawing.Point(387, 325);
            this.txtb_TienKham.Multiline = true;
            this.txtb_TienKham.Name = "txtb_TienKham";
            this.txtb_TienKham.Size = new System.Drawing.Size(659, 41);
            this.txtb_TienKham.TabIndex = 20;
            this.txtb_TienKham.Text = "300000";
            this.txtb_TienKham.TextChanged += new System.EventHandler(this.txt_tienkham_TextChanged);
            // 
            // txtb_ThangSoBanLe
            // 
            this.txtb_ThangSoBanLe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_ThangSoBanLe.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_ThangSoBanLe.Location = new System.Drawing.Point(387, 389);
            this.txtb_ThangSoBanLe.Multiline = true;
            this.txtb_ThangSoBanLe.Name = "txtb_ThangSoBanLe";
            this.txtb_ThangSoBanLe.Size = new System.Drawing.Size(659, 41);
            this.txtb_ThangSoBanLe.TabIndex = 21;
            this.txtb_ThangSoBanLe.Text = "0.1";
            this.txtb_ThangSoBanLe.TextChanged += new System.EventHandler(this.txt_thangsobanle_TextChanged);
            // 
            // txtb_VAT
            // 
            this.txtb_VAT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_VAT.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_VAT.Location = new System.Drawing.Point(387, 452);
            this.txtb_VAT.Multiline = true;
            this.txtb_VAT.Name = "txtb_VAT";
            this.txtb_VAT.Size = new System.Drawing.Size(659, 41);
            this.txtb_VAT.TabIndex = 22;
            this.txtb_VAT.Text = "0.05";
            this.txtb_VAT.TextChanged += new System.EventHandler(this.txt_vat_TextChanged);
            // 
            // btn_MacDinh_CaiDat
            // 
            this.btn_MacDinh_CaiDat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MacDinh_CaiDat.BackColor = System.Drawing.SystemColors.Control;
            this.btn_MacDinh_CaiDat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_MacDinh_CaiDat.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MacDinh_CaiDat.Location = new System.Drawing.Point(1118, 571);
            this.btn_MacDinh_CaiDat.Name = "btn_MacDinh_CaiDat";
            this.btn_MacDinh_CaiDat.Size = new System.Drawing.Size(147, 54);
            this.btn_MacDinh_CaiDat.TabIndex = 23;
            this.btn_MacDinh_CaiDat.Text = "Mặc định";
            this.btn_MacDinh_CaiDat.UseVisualStyleBackColor = false;
            this.btn_MacDinh_CaiDat.Click += new System.EventHandler(this.btn_datlai_Click);
            // 
            // btn_Luu_CaiDat
            // 
            this.btn_Luu_CaiDat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Luu_CaiDat.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Luu_CaiDat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Luu_CaiDat.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu_CaiDat.Location = new System.Drawing.Point(869, 571);
            this.btn_Luu_CaiDat.Name = "btn_Luu_CaiDat";
            this.btn_Luu_CaiDat.Size = new System.Drawing.Size(147, 54);
            this.btn_Luu_CaiDat.TabIndex = 24;
            this.btn_Luu_CaiDat.Text = "Lưu";
            this.btn_Luu_CaiDat.UseVisualStyleBackColor = false;
            this.btn_Luu_CaiDat.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_TrangChu_CaiDat
            // 
            this.btn_TrangChu_CaiDat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TrangChu_CaiDat.BackgroundImage = global::InterfaceDesign.Properties.Resources.home;
            this.btn_TrangChu_CaiDat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TrangChu_CaiDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TrangChu_CaiDat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrangChu_CaiDat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_TrangChu_CaiDat.Location = new System.Drawing.Point(12, 12);
            this.btn_TrangChu_CaiDat.Name = "btn_TrangChu_CaiDat";
            this.btn_TrangChu_CaiDat.Size = new System.Drawing.Size(39, 39);
            this.btn_TrangChu_CaiDat.TabIndex = 65;
            this.btn_TrangChu_CaiDat.UseVisualStyleBackColor = false;
            this.btn_TrangChu_CaiDat.Click += new System.EventHandler(this.btn_TrangChu_CaiDat_Click);
            // 
            // btn_TroVe_CaiDat
            // 
            this.btn_TroVe_CaiDat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TroVe_CaiDat.BackgroundImage = global::InterfaceDesign.Properties.Resources.back;
            this.btn_TroVe_CaiDat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TroVe_CaiDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TroVe_CaiDat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TroVe_CaiDat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_TroVe_CaiDat.Location = new System.Drawing.Point(12, 57);
            this.btn_TroVe_CaiDat.Name = "btn_TroVe_CaiDat";
            this.btn_TroVe_CaiDat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_TroVe_CaiDat.Size = new System.Drawing.Size(35, 35);
            this.btn_TroVe_CaiDat.TabIndex = 69;
            this.btn_TroVe_CaiDat.Text = " ";
            this.btn_TroVe_CaiDat.UseVisualStyleBackColor = false;
            this.btn_TroVe_CaiDat.Click += new System.EventHandler(this.btn_TroVe_CaiDat_Click);
            // 
            // form_caidat
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.ControlBox = false;
            this.Controls.Add(this.btn_TroVe_CaiDat);
            this.Controls.Add(this.btn_TrangChu_CaiDat);
            this.Controls.Add(this.btn_Luu_CaiDat);
            this.Controls.Add(this.btn_MacDinh_CaiDat);
            this.Controls.Add(this.txtb_VAT);
            this.Controls.Add(this.txtb_ThangSoBanLe);
            this.Controls.Add(this.txtb_TienKham);
            this.Controls.Add(this.txtb_SoBNToiDa);
            this.Controls.Add(this.lb_TienKham);
            this.Controls.Add(this.lb_SoBNToiDa);
            this.Controls.Add(this.lb_ThangSoBanLe);
            this.Controls.Add(this.lb_CaiDat);
            this.Controls.Add(this.lb_VAT);
            this.Name = "form_caidat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cài Đặt";
            this.Load += new System.EventHandler(this.form_caidat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_TienKham;
        private System.Windows.Forms.Label lb_SoBNToiDa;
        private System.Windows.Forms.Label lb_ThangSoBanLe;
        private System.Windows.Forms.Label lb_CaiDat;
        private System.Windows.Forms.Label lb_VAT;
        private System.Windows.Forms.TextBox txtb_SoBNToiDa;
        private System.Windows.Forms.TextBox txtb_TienKham;
        private System.Windows.Forms.TextBox txtb_ThangSoBanLe;
        private System.Windows.Forms.TextBox txtb_VAT;
        private System.Windows.Forms.Button btn_MacDinh_CaiDat;
        private System.Windows.Forms.Button btn_Luu_CaiDat;
        private System.Windows.Forms.Button btn_TrangChu_CaiDat;
        private System.Windows.Forms.Button btn_TroVe_CaiDat;
    }
}