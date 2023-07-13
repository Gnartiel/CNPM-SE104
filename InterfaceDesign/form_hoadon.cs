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
using Excel = Microsoft.Office.Interop.Excel;

namespace InterfaceDesign
{
    public partial class form_hoadon : Form
    {
        public string mapk = "";
        public form_hoadon(string mpk)
        {
            mapk = mpk;
            InitializeComponent();
        }

        SqlConnection connection;
        SqlCommand cmd;
        private void KetNoi()
        {
            connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString);
            try
            {
                connection.Open(); // Mo ket noi, neu thanh cong
                //MessageBox.Show("Ket noi thanh cong");
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
        private void Form1_Load(object sender, EventArgs e)
        {
            txtb_MaPhieuKham_PKB.Text = mapk;
            lv_TenLoaiBenh_HD.Items.Clear();
            lv_HoaDon_HD.Items.Clear();
            KetNoi();
            LoadThamSo();
            LoadListview1();
            LoadListview2();
        }

        private SqlDataAdapter da;
        private DataSet ds;
        private DataTable table;
        void LoadThamSo()
        {
            try
            {
                connection.Open();
                string sql = "Select * From PHIEUKHAMBENH, BENHNHAN where PHIEUKHAMBENH.MABENHNHAN = BENHNHAN.MABENHNHAN AND MaPhieuKhamBenh='" + txtb_MaPhieuKham_PKB.Text.Trim() + "'";
                da = new SqlDataAdapter(sql, connection);
                ds = new DataSet();
                da.Fill(ds, "PHIEUKHAMBENH");
                table = ds.Tables["PHIEUKHAMBENH"];
                txtb_TenBenhNhan_HD.Text = table.Rows[0]["HoTenBenhNhan"].ToString();
                lb_NgayNhap.Text = table.Rows[0]["NgayKham"].ToString().Substring(0,10);
                txtb_TrieuChung_HD.Text = table.Rows[0]["TrieuChung"].ToString();
                txtb_TienKham_HD.Text = table.Rows[0]["TienKham"].ToString();
                txtb_TienThuoc_HD.Text = table.Rows[0]["TienThuoc"].ToString();
                txtb_TongTien_HD.Text = table.Rows[0]["TongTien"].ToString();

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
        void LoadListview1()
        {
            
            try
            {
                connection.Open();

                string sql = "select MaLoaiBenh from CT_BENH where MaPhieuKhamBenh='" + txtb_MaPhieuKham_PKB.Text.Trim() + "'";
                cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader[0].ToString().Trim());
                    lv_TenLoaiBenh_HD.Items.Add(itm);
                }
                connection.Close();
                connection.Open();
                for (int i = 0; i < lv_TenLoaiBenh_HD.Items.Count; i++)
                {
                    string load = "select TenLoaiBenh from LOAIBENH where LOAIBENH.MaLoaiBenh=N'" + lv_TenLoaiBenh_HD.Items[i].SubItems[0].Text.Trim() + "'";
                    da = new SqlDataAdapter(load, connection);
                    ds = new DataSet();
                    da.Fill(ds, "LOAIBENH");
                    table = ds.Tables["LOAIBENH"];
                    string kq = table.Rows[0]["TenLoaiBenh"].ToString();
                    ListViewItem itm = new ListViewItem(kq);
                    lv_TenLoaiBenh_HD.Items[i] = itm;
                }
                connection.Close();
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

        void LoadListview2()
        {
            try
            {
                connection.Open();
                string sql = "select TENTHUOC, SOLUONG, LIEUDUNG, THANHTIEN " +
                    "from PHIEUKHAMBENH, CT_PHIEUKHAMBENH, THUOC " +
                    "WHERE PHIEUKHAMBENH.MaPhieuKhamBenh=CT_PHIEUKHAMBENH.MaPhieuKhamBenh and THUOC.MATHUOC = CT_PHIEUKHAMBENH.MATHUOC and CT_PHIEUKHAMBENH.MaPhieuKhamBenh='" + txtb_MaPhieuKham_PKB.Text.Trim() + "'";

                cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader[0].ToString());
                    itm.SubItems.Add(reader[2].ToString());
                    itm.SubItems.Add(reader[1].ToString());
                    itm.SubItems.Add(reader[3].ToString());
                    lv_HoaDon_HD.Items.Add(itm);
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




    }

}
