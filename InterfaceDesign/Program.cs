using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceDesign
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new form_manhinhchinh());
            //application.run(new form_danhsach());
            //application.run(new form_tracuu());
            //application.run(new form_ketxuat());
            //application.run(new form_caidat());

            //application.run(new form_phieunhapthuoc());
            //application.run(new form_loaibenh());
            //application.run(new form_thuoc());
            //application.run(new form_donvicachdung());
            //application.run(new form_benhnhan());
            //application.run(new form_phieukhambenh());

            //application.run(new form_baocaodoanhthu());
            //application.run(new form_baocaosudungthuoc());*
        }
    }
}
