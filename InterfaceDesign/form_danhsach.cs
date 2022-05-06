using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceDesign
{
    public partial class form_danhsach : Form
    {
        public form_danhsach()
        {
            InitializeComponent();
        }

        private void form_danhsach_Load(object sender, EventArgs e)
        {

        }

        private void btn_BenhNhan_Click(object sender, EventArgs e)
        {
            Form frm = new form_benhnhan();
            frm.Show();
            this.Hide();
        }

        private void btn_PhieuKhamBenh_Click(object sender, EventArgs e)
        {
            Form frm = new form_phieukhambenh();
            frm.Show();
            this.Hide();
        }

        private void btn_Thuoc_Click(object sender, EventArgs e)
        {
            Form frm = new form_thuoc();
            frm.Show();
            this.Hide();
        }

        private void btn_DonViCachDung_Click(object sender, EventArgs e)
        {
            Form frm = new form_donvicachdung();
            frm.Show();
            this.Hide();
        }

        private void btn_PhieuNhapThuoc_Click(object sender, EventArgs e)
        {
            Form frm = new form_phieunhapthuoc();
            frm.Show();
            this.Hide();
        }

        private void btn_LoaiBenh_Click(object sender, EventArgs e)
        {
            Form frm = new form_loaibenh();
            frm.Show();
            this.Hide();
        }

        private void btn_TrangChur_ManHinhPhu_Click(object sender, EventArgs e)
        {
            Form frm = new form_manhinhchinh();
            frm.Show();
            this.Hide();
        }

        private void btn_TroVe_ManHinhPhu_Click(object sender, EventArgs e)
        {
            Form frm = new form_manhinhchinh();
            frm.Show();
            this.Hide();
        }
    }
}
