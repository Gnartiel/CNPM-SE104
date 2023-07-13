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
    public partial class form_donvicachdung : Form
    {
        public form_donvicachdung()
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

        private void form_donvicachdung_Load(object sender, EventArgs e)
        {
            KetNoi();
            connection.Open();
            string stmt = "SELECT COUNT(*) FROM CACHDUNG";
            int count = 0;
            SqlCommand cmdCount = new SqlCommand(stmt, connection);
            count = (int)cmdCount.ExecuteScalar();
            connection.Close();
            if (count > 0)
            {
                LoadCD();
            }
            connection.Open();
            string stmt2 = "SELECT COUNT(*) FROM DONVI";
            int count2 = 0;
            SqlCommand cmdCount2 = new SqlCommand(stmt2, connection);
            count2 = (int)cmdCount2.ExecuteScalar();
            connection.Close();
            if (count2 > 0)
            {
                LoadDV();
            }
            mdv = AddIDAuto(lv_DonVi);
            txtb_MaDV.Text = "DV" + mdv;
            mcd = AddIDAuto(lv_CachDung);
            txtb_MaCD.Text = "CD" + mcd;
        }
                
        private void btn_TrangChu_DonViCachDung_Click(object sender, EventArgs e)
        {
            Form frm = new form_manhinhchinh();
            frm.Show();
            this.Hide();
        }

        private void btn_Trove_DonViCachDung_Click(object sender, EventArgs e)
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

        //
        //Đơn vị
        //
        string mdv = "";
        void LoadDV()
        {
            try
            {
                connection.Open();
                string sql = "Select * From DONVI";
                cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader[0].ToString());
                    itm.SubItems.Add(reader[1].ToString());
                    lv_DonVi.Items.Add(itm);
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
        private void btn_Them_ThemDonVi_Click(object sender, EventArgs e)
        {
            connection.Open();
            string stmt4 = "select count(*) from DONVI where TenDonVi = N'" + txtb_TenDV.Text.Trim() + "'";
            int count4 = 0;
            SqlCommand cmdCount4 = new SqlCommand(stmt4, connection);
            count4 = (int)cmdCount4.ExecuteScalar();
            connection.Close();
            if ((string.IsNullOrEmpty(txtb_TenDV.Text)))
            {
                DialogResult dg = MessageBox.Show("Chưa điền đủ thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.No)
                {
                    txtb_MaDV.Clear();
                    txtb_TenDV.Clear();
                }
            }
            else if (CheckDouble(lv_DonVi, txtb_MaDV.Text) == true)
            {
                MessageBox.Show("Mã đơn vị không được lặp lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (count4 >0)
            {
                MessageBox.Show("Tên đơn vị đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else
            {
                try
                {
                    connection.Open();
                    string stmt = "INSERT INTO DONVI(MaDonVi, TenDonVi) VALUES('" + txtb_MaDV.Text.Trim() + "',N'" + txtb_TenDV.Text + "')";
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
                    lv_DonVi.Items.Clear();
                    LoadDV();
                }
                txtb_MaDV.Clear();
                txtb_TenDV.Clear();
            }
            mdv = AddIDAuto(lv_DonVi);
            txtb_MaDV.Text = "DV" + mdv;
        }

        private void btn_Sua_SuaDonVi_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lv_DonVi.Items.Count; i++)
            {
                if (lv_DonVi.Items[i].Selected)
                {
                    if ((string.IsNullOrEmpty(txtb_TenDV.Text)))
                    {
                        DialogResult dg = MessageBox.Show("Chưa điền đủ thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.No)
                        {
                            txtb_TenDV.Clear();
                        }
                    }
                    else
                    {
                        try
                        {
                            connection.Open();
                            string stmt = "update DONVI set TenDonVi=N'" + txtb_TenDV.Text + "' where MaDonVi = '" + txtb_MaDV.Text.Trim() + "'";
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
                            lv_DonVi.Items.Clear();
                            LoadDV();
                        }
                        
                        txtb_TenDV.Clear();
                    }
                }
            }
            mdv = AddIDAuto(lv_DonVi);
            txtb_MaDV.Text = "DV" + mdv;
        }


        private void btn_Xoa_XoaDonVi_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa không?", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                for (int i = 0; i < lv_DonVi.Items.Count; i++)
                {
                    if (lv_DonVi.Items[i].Selected)
                    {
                        try
                        {
                            connection.Open();
                            string stmt = "select count(*) from THUOC where MaDonVi = '" + lv_DonVi.Items[i].SubItems[0].Text + "'";
                            int count = 0;
                            SqlCommand cmdCount = new SqlCommand(stmt, connection);
                            count = (int)cmdCount.ExecuteScalar();
                            connection.Close();
                            if (count == 0)
                            {
                                connection.Open();
                                string s = "Delete from DONVI where MaDonVi = '" + lv_DonVi.Items[i].SubItems[0].Text.Trim() + "'";
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
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                            lv_DonVi.Items.Clear();
                            LoadDV();
                        }
                    }
                }
                mdv = AddIDAuto(lv_DonVi);
                txtb_MaDV.Text = "DV" + mdv;
                txtb_TenDV.Clear();
            }
        }
        private void lv_DonVi_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem items in lv_DonVi.SelectedItems)
            {
                txtb_MaDV.Text = items.SubItems[0].Text;
                txtb_TenDV.Text = items.SubItems[1].Text;
            }
        }

        private void lv_DonVi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            mdv = AddIDAuto(lv_DonVi);
            txtb_MaDV.Text = "DV" + mdv;
            txtb_TenDV.Clear();
        }
        //
        //Cách dùng
        //
        string mcd = "";
        void LoadCD()
        {
            try
            {
                connection.Open();
                string sql = "Select * From CACHDUNG";
                cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader[0].ToString());
                    itm.SubItems.Add(reader[1].ToString());
                    lv_CachDung.Items.Add(itm);
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
        private void btn_Them_ThemCachDung_Click(object sender, EventArgs e)
        {
            connection.Open();
            string stmt4 = "select count(*) from CACHDUNG where TenCachDung = N'" + txtb_TenCD.Text.Trim() + "'";
            int count4 = 0;
            SqlCommand cmdCount4 = new SqlCommand(stmt4, connection);
            count4 = (int)cmdCount4.ExecuteScalar();
            connection.Close();
            if ((string.IsNullOrEmpty(txtb_TenCD.Text)))
            {
                DialogResult dg = MessageBox.Show("Chưa điền đủ thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.No)
                { 
                    txtb_TenCD.Clear();
                }
            }
            else if (CheckDouble(lv_CachDung, txtb_MaCD.Text) == true)
            {
                MessageBox.Show("Mã cách dùng không được lặp lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (count4 > 0)
            {
                MessageBox.Show("Tên cách dùng đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connection.Open();
                    string stmt = "INSERT INTO CACHDUNG(MaCachDung, TenCachDung) VALUES('" + txtb_MaCD.Text.Trim() + "',N'" + txtb_TenCD.Text + "')";
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
                    lv_CachDung.Items.Clear();
                    LoadCD();
                }
                txtb_TenCD.Clear();
            }
            mcd = AddIDAuto(lv_CachDung);
            txtb_MaCD.Text = "CD" + mcd;
        }

        private void btn_Sua_SuaCachDung_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lv_CachDung.Items.Count; i++)
            {
                if (lv_CachDung.Items[i].Selected)
                {
                    if (string.IsNullOrEmpty(txtb_TenCD.Text))
                    {
                        DialogResult dg = MessageBox.Show("Chưa điền đủ thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.No)
                        {
                            txtb_TenCD.Clear();
                        }
                    }
                    else
                    {
                        try
                        {
                            connection.Open();
                            string stmt = "update CACHDUNG set TenCachDung=N'" + txtb_TenCD.Text + "' where MaCachDung = '" + txtb_MaCD.Text.Trim() + "'";
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
                            lv_CachDung.Items.Clear();
                            LoadCD();
                        }

                        txtb_TenCD.Clear();
                    }
                }
            }
            mcd = AddIDAuto(lv_CachDung);
            txtb_MaCD.Text = "CD" + mcd;
        }

        private void btn_Xoa_XoaCachDung_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa không?", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                for (int i = 0; i < lv_CachDung.Items.Count; i++)
                {
                    if (lv_CachDung.Items[i].Selected)
                    {
                        try
                        {
                            connection.Open();
                            string stmt = "select count(*) from THUOC where MaCachDung = '" + lv_CachDung.Items[i].SubItems[0].Text + "'";
                            int count = 0;
                            SqlCommand cmdCount = new SqlCommand(stmt, connection);
                            count = (int)cmdCount.ExecuteScalar();
                            connection.Close();
                            if (count == 0)
                            {
                                connection.Open();
                                string s = "Delete from CACHDUNG where MaCachDung = '" + lv_CachDung.Items[i].SubItems[0].Text.Trim() + "'";
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
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                            lv_CachDung.Items.Clear();
                            LoadCD();
                        }
                    }
                }
                txtb_TenCD.Clear();
                mcd = AddIDAuto(lv_CachDung);
                txtb_MaCD.Text = "CD" + mcd;
            }
        }

        private void lv_CachDung_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem items in lv_CachDung.SelectedItems)
            {
                txtb_MaCD.Text = items.SubItems[0].Text;
                txtb_TenCD.Text = items.SubItems[1].Text;
            }
        }
        private void lv_CachDung_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            mcd = AddIDAuto(lv_CachDung);
            txtb_MaCD.Text = "CD" + mcd;
            txtb_TenCD.Clear();
        }
    }
}
