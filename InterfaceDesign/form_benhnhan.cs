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
using System.Globalization;
using System.Configuration;
using Excel = Microsoft.Office.Interop.Excel;


namespace InterfaceDesign
{
    public partial class form_benhnhan : Form
    {
        CultureInfo vn = new CultureInfo("vi-VN");
        public form_benhnhan()
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

        void LoadBN()
        {
            try
            {
                connection.Open();
                string sql = "Select * From BENHNHAN"; 
                cmd = new SqlCommand(sql, connection); 
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader[0].ToString());
                    itm.SubItems.Add(reader[1].ToString());
                    itm.SubItems.Add(reader[2].ToString());
                    itm.SubItems.Add(reader[3].ToString());
                    itm.SubItems.Add(reader[4].ToString());
                    lv_DSBenhNhan.Items.Add(itm);
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
        private void form_benhnhan_Load(object sender, EventArgs e)
        {
            KetNoi();
            connection.Open();
            string stmt = "SELECT COUNT(*) FROM BENHNHAN";
            int count = 0;
            SqlCommand cmdCount = new SqlCommand(stmt, connection);
            count = (int)cmdCount.ExecuteScalar();
            connection.Close();
            if (count > 0)
            {
                LoadBN();
            }
            
            string ms = AddIDAuto(lv_DSBenhNhan);
            txtb_MaBenhNhan.Text = "BN" + ms;
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
        private void btn_Them_BN_Click(object sender, EventArgs e)
        {
            string ms = "";
            int ns;
            bool ktInt=Int32.TryParse(txtb_NamSinh.Text, out ns);
            if ((string.IsNullOrEmpty(txtb_HoTen.Text)) || (string.IsNullOrEmpty(txtb_DiaChi.Text)) || (string.IsNullOrEmpty(txtb_NamSinh.Text)))
            {
                DialogResult dg = MessageBox.Show("Chưa điền đủ thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dg == DialogResult.No)
                {
                    txtb_HoTen.Clear();
                    txtb_DiaChi.Clear();
                    txtb_NamSinh.Clear();
                }
            }
            else if (CheckDouble(lv_DSBenhNhan, txtb_MaBenhNhan.Text) == true)
            {
                MessageBox.Show("Mã bệnh nhân không được lặp lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else if(ktInt==false || ns > DateTime.Now.Year || ns < 0 )
            {
                MessageBox.Show("Vui lòng nhập lại năm sinh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string GT="";
                if (rbtn_Nam.Checked)
                    GT = rbtn_Nam.Text;
                if (rbtn_Nu.Checked)
                    GT = rbtn_Nu.Text;
                try
                {
                    connection.Open();
                    string stmt = "INSERT INTO BENHNHAN(MaBenhNhan, HoTenBenhNhan, GioiTinh,NamSinh,DiaChi ) " +
                        "VALUES('" + txtb_MaBenhNhan.Text.Trim() + "',N'" + txtb_HoTen.Text + "',N'" + GT + "'," + txtb_NamSinh.Text + ",N'" + txtb_DiaChi.Text + "')";
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
                    lv_DSBenhNhan.Items.Clear();
                    LoadBN();
                }
                txtb_HoTen.Clear();
                txtb_DiaChi.Clear();
                txtb_NamSinh.Clear();
            }
            ms = AddIDAuto(lv_DSBenhNhan);
            txtb_MaBenhNhan.Text = "BN" + ms;
        }

        private void btn_Sua_BN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lv_DSBenhNhan.Items.Count; i++)
            {
                if (lv_DSBenhNhan.Items[i].Selected)
                {
                    int nsinh;
                    bool ktInt = Int32.TryParse(txtb_NamSinh.Text, out nsinh);
                    if ((string.IsNullOrEmpty(txtb_HoTen.Text)) || (string.IsNullOrEmpty(txtb_DiaChi.Text)) || (string.IsNullOrEmpty(txtb_NamSinh.Text)))
                    {
                        DialogResult dg = MessageBox.Show("Chưa điền đủ thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.No)
                        {
                            txtb_HoTen.Clear();
                            txtb_DiaChi.Clear();
                            txtb_NamSinh.Clear();
                        }
                    }
                    else if (ktInt == false || nsinh > DateTime.Now.Year || nsinh <= 0)
                    {
                        MessageBox.Show("Vui lòng nhập lại năm sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string GT = "";
                        if (rbtn_Nam.Checked)
                            GT = rbtn_Nam.Text;
                        if (rbtn_Nu.Checked)
                            GT = rbtn_Nu.Text;
                        try
                        {
                            connection.Open();
                            string stmt = "update BENHNHAN " +
                                "set HoTenBenhNhan=N'" + txtb_HoTen.Text + "', GioiTinh=N'" + GT + "',NamSinh=" + txtb_NamSinh.Text + ",DiaChi=N'" + txtb_DiaChi.Text + "'" +
                                " where MaBenhNhan = '" + txtb_MaBenhNhan.Text.Trim() + "'";
                            SqlCommand cmdCount = new SqlCommand(stmt, connection);
                            cmdCount.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                            lv_DSBenhNhan.Items.Clear();
                            LoadBN();
                        }
                        txtb_HoTen.Clear();
                        txtb_DiaChi.Clear();
                        txtb_NamSinh.Clear();
                    }
                }
            }
            string ms = AddIDAuto(lv_DSBenhNhan);
            txtb_MaBenhNhan.Text = "BN" + ms;
        }

        private void btn_Xoa_BN_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa không?", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                for (int i = 0; i < lv_DSBenhNhan.Items.Count; i++)
                {
                    if (lv_DSBenhNhan.Items[i].Selected)
                    {
                        try
                        {
                            connection.Open();
                            string stmt = "select count(*) from PHIEUKHAMBENH where MaBenhNhan = '" + lv_DSBenhNhan.Items[i].SubItems[0].Text.Trim() + "'";
                            int count = 0;
                            SqlCommand cmdCount = new SqlCommand(stmt, connection);
                            count = (int)cmdCount.ExecuteScalar();
                            connection.Close();
                            if (count == 0)
                            {
                                connection.Open();
                                string s = "Delete from BENHNHAN where MaBenhNhan = '" + lv_DSBenhNhan.Items[i].SubItems[0].Text.Trim() + "'";
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
                            lv_DSBenhNhan.Items.Clear();
                            LoadBN();
                        }
                    }
                }
                string ms = AddIDAuto(lv_DSBenhNhan);
                txtb_MaBenhNhan.Text = "BN" + ms;
                txtb_HoTen.Clear();
                txtb_DiaChi.Clear();
                txtb_NamSinh.Clear();
            }
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            Form frm = new form_manhinhchinh();
            frm.Show();
            this.Hide();
        }

        private void btn_TroVe_BenhNhan_Click(object sender, EventArgs e)
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

        private void lv_DSBenhNhan_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem items in lv_DSBenhNhan.SelectedItems)
            {
                txtb_MaBenhNhan.Text = items.SubItems[0].Text;
                txtb_HoTen.Text = items.SubItems[1].Text;
                if (items.SubItems[2].Text == "Nam")
                {
                    this.rbtn_Nam.Checked = true;

                }
                else
                {
                    this.rbtn_Nu.Checked = true;
                }
                txtb_NamSinh.Text = items.SubItems[3].Text;
                txtb_DiaChi.Text = items.SubItems[4].Text;
            }
                        
        }
        
        private void lv_DSBenhNhan_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string ms = AddIDAuto(lv_DSBenhNhan);
            txtb_MaBenhNhan.Text = "BN" + ms;
            txtb_HoTen.Clear();
            txtb_DiaChi.Clear();
            txtb_NamSinh.Clear();
        }

        private void btn_Xuat_DSBN_Click(object sender, EventArgs e)
        {
            try
            {
                if (lv_DSBenhNhan.Items.Count == 0)
                    MessageBox.Show("Rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xls", ValidateNames = true })
                    {
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            Excel.Application app = new Excel.Application();
                            Excel.Workbook wb = app.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
                            Excel.Worksheet ws = (Excel.Worksheet)app.ActiveSheet;
                            app.Visible = false;
                            ws.Cells[1, 1] = "Mã bệnh nhân";
                            ws.Cells[1, 2] = "Họ tên";
                            ws.Cells[1, 3] = "Giới tính";
                            ws.Cells[1, 4] = "Năm sinh";
                            ws.Cells[1, 5] = "Địa chỉ";
                            int i = 2;

                            foreach (ListViewItem item in lv_DSBenhNhan.Items)
                            {
                                ws.Cells[i, 1] = item.SubItems[0].Text;
                                ws.Cells[i, 2] = item.SubItems[1].Text;
                                ws.Cells[i, 3] = item.SubItems[2].Text;
                                ws.Cells[i, 4] = item.SubItems[3].Text;
                                ws.Cells[i, 5] = item.SubItems[4].Text;
                                i++;
                            }
                            wb.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                            app.Quit();
                            MessageBox.Show("Xuất file Excel thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.ToString());
            }
            string ms = AddIDAuto(lv_DSBenhNhan);
            txtb_MaBenhNhan.Text = "BN" + ms;
        }
    }
}
