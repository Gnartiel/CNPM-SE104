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
    public partial class form_baocaosudungthuoc : Form
    {
        public form_baocaosudungthuoc()
        {
            InitializeComponent();
        }

        private void form_baocaosudungthuoc_Load(object sender, EventArgs e)
        {

        }

        private void lb_BCSuDungThuoc_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xuat_BCSDT_Click(object sender, EventArgs e)
        {

        }

        private void lb_Nam_BCSDT_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_Thang_BCSDT_Click(object sender, EventArgs e)
        {

        }

        private void lb_MaThuoc_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbx_Thang_CheckedChanged(object sender, EventArgs e)
        {

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
    }
}
