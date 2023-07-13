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
    public partial class form_caidat : Form
    {
        public form_caidat()
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
        private SqlDataAdapter da;
        private DataSet ds;
        private DataTable table;
        void LoadThamSo()
        {
            try
            {
                connection.Open();
                string sql = "Select GiaTri From THAMSO";
                da = new SqlDataAdapter(sql, connection);
                ds = new DataSet();
                da.Fill(ds, "THAMSO");
                table = ds.Tables["THAMSO"];
                txtb_SoBNToiDa.Text = table.Rows[0]["GiaTri"].ToString();
                txtb_TienKham.Text = table.Rows[2]["GiaTri"].ToString();
                txtb_ThangSoBanLe.Text = table.Rows[1]["GiaTri"].ToString();
                txtb_VAT.Text = table.Rows[3]["GiaTri"].ToString();

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
        void LoadDSTK()
        {
            try
            {
                connection.Open();
                string sql = "Select * From NHANVIEN";
                cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader[0].ToString());
                    itm.SubItems.Add(reader[1].ToString());
                    itm.SubItems.Add(reader[2].ToString());
                    itm.SubItems.Add(reader[3].ToString());
                    itm.SubItems.Add(reader[4].ToString());
                    lv_DSTK.Items.Add(itm);
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
        void LoadDSL()
        {
            try
            {
                connection.Open();
                string sql = "Select * From PHANQUYEN";
                cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader[0].ToString());
                    itm.SubItems.Add(reader[1].ToString());
                    itm.SubItems.Add(reader[2].ToString());
                    lv_DSLoai.Items.Add(itm);
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
        string ms="";
        private void form_caidat_Load(object sender, EventArgs e)
        {
            KetNoi();
            LoadThamSo();
            LoadDSTK();
            LoadDSL();
            ms = AddIDAuto(lv_DSTK);
            txtb_MaNV.Text = "NV" + ms;
        }

        private void btn_TrangChu_CaiDat_Click(object sender, EventArgs e)
        {
            Form frm = new form_manhinhchinh();
            frm.Show();
            this.Close();
        }

        private void btn_TroVe_CaiDat_Click(object sender, EventArgs e)
        {
            Form frm = new form_manhinhchinh();
            frm.Show();
            this.Hide();
        }

        private void btn_Luu_CaiDat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn lưu không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    connection.Open();
                    string sql1 = "UPDATE THAMSO SET GiaTri= '" + txtb_SoBNToiDa.Text + "'WHERE TenThamSo=N'BNToiDa'";
                    cmd = new SqlCommand(sql1, connection);
                    cmd.ExecuteNonQuery();
                    string sql2 = "UPDATE THAMSO SET GiaTri= '" + txtb_TienKham.Text + "'WHERE TenThamSo=N'TienKham'";
                    cmd = new SqlCommand(sql2, connection);
                    cmd.ExecuteNonQuery();
                    string sql3 = "UPDATE THAMSO SET GiaTri= '" + txtb_ThangSoBanLe.Text + "'WHERE TenThamSo=N'ThangSoBanLe'";
                    cmd = new SqlCommand(sql3, connection);
                    cmd.ExecuteNonQuery();
                    string sql4 = "UPDATE THAMSO SET GiaTri= '" + txtb_VAT.Text + "'WHERE TenThamSo=N'VAT'";
                    cmd = new SqlCommand(sql4, connection);
                    cmd.ExecuteNonQuery();
                    txtb_SoBNToiDa.Clear();
                    txtb_TienKham.Clear();
                    txtb_ThangSoBanLe.Clear();
                    txtb_VAT.Clear();
                    MessageBox.Show("Lưu thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                    LoadThamSo();
                }
            }
        }
        private void btn_MacDinh_CaiDat_Click(object sender, EventArgs e)
        {
            txtb_SoBNToiDa.Text = "40";
            txtb_TienKham.Text = "30000";
            txtb_ThangSoBanLe.Text = "10";
            txtb_VAT.Text = "5";
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void lv_DSTK_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem items in lv_DSTK.SelectedItems)
            {
                txtb_MaNV.Text = items.SubItems[0].Text;
                txtb_HoTen.Text = items.SubItems[1].Text;
                txtb_TenDN.Text = items.SubItems[2].Text;
                txtb_MK.Text = items.SubItems[3].Text;
                cbx_LoaiNV.Text = items.SubItems[4].Text;
            }
        }

        private void lv_DSLoai_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem items in lv_DSLoai.SelectedItems)
            {
                txtb_MaLoai.Text = items.SubItems[0].Text;
                txtb_TenLoai.Text = items.SubItems[1].Text;
                txtb_Quyen.Text = items.SubItems[2].Text;
            }
        }
        private string AddIDAuto(ListView lv)
        {
            string r = lv.Items[lv.Items.Count - 1].SubItems[0].Text;
            string ms = (int.Parse(r.Substring(2)) + 1).ToString();
            if (ms.Length == 1)
                ms = "00" + ms;
            else if (ms.Length == 2)
                ms = "0" + ms;
            return ms;
        }

        private bool CheckDouble(ListView lv, string s,int k)
        {
            for (int i = 0; i < lv.Items.Count; i++)
            {
                if (lv.Items[i].SubItems[k].ToString().Contains(s))
                    return true;
            }
            return false;
        }


        private void btn_Them_BN_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(cbx_LoaiNV.Text)) || (string.IsNullOrEmpty(txtb_HoTen.Text)) || (string.IsNullOrEmpty(txtb_TenDN.Text)) || (string.IsNullOrEmpty(txtb_MK.Text)))
            {
                DialogResult dg = MessageBox.Show("Chưa điền đủ thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.No)
                {
                    txtb_HoTen.Clear();
                    txtb_TenDN.Clear();
                    txtb_MK.Clear();
                    cbx_LoaiNV.Text = "";
                }
            }
            else if(CheckDouble(lv_DSTK,txtb_MaNV.Text,0)==true)
            {
                MessageBox.Show("Mã nhân viên không được lặp lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else
            {
                String[] row = { txtb_MaNV.Text, txtb_HoTen.Text, txtb_TenDN.Text, txtb_MK.Text, cbx_LoaiNV.Text };
                ListViewItem item = new ListViewItem(row);
                lv_DSTK.Items.Add(item);
                txtb_HoTen.Clear();
                txtb_TenDN.Clear();
                txtb_MK.Clear();
                cbx_LoaiNV.Text = "";
            }
            ms = AddIDAuto(lv_DSTK);
            txtb_MaNV.Text = "NV" + ms;
        }

        private void btn_Sua_BN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lv_DSTK.Items.Count; i++)
            {
                if (lv_DSTK.Items[i].Selected)
                {
                    if ((string.IsNullOrEmpty(cbx_LoaiNV.Text)) || (string.IsNullOrEmpty(txtb_HoTen.Text)) || (string.IsNullOrEmpty(txtb_TenDN.Text)) || (string.IsNullOrEmpty(txtb_MK.Text)))
                    {
                        DialogResult dg = MessageBox.Show("Chưa điền đủ thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.No)
                        {
                            txtb_HoTen.Clear();
                            txtb_TenDN.Clear();
                            txtb_MK.Clear();
                            cbx_LoaiNV.Text = "";
                        }
                    }
                    else
                    {
                        String[] row = { txtb_MaNV.Text, txtb_HoTen.Text, txtb_TenDN.Text, txtb_MK.Text, cbx_LoaiNV.Text };
                        ListViewItem item = new ListViewItem(row);
                        lv_DSTK.Items[i] = item;
                        txtb_HoTen.Clear();
                        txtb_TenDN.Clear();
                        txtb_MK.Clear();
                        cbx_LoaiNV.Text = "";
                    }
                }
            }
            ms = AddIDAuto(lv_DSTK);
            txtb_MaNV.Text = "NV" + ms;
        }

        private void btn_Xoa_BN_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa không?", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                for (int i = 0; i < lv_DSTK.Items.Count; i++)
                {
                    if (lv_DSTK.Items[i].Selected)
                    {
                        lv_DSTK.Items[i].Remove();
                        i--;
                    }
                }
                ms = AddIDAuto(lv_DSTK);
                txtb_MaNV.Text = "NV" + ms;
                txtb_HoTen.Clear();
                txtb_TenDN.Clear();
                txtb_MK.Clear();
                cbx_LoaiNV.Text = "";
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn lưu không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    connection.Open();
                    string sql1 = "DELETE FROM NHANVIEN";
                    cmd = new SqlCommand(sql1, connection);
                    cmd.ExecuteNonQuery();
                    //Tạo câu truy vân Update
                    for (int i = 0; i < lv_DSTK.Items.Count; i++)
                    {
                        string temp1 = lv_DSTK.Items[i].SubItems[0].Text;
                        string temp2 = lv_DSTK.Items[i].SubItems[1].Text;
                        string temp3 = lv_DSTK.Items[i].SubItems[2].Text;
                        string temp4 = lv_DSTK.Items[i].SubItems[3].Text;
                        string temp5 = lv_DSTK.Items[i].SubItems[4].Text;
                        string sql2 = "Delete from NHANVIEN where MaNhanVien='" + temp1 + "'";
                        cmd = new SqlCommand(sql2, connection);
                        cmd.ExecuteNonQuery();
                        string sql = "INSERT INTO NHANVIEN (MaNhanVien,HoTenNhanVien, TenDangNhap, MatKhau, LoaiNV) VALUES(N'" + temp1 + "',N'" + temp2 + "',N'" + temp3 + "',N'" + temp4 + "',N'" + temp5  + "')";
                        cmd = new SqlCommand(sql, connection);
                        cmd.ExecuteNonQuery();
                    }
                    ms = AddIDAuto(lv_DSTK);
                    txtb_MaNV.Text = "NV" + ms;
                    txtb_HoTen.Clear();
                    txtb_TenDN.Clear();
                    txtb_MK.Clear();
                    cbx_LoaiNV.Text = "";
                    MessageBox.Show("Lưu thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                    lv_DSTK.Items.Clear();
                    LoadDSTK();
                }
            }
        }
        private bool Check_in(string[] s, string[]a)
        {
            for (int i=0;i<s.Length;i++)
            {
                if (a.Contains(s[i]) == false)
                    return false;
            }    
            return true;
        }
        private void btn_Sua_LTK_Click(object sender, EventArgs e)
        {
            string[] q = { "Admin", "BS", "KT", "YT", "DS" };
            string[] a = txtb_Quyen.Text.Replace(" ","").Split(',');
            for (int i = 0; i < lv_DSLoai.Items.Count; i++)
            {
                if (lv_DSLoai.Items[i].Selected)
                {

                    if (string.IsNullOrEmpty(txtb_Quyen.Text))
                    {
                        DialogResult dg = MessageBox.Show("Chưa điền đủ thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.No)
                        {
                            txtb_MaLoai.Clear();
                            txtb_TenLoai.Clear();
                            txtb_Quyen.Clear();
                        }
                    }
                    else if(Check_in(a,q)==false)
                    {
                        MessageBox.Show("Loại tài khoản không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
                    else
                    {
                        String[] row = { txtb_MaLoai.Text, txtb_TenLoai.Text, txtb_Quyen.Text };
                        ListViewItem item = new ListViewItem(row);
                        lv_DSLoai.Items[i] = item;
                        txtb_MaLoai.Clear();
                        txtb_TenLoai.Clear();
                        txtb_Quyen.Clear();
                    }
                }
            }
        }

        private void btn_Luu_LTK_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn lưu không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    connection.Open();
                    string sqlpq1 = "DELETE FROM PHANQUYEN";
                    cmd = new SqlCommand(sqlpq1, connection);
                    cmd.ExecuteNonQuery();
                    //Tạo câu truy vân Update
                    for (int i = 0; i < lv_DSLoai.Items.Count; i++)
                    {
                        string temp1 = lv_DSLoai.Items[i].SubItems[0].Text;
                        string temp2 = lv_DSLoai.Items[i].SubItems[1].Text;
                        string temp3 = lv_DSLoai.Items[i].SubItems[2].Text;
                        string sql2 = "Delete from PHANQUYEN where MaLoai='" + temp1 + "'";
                        cmd = new SqlCommand(sql2, connection);
                        cmd.ExecuteNonQuery();
                        string sql = "INSERT INTO PHANQUYEN (MaLoai, Quyen, DoiTuong) VALUES(N'" + temp1 + "',N'" + temp2 + "',N'" + temp3 + "')";
                        cmd = new SqlCommand(sql, connection);
                        cmd.ExecuteNonQuery();
                    }
                    txtb_MaLoai.Clear();
                    txtb_TenLoai.Clear();
                    txtb_Quyen.Clear();
                    MessageBox.Show("Lưu thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                    lv_DSLoai.Items.Clear();
                    LoadDSL();
                }
            }
        }

        private void lv_DSTK_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ms = AddIDAuto(lv_DSTK);
            txtb_MaNV.Text = "NV" + ms;
            txtb_HoTen.Clear();
            txtb_TenDN.Clear();
            txtb_MK.Clear();
            cbx_LoaiNV.Text = "";
        }

        private void lv_DSLoai_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtb_MaLoai.Clear();
            txtb_TenLoai.Clear();
            txtb_Quyen.Clear();
        }
    }
}
