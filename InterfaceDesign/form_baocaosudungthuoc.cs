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
    public partial class form_baocaosudungthuoc : Form
    {
        public form_baocaosudungthuoc()
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
        void LoadBCSDT()
        {
            try
            {
                connection.Open();
                string sql = "SELECT Month(NgayKham) as 'Thang',Year(NgayKham) as 'Nam',TenThuoc, SUM(CT_PHIEUKHAMBENH.SoLuong) as 'So luong dung', COUNT(CT_PHIEUKHAMBENH.MaThuoc) as'So lan dung' " +
                    " FROM  THUOC, CT_PHIEUKHAMBENH, PHIEUKHAMBENH P " +
                    "  WHERE THUOC.MaThuoc=CT_PHIEUKHAMBENH.MaThuoc AND CT_PHIEUKHAMBENH.MaPhieuKhamBenh=P.MaPhieuKhamBenh  " +
                    " GROUP BY P.NgayKham, TenThuoc ";
                cmd = new SqlCommand(sql, connection); 
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader[0].ToString());
                    itm.SubItems.Add(reader[1].ToString());
                    itm.SubItems.Add(reader[2].ToString());
                    itm.SubItems.Add(reader[3].ToString());
                    itm.SubItems.Add(reader[4].ToString());
                    //itm.SubItems.Add(reader[5].ToString());

                    lv_BCSuDungThuoc.Items.Add(itm); 
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
        private void LoadNam()
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
        void LoadTenThuoc()
        {
            DataTable dt = new DataTable();
            connection.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From THUOC", connection);
                da.Fill(dt);
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.ToString());
            }

            try
            {
                cbx_Thuoc.DataSource = dt;
                cbx_Thuoc.DisplayMember = "TenThuoc";
                cbx_Thuoc.ValueMember = "MaThuoc";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }
        private void form_baocaosudungthuoc_Load(object sender, EventArgs e)
        {
            KetNoi();
            LoadTenThuoc();
            LoadBCSDT();
            LoadNam();
        }

        private void btn_Xuat_BCSDT_Click(object sender, EventArgs e)
        {
            try
            {
                if (lv_BCSuDungThuoc.Items.Count== 0)
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
                            ws.Cells[1, 1] = "Tháng";
                            ws.Cells[1, 2] = "Năm";
                            ws.Cells[1, 3] = "Tên Thuốc";
                            ws.Cells[1, 4] = "Số lượng dùng";
                            ws.Cells[1, 5] = "Số lần dùng";
                            int i = 2;

                            foreach (ListViewItem item in lv_BCSuDungThuoc.Items)
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
            
        }

        private void btn_TrangChu_BCSDT_Click(object sender, EventArgs e)
        {
            Form frm = new form_manhinhchinh();
            frm.Show();
            this.Hide();
        }

        private void btn_TroVe_BCSDT_Click(object sender, EventArgs e)
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

        private void btn_KetXuat_BCSDT_Click(object sender, EventArgs e)
        {
            lv_BCSuDungThuoc.Items.Clear();
            try
            {
                connection.Open();
                string lenh = "";
                if (rdbtn_Thang.Checked == true)
                {
                    lenh = "SELECT Month(NgayKham) as N'Tháng',Year(NgayKham) as N'Năm',TenThuoc, SUM(CT_PHIEUKHAMBENH.SoLuong) as N'Số lượng dùng', COUNT(CT_PHIEUKHAMBENH.MaThuoc) as N'Số lần dùng' " +
                        " FROM THUOC, CT_PHIEUKHAMBENH, PHIEUKHAMBENH P  WHERE Month(P.NgayKham)='" + int.Parse(cbx_Thang.Text) + "' " +
                        " AND THUOC.MaThuoc=CT_PHIEUKHAMBENH.MaThuoc AND CT_PHIEUKHAMBENH.MaPhieuKhamBenh=P.MaPhieuKhamBenh " +
                        " GROUP BY NgayKham, TenThuoc ";

                }
                else if (rdbtn_Nam.Checked == true)
                {
                    lenh = "SELECT Month(NgayKham) as N'Tháng',Year(NgayKham) as N'Năm',TenThuoc, SUM(CT_PHIEUKHAMBENH.SoLuong) as N'Số lượng dùng', COUNT(CT_PHIEUKHAMBENH.MaThuoc) as N'Số lần dùng' " +
                        " FROM THUOC, CT_PHIEUKHAMBENH, PHIEUKHAMBENH P  WHERE Year(P.NgayKham)='" + int.Parse(cbx_Nam.Text) + "' " +
                        " AND THUOC.MaThuoc=CT_PHIEUKHAMBENH.MaThuoc AND CT_PHIEUKHAMBENH.MaPhieuKhamBenh=P.MaPhieuKhamBenh  " +
                        " GROUP BY NgayKham, TenThuoc ";

                }
                else
                {
                    lenh = "SELECT Month(NgayKham) as N'Tháng',Year(NgayKham) as N'Năm',TenThuoc, SUM(CT_PHIEUKHAMBENH.SoLuong) as N'Số lượng dùng', COUNT(CT_PHIEUKHAMBENH.MaThuoc) as N'Số lần dùng' " +
                        " FROM THUOC, CT_PHIEUKHAMBENH, PHIEUKHAMBENH P WHERE TenThuoc='" + cbx_Thuoc.Text + "' " +
                        " AND THUOC.MaThuoc=CT_PHIEUKHAMBENH.MaThuoc AND CT_PHIEUKHAMBENH.MaPhieuKhamBenh=P.MaPhieuKhamBenh  " +
                        " GROUP BY NgayKham, TenThuoc ";

                }

                string sql1 = lenh;
                cmd = new SqlCommand(sql1, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                //Tạo câu truy vân Update
                while (reader.Read())
                {
                    //Tao ListviewItem voi text la cot dau tien trong bản ghi (Makh)
                    ListViewItem itm = new ListViewItem(reader[0].ToString());
                    //Moi mot subItem la cac cot tiep theo cua ban ghi                   
                    itm.SubItems.Add(reader[1].ToString());
                    itm.SubItems.Add(reader[2].ToString());
                    itm.SubItems.Add(reader[3].ToString());
                    itm.SubItems.Add(reader[4].ToString());
                    //itm.SubItems.Add(reader[5].ToString());

                    lv_BCSuDungThuoc.Items.Add(itm); //Add item vao listview
                }
                cbx_Nam.Text = "";
                cbx_Thang.Text = "";
                cbx_Thuoc.Text = "";

                MessageBox.Show("Kết xuất thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                //lv_BCSuDungThuoc.Items.Clear();
                //LoadBCSDT();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            LoadBCSDT();
        }
    }
}
