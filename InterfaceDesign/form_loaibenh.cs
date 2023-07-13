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
    public partial class form_loaibenh : Form
    {
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
        private void form_loaibenh_Load(object sender, EventArgs e)
        {
            KetNoi();
            connection.Open();
            string stmt = "SELECT COUNT(*) FROM LOAIBENH";
            int count = 0;
            SqlCommand cmdCount = new SqlCommand(stmt, connection);
            count = (int)cmdCount.ExecuteScalar();
            connection.Close();
            if (count > 0)
            {
                LoadListview();
            }
            string ms  = AddIDAuto(lv_LoaiBenh);
            txtb_MaLoaiBenh.Text = "LB" + ms;
        }

        void LoadListview()
        {
            try
            {
                connection.Open();
                string sql = "Select * From LOAIBENH"; 
                cmd = new SqlCommand(sql, connection); 
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader[0].ToString());
                    itm.SubItems.Add(reader[1].ToString());
                    itm.SubItems.Add(reader[2].ToString());
                    lv_LoaiBenh.Items.Add(itm);
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

        public form_loaibenh()
        {
            InitializeComponent();
        }

        private void btn_TrangChu_LoaiBenh_Click(object sender, EventArgs e)
        {
            Form frm = new form_manhinhchinh();
            frm.Show();
            this.Hide();
        }

        private void btn_TroVe_LoaiBenh_Click(object sender, EventArgs e)
        {
            Form frm = new form_danhsach();
            frm.Show();
            this.Hide();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa không?", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                for (int i = 0; i < lv_LoaiBenh.Items.Count; i++)
                {
                    if (lv_LoaiBenh.Items[i].Selected)
                    {
                        try
                        {
                            connection.Open();
                            string stmt = "select count(*) from CT_BENH where MaLoaiBenh = '" + lv_LoaiBenh.Items[i].SubItems[0].Text + "'";
                            int count = 0;
                            SqlCommand cmdCount = new SqlCommand(stmt, connection);
                            count = (int)cmdCount.ExecuteScalar();
                            connection.Close();
                            if (count == 0)
                            {
                                connection.Open();
                                string s = "Delete from LOAIBENH where MaLoaiBenh= '" + lv_LoaiBenh.Items[i].SubItems[0].Text.Trim() + "'";
                                SqlCommand cmd = new SqlCommand(s, connection);
                                cmd.ExecuteNonQuery();
                                connection.Close();
                                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                DialogResult dg = MessageBox.Show("Đối tượng hiện đang được sử dụng, không thể xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                if (dg == DialogResult.OK)
                                    return;
                            }
                        }
                        finally
                        {
                            connection.Close();
                            lv_LoaiBenh.Items.Clear();
                            LoadListview();
                        }
                    }
                }
                string ms  = AddIDAuto(lv_LoaiBenh);
                txtb_MaLoaiBenh.Text = "LB" + ms;
                txtb_TenBenh.Clear();
                txtb_TrieuChung.Clear();
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private string AddIDAuto(ListView lv)
        {
            if (lv.Items.Count == 0)
                return "001";
            string r = lv.Items[lv.Items.Count - 1].SubItems[0].Text.Replace(" ","");
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

        private void btn_Them_Click(object sender, EventArgs e)
        {
            connection.Open();
            string stmt4 = "select count(*) from LOAIBENH where TenLoaiBenh = N'" + txtb_TenBenh.Text.Trim() + "'";
            int count4 = 0;
            SqlCommand cmdCount4 = new SqlCommand(stmt4, connection);
            count4 = (int)cmdCount4.ExecuteScalar();
            connection.Close();
            if ((string.IsNullOrEmpty(txtb_TenBenh.Text)) || (string.IsNullOrEmpty(txtb_TrieuChung.Text)))
            {
                DialogResult dg = MessageBox.Show("Chưa điền đủ thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.No)
                {
                    txtb_TenBenh.Clear();
                    txtb_TrieuChung.Clear();
                }
            }
            else if (CheckDouble(lv_LoaiBenh, txtb_MaLoaiBenh.Text) == true)
            {
                MessageBox.Show("Mã loại bệnh không được lặp lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (count4 > 0)
            {
                MessageBox.Show("Tên loại bệnh đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connection.Open();
                    string stmt = "INSERT INTO LOAIBENH(MaLoaiBenh, TenLoaiBenh, TrieuChung) " +
                        "VALUES('" + txtb_MaLoaiBenh.Text.Trim() + "',N'" + txtb_TenBenh.Text + "',N'" + txtb_TrieuChung.Text + "')";
                    SqlCommand cmdCount = new SqlCommand(stmt, connection);
                    cmdCount.ExecuteNonQuery();
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
                    lv_LoaiBenh.Items.Clear();
                    LoadListview();
                }

                txtb_TenBenh.Clear();
                txtb_TrieuChung.Clear();
            }
            string ms = AddIDAuto(lv_LoaiBenh);
            txtb_MaLoaiBenh.Text = "LB" + ms;
        }
        
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lv_LoaiBenh.Items.Count; i++)
            {
                if (lv_LoaiBenh.Items[i].Selected)
                {
                    if ((string.IsNullOrEmpty(txtb_TenBenh.Text)) || (string.IsNullOrEmpty(txtb_TrieuChung.Text)))
                    {
                        DialogResult dg = MessageBox.Show("Chưa điền đủ thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.No)
                        {
                            txtb_TenBenh.Clear();
                            txtb_TrieuChung.Clear();
                        }
                    }
                    else
                    {
                        try
                        {
                            connection.Open();
                            string stmt = "update LOAIBENH set TenLoaiBenh=N'" + txtb_TenBenh.Text+"',TrieuChung=N'"+ txtb_TrieuChung.Text + "'" +
                                " where MaLoaiBenh = '" + txtb_MaLoaiBenh.Text.Trim() + "'";
                            SqlCommand cmdCount = new SqlCommand(stmt, connection);
                            cmdCount.ExecuteNonQuery();
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
                            lv_LoaiBenh.Items.Clear();
                            LoadListview();
                        }

                        txtb_TenBenh.Clear();
                        txtb_TrieuChung.Clear();
                    }
                }
            }
            string ms = AddIDAuto(lv_LoaiBenh);
            txtb_MaLoaiBenh.Text = "LB" + ms;
        }

        private void lv_LoaiBenh_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem items in lv_LoaiBenh.SelectedItems)
            {
                txtb_MaLoaiBenh.Text = items.SubItems[0].Text;
                txtb_TenBenh.Text = items.SubItems[1].Text;
                txtb_TrieuChung.Text = items.SubItems[2].Text;
            }
        }

        private void lv_LoaiBenh_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string ms = AddIDAuto(lv_LoaiBenh);
            txtb_MaLoaiBenh.Text = "LB" + ms;
            txtb_TenBenh.Clear();
            txtb_TrieuChung.Clear();
        }
    }
    
}
