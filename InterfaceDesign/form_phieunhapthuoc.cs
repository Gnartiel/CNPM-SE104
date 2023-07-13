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
using Excel=Microsoft.Office.Interop.Excel;

namespace InterfaceDesign
{
    public partial class form_phieunhapthuoc : Form
    {
        public form_phieunhapthuoc()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommand cmd;
        string sql0 = "set dateformat DMY";
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
        private void btn_TrangChu_PNT_Click(object sender, EventArgs e)
        {
            Form frm = new form_manhinhchinh();
            frm.Show();
            this.Hide();
        }

        private void btn_TroVe_PNT_Click(object sender, EventArgs e)
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
        private void form_phieunhapthuoc_Load(object sender, EventArgs e)
        {
            KetNoi();
            connection.Open();
            string stmt = "SELECT COUNT(*) FROM PHIEUNHAPTHUOC";
            int count = 0;
            SqlCommand cmdCount = new SqlCommand(stmt, connection);
            count = (int)cmdCount.ExecuteScalar();
            connection.Close();
            if (count > 0)
            {
                LoadDSPNT();
            }
            LoadTenThuoc();
            string ms = AddIDAuto(lv_DSPNT);
            txtb_MaPN_TTPNT.Text = "PN" + ms;
        }

        //
        //PNT
        //
        void LoadDSPNT()
        {
            try
            {
                connection.Open();
                cmd = new SqlCommand(sql0, connection);
                cmd.ExecuteNonQuery();
                string sql = "Select * From PHIEUNHAPTHUOC"; 
                cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader[0].ToString());
                    itm.SubItems.Add(reader[1].ToString().Substring(0,10));
                    itm.SubItems.Add(reader[2].ToString());
                    itm.SubItems.Add(reader[3].ToString());
                    lv_DSPNT.Items.Add(itm);
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
        private void btn_Them_ThongTinPNK_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(dtpk_NgayNhap.Text)))
            {
                DialogResult dg = MessageBox.Show("Chưa điền đủ thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.No)
                {
                    dtpk_NgayNhap.Value = DateTime.Now;
                }
            }
            else if (CheckDouble(lv_DSPNT, txtb_MaPN_TTPNT.Text.Trim()) == true)
            {
                MessageBox.Show("Mã phiếu khám không được lặp lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtpk_NgayNhap.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày nhập thuốc không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int sln = 0, dg = 0;
                try
                {
                    connection.Open();
                    cmd = new SqlCommand(sql0, connection);
                    cmd.ExecuteNonQuery();
                    string stmt = "INSERT INTO PHIEUNHAPTHUOC(MaPhieuNhap, NgayNhap,SoLuong,TongTienNhap) " +
                        "VALUES('" + txtb_MaPN_TTPNT.Text.Trim() + "','" + dtpk_NgayNhap.Text + "'," + sln + ", " + dg + ")";
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
                    lv_DSPNT.Items.Clear();
                    LoadDSPNT();
                }
                dtpk_NgayNhap.Value = DateTime.Now;
            }
            string ms = AddIDAuto(lv_DSPNT);
            txtb_MaPN_TTPNT.Text = "PN" + ms;
        }
        private void btn_Sua_DSPNT_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lv_DSPNT.Items.Count; i++)
            {
                if (lv_DSPNT.Items[i].Selected)
                {
                    if ((string.IsNullOrEmpty(dtpk_NgayNhap.Text)))
                    {
                        DialogResult dg = MessageBox.Show("Chưa điền đủ thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.No)
                        {
                            
                            dtpk_NgayNhap.Value = DateTime.Now;
                        }
                    }
                    else if (dtpk_NgayNhap.Value > DateTime.Now)
                    {
                        MessageBox.Show("Ngày nhập thuốc không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            connection.Open();
                            cmd = new SqlCommand(sql0, connection);
                            cmd.ExecuteNonQuery();
                            string stmt = "update PHIEUNHAPTHUOC set NgayNhap='" + dtpk_NgayNhap.Text + "' where MaPhieuNhap = '" + txtb_MaPN_TTPNT.Text.Trim() + "'";
                            SqlCommand cmdCount = new SqlCommand(stmt, connection);
                            cmdCount.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Cập nhật danh sách phiếu nhập thuốc thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                            lv_DSPNT.Items.Clear();
                            LoadDSPNT();
                        }
                        dtpk_NgayNhap.Value = DateTime.Now;
                    }
                    string ms = AddIDAuto(lv_DSPNT);
                    txtb_MaPN_TTPNT.Text = "PN" + ms;
                }
            }
        }

        private void btn_Xoa_DSPNT_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa không?", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                for (int i = 0; i < lv_DSPNT.Items.Count; i++)
                {
                    if (lv_DSPNT.Items[i].Selected)
                    {
                        try
                        {
                            connection.Open();
                            string stmt = "select count(*) from CT_PHIEUNHAPTHUOC where MaPhieuNhap = '" + txtb_MaPN_TTPNT.Text.Trim() + "'";
                            int count = 0;
                            SqlCommand cmdCount = new SqlCommand(stmt, connection);
                            count = (int)cmdCount.ExecuteScalar();
                            connection.Close();
                            if (count == 0)
                            {
                                connection.Open();
                                string s = "Delete from PHIEUNHAPTHUOC where MaPhieuNhap = '" + txtb_MaPN_TTPNT.Text.Trim() + "'";
                                SqlCommand cmd = new SqlCommand(s, connection);
                                cmd.ExecuteNonQuery();
                                connection.Close();
                                lv_DSPNT.Items.Clear();
                                LoadDSPNT();
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
                        }
                    }
                }
                string ms = AddIDAuto(lv_DSPNT);
                txtb_MaPN_TTPNT.Text = "PN" + ms;
                dtpk_NgayNhap.Value = DateTime.Now;
            }
        }
        private void btn_Xuat_DSPNT_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xls", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Excel.Application app = new Excel.Application();
                    Excel.Workbook wb = app.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
                    Excel.Worksheet ws = (Excel.Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Mã Phiếu Nhập";
                    ws.Cells[1, 2] = "Ngày Nhập";
                    ws.Cells[1, 3] = "Số Lượng Nhập";
                    ws.Cells[1, 4] = "Tổng Tiền";
                    int i = 2;
                    foreach (ListViewItem item in lv_DSPNT.Items)
                    {
                        ws.Cells[i, 1] = item.SubItems[0].Text;
                        ws.Cells[i, 2] = DateTime.Parse(item.SubItems[1].Text);
                        ws.Cells[i, 3] = item.SubItems[2].Text;
                        ws.Cells[i, 4] = item.SubItems[3].Text;
                        i++;
                    }
                    wb.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("Xuất file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            string ms = AddIDAuto(lv_DSPNT);
            txtb_MaPN_TTPNT.Text = "PN" + ms;
        }
        private void lv_DSPNT_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem items in lv_DSPNT.SelectedItems)
            {
                txtb_MaPN_TTPNT.Text = items.SubItems[0].Text;
                dtpk_NgayNhap.Value = DateTime.Parse(items.SubItems[1].Text);
                lv_CTPNT.Items.Clear();
                connection.Open();
                string stmt = "SELECT COUNT(*) FROM CT_PHIEUNHAPTHUOC where MaPhieuNhap='" + txtb_MaPN_TTPNT.Text + "'";
                int count = 0;
                SqlCommand cmdCount = new SqlCommand(stmt, connection);
                count = (int)cmdCount.ExecuteScalar();
                if (count > 0)
                {
                    connection.Close();
                    LoadCTPNT(txtb_MaPN_TTPNT.Text);
                }
                connection.Close();
                txtb_MaPN_CTPNT.Text = txtb_MaPN_TTPNT.Text;
            }
            
        }
        private void lv_DSPNT_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lv_CTPNT.Items.Clear();
            string ms = AddIDAuto(lv_DSPNT);
            txtb_MaPN_TTPNT.Text = "PN" + ms;
            dtpk_NgayNhap.Value = DateTime.Now;
            txtb_MaPN_CTPNT.Text = "";
        }
        //
        //CTPNT
        //
        private SqlDataAdapter da,da1;
        private DataSet ds,ds1;
        private System.Data.DataTable table,table1,table2;
        private SqlDataAdapter db;
        private DataSet du;

        void LoadCTPNT(string mpn)
        {
            try
            {
                connection.Open();
                cmd = new SqlCommand(sql0, connection);
                cmd.ExecuteNonQuery();

                string sql1 = "Select * from CT_PHIEUNHAPTHUOC where MaPhieuNhap='" + mpn + "'";
                cmd = new SqlCommand(sql1, connection); 
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader[1].ToString());

                    itm.SubItems.Add("");
                    itm.SubItems.Add(reader[2].ToString());
                    itm.SubItems.Add(reader[3].ToString());
                    itm.SubItems.Add(reader[4].ToString());
                    itm.SubItems.Add(reader[5].ToString());
                    lv_CTPNT.Items.Add(itm);
                }
                connection.Close();
                for (int i = 0; i < lv_CTPNT.Items.Count; i++)
                {
                    connection.Open();
                    string sql = "Select TenDonVi From THUOC, DONVI WHERE (DONVI.MaDonVi=THUOC.MaDonVi and MaThuoc =N'" + lv_CTPNT.Items[i].SubItems[0].Text.Trim() + "')";
                    da = new SqlDataAdapter(sql, connection);
                    ds = new DataSet();
                    da.Fill(ds, "THUOC");
                    table = ds.Tables["THUOC"];
                    string dv = table.Rows[0]["TenDonVi"].ToString();
                    connection.Close();
                    connection.Open();
                    string sql_th = "Select TenThuoc From THUOC WHERE MaThuoc =N'" + lv_CTPNT.Items[i].SubItems[0].Text.Trim() + "'";
                    da1 = new SqlDataAdapter(sql_th, connection);
                    ds1 = new DataSet();
                    da1.Fill(ds1, "THUOC");
                    table1 = ds1.Tables["THUOC"];
                    string th = table1.Rows[0]["TenThuoc"].ToString();
                    connection.Close();
                    String[] row = { th, dv, lv_CTPNT.Items[i].SubItems[2].Text, lv_CTPNT.Items[i].SubItems[3].Text, lv_CTPNT.Items[i].SubItems[4].Text, lv_CTPNT.Items[i].SubItems[5].Text.Trim() };
                    ListViewItem item = new ListViewItem(row);
                    lv_CTPNT.Items[i] = item;
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

        private void LoadTenThuoc()
        {
            DataTable dt = new DataTable();
            connection.Open();
            cmd = new SqlCommand(sql0, connection);
            cmd.ExecuteNonQuery();
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
                cbx_TenThuoc.DataSource = dt;
                cbx_TenThuoc.DisplayMember = "TenThuoc";
                cbx_TenThuoc.ValueMember = "TenThuoc";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }

        private void CapNhat_SL_TT(string mpn)
        {
            connection.Open();
            string s1 = "select count(*) as Dem from CT_PHIEUNHAPTHUOC where MaPhieuNhap=N'" + mpn.Trim() + "'";
            da = new SqlDataAdapter(s1, connection);
            ds = new DataSet();
            da.Fill(ds, "CT_PHIEUNHAPTHUOC");
            table = ds.Tables["CT_PHIEUNHAPTHUOC"];
            string sl = table.Rows[0]["Dem"].ToString();
            connection.Close();
            connection.Open();
            string s = "select sum(ThanhTienVAT) as Tong from CT_PHIEUNHAPTHUOC where MaPhieuNhap=N'" + mpn.Trim() + "'";
            da = new SqlDataAdapter(s, connection);
            ds = new DataSet();
            da.Fill(ds, "CT_PHIEUNHAPTHUOC");
            table = ds.Tables["CT_PHIEUNHAPTHUOC"];
            string tt = table.Rows[0]["Tong"].ToString();
            double dgn;
            if (string.IsNullOrEmpty(tt))
                dgn = 0;
            else
                dgn = double.Parse(tt);
            connection.Close();
            connection.Open();
            string s_dem = "update PHIEUNHAPTHUOC set SoLuong=" + int.Parse(sl) + ",TongTienNhap=" + dgn + " where MaPhieuNhap=N'" + mpn.Trim() + "'";
            SqlCommand cmdCount = new SqlCommand(s_dem, connection);
            cmdCount.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Đã nhật số lượng và thành tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Them_ThongTinThuocNhap_Click(object sender, EventArgs e)
        {
            int sln,dgn;
            bool ktInt = Int32.TryParse(txtb_SLuong.Text, out sln);
            bool ktInt2 = Int32.TryParse(txtb_DonGiaNhap.Text, out dgn);
            connection.Open();
            string stmt2 = "select count(*) from THUOC where TenThuoc = N'" + cbx_TenThuoc.Text.Trim() + "'";
            int count2 = 0;
            SqlCommand cmdCount2 = new SqlCommand(stmt2, connection);
            count2 = (int)cmdCount2.ExecuteScalar();
            connection.Close();
            if ((string.IsNullOrEmpty(txtb_MaPN_CTPNT.Text)) || (string.IsNullOrEmpty(txtb_SLuong.Text)) || (string.IsNullOrEmpty(txtb_DonGiaNhap.Text)) || (string.IsNullOrEmpty(cbx_TenThuoc.Text)))
            {
                DialogResult dg = MessageBox.Show("Chưa điền đủ thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.No)
                {
                    cbx_TenThuoc.Text = "";
                    txtb_SLuong.Clear();
                    txtb_DonGiaNhap.Clear();
                }
            }
            else if (CheckDouble(lv_CTPNT, cbx_TenThuoc.Text.Trim()) == true)
            {
                MessageBox.Show("Tên thuốc không được lặp lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ktInt == false || sln <= 0)
            {
                MessageBox.Show("Vui lòng nhập lại số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ktInt2 == false || dgn <= 0)
            {
                MessageBox.Show("Vui lòng nhập lại đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (count2 == 0)
            {
                MessageBox.Show("Tên thuốc không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
            else
            {
                try
                {
                    connection.Open();
                    string sql1 = "Select GiaTri From THAMSO where TenThamSo='VAT'";
                    da1 = new SqlDataAdapter(sql1, connection);
                    ds1 = new DataSet();
                    da1.Fill(ds1, "THAMSO");
                    table1 = ds1.Tables["THAMSO"];
                    int VAT = int.Parse(table1.Rows[0]["GiaTri"].ToString());
                    connection.Close();

                    int iDGVAT;
                    int iTTVAT;
                    int iSL;
                    int iDGN = 0;
                    bool check_DGN = int.TryParse(txtb_DonGiaNhap.Text, out iDGN);
                    bool check_SL = int.TryParse(txtb_SLuong.Text, out iSL);
                    if (check_DGN == true && check_SL == true)
                    {
                        iDGVAT = iDGN * VAT / 100 + iDGN;
                        iTTVAT = iDGVAT * iSL;

                        connection.Open();
                        string s1 = "select MaThuoc from THUOC where TenThuoc=N'" + cbx_TenThuoc.Text.Trim() + "'";
                        db = new SqlDataAdapter(s1, connection);
                        du = new DataSet();
                        db.Fill(du, "THUOC");
                        table2 = du.Tables["THUOC"];
                        string mt = table2.Rows[0]["MaThuoc"].ToString();
                        connection.Close();

                        connection.Open();
                        string stmt = "INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap,DonGiaVAT,ThanhTienVAT)" +
                            "VALUES('" + txtb_MaPN_CTPNT.Text.Trim() + "', '" + mt.Trim() + "', " + txtb_SLuong.Text + ", " + txtb_DonGiaNhap.Text + ", " + iDGVAT + ", " + iTTVAT + ")";
                        SqlCommand cmdCount = new SqlCommand(stmt, connection);
                        cmdCount.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CapNhat_DonGiaBan(mt,iDGVAT);
                        CapNhat_SL_Ton(mt, int.Parse(txtb_SLuong.Text));
                        
                    }
                    else
                    {
                        DialogResult dg = MessageBox.Show("Giá trị không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (dg == DialogResult.OK)
                        {
                            return;
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
                    lv_CTPNT.Items.Clear();
                    lv_DSPNT.Items.Clear();
                    LoadCTPNT(txtb_MaPN_CTPNT.Text);
                    CapNhat_SL_TT(txtb_MaPN_CTPNT.Text);
                    
                    LoadDSPNT();
                }
                cbx_TenThuoc.Text = "";
                txtb_SLuong.Clear();
                txtb_DonGiaNhap.Clear();
            }
        }

        private void btn_Xoa_CTPNT_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa không?", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                for (int i = 0; i < lv_CTPNT.Items.Count; i++)
                {
                    if (lv_CTPNT.Items[i].Selected)
                    {
                        try
                        {
                            connection.Open();
                            string s1 = "select MaThuoc from THUOC where TenThuoc=N'" + lv_CTPNT.Items[i].SubItems[0].Text.Trim() + "'";
                            db = new SqlDataAdapter(s1, connection);
                            du = new DataSet();
                            db.Fill(du, "THUOC");
                            table2 = du.Tables["THUOC"];
                            string mt = table2.Rows[0]["MaThuoc"].ToString();
                            connection.Close();

                            connection.Open();
                            string stmt = "select SoLuongTon from THUOC where MaThuoc =N'" + mt + "'";
                            int count = 0;
                            SqlCommand cmdCount = new SqlCommand(stmt, connection);
                            count = (int)cmdCount.ExecuteScalar();
                            connection.Close();
                            if (count >= int.Parse(lv_CTPNT.Items[i].SubItems[2].Text))
                            {
                                connection.Open();
                                string s = "Delete from CT_PHIEUNHAPTHUOC where MaPhieuNhap = '" + txtb_MaPN_CTPNT.Text.Trim() + "' and MaThuoc='" + mt + "'";
                                SqlCommand cmd = new SqlCommand(s, connection);
                                cmd.ExecuteNonQuery();
                                connection.Close();
                                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CapNhat_SL_Ton(mt.Trim(), -(int.Parse(lv_CTPNT.Items[i].SubItems[2].Text)));
                                

                            }
                            else
                            {
                                DialogResult dg = MessageBox.Show("Thuốc đang được sử dụng, không thể xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            lv_CTPNT.Items.Clear();
                            lv_DSPNT.Items.Clear();
                            LoadCTPNT(txtb_MaPN_CTPNT.Text);
                            CapNhat_SL_TT(txtb_MaPN_CTPNT.Text);
                            
                            LoadDSPNT();
                        }
                    }
                }
                cbx_TenThuoc.Text = "";
                txtb_SLuong.Clear();
                txtb_DonGiaNhap.Clear();
            }
        }

        private void CapNhat_DonGiaBan(string mt,double tt)
        {
            try
            {
                connection.Open();
                string sql1 = "Select GiaTri From THAMSO where TenThamSo=N'ThangSoBanLe'";
                da1 = new SqlDataAdapter(sql1, connection);
                ds1 = new DataSet();
                da1.Fill(ds1, "THAMSO");
                table1 = ds1.Tables["THAMSO"];
                int ts = int.Parse(table1.Rows[0]["GiaTri"].ToString());
                connection.Close();
                //int dg = 0;
                /*connection.Open();
                string stmt = "select SoLuongTon from THUOC where MaThuoc =N'" + mt.Trim() + "'";
                int count = 0;
                SqlCommand cmdCount = new SqlCommand(stmt, connection);
                count = (int)cmdCount.ExecuteScalar();
                connection.Close();
                connection.Open();
                string stmt4 = "select DonGiaBan from THUOC where MaThuoc =N'" + mt.Trim() + "'";
                int count4 = 0;
                SqlCommand cmdCount4 = new SqlCommand(stmt4, connection);
                count4 = (int)cmdCount4.ExecuteScalar();
                connection.Close();*/
                /*if (count == 0)
                    dg = count4;
                else
                {
                    connection.Open();
                    string stmt2 = "select DonGiaNhap" +
                        " from PHIEUNHAPTHUOC P,CT_PHIEUNHAPTHUOC C " +
                        "where P.MaPhieuNhap=C.MaPhieuNhap " +
                        "and NgayNhap=(select distinct max(NgayNhap) from PHIEUNHAPTHUOC P,CT_PHIEUNHAPTHUOC C where P.MaPhieuNhap=C.MaPhieuNhap and P.MaThuoc='" + mt.Trim() + "') " +
                        "and MaThuoc='" + mt.Trim() + "'";

                    SqlCommand cmdCount2 = new SqlCommand(stmt2, connection);
                    dg = (int)cmdCount2.ExecuteScalar();
                    connection.Close();
                    dg = (dg * ts / 100 + dg);
                }  */
                double dg = (tt * ts / 100 + tt);
                connection.Open();
                string stmt3 = "update THUOC " +
                    "set DonGiaBan=" + dg +
                    "where MaThuoc='" + mt.Trim() + "'";
                SqlCommand cmdCount3 = new SqlCommand(stmt3, connection);
                cmdCount3.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Cập nhật đơn giá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void CapNhat_SL_Ton(string mt, int sl)
        {
            try
            {
                connection.Open();
                string stmt3 = "update THUOC " +
                    "set SoLuongTon=SoLuongTon+" + sl +
                    "where MaThuoc='" + mt.Trim() + "'";
                SqlCommand cmdCount3 = new SqlCommand(stmt3, connection);
                cmdCount3.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Cập nhật số lượng tồn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        
        private void btn_Xuat_CTPNT_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xls", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Excel.Application app = new Excel.Application();
                    Excel.Workbook wb = app.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
                    Excel.Worksheet ws = (Excel.Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Tên Thuốc";
                    ws.Cells[1, 2] = "Đơn Vị";
                    ws.Cells[1, 3] = "Số Lượng";
                    ws.Cells[1, 4] = "Đơn Giá Nhập";
                    ws.Cells[1, 5] = "Đơn Giá VAT";
                    ws.Cells[1, 6] = "Thành Tiền VAT";
                    int i = 2;
                    foreach (ListViewItem item in lv_CTPNT.Items)
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
                    MessageBox.Show("Xuất file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void lv_CTPNT_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem items in lv_CTPNT.SelectedItems)
            {
                cbx_TenThuoc.Text = items.SubItems[0].Text;
                txtb_SLuong.Text= items.SubItems[2].Text;
                txtb_DonGiaNhap.Text= items.SubItems[3].Text;
            }
        }

        private void lv_CTPNT_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cbx_TenThuoc.Text = "";
            txtb_SLuong.Clear();
            txtb_DonGiaNhap.Clear();
        }
    }
}