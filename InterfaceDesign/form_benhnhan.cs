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
    public partial class form_benhnhan : Form
    {
        public form_benhnhan()
        {
            InitializeComponent();
        }

        private void form_benhnhan_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lv_MaBenhNhan_BN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void danhSaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            Form frm = new form_manhinhchinh();
            frm.Show();
            this.Hide();
        }

        private void lb_NamSinh_Click(object sender, EventArgs e)
        {

        }

        private void btn_TroVe_BenhNhan_Click(object sender, EventArgs e)
        {
            Form frm = new form_danhsach();
            frm.Show();
            this.Hide();
        }
    }
}
