using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace InterfaceDesign
{
    public partial class form_tracuu : Form
    {
        public form_tracuu()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommand cmd;
        //string sql0 = "set dateformat DMY";
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
        private void LoadHoTen()
        {
            DataTable dt = new DataTable();
            connection.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From BENHNHAN", connection);
                da.Fill(dt);
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.ToString());
            }

            try
            {
                cbx_HoTen.DataSource = dt;
                cbx_HoTen.DisplayMember = "HoTenBenhNhan";
                cbx_HoTen.ValueMember = "HoTenBenhNhan";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }
        private void LoadTenLB()
        {
            DataTable dt = new DataTable();
            connection.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From LOAIBENH", connection);
                da.Fill(dt);
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.ToString());
            }

            try
            {
                cbx_LoaiBenh.DataSource = dt;
                cbx_LoaiBenh.DisplayMember = "TenLoaiBenh";
                cbx_LoaiBenh.ValueMember = "MaLoaiBenh";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }

        private void form_tracuu_Load(object sender, EventArgs e)
        {
            KetNoi();
            LoadTenLB();
            LoadHoTen();
        }

        private void btn_TrangChu_TraCuu_Click(object sender, EventArgs e)
        {
            Form frm = new form_manhinhchinh();
            frm.Show();
            this.Hide();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            lv_TraCuuBN.Items.Clear();
            
            string lenh = "";
            string nk = dtbx_NgayKham.Text;
            string ngay = nk[6] + "" + nk[7] + "" + nk[8] + "" + nk[9] + "/" + nk[3] + "" + nk[4] + "/" + nk[0] + "" + nk[1];
            if (rdbtn_HoTen.Checked == true)
            {
                lenh = "select HoTenBenhNhan,NgayKham,PHIEUKHAMBENH.TrieuChung from BENHNHAN,PHIEUKHAMBENH " +
                "where BENHNHAN.HoTenBenhNhan= N'" + cbx_HoTen.Text.Trim() + "' " +
                "and PHIEUKHAMBENH.MaBenhNhan=BENHNHAN.MaBenhNhan";
            }
            else if (rdbtn_NgayKham.Checked == true)
            {
                lenh = "select HoTenBenhNhan,NgayKham,PHIEUKHAMBENH.TrieuChung from BENHNHAN,PHIEUKHAMBENH" +
                " where NgayKham='" + ngay + "' " +
                "and PHIEUKHAMBENH.MaBenhNhan=BENHNHAN.MaBenhNhan";
            }
            else if (rdbtn_LoaiBenh.Checked == true)
            {
                lenh = "select HoTenBenhNhan,NgayKham,PHIEUKHAMBENH.TrieuChung from BENHNHAN,PHIEUKHAMBENH,LOAIBENH,CT_BENH " +
                "where LOAIBENH.TenLoaiBenh= N'" + cbx_LoaiBenh.Text + "' " +
                "and PHIEUKHAMBENH.MaBenhNhan=BENHNHAN.MaBenhNhan and CT_BENH.MaLoaiBenh=LOAIBENH.MaLoaiBenh and CT_BENH.MaPhieuKhamBenh=PHIEUKHAMBENH.MaPhieuKhamBenh";
            }

            try
            {
                connection.Open();
                //cmd = new SqlCommand(sql0, connection);
                //cmd.ExecuteNonQuery();
                string sql = lenh;
                cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader[0].ToString());
                    itm.SubItems.Add(reader[1].ToString().Substring(0,10));
                    itm.SubItems.Add(reader[2].ToString());
                    lv_TraCuuBN.Items.Add(itm);
                }
                DialogResult dg = MessageBox.Show("Đã tìm được " + lv_TraCuuBN.Items.Count.ToString().Trim() + " kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //Hiển thị thông báo lỗi của ngoại lệ
            }
            finally
            {
                connection.Close();
            }
        }

        private void btn_TroVe_TraCuu_Click(object sender, EventArgs e)
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
