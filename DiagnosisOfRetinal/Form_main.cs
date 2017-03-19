using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using System.IO;
using System.Threading;

namespace DiagnosisOfRetinal
{
    public partial class Form_main : Skin.Controles.W10Form
    {
        private Form Form_start;

        private static SurveyDAO surveyDAO = new SurveyDAO();

        private Doctor doctor;
        private Patient patient;
        private Survey survey;
        private List<Survey> oldSurveysList = null;

        public Form_main(Form Form_start)
        {
            InitializeComponent();
            this.Form_start = Form_start;
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            this.printForm();
            this.timerByDateTime.Start();
        }

        private void statusOpenDoctor()
        {
            gb_openVideoFile.Visible = false;
            gb_old_survey.Visible = false;
            gb_snapshot.Visible = false;
            gb_global_params.Visible = false;
            gb_local_folding_params.Visible = false;
            gb_local_fovea_params.Visible = false;

            wil_fio_patient.Visible = false;
            lbl_fio_patient.Visible = false;
            wib_card_patient.Visible = false;
            lbl_card_patient.Visible = false;

            gb_survey_info.Visible = true;
            gb_survey_info.Size = new Size(459, 141);
            lbl_doctor_name.Text = doctor.Surname + " " + doctor.Name + " " + doctor.Middlename;
            lbl_date.Text = DateTime.Now.ToString();
            btn_open_patient.Visible = true;

            menuNewSurvey.Visible = false;
            menuOpenPatient.Text = "Выбрать пациента";
            menuOpenPatient.Visible = true;
            //menuExport.Visible = false;
            menuSaveSurvey.Visible = false;

            this.Height = 546;
            this.MinimumSize = new Size(1000, 585);
        }

        private void statusOpenPatient()
        {
            gb_snapshot.Visible = false;

            gb_survey_info.Visible = true;
            gb_survey_info.Size = new Size(459, 195);
            wil_fio_patient.Visible = true;
            lbl_fio_patient.Visible = true;
            lbl_fio_patient.Text = patient.Surname + " " + patient.Name + " " + patient.Middlename;
            wib_card_patient.Visible = true;
            lbl_card_patient.Visible = true;
            lbl_card_patient.Text = "№ " + patient.Card_number.ToString();
            lbl_date.Text = DateTime.Now.ToString();

            btn_open_patient.Visible = true;
            btn_open_patient.Location = new Point(16,205);
            btn_open_patient.Text = "Сменить пациента";

            gb_old_survey.Visible = true;
            gb_old_survey.Size = new Size(498, 284);

            this.oldSurveysList = surveyDAO.get_all_survey_by_patientID(patient.ID);
            lb_old_survey.Items.Clear();
            foreach (Survey surveyItem in oldSurveysList)
            {
                lb_old_survey.Items.Add(surveyItem.Date_survey);
            }

            btn_open_old_survey.Enabled = false;

            menuOpenPatient.Text = "Сменить пациента";
            menuOpenPatient.Visible = true;
            menuNewSurvey.Visible = false;
            //menuExport.Visible = false;
            menuSaveSurvey.Visible = false;

            this.MinimumSize = new Size(1000, 585);
        }


        private void statusOpenVideoSurvey()
        {
            gb_snapshot.Visible = false;

            gb_survey_info.Visible = true;
            gb_survey_info.Size = new Size(459, 141);
            btn_open_patient.Visible = false;
            wil_fio_patient.Visible = true;
            lbl_fio_patient.Visible = true;
            lbl_fio_patient.Text = patient.Surname + " " + patient.Name + " " + patient.Middlename;
            wib_card_patient.Visible = true;
            lbl_card_patient.Visible = true;
            lbl_card_patient.Text = "№ " + patient.Card_number.ToString();
            lbl_date.Text = DateTime.Now.ToString();

            gb_openVideoFile.Visible = true;
            gb_old_survey.Visible = false;

            gb_global_params.Visible = true;
            gb_global_params.Enabled = false;

            gb_local_folding_params.Visible = true;
            gb_local_folding_params.Enabled = false;

            this.statusOpenFovea(true);
            gb_local_fovea_params.Visible = true;
            gb_local_fovea_params.Enabled = false;

            menuNewSurvey.Visible = true;
            menuOpenPatient.Text = "Сменить пациента";
            menuOpenPatient.Visible = true;
            //menuExport.Visible = false;
            menuSaveSurvey.Visible = false;

            this.setGlobalSurveyParams();
            this.setLocalSurveyParams(1);

            this.MinimumSize = new Size(1000, 585);
        }

        private void statusOpenSurvey()
        {
            gb_old_survey.Visible = false;

            gb_survey_info.Visible = true;
            gb_survey_info.Size = new Size(459, 141);
            btn_open_patient.Visible = false;
            wil_fio_patient.Visible = true;
            lbl_fio_patient.Visible = true;
            wib_card_patient.Visible = true;
            lbl_card_patient.Visible = true;
            if (Session.isHaveSession("oldSurveyDateTime"))
            {
                lbl_date.Text = DateTime.Now.ToString() + " ("+Session.getSessionItem<DateTime>("oldSurveyDateTime").ToString()+")";
            }
            else
            {
                lbl_date.Text = DateTime.Now.ToString();
            }

            gb_openVideoFile.Visible = false;

            this.statusOpenFovea(true);
            gb_global_params.Visible = true;
            gb_local_fovea_params.Enabled = true;
            gb_local_folding_params.Visible = true;
            gb_global_params.Enabled = true;
            gb_local_fovea_params.Visible = true;
            gb_local_folding_params.Enabled = true;

            menuNewSurvey.Visible = true;
            menuOpenPatient.Visible = true;
            //menuExport.Visible = true;
            menuSaveSurvey.Visible = true;

            if (Session.getSessionItem<String>("video_filename") != "нет")
            {
                lbl_no_videofile.Visible = false;
                btn_open_more_info.Enabled = true;

                gb_snapshot.Text = gb_snapshot.Text = "Снимок №" + Session.getSessionItem<int>("snapshot");
            }
            else
            {
                lbl_no_videofile.Visible = true;
                btn_open_more_info.Enabled = false;
                gb_snapshot.Text = gb_snapshot.Text = "Снимок №" + Session.getSessionItem<int>("snapshot");
            }
            gb_snapshot.Visible = true;

            this.MinimumSize = new Size(1000,546);

            this.setGlobalSurveyParams();
            this.setLocalSurveyParams(Session.getSessionItem<int>("snapshot"));
        }


        private void statusOpenFovea(bool check)
        {
            label7.Visible = check;
            label1.Visible = check;
            label2.Visible = check;
            label3.Visible = check;
            label12.Visible = check;
            label5.Visible = check;
            tbWidth.Visible = check;
            tbDepth.Visible = check;
            tbDepthBottom.Visible = check;
            tbNormality.Visible = check;
            tbSymmetry.Visible = check;
            tbDivision.Visible = check;

            label25.Visible = !check;
        }

        private void файлToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            файлToolStripMenuItem.ForeColor = Color.FromName("Highlight");
        }

        private void файлToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            файлToolStripMenuItem.ForeColor = Color.FromName("White");
        }

        private void lbl_date_survay_Click(object sender, EventArgs e)
        {
            lbl_date_survay.Text = DateTime.Now.ToString();
        }

        private void lbl_name_patient_Click(object sender, EventArgs e)
        {

        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void открытьОбследованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_open_patient_Click(object sender, EventArgs e)
        {
            new Form_add_patient().ShowDialog();
            this.printForm();
        }

        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Session.isHaveSession("survey")){
                try
                {
                    if (Session.isHaveSession("oldSurveyDateTime"))
                    {
                        DialogResult result = MessageBox.Show("Обновить обследование перед выходом?", "Внимание", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            surveyDAO.update(survey);
                            e.Cancel = false;
                            Form_start.Close();
                        }
                        else if (result == DialogResult.No)
                        {
                            e.Cancel = false;
                            Form_start.Close();
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            e.Cancel = true;
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Сохранить обследование перед выходом?", "Внимание", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            surveyDAO.insert(survey);
                            e.Cancel = false;
                            Form_start.Close();
                        }
                        else if (result == DialogResult.No)
                        {
                            e.Cancel = false;
                            Form_start.Close();
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            e.Cancel = true;
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
            else
            {
                try
                {
                    DialogResult result = MessageBox.Show("Вы действительно хотите выйти?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        e.Cancel = false;
                        Form_start.Close();
                    }
                    else if (result == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
                catch (NullReferenceException) { }
            }
        }

        private void btn_openVideoFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Выберите видео-файл сетчатки";
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.DefaultExt = ".avi";
            string VideoFormat = "Video files | *.avi;";
            openFileDialog.Filter = VideoFormat;

            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                long surveyId = survey.ID;
                this.closeSurvey();

                Session.setSessionItem<String>("video_filename", openFileDialog.FileName);
                String videoFilename = Session.getSessionItem<String>("video_filename");


                Thread t = new Thread(new ThreadStart(delegate
                {
                    new Form_progressBar().ShowDialog();
                }));
                t.Start();

                ScilabWrapper mw = new ScilabWrapper(videoFilename);

                survey = mw.getSurvey();
                if (Session.isHaveSession("oldSurveyDateTime")) {
                    survey.ID = surveyId;
                }
                mw = null;

                Session.setSessionItem<Survey>("survey",survey);

                gb_snapshot.Text = "Снимок №1";

                Session.setSessionItem<int>("snapshot", 1);


                using (var file = new FileStream(@"scan\frame" + Session.getSessionItem<int>("snapshot").ToString() + ".jpg", FileMode.Open, FileAccess.Read, FileShare.Inheritable))
                {
                    FrameBox.Image = Image.FromStream(file);
                }

                this.setGlobalSurveyParams();
                this.setLocalSurveyParams(1);

                this.printForm();
                save_report.Visible = true;
            }
        }

        private void setGlobalSurveyParams()
        {
            if (survey.Global_correlation != null)
                tbGlCorcoef.Text = ((MWNumericArray)survey.Global_correlation).ToString();
            else 
                tbGlCorcoef.Text = "";
            if (survey.Global_critical_points != null)
                tbGlCriticalPoints.Text = survey.Global_critical_points.ToString();
            else
                tbGlCriticalPoints.Text = "";
            if (survey.Global_max_amplitude != null)
                tbGLMaxAmp.Text = ((MWNumericArray)survey.Global_max_amplitude).ToString();
            else
                tbGLMaxAmp.Text = "";
            if (survey.Global_min_amplitude != null)
                tbGLMinAmp.Text = ((MWNumericArray)survey.Global_min_amplitude).ToString();
            else
                tbGLMinAmp.Text = "";
            if (survey.Global_mean_amplitude != null)
                tbGLMeanAmp.Text = ((MWNumericArray)survey.Global_mean_amplitude).ToString();
            else 
                tbGLMeanAmp.Text = "";
            if (survey.Global_n != null)
                tbGLN.Text = ((MWNumericArray)survey.Global_n).ToString();
            else 
                tbGLN.Text = "";

            if (survey.Global_fovea_length != null)
                tbGlWidth.Text = ((MWNumericArray)survey.Global_fovea_length).ToString();
            else
                tbGlWidth.Text = "";
            if (survey.Global_fovea_depth_top != null)
                tbGlDepth.Text = ((MWNumericArray)survey.Global_fovea_depth_top).ToString();
            else
                tbGlDepth.Text = "";
            if (survey.Global_fovea_depth_bot != null)
                tbGlDepthBottom.Text = ((MWNumericArray)survey.Global_fovea_depth_bot).ToString();
            else
                tbGlDepthBottom.Text = "";
            if (survey.Global_fovea_coef_symmetry != null)
                tbGlSymmetry.Text = ((MWNumericArray)survey.Global_fovea_coef_symmetry).ToString();
            else
                tbGlSymmetry.Text = "";
            if (survey.Global_fovea_coef_normality != null)
                tbGlNormality.Text = ((MWNumericArray)survey.Global_fovea_coef_normality).ToString();
            else
                tbGlNormality.Text = "";
            if (tbGlDepthBottom.Text != "" && tbGlDepth.Text != "")
                tbGlDivision.Text = ((MWNumericArray)(survey.Global_fovea_depth_bot/(survey.Global_fovea_depth_bot + survey.Global_fovea_depth_top))).ToString();
            else
                tbGlDivision.Text = "";
            if (survey.Global_sum_variability != null)
                gb_sum_corn.Text = string.Format("{0:0.00##}", survey.Global_sum_variability);
            else
                gb_sum_corn.Text = "";
            if (survey.Global_median_variability != null)
                gb_mean_corn.Text = string.Format("{0:0.00##}", survey.Global_median_variability);
            else
                gb_mean_corn.Text = "";
        }

        /*private void check0Freq()
        {
            if ((high_count.Text.Equals("1")) && (high_amp.Text.Equals("0")) && (high_mean.Text.Equals("0")))
            {
                high_count.Text = "Не зафиксированы";
                high_amp.Text = "Не зафиксированы";
                high_mean.Text = "Не зафиксированы";
            }
            if ((middle_count.Text.Equals("1")) && (middle_amp.Text.Equals("0")) && (middle_mean.Text.Equals("0")))
            {
                middle_count.Text = "Не зафиксированы";
                middle_amp.Text = "Не зафиксированы";
                middle_mean.Text = "Не зафиксированы";
            }
            if ((low_count.Text.Equals("1")) && (low_amp.Text.Equals("0")) && (low_mean.Text.Equals("0")))
            {
                low_count.Text = "Не зафиксированы";
                low_amp.Text = "Не зафиксированы";
                low_mean.Text = "Не зафиксированы";
            }
        }*/

        private void setLocalSurveyParams(int snapshot_num)
        {
            Corner_variability corner_variability = survey.Corner_variability.ToList<Corner_variability>().Find(x => x.Num_snapshot == snapshot_num);
            if (corner_variability != null)
            {
                tbMaxCorner.Text = ((MWNumericArray)corner_variability.Max_variability).ToString();
                tbAllCorner.Text = ((MWNumericArray)corner_variability.Sum_variability).ToString();
                tbMeanCorner.Text = ((MWNumericArray)corner_variability.Median_variability).ToString();
            }
            else
            {
                tbMaxCorner.Text = "";
                tbAllCorner.Text = "";
                tbMeanCorner.Text = "";
            }
            Fourier_params fourier_params = survey.Fourier_params.ToList<Fourier_params>().Find(x => x.Num_snapshot == snapshot_num);
            /*if(fourier_params != null)
            {
                high_count.Text = ((MWNumericArray)fourier_params.High_freq_amount).ToString();
                high_amp.Text = ((MWNumericArray)fourier_params.High_freq_amp).ToString();
                high_mean.Text = ((MWNumericArray)fourier_params.High_freq_mean).ToString();

                middle_count.Text = ((MWNumericArray)fourier_params.Middle_freq_amount).ToString();
                middle_amp.Text = ((MWNumericArray)fourier_params.Middle_freq_amp).ToString();
                middle_mean.Text = ((MWNumericArray)fourier_params.Middle_freq_mean).ToString();

                low_count.Text = ((MWNumericArray)fourier_params.Low_freq_amount).ToString();
                low_amp.Text = ((MWNumericArray)fourier_params.Low_freq_amp).ToString();
                low_mean.Text = ((MWNumericArray)fourier_params.Low_freq_mean).ToString();

                check0Freq();
            }
            else
            {
                high_count.Text = "";
                high_amp.Text = "";
                high_mean.Text = "";

                middle_count.Text = "";
                middle_amp.Text = "";
                middle_mean.Text = "";

                low_count.Text = "";
                low_amp.Text = "";
                low_mean.Text = "";
            }*/

            Folding folding = survey.Foldings.ToList<Folding>().Find(x => x.Num_snapshot == snapshot_num);
            if (folding != null)
            {
                tbMaxAmp.Text = ((MWNumericArray)folding.Max_amplitude).ToString();
                tbMinAmp.Text = ((MWNumericArray)folding.Min_amplitude).ToString();
                tbMeanAmp.Text = ((MWNumericArray)folding.Mean_amplitude).ToString();
                tbN.Text = folding.N.ToString();
            }
            else
            {
                tbMaxAmp.Text = "";
                tbMinAmp.Text = "";
                tbMeanAmp.Text = "";
                tbN.Text = "";
            }

            Critical_points critical_points_left = survey.Critical_points.ToList<Critical_points>().Find(x => x.Num_second_snapshot == snapshot_num);
            Critical_points critical_points_right = survey.Critical_points.ToList<Critical_points>().Find(x => x.Num_first_snapshot == snapshot_num);
            Correlation correlation_left = survey.Correlations.ToList<Correlation>().Find(x => x.Num_second_snapshot == snapshot_num);
            Correlation correlation_right = survey.Correlations.ToList<Correlation>().Find(x => x.Num_first_snapshot == snapshot_num);
            if(snapshot_num == 1)
            {
                if (critical_points_right != null)
                {
                    tbCPLeft.Text = "Нет";
                    tbCPRight.Text = critical_points_right.Count.ToString();
                }
                else
                {
                    tbCPLeft.Text = "";
                    tbCPRight.Text = "";
                }
                if (correlation_right != null)
                {
                    tbCorLeft.Text = "Нет";
                    tbCorRight.Text = ((MWNumericArray)correlation_right.Сoefficient).ToString();
                }
                else
                {
                    tbCorLeft.Text = "";
                    tbCorRight.Text = "";
                }
            }
            else if(snapshot_num == 19)
            {
                if (critical_points_left != null)
                {
                    tbCPLeft.Text = critical_points_left.Count.ToString();
                    tbCPRight.Text = "Нет";
                }
                else
                {
                    tbCPLeft.Text = "";
                    tbCPRight.Text = "";
                }
                if (correlation_left != null)
                {
                    tbCorLeft.Text = ((MWNumericArray)correlation_left.Сoefficient).ToString();
                    tbCorRight.Text = "Нет";
                }
                else
                {
                    tbCorLeft.Text = "";
                    tbCorRight.Text = "";
                }
            }
            else
            {
                if (correlation_left != null && correlation_right != null)
                {
                    tbCorLeft.Text = ((MWNumericArray)correlation_left.Сoefficient).ToString();
                    tbCorRight.Text = ((MWNumericArray)correlation_right.Сoefficient).ToString();
                }
                else
                {
                    tbCorLeft.Text = "";
                    tbCorRight.Text = "";
                }
                if (critical_points_left != null && critical_points_right != null)
                {
                    tbCPLeft.Text = critical_points_left.Count.ToString();
                    tbCPRight.Text = critical_points_right.Count.ToString();
                }
                else
                {
                    tbCPLeft.Text = "";
                    tbCPRight.Text = "";
                }
            }
            try
            {
                double depth = survey.Foveas.ToList<Fovea>().Find(x => x.Num_snapshot == snapshot_num).Depth_top;
                double depthBottom = survey.Foveas.ToList<Fovea>().Find(x => x.Num_snapshot == snapshot_num).Depth_bot;

                tbWidth.Text = ((MWNumericArray)survey.Foveas.ToList<Fovea>().Find(x => x.Num_snapshot == snapshot_num).Length).ToString();
                tbDepth.Text = ((MWNumericArray)depth).ToString();
                tbDepthBottom.Text = ((MWNumericArray)depthBottom).ToString();
                tbNormality.Text = ((MWNumericArray)survey.Foveas.ToList<Fovea>().Find(x => x.Num_snapshot == snapshot_num).Coef_normality).ToString();
                tbSymmetry.Text = ((MWNumericArray)survey.Foveas.ToList<Fovea>().Find(x => x.Num_snapshot == snapshot_num).Coef_symmetry).ToString();
                tbDivision.Text = ((MWNumericArray)(depthBottom / (depthBottom + depth))).ToString();

                this.statusOpenFovea(true);
            }
            catch
            {
                this.statusOpenFovea(false);
            }
        }

        private void closeSurvey(){
            this.survey = null;

            if (FrameBox.Image != null)
            {
                FrameBox.Image.Dispose();
                FrameBox.Image = null;
            }

            try
            {
                Directory.Delete(@"scan\", true);
                Directory.CreateDirectory(@"scan\");
            }
            catch(DirectoryNotFoundException e)
            {
                Directory.CreateDirectory(@"scan\");
            }
            Session.removeSessionItem("survey");
            Session.removeSessionItem("video_filename");
        }

        private void closePatient()
        {
            this.closeSurvey();
            patient = null;
            Session.removeSessionItem("patient");
        }

        private void webTrackBar1_ValueChanged(object sender, decimal value)
        {
            Session.setSessionItem<int>("snapshot", (int)(value+1));

            gb_snapshot.Text = "Снимок №" + Session.getSessionItem<int>("snapshot").ToString();
            if (Session.getSessionItem<String>("video_filename") != "нет")
            {
                using (var file = new FileStream(@"scan\frame" + Session.getSessionItem<int>("snapshot").ToString() + ".jpg", FileMode.Open, FileAccess.Read, FileShare.Inheritable))
                {
                    FrameBox.Image = Image.FromStream(file);
                }
            }
            this.setLocalSurveyParams((int)(value + 1));
        }

        private void lb_old_survey_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = ((ListBox)sender).SelectedItem;

            if (selected != null)
            {
                btn_open_old_survey.Enabled = true;
            }
            else
            {
                btn_open_old_survey.Enabled = false;
            }
        }

        private void btn_create_new_survey_Click(object sender, EventArgs e)
        {
            Session.removeSessionItem("survey");
            Session.setSessionItem<Survey>("survey", new Survey());
            this.printForm();
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(System.IO.Path.GetFullPath(@"scan\"));
                foreach (FileInfo file in dirInfo.GetFiles())
                {
                    file.Delete();
                }
            }
            catch { }
        }

        private void tbGlCorcoef_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void webTexbox17_Click(object sender, EventArgs e)
        {

        }

        private void printForm()
        {
            if (Session.isHaveSession("doctor"))
            {
                doctor = Session.getSessionItem<Doctor>("doctor");
                this.statusOpenDoctor();
                if (Session.isHaveSession("patient"))
                {
                    patient = Session.getSessionItem<Patient>("patient");
                    this.statusOpenPatient();
                    if (Session.isHaveSession("survey"))
                    {
                        this.survey = Session.getSessionItem<Survey>("survey");
                        if (Session.isHaveSession("video_filename"))
                        {
                            this.statusOpenSurvey();
                        }
                        else
                        {
                            this.statusOpenVideoSurvey();
                        }
                    }
                }
            }
        }

        private void menuNewSurvey_Click(object sender, EventArgs e)
        {
            Session.removeSessionItem("oldSurveyDateTime");
            Session.removeSessionItem("survey");
            Session.removeSessionItem("video_filename");
            this.printForm();
            save_report.Visible = false;

            try {
                DirectoryInfo dirInfo = new DirectoryInfo(System.IO.Path.GetFullPath(@"scan\"));
                foreach (FileInfo file in dirInfo.GetFiles())
                {
                    file.Delete();
                }
            }
            catch { }
        }

        private void menuOpenPatient_Click(object sender, EventArgs e)
        {
            Session.removeSessionItem("oldSurveyDateTime");
            this.btn_open_patient_Click(sender , e);
        }

        private void btn_open_old_survey_Click(object sender, EventArgs e)
        {
            survey = oldSurveysList[lb_old_survey.SelectedIndex];

            Session.setSessionItem<DateTime>("oldSurveyDateTime", survey.Date_survey);
            Session.setSessionItem<Survey>("survey", survey);
            Session.setSessionItem<String>("video_filename", "нет");
            Session.setSessionItem<int>("snapshot", 1);

            FrameBox.Image = null;

            this.printForm();
            save_report.Visible = true;
        }

        private void menuSaveSurvey_Click(object sender, EventArgs e)
        {
            survey.Date_survey = DateTime.Now;
            survey.ID = surveyDAO.insert(survey);
            Session.setSessionItem<Survey>("survey", survey);
            Session.removeSessionItem("oldSurveyDateTime");
            Session.setSessionItem<DateTime>("oldSurveyDateTime", DateTime.Now);
            MessageBox.Show("Обследование успешно сохранено!");
        }

        private void menuUpdateSurvey_Click(object sender, EventArgs e)
        {
            survey.ID = Session.getSessionItem<Survey>("survey").ID;
            surveyDAO.update(survey);
            MessageBox.Show("Обследование успешно обновлено!");
        }

        private void btn_open_other_videofile_Click(object sender, EventArgs e)
        {
            btn_openVideoFile_Click(sender, e);
        }

        private void btn_open_more_info_Click(object sender, EventArgs e)
        {
            new Form_info_snaphot().ShowDialog();
            webTrackBar1.Value = Session.getSessionItem<int>("snapshot") - 1;
            webTrackBar1_ValueChanged(sender, Session.getSessionItem<int>("snapshot") - 1);
            this.printForm();
        }

        private void menuAnalisys_Click(object sender, EventArgs e)
        {
            new Form_analisys().ShowDialog();
        }

        private void save_report_Click(object sender, EventArgs e)
        {
            try
            {
                new ExportDoc().ShowDialog();
            }
            catch { }
        }

        private void timerByDateTime_Tick(object sender, EventArgs e)
        {
            if (Session.isHaveSession("oldSurveyDateTime"))
            {
                menuUpdateSurvey.Visible = true;
                menuSaveSurvey.Visible = false;
                lbl_date.Text = DateTime.Now.ToString() + " (" + Session.getSessionItem<DateTime>("oldSurveyDateTime").ToString() + ")";
            }
            else
            {
                menuUpdateSurvey.Visible = false;
                lbl_date.Text = DateTime.Now.ToString();
            }
        }

    }
}
