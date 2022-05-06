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
    public partial class form_tracuu : Form
    {
        public form_tracuu()
        {
            InitializeComponent();
        }

        private void form_tracuu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbx_LoaiBenh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_TrangChu_TraCuu_Click(object sender, EventArgs e)
        {
            Form frm = new form_manhinhchinh();
            frm.Show();
            this.Hide();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btn_TroVe_TraCuu_Click(object sender, EventArgs e)
        {
            Form frm = new form_manhinhchinh();
            frm.Show();
            this.Hide();
        }
    }
}
