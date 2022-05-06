
namespace InterfaceDesign
{
    partial class form_ketxuat
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
            this.btn_BCSDT = new System.Windows.Forms.Button();
            this.btn_TroVe_KetXuat = new System.Windows.Forms.Button();
            this.btn_TrangChu_KetXuat = new System.Windows.Forms.Button();
            this.btn_BCDT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_BCSDT
            // 
            this.btn_BCSDT.BackColor = System.Drawing.SystemColors.Control;
            this.btn_BCSDT.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BCSDT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_BCSDT.Location = new System.Drawing.Point(449, 403);
            this.btn_BCSDT.Name = "btn_BCSDT";
            this.btn_BCSDT.Size = new System.Drawing.Size(409, 141);
            this.btn_BCSDT.TabIndex = 1;
            this.btn_BCSDT.Text = "Báo Cáo Sử Dụng Thuốc";
            this.btn_BCSDT.UseVisualStyleBackColor = false;
            this.btn_BCSDT.Click += new System.EventHandler(this.btn_BCSDT_Click);
            // 
            // btn_TroVe_KetXuat
            // 
            this.btn_TroVe_KetXuat.BackgroundImage = global::InterfaceDesign.Properties.Resources.back;
            this.btn_TroVe_KetXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TroVe_KetXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TroVe_KetXuat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TroVe_KetXuat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TroVe_KetXuat.Location = new System.Drawing.Point(18, 67);
            this.btn_TroVe_KetXuat.Name = "btn_TroVe_KetXuat";
            this.btn_TroVe_KetXuat.Size = new System.Drawing.Size(35, 35);
            this.btn_TroVe_KetXuat.TabIndex = 27;
            this.btn_TroVe_KetXuat.UseVisualStyleBackColor = true;
            this.btn_TroVe_KetXuat.Click += new System.EventHandler(this.btn_TroVe_KetXuat_Click);
            // 
            // btn_TrangChu_KetXuat
            // 
            this.btn_TrangChu_KetXuat.BackgroundImage = global::InterfaceDesign.Properties.Resources.home;
            this.btn_TrangChu_KetXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TrangChu_KetXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TrangChu_KetXuat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrangChu_KetXuat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TrangChu_KetXuat.Location = new System.Drawing.Point(18, 12);
            this.btn_TrangChu_KetXuat.Name = "btn_TrangChu_KetXuat";
            this.btn_TrangChu_KetXuat.Size = new System.Drawing.Size(39, 39);
            this.btn_TrangChu_KetXuat.TabIndex = 26;
            this.btn_TrangChu_KetXuat.UseVisualStyleBackColor = true;
            this.btn_TrangChu_KetXuat.Click += new System.EventHandler(this.btn_TrangChu_KetXuat_Click);
            // 
            // btn_BCDT
            // 
            this.btn_BCDT.BackColor = System.Drawing.SystemColors.Control;
            this.btn_BCDT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_BCDT.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BCDT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_BCDT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BCDT.Location = new System.Drawing.Point(449, 169);
            this.btn_BCDT.Name = "btn_BCDT";
            this.btn_BCDT.Size = new System.Drawing.Size(409, 141);
            this.btn_BCDT.TabIndex = 0;
            this.btn_BCDT.Text = "Báo Cáo Doanh Thu";
            this.btn_BCDT.UseVisualStyleBackColor = false;
            this.btn_BCDT.Click += new System.EventHandler(this.btn_BCDT_Click);
            // 
            // form_ketxuat
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.ControlBox = false;
            this.Controls.Add(this.btn_TroVe_KetXuat);
            this.Controls.Add(this.btn_TrangChu_KetXuat);
            this.Controls.Add(this.btn_BCSDT);
            this.Controls.Add(this.btn_BCDT);
            this.Name = "form_ketxuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết Xuất";
            this.Load += new System.EventHandler(this.form_ketxuat_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_BCDT;
        private System.Windows.Forms.Button btn_BCSDT;
        private System.Windows.Forms.Button btn_TroVe_KetXuat;
        private System.Windows.Forms.Button btn_TrangChu_KetXuat;
    }
}