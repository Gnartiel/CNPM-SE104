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
    public partial class form_manhinhchinh : Form
    {
        public form_manhinhchinh()
        {
            InitializeComponent();
        }

        private void form_manhinhchinh_Load(object sender, EventArgs e)
        {

        }

        private void btn_DanhSach_Click(object sender, EventArgs e)
        {
            Form frm = new form_danhsach();
            frm.Show();
            this.Hide();
        }

        private void btn_CaiDat_Click(object sender, EventArgs e)
        {
            Form frm = new form_caidat();
            frm.Show();
            this.Hide();
        }

        private void btn_KetXuat_Click(object sender, EventArgs e)
        {
            Form frm = new form_ketxuat();
            frm.Show();
            this.Hide();
        }

        private void btn_TraCuu_Click(object sender, EventArgs e)
        {
            Form frm = new form_tracuu();
            frm.Show();
            this.Hide();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
