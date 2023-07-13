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
    public partial class form_phieukhambenh : Form
    {
        public form_phieukhambenh()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommand cmd;
        string sql0 = "set dateformat DMY";
        private SqlDataAdapter da, da1, da2, db;
        private DataSet ds, ds1, ds2, du;
        private System.Data.DataTable table, table1, table2;
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
        private void form_phieukhambenh_Load(object sender, EventArgs e)
        {
            KetNoi();
            connection.Open();
            string stmt = "SELECT COUNT(*) FROM PHIEUKHAMBENH";
            int count = 0;
            SqlCommand cmdCount = new SqlCommand(stmt, connection);
            count = (int)cmdCount.ExecuteScalar();
            connection.Close();
            if (count > 0)
            {
                LoadListview();
            }
            LoadTenBenhNhan();
            LoadTenLoaiBenh();
            LoadTenThuoc();
            string ms = AddIDAuto(lv_PKB);
            txtb_MaPhieuKham_PKB.Text = "PK" + ms;
        }
        //
        //Load
        //
        private void LoadTenThuoc()
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
                cbx_TenThuoc.DataSource = dt;
                cbx_TenThuoc.DisplayMember = "TenThuoc";
                cbx_TenThuoc.ValueMember = "TenThuoc";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }
        void LoadListview_CTB(string mpk)
        {
            lv_ChiTietBenh.Items.Clear();
            try
            {
                connection.Open();
                cmd = new SqlCommand(sql0, connection);
                cmd.ExecuteNonQuery();

                string sql1 = "Select * from CT_BENH where MaPhieuKhamBenh='" + mpk + "'";
                cmd = new SqlCommand(sql1, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader[1].ToString());
                    lv_ChiTietBenh.Items.Add(itm);
                }
                connection.Close();
                for (int i = 0; i < lv_ChiTietBenh.Items.Count; i++)
                {
                    connection.Open();
                    string sql_th = "Select TenLoaiBenh From LOAIBENH WHERE MaLoaiBenh =N'" + lv_ChiTietBenh.Items[i].SubItems[0].Text.Trim() + "'";
                    da1 = new SqlDataAdapter(sql_th, connection);
                    ds1 = new DataSet();
                    da1.Fill(ds1, "LOAIBENH");
                    table1 = ds1.Tables["LOAIBENH"];
                    string th = table1.Rows[0]["TenLoaiBenh"].ToString();
                    connection.Close();
                    String[] row = { th };
                    ListViewItem item = new ListViewItem(row);
                    lv_ChiTietBenh.Items[i] = item;
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
        void LoadListview_CTPKB(string mpk)
        {
            lv_CTPKB.Items.Clear();
            try
            {
                connection.Open();
                cmd = new SqlCommand(sql0, connection);
                cmd.ExecuteNonQuery();

                string sql1 = "Select * from CT_PHIEUKHAMBENH where MaPhieuKhamBenh='" + mpk + "'";
                cmd = new SqlCommand(sql1, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader[1].ToString());
                    itm.SubItems.Add("");
                    itm.SubItems.Add(reader[2].ToString());
                    itm.SubItems.Add("");
                    itm.SubItems.Add(reader[3].ToString());
                    itm.SubItems.Add(reader[4].ToString());
                    lv_CTPKB.Items.Add(itm);
                }
                connection.Close();
                for (int i = 0; i < lv_CTPKB.Items.Count; i++)
                {
                    connection.Open();
                    string sql_th = "Select TenThuoc From THUOC WHERE MaThuoc =N'" + lv_CTPKB.Items[i].SubItems[0].Text.Trim() + "'";
                    da2 = new SqlDataAdapter(sql_th, connection);
                    ds2 = new DataSet();
                    da2.Fill(ds2, "THUOC");
                    table2 = ds2.Tables["THUOC"];
                    string th = table2.Rows[0]["TenThuoc"].ToString();
                    connection.Close();

                    connection.Open();
                    string sql_dv = "Select TenDonVi From DONVI, THUOC WHERE DONVI.MaDonVi= THUOC.MaDonVi AND MaThuoc =N'" + lv_CTPKB.Items[i].SubItems[0].Text.Trim() + "'";
                    da = new SqlDataAdapter(sql_dv, connection);
                    ds = new DataSet();
                    da.Fill(ds, "DONVI");
                    table = ds.Tables["DONVI"];
                    string dv = table.Rows[0]["TenDonVi"].ToString();
                    connection.Close();

                    connection.Open();
                    string sql_cd = "Select TenCachDung From CACHDUNG, THUOC WHERE CACHDUNG.MaCachDung= THUOC.MaCachDung AND MaThuoc =N'" + lv_CTPKB.Items[i].SubItems[0].Text.Trim() + "'";
                    da1 = new SqlDataAdapter(sql_cd, connection);
                    ds1 = new DataSet();
                    da1.Fill(ds1, "CACHDUNG");
                    table1 = ds1.Tables["CACHDUNG"];
                    string cd = table1.Rows[0]["TenCachDung"].ToString();
                    connection.Close();
                    String[] row = { th, dv, lv_CTPKB.Items[i].SubItems[2].Text,cd, lv_CTPKB.Items[i].SubItems[4].Text, lv_CTPKB.Items[i].SubItems[5].Text };
                    ListViewItem item = new ListViewItem(row);
                    lv_CTPKB.Items[i] = item;
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
        private void LoadTenLoaiBenh()
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
                cbx_TenLoaiBenh.DataSource = dt;
                cbx_TenLoaiBenh.DisplayMember = "TenLoaiBenh";
                cbx_TenLoaiBenh.ValueMember = "TenLoaiBenh";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }
        private void LoadTenBenhNhan()
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
                cbx_TenBN.DataSource = dt;
                cbx_TenBN.DisplayMember = "HoTenBenhNhan";
                cbx_TenBN.ValueMember = "HoTenBenhNhan";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }
        void LoadListview()
        {
            try
            {
                connection.Open();
                cmd = new SqlCommand(sql0, connection);
                cmd.ExecuteNonQuery();
                string sql = "Select * From PHIEUKHAMBENH order by MaPhieuKhamBenh desc";
                cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader[0].ToString());
                    itm.SubItems.Add(reader[1].ToString());
                    itm.SubItems.Add(reader[2].ToString().Substring(0, 10));
                    itm.SubItems.Add(reader[3].ToString());
                    itm.SubItems.Add(reader[4].ToString());
                    itm.SubItems.Add(reader[5].ToString());
                    itm.SubItems.Add(reader[6].ToString());

                    lv_PKB.Items.Add(itm);
                }
                connection.Close();
                for (int i = 0; i < lv_PKB.Items.Count; i++)
                {
                    connection.Open();
                    string s1 = "select HoTenBenhNhan from BENHNHAN where MaBenhNhan=N'" + lv_PKB.Items[i].SubItems[1].Text.Trim() + "' ";
                    db = new SqlDataAdapter(s1, connection);
                    du = new DataSet();
                    db.Fill(du, "BENHNHAN");
                    table2 = du.Tables["BENHNHAN"];
                    string mt = table2.Rows[0]["HoTenBenhNhan"].ToString();
                    connection.Close();
                    string[] row = { lv_PKB.Items[i].SubItems[0].Text, mt, lv_PKB.Items[i].SubItems[2].Text, lv_PKB.Items[i].SubItems[3].Text, lv_PKB.Items[i].SubItems[4].Text, lv_PKB.Items[i].SubItems[5].Text, lv_PKB.Items[i].SubItems[6].Text };
                    ListViewItem tem = new ListViewItem(row);
                    lv_PKB.Items[i] = tem;
                }


                string ms = AddIDAuto(lv_PKB);
                txtb_MaPhieuKham_PKB.Text = "PK" + ms;
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
        //btn
        private void btn_TrangChu_PKB_Click(object sender, EventArgs e)
        {
            Form frm = new form_manhinhchinh();
            frm.Show();
            this.Hide();
        }

        private void btn_TroVe_PKB_Click(object sender, EventArgs e)
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
        //
        //PKB
        //
        private void CapNhat_TT(string mpk)
        {
            try
            {
                connection.Open();
                string s1 = "select sum(ThanhTien) as Tong from CT_PHIEUKHAMBENH where MaPhieuKhamBenh=N'" + mpk.Trim() + "'";
                da = new SqlDataAdapter(s1, connection);
                ds = new DataSet();
                da.Fill(ds, "CT_PHIEUNHAPTHUOC");
                table = ds.Tables["CT_PHIEUNHAPTHUOC"];
                string tt = table.Rows[0]["Tong"].ToString();
                connection.Close();
                connection.Open();
                string sql2 = "Select GiaTri From THAMSO where TenThamSo=N'TienKham'";
                da = new SqlDataAdapter(sql2, connection);
                ds = new DataSet();
                da.Fill(ds, "THAMSO");
                table1 = ds.Tables["THAMSO"];
                int TK = int.Parse(table1.Rows[0]["GiaTri"].ToString());
                connection.Close();

                int dgn;
                if (string.IsNullOrEmpty(tt))
                    dgn = 0;
                else
                    dgn = int.Parse(tt);
                int sum = TK + dgn;
                connection.Close();
                connection.Open();
                string stmt3 = "update PHIEUKHAMBENH " +
                    "set TienThuoc=" + dgn + ", TongTien = " + sum +
                    " where MaPhieuKhamBenh='" + mpk.Trim() + "'";
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
        private string AddIDAuto(ListView lv)
        {
            if (lv.Items.Count == 0)
                return "001";
            string r = lv.Items[0].SubItems[0].Text;
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

        private void btn_Them_ThemPKB_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sql2 = "Select GiaTri From THAMSO where TenThamSo=N'BNToiDa'";
            da = new SqlDataAdapter(sql2, connection);
            ds = new DataSet();
            da.Fill(ds, "THAMSO");
            table1 = ds.Tables["THAMSO"];
            int BNTD = int.Parse(table1.Rows[0]["GiaTri"].ToString());
            connection.Close();
           
            connection.Open();
            string stmt = "select count(*) from BENHNHAN where HoTenBenhNhan = N'" + cbx_TenBN.Text.Trim() + "'";
            int count = 0;
            SqlCommand cmdCount = new SqlCommand(stmt, connection);
            count = (int)cmdCount.ExecuteScalar();
            connection.Close();
            connection.Open();
            cmd = new SqlCommand(sql0, connection);
            cmd.ExecuteNonQuery();
            string stmt1 = "select count(*) from PHIEUKHAMBENH where NgayKham = '" + dtpk_NgayNhap.Text.Trim() + "'";
            int count2 = 0;
            SqlCommand cmdCount1 = new SqlCommand(stmt1, connection);
            count2 = (int)cmdCount1.ExecuteScalar();
            connection.Close();
            if ((string.IsNullOrEmpty(txtb_TrieuChung.Text)) || (string.IsNullOrEmpty(cbx_TenBN.Text)) || (string.IsNullOrEmpty(dtpk_NgayNhap.Value.ToString())))
            {
                DialogResult dg = MessageBox.Show("Chưa điền đủ thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.No)
                {
                    txtb_TrieuChung.Clear();
                    cbx_TenBN.Text = "";
                    dtpk_NgayNhap.Value = DateTime.Now;
                }
            }
            else if (count2>=BNTD)
            {
                MessageBox.Show("Số lượng bệnh nhân trong ngày đã vượt mức quy định", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CheckDouble(lv_PKB, txtb_MaPhieuKham_PKB.Text.Trim()) == true)
            {
                MessageBox.Show("Mã phiếu khám không được lặp lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (count == 0)
            {
                MessageBox.Show("Tên bệnh nhân không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtpk_NgayNhap.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày nhập thuốc không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int TT = 0;
                try
                {
                    connection.Open();
                    string s1 = "select MaBenhNhan from BENHNHAN where HoTenBenhNhan=N'" + cbx_TenBN.Text.Trim() + "'";
                    db = new SqlDataAdapter(s1, connection);
                    du = new DataSet();
                    db.Fill(du, "BENHNHAN");
                    table2 = du.Tables["BENHNHAN"];
                    string mt = table2.Rows[0]["MaBenhNhan"].ToString();
                    connection.Close();

                    connection.Open();
                    string sql1 = "Select GiaTri From THAMSO where TenThamSo=N'TienKham'";
                    da1 = new SqlDataAdapter(sql1, connection);
                    ds1 = new DataSet();
                    da1.Fill(ds1, "THAMSO");
                    table1 = ds1.Tables["THAMSO"];
                    int TK = int.Parse(table1.Rows[0]["GiaTri"].ToString());
                    connection.Close();
                                       
                    connection.Open();
                    cmd = new SqlCommand(sql0, connection);
                    cmd.ExecuteNonQuery();
                    string stmt2 = "INSERT INTO PHIEUKHAMBENH(MaPhieuKhamBenh, MaBenhNhan,NgayKham,TrieuChung,TienKham,TienThuoc,TongTien) " +
                        "VALUES('" + txtb_MaPhieuKham_PKB.Text.Trim() + "','" + mt.Trim() + "','" + dtpk_NgayNhap.Text + "'," + "N'" + txtb_TrieuChung.Text.Trim() + "'," + TK + "," + TT + ", " + TK + ")";
                    SqlCommand cmdCount2 = new SqlCommand(stmt2, connection);
                    cmdCount2.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                    lv_CTPKB.Items.Clear();
                    lv_PKB.Items.Clear();
                    LoadListview_CTPKB(txtb_MaPhieuKham_CTPKB.Text);

                    LoadListview();
                }

                string ms = AddIDAuto(lv_PKB);
                txtb_MaPhieuKham_PKB.Text = "PK" + ms;
                //txtb_TrieuChung.Clear();
                //cbx_TenBN.Text = "";
                //dtpk_NgayNhap.Value = DateTime.Now;

            }
        }

        private void btn_Sua_SuaPKB_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lv_PKB.Items.Count; i++)
            {
                if (lv_PKB.Items[i].Selected)
                {
                    connection.Open();
                    string stmt = "select count(*) from BENHNHAN where HoTenBenhNhan=N'" + cbx_TenBN.Text.Trim() + "'";
                    int count = 0;
                    SqlCommand cmdCount = new SqlCommand(stmt, connection);
                    count = (int)cmdCount.ExecuteScalar();
                    connection.Close();
                    if ((string.IsNullOrEmpty(txtb_TrieuChung.Text)) || (string.IsNullOrEmpty(cbx_TenBN.Text)) || (string.IsNullOrEmpty(dtpk_NgayNhap.Value.ToString())))
                    {
                        DialogResult dg = MessageBox.Show("Chưa điền đủ thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.No)
                        {
                            txtb_TrieuChung.Clear();
                            cbx_TenBN.Text = "";
                            dtpk_NgayNhap.Value = DateTime.Now;
                        }
                    }
                    else if (count == 0)
                    {
                        MessageBox.Show("Tên bệnh nhân không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            string s1 = "select MaBenhNhan from BENHNHAN where HoTenBenhNhan=N'" + cbx_TenBN.Text.Trim() + "'";
                            db = new SqlDataAdapter(s1, connection);
                            du = new DataSet();
                            db.Fill(du, "BENHNHAN");
                            table2 = du.Tables["BENHNHAN"];
                            string mt = table2.Rows[0]["MaBenhNhan"].ToString();
                            connection.Close();

                            connection.Open();
                            cmd = new SqlCommand(sql0, connection);
                            cmd.ExecuteNonQuery();
                            string stmt1 = "update PHIEUKHAMBENH set MaBenhNhan='" + mt.Trim() + "',NgayKham='" + dtpk_NgayNhap.Text + "',TrieuChung=N'" + txtb_TrieuChung.Text + "' where MaPhieuKhamBenh = '" + txtb_MaPhieuKham_PKB.Text.Trim() + "'";
                            SqlCommand cmdCount1 = new SqlCommand(stmt1, connection);
                            cmdCount1.ExecuteNonQuery();
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
                            lv_PKB.Items.Clear();
                            LoadListview();
                        }
                    }
                }
            }
            string ms = AddIDAuto(lv_PKB);
            txtb_MaPhieuKham_PKB.Text = "PK" + ms;
        }

        private void lv_PKB_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem items in lv_PKB.SelectedItems)
            {
                txtb_MaPhieuKham_PKB.Text = items.SubItems[0].Text;
                cbx_TenBN.Text = items.SubItems[1].Text;
                dtpk_NgayNhap.Value = DateTime.Parse(items.SubItems[2].Text);
                txtb_TrieuChung.Text = items.SubItems[3].Text;
                txtb_MaPhieuKham_CTBenh.Text = txtb_MaPhieuKham_PKB.Text;
                txtb_MaPhieuKham_CTPKB.Text = txtb_MaPhieuKham_PKB.Text;
                LoadListview_CTB(txtb_MaPhieuKham_PKB.Text);
                LoadListview_CTPKB(txtb_MaPhieuKham_PKB.Text);
            }
        }

        private void btn_Xoa_XoaPKB_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa không?", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                for (int i = 0; i < lv_PKB.Items.Count; i++)
                {
                    if (lv_PKB.Items[i].Selected)
                    {
                        try
                        {
                            connection.Open();
                            string stmt = "select count(*) from CT_BENH where MaPhieuKhamBenh = '" + txtb_MaPhieuKham_PKB.Text.Trim() + "'";
                            int count1 = 0;
                            SqlCommand cmdCount = new SqlCommand(stmt, connection);
                            count1 = (int)cmdCount.ExecuteScalar();
                            connection.Close();

                            connection.Open();
                            string stmt1 = "select count(*) from CT_PHIEUKHAMBENH where MaPhieuKhamBenh = '" + txtb_MaPhieuKham_PKB.Text.Trim() + "'";
                            int count2 = 0;
                            SqlCommand cmdCount1 = new SqlCommand(stmt1, connection);
                            count2 = (int)cmdCount1.ExecuteScalar();
                            connection.Close();
                            int count = count1 + count2;
                            if (count == 0)
                            {
                                connection.Open();
                                string s = "Delete from PHIEUKHAMBENH where MaPhieuKhamBenh = '" + txtb_MaPhieuKham_PKB.Text.Trim() + "'";
                                SqlCommand cmd = new SqlCommand(s, connection);
                                cmd.ExecuteNonQuery();
                                connection.Close();
                                lv_PKB.Items.Clear();
                                LoadListview();
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
                string ms = AddIDAuto(lv_PKB);
                txtb_MaPhieuKham_PKB.Text = "PK" + ms;
                txtb_TrieuChung.Clear();
                cbx_TenBN.Text = "";
                dtpk_NgayNhap.Value = DateTime.Now;
            }
        }

        private void btn_Luu_PKB_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xls", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Excel.Application app = new Excel.Application();
                    Excel.Workbook wb = app.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
                    Excel.Worksheet ws = (Excel.Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Mã Phiếu Khám Bệnh";
                    ws.Cells[1, 2] = "Họ Tên Bệnh Nhân";
                    ws.Cells[1, 3] = "Ngày Khám";
                    ws.Cells[1, 4] = "Triệu Chứng";
                    ws.Cells[1, 5] = "Tiền Khám";
                    ws.Cells[1, 6] = "Tiền Thuốc";
                    ws.Cells[1, 7] = "Tổng Tiền";
                    int i = 2;
                    foreach (ListViewItem item in lv_PKB.Items)
                    {
                        ws.Cells[i, 1] = item.SubItems[0].Text;
                        ws.Cells[i, 2] = item.SubItems[1].Text;
                        ws.Cells[i, 3] = item.SubItems[2].Text;
                        ws.Cells[i, 4] = item.SubItems[3].Text;
                        ws.Cells[i, 5] = item.SubItems[4].Text;
                        ws.Cells[i, 6] = item.SubItems[5].Text;
                        ws.Cells[i, 7] = item.SubItems[6].Text;
                        i++;
                    }
                    wb.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("Your data has been successfully exported", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            string ms = AddIDAuto(lv_PKB);
            txtb_MaPhieuKham_PKB.Text = "PN" + ms;

        }

        private void btn_Them_ThemChiTietBenh_Click(object sender, EventArgs e)
        {
            
            connection.Open();
            string stmt2 = "select count(*) from LOAIBENH where TenLoaiBenh = N'" + cbx_TenLoaiBenh.Text.Trim() + "'";
            int count2 = 0;
            SqlCommand cmdCount2 = new SqlCommand(stmt2, connection);
            count2 = (int)cmdCount2.ExecuteScalar();
            connection.Close();
            if ((string.IsNullOrEmpty(txtb_MaPhieuKham_CTBenh.Text)) || (string.IsNullOrEmpty(cbx_TenLoaiBenh.Text)))
            {
                DialogResult dg = MessageBox.Show("Chưa điền đủ thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.No)
                {
                    txtb_MaPhieuKham_CTBenh.Clear();
                    cbx_TenLoaiBenh.Text = "";
                }
            }
              
            else if (count2 == 0)
            {
                MessageBox.Show("Tên bệnh không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbx_TenLoaiBenh.Text = "";
            }
            else
            {
                try
                {
                    connection.Open();
                    string sql_lb = "Select MaLoaiBenh From LOAIBENH WHERE TenLoaiBenh =N'" + cbx_TenLoaiBenh.Text + "'";
                    da2 = new SqlDataAdapter(sql_lb, connection);
                    ds2 = new DataSet();
                    da2.Fill(ds2, "LOAIBENH");
                    table2 = ds2.Tables["LOAIBENH"];
                    string mlb = table2.Rows[0]["MaLoaiBenh"].ToString();
                    connection.Close();

                    connection.Open();
                    string sql_b = "INSERT INTO CT_BENH (MaPhieuKhamBenh, MaLoaiBenh)" +
                        "VALUES('" + txtb_MaPhieuKham_CTBenh.Text.Trim() + "', '" + mlb.Trim() + "'" + ")";
                    SqlCommand cmdCount = new SqlCommand(sql_b, connection);
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
                    lv_ChiTietBenh.Items.Clear();
                    LoadListview_CTB(txtb_MaPhieuKham_CTBenh.Text);
                }
                cbx_TenLoaiBenh.Text = "";
            }
        }

        private void btn_Sua_SuaChiTietBenh_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lv_ChiTietBenh.Items.Count; i++)
            {
                if (lv_ChiTietBenh.Items[i].Selected)
                {
                    connection.Open();
                    string stmt2 = "select count(*) from LOAIBENH where TenLoaiBenh = N'" + cbx_TenLoaiBenh.Text.Trim() + "'";
                    int count2 = 0;
                    SqlCommand cmdCount2 = new SqlCommand(stmt2, connection);
                    count2 = (int)cmdCount2.ExecuteScalar();
                    connection.Close();

                    if ((string.IsNullOrEmpty(txtb_MaPhieuKham_CTBenh.Text)) || (string.IsNullOrEmpty(cbx_TenLoaiBenh.Text)))
                    {
                        DialogResult dg = MessageBox.Show("Chưa điền đủ thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.No)
                        {
                            txtb_MaPhieuKham_CTBenh.Clear();
                            cbx_TenLoaiBenh.Text = "";
                        }
                    }
                    else if (count2 == 0)
                    {
                        MessageBox.Show("Tên bệnh không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbx_TenLoaiBenh.Text = "";
                    }
                    else
                    {
                        try
                        {
                            connection.Open();
                            string sql_lb = "Select MaLoaiBenh From LOAIBENH WHERE TenLoaiBenh =N'" + cbx_TenLoaiBenh.Text + "'";
                            da2 = new SqlDataAdapter(sql_lb, connection);
                            ds2 = new DataSet();
                            da2.Fill(ds2, "LOAIBENH");
                            table2 = ds2.Tables["LOAIBENH"];
                            string mlb = table2.Rows[0]["MaLoaiBenh"].ToString();
                            connection.Close();

                            connection.Open();
                            string sctb = "update CT_BENH set MaLoaiBenh ='" + mlb.Trim() + "' where MaPhieuKhamBenh = '" + txtb_MaPhieuKham_CTBenh.Text.Trim() + "'";
                            SqlCommand cmdCount = new SqlCommand(sctb, connection);
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
                            lv_ChiTietBenh.Items.Clear();
                            LoadListview_CTB(txtb_MaPhieuKham_CTBenh.Text);
                        }

                        cbx_TenLoaiBenh.Text = "";
                    }
                }
            }
        }

        private void btn_Xoa_XoaChiTietBenh_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa không?", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                for (int i = 0; i < lv_ChiTietBenh.Items.Count; i++)
                {
                    if (lv_ChiTietBenh.Items[i].Selected)
                    {
                        try
                        {
                            connection.Open();
                            string s1 = "select MaLoaiBenh from LOAIBENH where TenLoaiBenh = N'" + lv_ChiTietBenh.Items[i].SubItems[0].Text.Trim() + "'";
                            da = new SqlDataAdapter(s1, connection);
                            ds = new DataSet();
                            da.Fill(ds, "LOAIBENH");
                            table2 = ds.Tables["LOAIBENH"];
                            string mlb = table2.Rows[0]["MaLoaiBenh"].ToString();
                            connection.Close();

                            connection.Open();
                            string s = "Delete from CT_BENH where MaLoaiBenh = '" + mlb.Trim() + "'";
                            SqlCommand cmd = new SqlCommand(s, connection);
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                            lv_ChiTietBenh.Items.Clear();
                            LoadListview_CTB(txtb_MaPhieuKham_CTBenh.Text);
                        }
                    }
                }
                
                cbx_TenLoaiBenh.Text = "";
            }
        }

        private void lv_PKB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string ms = AddIDAuto(lv_PKB);
            txtb_MaPhieuKham_PKB.Text = "PK" + ms;
            txtb_TrieuChung.Clear();
            cbx_TenBN.Text = "";
            dtpk_NgayNhap.Value = DateTime.Now;
        }

        private void btn_Them_ThemChiTietPKB_Click(object sender, EventArgs e)
        {
            int sln;
            bool ktInt = Int32.TryParse(txtb_SoLuong.Text, out sln);
            connection.Open();
            string stmt2 = "select count(*) from THUOC where TenThuoc = N'" + cbx_TenThuoc.Text.Trim() + "'";
            int count2 = 0;
            SqlCommand cmdCount2 = new SqlCommand(stmt2, connection);
            count2 = (int)cmdCount2.ExecuteScalar();
            connection.Close();
            connection.Open();
            string stmt3 = "select SoLuongTon from THUOC where TenThuoc = N'" + cbx_TenThuoc.Text.Trim() + "'";
            SqlCommand cmdCount3 = new SqlCommand(stmt3, connection);
            int slt = (int)cmdCount3.ExecuteScalar();
            connection.Close();
            if ((string.IsNullOrEmpty(txtb_MaPhieuKham_CTPKB.Text)) || (string.IsNullOrEmpty(cbx_TenThuoc.Text)) || (string.IsNullOrEmpty(txtb_LieuDung.Text)) || (string.IsNullOrEmpty(txtb_SoLuong.Text)))
            {
                DialogResult dg = MessageBox.Show("Chưa điền đủ thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.No)
                {
                    txtb_SoLuong.Clear();
                    txtb_LieuDung.Clear();
                    cbx_TenThuoc.Text = "";
                }
            }
            else if (count2 == 0)
            {
                MessageBox.Show("Tên thuốc không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbx_TenThuoc.Text = "";
            }
            else if (ktInt == false || sln <= 0 ) 
            {
                MessageBox.Show("Vui lòng nhập lại số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (sln > slt)
            {
                MessageBox.Show("Số lượng trong kho còn: "+slt, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int DGB = 0;
                    connection.Open();
                    string sql1 = "Select DonGiaBan From THUOC Where TenThuoc = N'" + cbx_TenThuoc.Text + "'";
                    da1 = new SqlDataAdapter(sql1, connection);
                    ds1 = new DataSet();
                    da1.Fill(ds1, "THUOC");
                    table1 = ds1.Tables["THUOC"];
                    DGB = int.Parse(table1.Rows[0]["DonGiaBan"].ToString());
                    connection.Close();
                    
                    int iSL=0;
                    int iTT = 0;
                    bool check_SL = int.TryParse(txtb_SoLuong.Text, out iSL);
                    if (check_SL == true)
                    {
                        iTT = iSL * DGB;
                        //textBox1.Text = iTT.ToString();
                        connection.Open();
                        string sql_th = "Select MaThuoc From THUOC WHERE TenThuoc =N'" + cbx_TenThuoc.Text + "'";
                        da2 = new SqlDataAdapter(sql_th, connection);
                        ds2 = new DataSet();
                        da2.Fill(ds2, "THUOC");
                        table2 = ds2.Tables["THUOC"];
                        string mt = table2.Rows[0]["MaThuoc"].ToString();
                        connection.Close();

                        connection.Open();
                        string stmt = "INSERT INTO CT_PHIEUKHAMBENH (MaPhieuKhamBenh, MaThuoc, SoLuong, LieuDung, ThanhTien)" +
                            "VALUES('" + txtb_MaPhieuKham_CTPKB.Text.Trim() + "', '" + mt.Trim() + "', " + txtb_SoLuong.Text + ", N'" + txtb_LieuDung.Text + "', " + iTT + ")";
                        SqlCommand cmdCount = new SqlCommand(stmt, connection);
                        cmdCount.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CapNhat_SL_Ton(mt, -int.Parse(txtb_SoLuong.Text));
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
                    lv_CTPKB.Items.Clear();
                    lv_PKB.Items.Clear();
                    LoadListview_CTPKB(txtb_MaPhieuKham_CTPKB.Text);
                    CapNhat_TT(txtb_MaPhieuKham_CTPKB.Text);
                    LoadListview();
                }

                txtb_SoLuong.Clear();
                txtb_LieuDung.Clear();
                cbx_TenThuoc.Text = "";
            }
        }

        private void lv_CTPKB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtb_SoLuong.Clear();
            txtb_LieuDung.Clear();
            cbx_TenThuoc.Text = "";
        }

        private void btn_Xoa_XoaChiTietPKB_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa không?", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                for (int i = 0; i < lv_CTPKB.Items.Count; i++)
                {
                    if (lv_CTPKB.Items[i].Selected)
                    {
                        try
                        {
                            connection.Open();
                            string s1 = "select MaThuoc from THUOC where TenThuoc = N'" + lv_CTPKB.Items[i].SubItems[0].Text.Trim() + "'";
                            da = new SqlDataAdapter(s1, connection);
                            ds = new DataSet();
                            da.Fill(ds, "THUOC");
                            table2 = ds.Tables["THUOC"];
                            string mt = table2.Rows[0]["MaThuoc"].ToString();
                            connection.Close();

                            connection.Open();
                            string s = "Delete from CT_PHIEUKHAMBENH where MaThuoc = '" + mt.Trim() + "'";
                            SqlCommand cmd = new SqlCommand(s, connection);
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CapNhat_SL_Ton(mt, int.Parse(lv_CTPKB.Items[i].SubItems[2].Text));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                            lv_CTPKB.Items.Clear();
                            lv_PKB.Items.Clear();
                            LoadListview_CTPKB(txtb_MaPhieuKham_CTPKB.Text);
                            CapNhat_TT(txtb_MaPhieuKham_CTPKB.Text);
                            LoadListview();
                        }
                    }
                }
                txtb_SoLuong.Clear();
                txtb_LieuDung.Clear();
                cbx_TenThuoc.Text = "";
            }
        }

        private void lv_ChiTietBenh_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cbx_TenLoaiBenh.Text = "";
        }
            
        private void lv_ChiTietBenh_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem items in lv_ChiTietBenh.SelectedItems)
            {
                cbx_TenLoaiBenh.Text = items.SubItems[0].Text;
            }
        }

        private void lv_CTPKB_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem items in lv_CTPKB.SelectedItems)
            {
                cbx_TenThuoc.Text = items.SubItems[0].Text;
                txtb_LieuDung.Text = items.SubItems[3].Text;
                txtb_SoLuong.Text = items.SubItems[2].Text;
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
        private void btn_Xuat_Click(object sender, EventArgs e)
        {
            for (int i=0;i<lv_PKB.Items.Count;i++)
            {
                if(lv_PKB.Items[i].Selected)
                {
                    Form frm = new form_hoadon(txtb_MaPhieuKham_PKB.Text);
                    frm.Show();
                    return;
                }    
            }
            MessageBox.Show("Vui lòng chọn hóa đơn cần xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}