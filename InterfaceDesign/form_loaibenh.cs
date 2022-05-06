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
    public partial class form_loaibenh : Form
    {
        public form_loaibenh()
        {
            InitializeComponent();
        }

        private void form_loaibenh_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtb_TrieuChung_TextChanged(object sender, EventArgs e)
        {

        }

        private void form_LoaiBenh_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_ThongTinLB_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

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
    }
}
