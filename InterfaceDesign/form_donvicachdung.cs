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
    public partial class form_donvicachdung : Form
    {
        public form_donvicachdung()
        {
            InitializeComponent();
        }

        private void form_donvicachdung_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lv_MaDonVi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_XoaCachDung_Click(object sender, EventArgs e)
        {

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
    }
}
