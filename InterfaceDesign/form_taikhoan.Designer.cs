
namespace InterfaceDesign
{
    partial class form_taikhoan
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
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.lb_MKDN = new System.Windows.Forms.Label();
            this.lb_TenDN = new System.Windows.Forms.Label();
            this.txtb_MKDN = new System.Windows.Forms.TextBox();
            this.txtb_TenDN = new System.Windows.Forms.TextBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.btn_QuenMK = new System.Windows.Forms.Button();
            this.chkshow = new System.Windows.Forms.RadioButton();
            this.chkoff = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Thoat.Location = new System.Drawing.Point(483, 36);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(110, 35);
            this.btn_Thoat.TabIndex = 3;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // lb_MKDN
            // 
            this.lb_MKDN.AutoSize = true;
            this.lb_MKDN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MKDN.Location = new System.Drawing.Point(24, 192);
            this.lb_MKDN.Name = "lb_MKDN";
            this.lb_MKDN.Size = new System.Drawing.Size(104, 27);
            this.lb_MKDN.TabIndex = 20;
            this.lb_MKDN.Text = "Mật khẩu";
            // 
            // lb_TenDN
            // 
            this.lb_TenDN.AutoSize = true;
            this.lb_TenDN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenDN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_TenDN.Location = new System.Drawing.Point(24, 137);
            this.lb_TenDN.Name = "lb_TenDN";
            this.lb_TenDN.Size = new System.Drawing.Size(154, 27);
            this.lb_TenDN.TabIndex = 19;
            this.lb_TenDN.Text = "Tên đăng nhập";
            // 
            // txtb_MKDN
            // 
            this.txtb_MKDN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_MKDN.Location = new System.Drawing.Point(200, 189);
            this.txtb_MKDN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtb_MKDN.Multiline = true;
            this.txtb_MKDN.Name = "txtb_MKDN";
            this.txtb_MKDN.PasswordChar = '*';
            this.txtb_MKDN.Size = new System.Drawing.Size(393, 42);
            this.txtb_MKDN.TabIndex = 1;
            // 
            // txtb_TenDN
            // 
            this.txtb_TenDN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_TenDN.Location = new System.Drawing.Point(200, 134);
            this.txtb_TenDN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtb_TenDN.Multiline = true;
            this.txtb_TenDN.Name = "txtb_TenDN";
            this.txtb_TenDN.Size = new System.Drawing.Size(393, 42);
            this.txtb_TenDN.TabIndex = 0;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.SystemColors.Control;
            this.btn_DangNhap.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.Location = new System.Drawing.Point(370, 317);
            this.btn_DangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(186, 46);
            this.btn_DangNhap.TabIndex = 2;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // btn_QuenMK
            // 
            this.btn_QuenMK.BackColor = System.Drawing.SystemColors.Control;
            this.btn_QuenMK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_QuenMK.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuenMK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_QuenMK.Location = new System.Drawing.Point(64, 317);
            this.btn_QuenMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QuenMK.Name = "btn_QuenMK";
            this.btn_QuenMK.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_QuenMK.Size = new System.Drawing.Size(200, 46);
            this.btn_QuenMK.TabIndex = 21;
            this.btn_QuenMK.Text = "Quên Mật Khẩu";
            this.btn_QuenMK.UseVisualStyleBackColor = false;
            this.btn_QuenMK.Click += new System.EventHandler(this.btn_QuenMK_Click);
            // 
            // chkshow
            // 
            this.chkshow.AutoSize = true;
            this.chkshow.Location = new System.Drawing.Point(455, 255);
            this.chkshow.Name = "chkshow";
            this.chkshow.Size = new System.Drawing.Size(120, 21);
            this.chkshow.TabIndex = 22;
            this.chkshow.Text = "Hiện mật khẩu";
            this.chkshow.UseVisualStyleBackColor = true;
            this.chkshow.CheckedChanged += new System.EventHandler(this.chkshow_CheckedChanged_1);
            // 
            // chkoff
            // 
            this.chkoff.AutoSize = true;
            this.chkoff.Checked = true;
            this.chkoff.Location = new System.Drawing.Point(249, 255);
            this.chkoff.Name = "chkoff";
            this.chkoff.Size = new System.Drawing.Size(108, 21);
            this.chkoff.TabIndex = 23;
            this.chkoff.TabStop = true;
            this.chkoff.Text = "Ẩn mật khẩu";
            this.chkoff.UseVisualStyleBackColor = true;
            // 
            // form_taikhoan
            // 
            this.AcceptButton = this.btn_DangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 415);
            this.ControlBox = false;
            this.Controls.Add(this.chkoff);
            this.Controls.Add(this.chkshow);
            this.Controls.Add(this.btn_QuenMK);
            this.Controls.Add(this.lb_MKDN);
            this.Controls.Add(this.lb_TenDN);
            this.Controls.Add(this.txtb_MKDN);
            this.Controls.Add(this.txtb_TenDN);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.btn_Thoat);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_taikhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tài khoản";
            this.Load += new System.EventHandler(this.form_taikhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label lb_MKDN;
        private System.Windows.Forms.Label lb_TenDN;
        private System.Windows.Forms.TextBox txtb_MKDN;
        private System.Windows.Forms.TextBox txtb_TenDN;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Button btn_QuenMK;
        private System.Windows.Forms.RadioButton chkshow;
        private System.Windows.Forms.RadioButton chkoff;
    }
}