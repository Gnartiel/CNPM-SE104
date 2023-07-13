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
    public partial class form_baocaodoanhthu : Form
    {
        public form_baocaodoanhthu()
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
        void LoadBCDT()
        {
            try
            {
                connection.Open();
                string sql = "SELECT  Month(NgayKham) as N'Tháng', Year(NgayKham) as N'Năm', sum(TongTien) as'Tổng Doanh Thu' " +
                    "FROM PHIEUKHAMBENH GROUP BY Month(NgayKham), Year(NgayKham) ORDER BY Year(NgayKham)";
                cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    ListViewItem itm = new ListViewItem(reader[0].ToString());
                    itm.SubItems.Add(reader[1].ToString());
                    itm.SubItems.Add(reader[2].ToString() + "VND");

                    lv_BCDoanhThu.Items.Add(itm);
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
        void LoadNam()
        {
            DataTable dt = new DataTable();
            connection.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select DISTINCT Year(NgayKham) as NAM From PHIEUKHAMBENH", connection);
                da.Fill(dt);
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.ToString());
            }

            try
            {
                cbx_Nam.DataSource = dt;
                cbx_Nam.DisplayMember = "NAM";
                cbx_Nam.ValueMember = "NAM";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }
        
        private void form_baocaodoanhthu_Load(object sender, EventArgs e)
        {
            KetNoi();
            LoadNam();
            LoadBCDT();
 
        }

        private void btn_TrangChu_BCDT_Click(object sender, EventArgs e)
        {
            Form frm = new form_manhinhchinh();
            frm.Show();
            this.Hide();
        }

        private void btn_TroVe_BCDT_Click(object sender, EventArgs e)
        {
            Form frm = new form_ketxuat();
            frm.Show();
            this.Hide();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_Xuat_BCDT_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xls", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                        Excel.Workbook wb = app.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
                        Excel.Worksheet ws = (Excel.Worksheet)app.ActiveSheet;
                        app.Visible = false;
                        ws.Cells[1, 1] = "Tháng";
                        ws.Cells[1, 2] = "Năm";
                        ws.Cells[1, 3] = "Tổng Doanh Thu";

                        int i = 2;
                        foreach (ListViewItem item in lv_BCDoanhThu.Items)
                        {
                            ws.Cells[i, 1] = item.SubItems[0].Text;
                            ws.Cells[i, 2] = item.SubItems[1].Text;
                            ws.Cells[i, 3] = item.SubItems[2].Text;
        
                            i++;
                        }
                        wb.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                        app.Quit();
                        MessageBox.Show("Xuất file Excel thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                lv_BCDoanhThu.Items.Clear();
                LoadBCDT();
            }
        }

        private void lv_BCDoanhThu_MouseClick(object sender, MouseEventArgs e)
        {
            lv_CTBCDoanhThu.Items.Clear();
            foreach (ListViewItem items in lv_BCDoanhThu.SelectedItems)
            {
                connection.Open();
                string sql1 = "Select Day(NgayKham) N'Ngày', Month(NgayKham) N'Tháng', Year(NgayKham) N'Năm', SUM(P.TongTien) DoanhThu, COUNT(MaPhieuKhamBenh) N'Số Bệnh Nhân', N'Tỷ Lệ' " +
                    " FROM PHIEUKHAMBENH P " +
                    "WHERE Month(NgayKham) =  " + items.SubItems[0].Text + " and Year(NgayKham)=" + items.SubItems[1].Text +
                    " GROUP BY Day(NgayKham), Month(NgayKham), Year(NgayKham)";

                cmd = new SqlCommand(sql1, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader[0].ToString());
                    itm.SubItems.Add(reader[1].ToString());
                    itm.SubItems.Add(reader[2].ToString());
                    itm.SubItems.Add(reader[3].ToString());
                    itm.SubItems.Add(reader[4].ToString());
                    itm.SubItems.Add("");

                    lv_CTBCDoanhThu.Items.Add(itm);
                }
                for (int i = 0; i < lv_CTBCDoanhThu.Items.Count; i++)
                {
                    double tyle = 0;
                    string t = items.SubItems[2].Text.Replace("VND", "");
                    tyle = double.Parse(lv_CTBCDoanhThu.Items[i].SubItems[3].Text) / double.Parse(t) * 100.0;
                    string[] row = { lv_CTBCDoanhThu.Items[i].SubItems[0].Text, lv_CTBCDoanhThu.Items[i].SubItems[1].Text, lv_CTBCDoanhThu.Items[i].SubItems[2].Text, lv_CTBCDoanhThu.Items[i].SubItems[3].Text, lv_CTBCDoanhThu.Items[i].SubItems[4].Text, Math.Round(tyle, 2).ToString() + "%" };
                    ListViewItem tem = new ListViewItem(row);
                    lv_CTBCDoanhThu.Items[i] = tem;


                }
                connection.Close();
            }
        }

        private void btn_KetXuat_BCDT_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string lenh = "";
                lenh = "SELECT Month(NgayKham) as N'Tháng', Year(NgayKham) as N'Năm', sum(TongTien) as'Tổng Doanh Thu' FROM PHIEUKHAMBENH WHERE Year(NgayKham)='" + int.Parse(cbx_Nam.Text) + "' GROUP BY Month(NgayKham), Year(NgayKham)";
                lv_BCDoanhThu.Items.Clear();
                string sql1 = lenh;
                cmd = new SqlCommand(sql1, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader[0].ToString());
                    itm.SubItems.Add(reader[1].ToString());
                    itm.SubItems.Add(reader[2].ToString() + "VND");
                    lv_BCDoanhThu.Items.Add(itm);
                }

                cbx_Nam.Text = "";
                MessageBox.Show("Kết xuất thành công");
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

        private void btn_Xuat_CTBCDT_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xls", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Excel.Workbook wb = app.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
                    Excel.Worksheet ws = (Excel.Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Ngày";
                    ws.Cells[1, 2] = "Tháng";
                    ws.Cells[1, 3] = "Năm";
                    ws.Cells[1, 4] = "Doanh Thu";
                    ws.Cells[1, 5] = "Số Bệnh Nhân";
                    ws.Cells[1, 6] = "Tỷ Lệ";
                    int i = 2;
                    foreach (ListViewItem item in lv_CTBCDoanhThu.Items)
                    {
                        ws.Cells[i, 1] = item.SubItems[0].Text;
                        ws.Cells[i, 2] = item.SubItems[1].Text;
                        ws.Cells[i, 3] = item.SubItems[2].Text;
                        ws.Cells[i, 4] = item.SubItems[3].Text;
                        ws.Cells[i, 5] = item.SubItems[4].Text;
                        ws.Cells[i, 6] = item.SubItems[5].Text;
                        i++;
                    }
                    wb.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("Xuất file Excel thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  }
            }
        }
    }
}
