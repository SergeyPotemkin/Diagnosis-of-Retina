/*
    Copyright 2016,2017 Sergey Potemkin
    This file is part of the DOR.
   (Diagnosis of Retina)
   DOR is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License v3.0.
    
    You should have received a copy of the GNU General Public License v3.0
    along with DOR.  If not, see <http://www.gnu.org/licenses/>.
*/

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
