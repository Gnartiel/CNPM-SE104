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
    public partial class form_ketxuat : Form
    {
        public form_ketxuat()
        {
            InitializeComponent();
        }

        private void btn_BCDT_Click(object sender, EventArgs e)
        {
            Form frm = new form_baocaodoanhthu();
            frm.Show();
            this.Hide();
        }

        private void btn_TrangChu_KetXuat_Click(object sender, EventArgs e)
        {
            Form frm = new form_manhinhchinh();
            frm.Show();
            this.Hide();
        }

        private void btn_TroVe_KetXuat_Click(object sender, EventArgs e)
        {
            Form frm = new form_manhinhchinh();
            frm.Show();
            this.Hide();
        }

        private void form_ketxuat_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_BCSDT_Click(object sender, EventArgs e)
        {
            Form frm = new form_baocaosudungthuoc();
            frm.Show();
            this.Hide();
        }
    }
}
