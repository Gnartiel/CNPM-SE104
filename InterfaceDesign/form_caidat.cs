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
    public partial class form_caidat : Form
    {
        public form_caidat()
        {
            InitializeComponent();
        }

        private void lb_caidat_Click(object sender, EventArgs e)
        {

        }

        private void lb_sobenhnhantoida_Click(object sender, EventArgs e)
        {

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {

        }

        private void btn_datlai_Click(object sender, EventArgs e)
        {

        }

        private void txt_vat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_thangsobanle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tienkham_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sobenhnhantoida_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_tienkham_Click(object sender, EventArgs e)
        {

        }

        private void lb_thangsobanle_Click(object sender, EventArgs e)
        {

        }

        private void lb_vat_Click(object sender, EventArgs e)
        {

        }

        private void form_caidat_Load(object sender, EventArgs e)
        {

        }

        private void btn_TrangChu_CaiDat_Click(object sender, EventArgs e)
        {
            Form frm = new form_manhinhchinh();
            frm.Show();
            this.Close();
        }

        private void btn_TroVe_CaiDat_Click(object sender, EventArgs e)
        {
            Form frm = new form_manhinhchinh();
            frm.Show();
            this.Hide();
        }
    }
}
