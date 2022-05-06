
namespace InterfaceDesign
{
    partial class form_manhinhchinh
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
            this.btn_DanhSach = new System.Windows.Forms.Button();
            this.btn_TraCuu = new System.Windows.Forms.Button();
            this.btn_CaiDat = new System.Windows.Forms.Button();
            this.btn_KetXuat = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_DanhSach
            // 
            this.btn_DanhSach.BackColor = System.Drawing.SystemColors.Control;
            this.btn_DanhSach.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.btn_DanhSach.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_DanhSach.Location = new System.Drawing.Point(380, 200);
            this.btn_DanhSach.Margin = new System.Windows.Forms.Padding(5);
            this.btn_DanhSach.Name = "btn_DanhSach";
            this.btn_DanhSach.Size = new System.Drawing.Size(210, 120);
            this.btn_DanhSach.TabIndex = 0;
            this.btn_DanhSach.Text = "Danh sách";
            this.btn_DanhSach.UseVisualStyleBackColor = false;
            this.btn_DanhSach.Click += new System.EventHandler(this.btn_DanhSach_Click);
            // 
            // btn_TraCuu
            // 
            this.btn_TraCuu.BackColor = System.Drawing.SystemColors.Control;
            this.btn_TraCuu.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.btn_TraCuu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_TraCuu.Location = new System.Drawing.Point(380, 373);
            this.btn_TraCuu.Margin = new System.Windows.Forms.Padding(5);
            this.btn_TraCuu.Name = "btn_TraCuu";
            this.btn_TraCuu.Size = new System.Drawing.Size(210, 120);
            this.btn_TraCuu.TabIndex = 2;
            this.btn_TraCuu.Text = "Tra cứu";
            this.btn_TraCuu.UseVisualStyleBackColor = false;
            this.btn_TraCuu.Click += new System.EventHandler(this.btn_TraCuu_Click);
            // 
            // btn_CaiDat
            // 
            this.btn_CaiDat.BackColor = System.Drawing.SystemColors.Control;
            this.btn_CaiDat.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.btn_CaiDat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_CaiDat.Location = new System.Drawing.Point(818, 373);
            this.btn_CaiDat.Margin = new System.Windows.Forms.Padding(5);
            this.btn_CaiDat.Name = "btn_CaiDat";
            this.btn_CaiDat.Size = new System.Drawing.Size(210, 120);
            this.btn_CaiDat.TabIndex = 3;
            this.btn_CaiDat.Text = "Cài đặt";
            this.btn_CaiDat.UseVisualStyleBackColor = false;
            this.btn_CaiDat.Click += new System.EventHandler(this.btn_CaiDat_Click);
            // 
            // btn_KetXuat
            // 
            this.btn_KetXuat.BackColor = System.Drawing.SystemColors.Control;
            this.btn_KetXuat.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.btn_KetXuat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_KetXuat.Location = new System.Drawing.Point(818, 200);
            this.btn_KetXuat.Margin = new System.Windows.Forms.Padding(5);
            this.btn_KetXuat.Name = "btn_KetXuat";
            this.btn_KetXuat.Size = new System.Drawing.Size(210, 120);
            this.btn_KetXuat.TabIndex = 4;
            this.btn_KetXuat.Text = "Kết xuất";
            this.btn_KetXuat.UseVisualStyleBackColor = false;
            this.btn_KetXuat.Click += new System.EventHandler(this.btn_KetXuat_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.btn_Thoat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Thoat.Location = new System.Drawing.Point(587, 598);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(212, 72);
            this.btn_Thoat.TabIndex = 5;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // form_manhinhchinh
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_KetXuat);
            this.Controls.Add(this.btn_CaiDat);
            this.Controls.Add(this.btn_TraCuu);
            this.Controls.Add(this.btn_DanhSach);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "form_manhinhchinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn Hính Chính";
            this.Load += new System.EventHandler(this.form_manhinhchinh_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DanhSach;
        private System.Windows.Forms.Button btn_TraCuu;
        private System.Windows.Forms.Button btn_CaiDat;
        private System.Windows.Forms.Button btn_KetXuat;
        private System.Windows.Forms.Button btn_Thoat;
    }
}