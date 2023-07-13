using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace InterfaceDesign
{
    public partial class form_taikhoan : Form
    {
       
        public form_taikhoan()
        {
            InitializeComponent();
        }

        
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }
        SqlConnection connection;
        SqlCommand cmd;
        private void KetNoi()
        {
            connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString);
            try
            {
                connection.Open(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void form_taikhoan_Load(object sender, EventArgs e)
        {
            KetNoi();
        }

        private void btn_QuenMK_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Liên hệ quản lý để lấy lại mật khẩu", "Quên Mật Khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string sql = "Select * From NHANVIEN"; 
                cmd = new SqlCommand(sql, connection); 
                SqlDataReader reader = cmd.ExecuteReader();
                int kq = 0;
                while (reader.Read())
                {
                    if (txtb_TenDN.Text == reader[2].ToString() && txtb_MKDN.Text == reader[3].ToString())
                    {
                        kq = 1;
                        class_ThongTinNguoiDung.type=reader[4].ToString().Trim();
                        class_ThongTinNguoiDung.name = reader[1].ToString();
                    }
                }
                if (kq == 1)
                {
                    DialogResult dg = MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dg == DialogResult.OK)
                    {
                        form_manhinhchinh frm = new form_manhinhchinh();
                        frm.Show();
                        this.Hide();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại hoặc nhập sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtb_MKDN.Text = "";
                    txtb_TenDN.Text = "";
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void chkshow_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkshow.Checked)
            {
                txtb_MKDN.PasswordChar = (char)0;
            }
            else
            {
                txtb_MKDN.PasswordChar = '*';
            }
        }
    }
}
