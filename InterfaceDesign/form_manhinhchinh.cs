using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace InterfaceDesign
{
    public partial class form_manhinhchinh : Form
    {

        public form_manhinhchinh()
        {
            InitializeComponent();
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
        private void form_manhinhchinh_Load(object sender, EventArgs e)
        {
            KetNoi();
            lb_TenUser.Text = "Xin chào, " + class_ThongTinNguoiDung.type + " " + class_ThongTinNguoiDung.name;
        }

        private void btn_DanhSach_Click(object sender, EventArgs e)
        {
            try
            {
                //Truoc khi thuc thi lenh phai mo ket noi           
                connection.Open();
                string sql = "Select DoiTuong From PHANQUYEN where MaLoai='DS'";
                cmd = new SqlCommand(sql, connection);
                string r = cmd.ExecuteScalar().ToString();
                if (r.Contains(class_ThongTinNguoiDung.type.ToString()))
                {
                    Form frm = new form_danhsach();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    DialogResult dg = MessageBox.Show("Bạn Không có quyền truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        private void btn_CaiDat_Click(object sender, EventArgs e)
        {
            try
            {
                //Truoc khi thuc thi lenh phai mo ket noi           
                connection.Open();
                string sql = "Select DoiTuong From PHANQUYEN where MaLoai='CD'";
                cmd = new SqlCommand(sql, connection);
                string r = cmd.ExecuteScalar().ToString();
                if (r.Contains(class_ThongTinNguoiDung.type.ToString()))
                {
                    Form frm = new form_caidat();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    DialogResult dg = MessageBox.Show("Bạn Không có quyền truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        private void btn_KetXuat_Click(object sender, EventArgs e)
        {
            try
            {
                //Truoc khi thuc thi lenh phai mo ket noi           
                connection.Open();
                string sql = "Select DoiTuong From PHANQUYEN where MaLoai='KX'";
                cmd = new SqlCommand(sql, connection);
                string r = cmd.ExecuteScalar().ToString();
                if (r.Contains(class_ThongTinNguoiDung.type.ToString()))
                {
                    Form frm = new form_ketxuat();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    DialogResult dg = MessageBox.Show("Bạn Không có quyền truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        private void btn_TraCuu_Click(object sender, EventArgs e)
        {
            try
            {
                //Truoc khi thuc thi lenh phai mo ket noi           
                connection.Open();
                string sql = "Select DoiTuong From PHANQUYEN where MaLoai='TC'";
                cmd = new SqlCommand(sql, connection);
                string r = cmd.ExecuteScalar().ToString();
                if (r.Contains(class_ThongTinNguoiDung.type.ToString()))
                {
                    Form frm = new form_tracuu();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    DialogResult dg = MessageBox.Show("Bạn Không có quyền truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đăng xuất ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Form frm = new form_taikhoan();
                frm.Show();
                this.Hide();
            }    
        }

        private void lb_TenUser_Click(object sender, EventArgs e)
        {
            
        }
    }
}
