using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagnosisOfRetinal
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /*launch_form lForm = new launch_form();
            DateTime end = DateTime.Now + TimeSpan.FromSeconds(7);
            lForm.Show();
            while(end > DateTime.Now){
                Application.DoEvents();
            }
            lForm.Close();
            lForm.Dispose();*/
            Application.Run(new Form_add_doctor());
        }
    }
}
