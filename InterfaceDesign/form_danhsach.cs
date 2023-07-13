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
    public partial class form_danhsach : Form
    {
        public form_danhsach()
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
        private void form_danhsach_Load(object sender, EventArgs e)
        {
            KetNoi();
        }

        private void btn_BenhNhan_Click(object sender, EventArgs e)
        {
            try
            {
                //Truoc khi thuc thi lenh phai mo ket noi           
                connection.Open();
                string sql = "Select DoiTuong From PHANQUYEN where MaLoai='BN'";
                cmd = new SqlCommand(sql, connection);
                string r = cmd.ExecuteScalar().ToString();
                if (r.Contains(class_ThongTinNguoiDung.type.ToString()))
                {
                    Form frm = new form_benhnhan();
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

        private void btn_PhieuKhamBenh_Click(object sender, EventArgs e)
        {
            try
            {
                //Truoc khi thuc thi lenh phai mo ket noi           
                connection.Open();
                string sql = "Select DoiTuong From PHANQUYEN where MaLoai='PKB'";
                cmd = new SqlCommand(sql, connection);
                string r = cmd.ExecuteScalar().ToString();
                if (r.Contains(class_ThongTinNguoiDung.type.ToString()))
                {
                    Form frm = new form_phieukhambenh();
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

        private void btn_Thuoc_Click(object sender, EventArgs e)
        {
            try
            {
                //Truoc khi thuc thi lenh phai mo ket noi           
                connection.Open();
                string sql = "Select DoiTuong From PHANQUYEN where MaLoai='TH'";
                cmd = new SqlCommand(sql, connection);
                string r = cmd.ExecuteScalar().ToString();
                if (r.Contains(class_ThongTinNguoiDung.type.ToString()))
                {
                    Form frm = new form_thuoc();
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

        private void btn_DonViCachDung_Click(object sender, EventArgs e)
        {
            try
            {
                //Truoc khi thuc thi lenh phai mo ket noi           
                connection.Open();
                string sql = "Select DoiTuong From PHANQUYEN where MaLoai='DVCD'";
                cmd = new SqlCommand(sql, connection);
                string r = cmd.ExecuteScalar().ToString();
                if (r.Contains(class_ThongTinNguoiDung.type.ToString()))
                {
                    Form frm = new form_donvicachdung();
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

        private void btn_PhieuNhapThuoc_Click(object sender, EventArgs e)
        {
            try
            {
                //Truoc khi thuc thi lenh phai mo ket noi           
                connection.Open();
                string sql = "Select DoiTuong From PHANQUYEN where MaLoai='PNT'";
                cmd = new SqlCommand(sql, connection);
                string r = cmd.ExecuteScalar().ToString();
                if (r.Contains(class_ThongTinNguoiDung.type.ToString()))
                {
                    Form frm = new form_phieunhapthuoc();
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

        private void btn_LoaiBenh_Click(object sender, EventArgs e)
        {
            try
            {
                //Truoc khi thuc thi lenh phai mo ket noi           
                connection.Open();
                string sql = "Select DoiTuong From PHANQUYEN where MaLoai='LB'";
                cmd = new SqlCommand(sql, connection);
                string r = cmd.ExecuteScalar().ToString();
                if (r.Contains(class_ThongTinNguoiDung.type.ToString()))
                {
                    Form frm = new form_loaibenh();
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

        private void btn_TrangChur_ManHinhPhu_Click(object sender, EventArgs e)
        {
            Form frm = new form_manhinhchinh();
            frm.Show();
            this.Hide();
        }

        private void btn_TroVe_ManHinhPhu_Click(object sender, EventArgs e)
        {
            Form frm = new form_manhinhchinh();
            frm.Show();
            this.Hide();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }
    }
}
