using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagnosisOfRetinal
{
    public partial class Form_analisys : Skin.Controles.W10Form
    {
        PatientDAO pDAO;
        Patient patient;
        List<Survey> surveys;
        double _p1;
        double _p2;
        string selected_item;
        DateTime min_date;
        DateTime max_date;
        Points points;

        List<Patient> patients;
        List<long> patients_id_list;

        string info_fovea;

        public Form_analisys()
        {
            InitializeComponent();

            init();
        }

        private void init()
        {
            pDAO = new PatientDAO();
            surveys = new List<Survey>();
            long id_select_patient = 0;
            if (Session.isHaveSession("patient"))
                id_select_patient = Session.getSessionItem<Patient>("patient").ID;

            chart1.Legends[0].Enabled = false;

            patients_id_list = new List<long>();
            patients = pDAO.get_all_patients();
            foreach (Patient _patient in patients)
            {
                if (_patient.Surveys.Count != 0)
                {
                    cb_Patients.Items.Add(_patient.Surname + " " + _patient.Name + " " + _patient.Middlename + "( №" + _patient.Card_number + " )");
                    patients_id_list.Add(_patient.ID);
                    if (_patient.ID == id_select_patient)
                        cb_Patients.SelectedIndex = patients_id_list.Count - 1;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0 && listBox1.SelectedItem != null)
            {
                chart1.Titles[0].Text = "Область: глобальная;    Выбранный параметр: " + listBox1.SelectedItem.ToString();
                chart1.Legends[0].Enabled = false;
                paintGrafik(listBox1.SelectedItem.ToString(), true, false, false);

                listBox2.ClearSelected();
                listBox3.ClearSelected();
            }
            else if (tabControl1.SelectedIndex == 1 && (listBox2.SelectedItem != null || listBox3.SelectedItem != null))
            {
                chart1.Legends[0].Enabled = true;
                panel1.Enabled = true;

                if (tabControl2.SelectedIndex == 0)
                {
                    selected_item = listBox2.SelectedItem.ToString();

                    listBox1.ClearSelected();
                    listBox3.ClearSelected();
                }
                else
                {
                    selected_item = listBox3.SelectedItem.ToString();

                    listBox1.ClearSelected();
                    listBox2.ClearSelected();
                }

                chart1.Titles[0].Text = "Область: локальная;    Выбранный параметр: " + selected_item;
                if (rb_all.Checked)
                    paintGrafik(selected_item, false, true, true);
                else
                    paintGrafik(selected_item, false, rb_max.Checked, rb_min.Checked);
            }
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((tabControl2.SelectedIndex == 0 && listBox2.SelectedItem != null)
              || (tabControl2.SelectedIndex == 1 && listBox3.SelectedItem != null))
                panel1.Enabled = true;
            else
                panel1.Enabled = false;
        }

        private void dtp_StartDate_CloseUp(object sender, EventArgs e)
        {
            dtp_EndDate.MinDate = dtp_StartDate.Value;

            tabControl1.Enabled = false;
            chart1.Legends[0].Enabled = false;
            chart1.Titles[0].Text = "";
            surveys.Clear();
            paintGrafik(null, true, false, false);

            listBox1.ClearSelected();
            listBox2.ClearSelected();
            listBox3.ClearSelected();
        }
        private void dtp_EndDate_CloseUp(object sender, EventArgs e)
        {
            dtp_StartDate.MaxDate = dtp_EndDate.Value;

            tabControl1.Enabled = false;
            chart1.Legends[0].Enabled = false;
            chart1.Titles[0].Text = "";
            surveys.Clear();
            paintGrafik(null, true, false, false);

            listBox1.ClearSelected();
            listBox2.ClearSelected();
            listBox3.ClearSelected();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.Enabled = true;
            panel1.Enabled = false;
            chart1.Legends[0].Enabled = false;
            chart1.Titles[0].Text = "";
            surveys.Clear();

            surveys = new List<Survey>();
            try
            {
                foreach (Survey survey in patient.Surveys)
                {
                    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    if (survey.Date_survey.Date >= dtp_StartDate.Value && survey.Date_survey.Date <= dtp_EndDate.Value)
                    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    {
                        surveys.Add(survey);
                    }
                }

                paintGrafik(null, true, false, false);
            }
            catch(Exception)
            {
                MessageBox.Show("Данный пациент не обнаружен в базе!");
            }
        }

        private void cb_Patients_SelectedIndexChanged(object sender, EventArgs e)
        {
            patient = pDAO.read(patients_id_list[cb_Patients.SelectedIndex]);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            min_date = patient.Surveys.Min(x => x.Date_survey).Date;
            max_date = patient.Surveys.Max(x => x.Date_survey).Date;
            dtp_StartDate.MaxDate = DateTime.Now;
            dtp_EndDate.MaxDate = DateTime.Now;
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            dtp_StartDate.MinDate = min_date;
            dtp_StartDate.MaxDate = max_date;
            dtp_EndDate.MinDate = min_date;
            dtp_EndDate.MaxDate = max_date;

            dtp_StartDate.Value = min_date;
            dtp_EndDate.Value = max_date;

            tabControl1.Enabled = false;
            chart1.Legends[0].Enabled = false;
            chart1.Titles[0].Text = "";
            surveys.Clear();
            paintGrafik(null, true, false, false);
            listBox1.ClearSelected();
            listBox2.ClearSelected();
            listBox3.ClearSelected();
        }

        private void paintGrafik(string _param, bool global, bool check1, bool check2)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();

            points = new Points();

            if (_param == null)
            {
                return;
            }
            if (global && _param == "Корреляция")
            {
                points._params = surveys.Select(x => (double)x.Global_correlation).ToList();

            }
            else if (global && _param == "Критические точки")
            {
                points._params = surveys.Select(x => (double)x.Global_critical_points).ToList();

            }
            else if (global && _param == "Максимальная амплитуда складок")
            {
                points._params = surveys.Select(x => (double)x.Global_max_amplitude).ToList();

            }
            else if (global && _param == "Минимальная амплитуда складок")
            {
                points._params = surveys.Select(x => (double)x.Global_min_amplitude).ToList();

            }
            else if (global && _param == "Средняя амплитуда складок")
            {
                points._params = surveys.Select(x => (double)x.Global_mean_amplitude).ToList();

            }
            else if (global && _param == "Частота складок")
            {
                points._params = surveys.Select(x => (double)x.Global_n).ToList();

            }

            else if (_param == "Ширина ц.ям.")
            {

                points._params = surveys.Select(x => (x.Foveas.Count != 0) ? (double)x.Foveas.Max(y => y.Length) : 0).ToList();
                points._params2 = surveys.Select(x => (x.Foveas.Count != 0) ? (double)x.Foveas.Min(y => y.Length) : 0).ToList();

            }
            else if (_param == "Глубина ц.ям.")
            {
                points._params = surveys.Select(x => (x.Foveas.Count != 0) ? (double)x.Foveas.Max(y => y.Depth_top) : 0).ToList();
                points._params2 = surveys.Select(x => (x.Foveas.Count != 0) ? (double)x.Foveas.Min(y => y.Depth_top) : 0).ToList();

            }
            else if (_param == "Отношение ц.ям.")
            {
                points._params = surveys.Select(x => (x.Foveas.Count != 0) ? (double)x.Foveas.Max(y => (y.Depth_top / (y.Depth_top + y.Depth_bot))) : 0).ToList();
                points._params2 = surveys.Select(x => (x.Foveas.Count != 0) ? (double)x.Foveas.Min(y => (y.Depth_top / (y.Depth_top + y.Depth_bot))) : 0).ToList();

            }
            else if (_param == "Симметричность ц.ям.")
            {
                points._params = surveys.Select(x => (x.Foveas.Count != 0) ? (double)x.Foveas.Max(y => y.Coef_symmetry) : 0).ToList();
                points._params2 = surveys.Select(x => (x.Foveas.Count != 0) ? (double)x.Foveas.Min(y => y.Coef_symmetry) : 0).ToList();

            }
            else if (_param == "Нормальность ц.ям.")
            {
                points._params = surveys.Select(x => (x.Foveas.Count != 0) ? (double)x.Foveas.Max(y => y.Coef_normality) : 0).ToList();
                points._params2 = surveys.Select(x => (x.Foveas.Count != 0) ? (double)x.Foveas.Min(y => y.Coef_normality) : 0).ToList();

            }

            else if (!global && _param == "Корреляция")
            {
                points._params = surveys.Select(x => (double)x.Correlations.Max(y => y.Сoefficient)).ToList();
                points._params2 = surveys.Select(x => (double)x.Correlations.Min(y => y.Сoefficient)).ToList();

            }
            else if (!global && _param == "Критические точки")
            {
                points._params = surveys.Select(x => (double)x.Critical_points.Max(y => y.Count)).ToList();
                points._params2 = surveys.Select(x => (double)x.Critical_points.Min(y => y.Count)).ToList();
            }
            else if (!global && _param == "Максимальная амплитуда складок")
            {
                points._params = surveys.Select(x => (double)x.Foldings.Max(y => y.Max_amplitude)).ToList();
                points._params2 = surveys.Select(x => (double)x.Foldings.Min(y => y.Max_amplitude)).ToList();
            }
            else if (!global && _param == "Минимальная амплитуда складок")
            {
                points._params = surveys.Select(x => (double)x.Foldings.Max(y => y.Min_amplitude)).ToList();
                points._params2 = surveys.Select(x => (double)x.Foldings.Min(y => y.Min_amplitude)).ToList();
            }
            else if (!global && _param == "Средняя амплитуда складок")
            {
                points._params = surveys.Select(x => (double)x.Foldings.Max(y => y.Mean_amplitude)).ToList();
                points._params2 = surveys.Select(x => (double)x.Foldings.Min(y => y.Mean_amplitude)).ToList();
            }
            else if (!global && _param == "Частота складок")
            {
                points._params = surveys.Select(x => (double)x.Foldings.Max(y => y.N)).ToList();
                points._params2 = surveys.Select(x => (double)x.Foldings.Min(y => y.N)).ToList();
            }
            points.dates = surveys.Select(x => x.Date_survey).ToList();

            for (int i = 0; i < points.dates.Count; i++)
            {
                if (global || check1)
                {
                    _p1 = points._params[i];
                    chart1.Series[0].Points.AddY(_p1);
                    if (tabControl1.SelectedIndex == 1 && tabControl2.SelectedIndex == 0 && _p1 == 0)
                        info_fovea = "(нет ц.ям.)";
                    else
                        info_fovea = "";
                    chart1.Series[0].Points.Last().AxisLabel = points.dates[i].ToShortDateString()
                                                               + "\n"
                                                               + points.dates[i].ToShortTimeString()
                                                               + "\n"
                                                               + info_fovea;
                    chart1.Series[1].Points.AddY(_p1);
                    chart1.Series[1].Points.Last().ToolTip = "Значение: "
                                                             + (_p1).ToString()
                                                             + info_fovea
                                                             + "\nДата: "
                                                             + points.dates[i];
                }
                if (check2)
                {
                    _p2 = points._params2[i];
                    chart1.Series[2].Points.AddY(_p2);
                    if (tabControl1.SelectedIndex == 1 && tabControl2.SelectedIndex == 0 && _p2 == 0)
                        info_fovea = "(нет ц.ям.)";
                    else
                        info_fovea = "";
                    chart1.Series[2].Points.Last().AxisLabel = points.dates[i].ToShortDateString()
                                                               + "\n"
                                                               + points.dates[i].ToShortTimeString()
                                                               + "\n"
                                                               + info_fovea;
                    chart1.Series[3].Points.AddY(_p2);
                    chart1.Series[3].Points.Last().ToolTip = "Значение: "
                                                             + (_p2).ToString()
                                                             + info_fovea
                                                             + "\nДата: "
                                                             + points.dates[i];
                }
            }
        }

        private void webRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedIndex == 0)
                selected_item = listBox2.SelectedItem.ToString();
            else
                selected_item = listBox3.SelectedItem.ToString();

            chart1.Legends[0].Enabled = true;
            chart1.Titles[0].Text = "Область: локальная;    Выбранный параметр: " + selected_item;
            if (rb_all.Checked)
                paintGrafik(selected_item, false, true, true);
            else if (rb_max.Checked)
                paintGrafik(selected_item, false, true, false);
            else if (rb_min.Checked)
                paintGrafik(selected_item, false, false, true);
        }

        private void Form_analisys_Load(object sender, EventArgs e)
        {

        }
    }
}
