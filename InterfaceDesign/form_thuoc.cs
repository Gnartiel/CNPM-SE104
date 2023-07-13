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
    public partial class form_thuoc : Form
    {
        SqlConnection connection;
        SqlCommand cmd;
        private void KetNoi()
        {
            connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString);
            try
            {
                connection.Open();
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
        private System.Data.DataTable table1, table2;

        void LoadListview()
        {
            try
            {
                connection.Open();
                string sql = "select MaThuoc,TenThuoc,TenDonVi,TenCachDung, CongDung,HuongDanSuDung,SoLuongTon,DonGiaBan " +
                    "from THUOC,DONVI,CACHDUNG where THUOC.MaDonVi=DONVI.MaDonVi and THUOC.MaCachDung=CACHDUNG.MaCachDung"; 

                cmd = new SqlCommand(sql, connection); 
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader[0].ToString());
                    itm.SubItems.Add(reader[1].ToString());
                    itm.SubItems.Add(reader[2].ToString());
                    itm.SubItems.Add(reader[3].ToString());
                    itm.SubItems.Add(reader[4].ToString());
                    itm.SubItems.Add(reader[5].ToString());
                    itm.SubItems.Add(reader[6].ToString());
                    itm.SubItems.Add(reader[7].ToString());
                    lv_Thuoc.Items.Add(itm); 
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
        public form_thuoc()
        {
            InitializeComponent();
        }

        private void form_thuoc_Load(object sender, EventArgs e)
        {
            KetNoi();
            try
            {
                connection.Open();
                string stmt = "SELECT COUNT(*) FROM THUOC";
                int count = 0;
                SqlCommand cmdCount = new SqlCommand(stmt, connection);
                count = (int)cmdCount.ExecuteScalar();
                connection.Close();
                if (count > 0)
                {
                    LoadListview();
                }
            }
            finally
            {
                connection.Close();
            }
            LoadTenDonVi();
            LoadTenCachDung();
            string ms = AddIDAuto(lv_Thuoc);
            txtb_MaThuoc.Text = "TH" + ms;
        }

        private string AddIDAuto(ListView lv)
        {
            if (lv.Items.Count == 0)
                return "001";
            string r = lv.Items[lv.Items.Count - 1].SubItems[0].Text;
            string ms = (int.Parse(r.Substring(2)) + 1).ToString();
            if (ms.Length == 1)
                ms = "00" + ms;
            else if (ms.Length == 2)
                ms = "0" + ms;
            return ms;
        }

        private bool CheckDouble(ListView lv, string s)
        {
            for (int i = 0; i < lv.Items.Count; i++)
            {
                if (lv.Items[i].SubItems[0].ToString().Contains(s))
                    return true;
            }
            return false;
        }
        
        private void btn_TrangChu_Thuoc_Click(object sender, EventArgs e)
        {
            Form frm = new form_manhinhchinh();
            frm.Show();
            this.Hide();
        }

        private void btn_TroVe_Thuoc_Click(object sender, EventArgs e)
        {
            Form frm = new form_danhsach();
            frm.Show();
            this.Hide();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_ThemThuoc_Click(object sender, EventArgs e)
        {
            connection.Open();
            string stmt = "select count(*) from DONVI where TenDonVi = N'" + cbx_TenDonVi.Text.Trim() + "'";
            int count = 0;
            SqlCommand cmdCount = new SqlCommand(stmt, connection);
            count = (int)cmdCount.ExecuteScalar();
            connection.Close();
            connection.Open();
            string stmt2 = "select count(*) from CACHDUNG where TenCachDung = N'" + cbx_TenCachDung.Text.Trim() + "'";
            int count2 = 0;
            SqlCommand cmdCount2 = new SqlCommand(stmt2, connection);
            count2 = (int)cmdCount2.ExecuteScalar();
            connection.Close();
            connection.Open();
            string stmt4 = "select count(*) from THUOC where TenThuoc = N'" + txtb_TenThuoc.Text.Trim() + "'";
            int count4 = 0;
            SqlCommand cmdCount4 = new SqlCommand(stmt4, connection);
            count4 = (int)cmdCount4.ExecuteScalar();
            connection.Close();

            if ((string.IsNullOrEmpty(txtb_MaThuoc.Text)) || (string.IsNullOrEmpty(cbx_TenCachDung.Text)) || (string.IsNullOrEmpty(txtb_TenThuoc.Text)) || (string.IsNullOrEmpty(cbx_TenDonVi.Text)) || (string.IsNullOrEmpty(txtb_CongDung.Text)) || (string.IsNullOrEmpty(txtb_HDSD.Text)))
            {
                DialogResult dg = MessageBox.Show("Chưa điền đủ thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.No)
                {
                    
                    txtb_CongDung.Clear();
                    txtb_HDSD.Clear();
                    txtb_TenThuoc.Clear();
                    cbx_TenCachDung.Text="";
                    cbx_TenDonVi.Text="";
                }
            }
            else if (CheckDouble(lv_Thuoc, txtb_MaThuoc.Text) == true)
            {
                MessageBox.Show("Mã thuốc không được lặp lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (count==0)
            {
                MessageBox.Show("Tên đơn vị không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (count2==0)
            {
                MessageBox.Show("Tên cách dùng không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (count4 > 0)
            {
                MessageBox.Show("Tên thuốc đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else
            {
                int slt = 0, dgb = 0;
                try
                {
                    connection.Open();
                    string s = "select MaDonVi from DONVI where TenDonVi=N'" + cbx_TenDonVi.Text.Trim() + "'";
                    da = new SqlDataAdapter(s, connection);
                    ds = new DataSet();
                    da.Fill(ds, "DONVI");
                    table1 = ds.Tables["DONVI"];
                    string dv = table1.Rows[0]["MaDonVi"].ToString();
                    connection.Close();
                    connection.Open();
                    string s1 = "select MaCachDung from CACHDUNG where TenCachDung=N'" + cbx_TenCachDung.Text.Trim() + "'";
                    db = new SqlDataAdapter(s1, connection);
                    du = new DataSet();
                    db.Fill(du, "CACHDUNG");
                    table2 = du.Tables["CACHDUNG"];
                    string cd = table2.Rows[0]["MaCachDung"].ToString();
                    connection.Close();
                    connection.Open();
                    string stmt3 = "INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan) VALUES(N'" + txtb_MaThuoc.Text.Trim() + "',N'" + txtb_TenThuoc.Text + "',N'" + dv + "',N'" + cd + "',N'" + txtb_CongDung.Text + "',N'" + txtb_HDSD.Text + "', " + slt + ", " + dgb + ")";
                    SqlCommand cmdCount3 = new SqlCommand(stmt3, connection);
                    cmdCount3.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                    lv_Thuoc.Items.Clear();
                    LoadListview();
                }
                txtb_CongDung.Clear();
                txtb_HDSD.Clear();
                txtb_TenThuoc.Clear();
                cbx_TenCachDung.Text = "";
                cbx_TenDonVi.Text = "";
            }
            string ms = AddIDAuto(lv_Thuoc);
            txtb_MaThuoc.Text = "TH" + ms;
        }
        private void LoadTenDonVi()
        {
            DataTable dt = new DataTable();
            connection.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From DONVI", connection);
                da.Fill(dt);
                connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            try
            {
                
                cbx_TenDonVi.DisplayMember = dt.Columns["TenDonVi"].ColumnName;
                cbx_TenDonVi.ValueMember = dt.Columns["TenDonVi"].ColumnName;
                cbx_TenDonVi.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadTenCachDung()
        {
            DataTable dt = new DataTable();
            
            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * From CACHDUNG", connection);
                da.Fill(dt);
                connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            try
            {
                connection.Open();
                cbx_TenCachDung.DisplayMember = dt.Columns["TenCachDung"].ColumnName;
                cbx_TenCachDung.ValueMember = dt.Columns["TenCachDung"].ColumnName;
                cbx_TenCachDung.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        private void btn_SuaThuoc_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lv_Thuoc.Items.Count; i++)
            {
                if (lv_Thuoc.Items[i].Selected)
                {
                    connection.Open();
                    string stmt = "select count(*) from DONVI where TenDonVi = N'" + cbx_TenDonVi.Text.Trim() + "'";
                    int count = 0;
                    SqlCommand cmdCount = new SqlCommand(stmt, connection);
                    count = (int)cmdCount.ExecuteScalar();

                    string stmt2 = "select count(*) from CACHDUNG where TenCachDung = N'" + cbx_TenCachDung.Text.Trim() + "'";
                    int count2 = 0;
                    SqlCommand cmdCount2 = new SqlCommand(stmt2, connection);
                    count2 = (int)cmdCount2.ExecuteScalar();                                   
                    connection.Close();
                    if ((string.IsNullOrEmpty(txtb_MaThuoc.Text)) || (string.IsNullOrEmpty(cbx_TenCachDung.Text)) || (string.IsNullOrEmpty(txtb_TenThuoc.Text)) || (string.IsNullOrEmpty(cbx_TenDonVi.Text)) || (string.IsNullOrEmpty(txtb_CongDung.Text)) || (string.IsNullOrEmpty(txtb_HDSD.Text)))
                    {
                        DialogResult dg = MessageBox.Show("Chưa điền đủ thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.No)
                        {
                            
                            txtb_CongDung.Clear();
                            txtb_HDSD.Clear();
                            txtb_TenThuoc.Clear();
                            cbx_TenCachDung.Text = "";
                            cbx_TenDonVi.Text = "";
                        }
                    }
                    else if (count == 0)
                    {
                        MessageBox.Show("Tên đơn vị không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (count2 == 0)
                    {
                        MessageBox.Show("Tên cách dùng không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            connection.Open();
                            string s = "select MaDonVi from DONVI where TenDonVi=N'" + cbx_TenDonVi.Text.Trim() + "'";
                            da = new SqlDataAdapter(s, connection);
                            ds = new DataSet();
                            da.Fill(ds, "DONVI");
                            table1 = ds.Tables["DONVI"];
                            string dv = table1.Rows[0]["MaDonVi"].ToString();
                            connection.Close();
                            connection.Open();
                            string s1 = "select MaCachDung from CACHDUNG where TenCachDung=N'" + cbx_TenCachDung.Text.Trim() + "'";
                            db = new SqlDataAdapter(s1, connection);
                            du = new DataSet();
                            db.Fill(du, "CACHDUNG");
                            table2 = du.Tables["CACHDUNG"];
                            string cd = table2.Rows[0]["MaCachDung"].ToString();
                            connection.Close();
                            connection.Open();
                            string stmt3 = "update THUOC " +
                                "set TenThuoc=N'" + txtb_TenThuoc.Text + "',MaDonVi=N'" +dv+"',MaCachDung=N'" +cd+"',CongDung=N'" + txtb_CongDung.Text + "',HuongDanSuDung=N'" + txtb_HDSD.Text + "' " +
                                "where MaThuoc='" + txtb_MaThuoc.Text.Trim() + "'";
                            SqlCommand cmdCount3 = new SqlCommand(stmt3, connection);
                            cmdCount3.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                            lv_Thuoc.Items.Clear();
                            LoadListview();
                        }
                        txtb_CongDung.Clear();
                        txtb_HDSD.Clear();
                        txtb_TenThuoc.Clear();
                        cbx_TenCachDung.Text = "";
                        cbx_TenDonVi.Text = "";
                    }
                }
            }
            string ms = AddIDAuto(lv_Thuoc);
            txtb_MaThuoc.Text = "TH" + ms;
        }

        private void lv_Thuoc_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem items in lv_Thuoc.SelectedItems)
            {
                txtb_MaThuoc.Text= items.SubItems[0].Text;
                txtb_TenThuoc.Text= items.SubItems[1].Text;
                cbx_TenDonVi.Text = items.SubItems[2].Text;
                cbx_TenCachDung.Text = items.SubItems[3].Text;
                txtb_CongDung.Text= items.SubItems[4].Text;
                txtb_HDSD.Text= items.SubItems[5].Text;
                
            }
        }

        private void btn_XoaThuoc_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa không?", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                for (int i = 0; i < lv_Thuoc.Items.Count; i++)
                {
                    if (lv_Thuoc.Items[i].Selected)
                    {
                        try
                        {
                            connection.Open();
                            string stmt = "select count(*) from CT_PHIEUKHAMBENH where MaThuoc = '" + lv_Thuoc.Items[i].SubItems[0].Text.Trim() + "'";
                            int count = 0;
                            SqlCommand cmdCount = new SqlCommand(stmt, connection);
                            count = (int)cmdCount.ExecuteScalar();
                            string stmt2 = "select count(*) from CT_PHIEUNHAPTHUOC where MaThuoc = '" + lv_Thuoc.Items[i].SubItems[0].Text.Trim() + "'";
                            SqlCommand cmdCount2 = new SqlCommand(stmt2, connection);
                            count += (int)cmdCount2.ExecuteScalar();
                            connection.Close();
                            if (count == 0)
                            {
                                connection.Open();
                                string s = "Delete from THUOC where MaThuoc = '" + lv_Thuoc.Items[i].SubItems[0].Text.Trim() + "'";
                                SqlCommand cmd = new SqlCommand(s, connection);
                                cmd.ExecuteNonQuery();
                                connection.Close();
                                DialogResult dg = MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (dg == DialogResult.OK)
                                    break;
                            }
                            else
                            {
                                DialogResult dg = MessageBox.Show("Đối tượng hiện đang được sử dụng, không thể xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                if (dg == DialogResult.OK)
                                    break;
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
                lv_Thuoc.Items.Clear();
                LoadListview();
                txtb_CongDung.Clear();
                txtb_HDSD.Clear();
                txtb_TenThuoc.Clear();
                cbx_TenCachDung.Text = "";
                cbx_TenDonVi.Text = "";
            }
            string ms = AddIDAuto(lv_Thuoc);
            txtb_MaThuoc.Text = "TH" + ms;
        }
        private SqlDataAdapter da,db;
        private DataSet ds,du;

        private void lv_Thuoc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string ms = AddIDAuto(lv_Thuoc);
            txtb_MaThuoc.Text = "TH" + ms;
            txtb_CongDung.Clear();
            txtb_HDSD.Clear();
            txtb_TenThuoc.Clear();
            cbx_TenCachDung.Text = "";
            cbx_TenDonVi.Text = "";
        }

        
    }
}
