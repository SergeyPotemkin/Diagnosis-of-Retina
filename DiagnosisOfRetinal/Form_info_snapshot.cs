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


namespace DiagnosisOfRetinal
{
    public partial class Form_info_snaphot : Skin.Controles.W10Form
    {
        private static SurveyDAO surveyDAO = new SurveyDAO();

        private Survey survey = null;

        private PictureBoxScroll pictureBoxScroll;

        public Form_info_snaphot()
        {
            InitializeComponent();
            pictureBoxScroll = new PictureBoxScroll(FrameBox);
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            if (Session.isHaveSession("survey"))
            {
                this.survey = Session.getSessionItem<Survey>("survey");
                lb_view.SelectedIndex = 0;
                this.printForm();
            }
        }

        private void lb_old_survey_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.printForm();
        }

        private void setImageByPictureBox(String path)
        {
            using (var file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Inheritable))
            {
                FrameBox.Image = Image.FromStream(file);
            }
        }

        private void printForm()
        {
            if (lb_view.SelectedIndex.Equals(0))
            {
                if (Session.isHaveSession("snapshot"))
                {
                    gb_snapshot.Text = "Снимок №" + (Session.getSessionItem<int>("snapshot"));
                    this.setImageByPictureBox(@"scan\frame" + Session.getSessionItem<int>("snapshot") + ".jpg");
                    pictureBoxScroll.setFrameImage(FrameBox.Image);

                    lbl_no_videofile.Visible = false;

                    webTrackBar1.Visible = true;
                    webTrackBar1.Value = (Session.getSessionItem<int>("snapshot") - 1);

                    gb_local_fovea_params.Visible = false;
                    gb_local_folding_params.Visible = false;
                    gb_local_correlation_params.Visible = false;
                    gb_local_critical_points.Visible = false;
                    groupBox1.Visible = false;
                }
            }
            if (lb_view.SelectedIndex.Equals(1))
            {
                webTrackBar1.Visible = true;
                gb_snapshot.Text = "Центральная ямка: Снимок №" + Session.getSessionItem<int>("snapshot");

                try
                {
                    this.setImageByPictureBox(@"scan\fovea" + Session.getSessionItem<int>("snapshot") + ".jpg");
                    gb_local_fovea_params.Visible = true;
                    this.setFoveaParams();
                }
                catch (Exception e)
                {
                    this.setImageByPictureBox(@"scan\frame" + Session.getSessionItem<int>("snapshot") + ".jpg");
                    gb_local_fovea_params.Visible = false;
                }

                pictureBoxScroll.setFrameImage(FrameBox.Image);

                gb_local_folding_params.Visible = false;
                gb_local_correlation_params.Visible = false;
                gb_local_critical_points.Visible = false;
                groupBox1.Visible = false;
            }
            else if (lb_view.SelectedIndex.Equals(2))
            {
                webTrackBar1.Visible = true;
                gb_snapshot.Text = "Корреляция точек: Снимок №" + Session.getSessionItem<int>("snapshot");
                this.setImageByPictureBox(@"scan\corcoef" + Session.getSessionItem<int>("snapshot") + ".jpg");
                pictureBoxScroll.setFrameImage(FrameBox.Image);

                gb_local_correlation_params.Visible = true;
                gb_local_fovea_params.Visible = false;
                gb_local_folding_params.Visible = false;
                gb_local_critical_points.Visible = false;
                groupBox1.Visible = false;

                this.setCorrelationParams();
            }
            else if (lb_view.SelectedIndex.Equals(3))
            {
                webTrackBar1.Visible = true;
                gb_snapshot.Text = "Критические точки: Снимок №" + Session.getSessionItem<int>("snapshot");
                this.setImageByPictureBox(@"scan\corcoef" + Session.getSessionItem<int>("snapshot") + ".jpg");
                pictureBoxScroll.setFrameImage(FrameBox.Image);

                gb_local_critical_points.Visible = true;
                gb_local_fovea_params.Visible = false;
                gb_local_folding_params.Visible = false;
                gb_local_correlation_params.Visible = false;
                groupBox1.Visible = false;

                this.setCriticalPointsParams();
            }
            else if (lb_view.SelectedIndex.Equals(4))
            {
                webTrackBar1.Visible = true;
                gb_snapshot.Text = "Складчатость: Снимок №" + Session.getSessionItem<int>("snapshot");
                this.setImageByPictureBox(@"scan\chastotnay" + Session.getSessionItem<int>("snapshot") + ".jpg");
                pictureBoxScroll.setFrameImage(FrameBox.Image);
                gb_local_fovea_params.Visible = false;
                gb_local_correlation_params.Visible = false;
                gb_local_critical_points.Visible = false;
                gb_local_folding_params.Visible = true;
                groupBox1.Visible = false;

                this.setFoldingParams();
            }
            else if (lb_view.SelectedIndex.Equals(5))
            {
                gb_snapshot.Text = "Угловая изменчивость поверхности: Снимок № " + Session.getSessionItem<int>("snapshot");

                gb_local_fovea_params.Visible = false;
                gb_local_correlation_params.Visible = false;
                gb_local_folding_params.Visible = false;
                this.setImageByPictureBox(@"scan\cornerVariability" + Session.getSessionItem<int>("snapshot") + ".jpg");
                pictureBoxScroll.setFrameImage(FrameBox.Image);
                gb_local_fovea_params.Visible = false;
                gb_local_correlation_params.Visible = false;
                gb_local_critical_points.Visible = false;
                gb_local_folding_params.Visible = false;
                groupBox1.Visible = true;
            }
            else if (lb_view.SelectedIndex.Equals(6))
            {
                gb_snapshot.Text = "Поиск расположения складок: Снимок № " + Session.getSessionItem<int>("snapshot");

                gb_local_fovea_params.Visible = false;
                gb_local_correlation_params.Visible = false;
                gb_local_folding_params.Visible = false;
                try
                {
                    this.setImageByPictureBox(@"scan\foldingimage" + Session.getSessionItem<int>("snapshot") + ".jpg");
                }
                catch { }
                pictureBoxScroll.setFrameImage(FrameBox.Image);
                gb_local_fovea_params.Visible = false;
                gb_local_correlation_params.Visible = false;
                gb_local_critical_points.Visible = false;
                gb_local_folding_params.Visible = false;
                groupBox1.Visible = false;
            }
        }

        private void setFoveaParams()
        {
            gb_local_fovea_params.Visible = true;
            Fovea fovea = survey.Foveas.ToList<Fovea>().Find(x => x.Num_snapshot == Session.getSessionItem<int>("snapshot"));

            if (fovea != null)
            {
                double depth = fovea.Depth_top;
                double depthBottom = fovea.Depth_bot;

                tbWidth.Text = ((MWNumericArray)fovea.Length).ToString();
                tbDepth.Text = ((MWNumericArray)fovea.Depth_top).ToString();
                tbDepthBottom.Text = ((MWNumericArray)fovea.Depth_bot).ToString();
                tbNormality.Text = ((MWNumericArray)fovea.Coef_normality).ToString();
                tbSymmetry.Text = ((MWNumericArray)fovea.Coef_symmetry).ToString();
                tbDivision.Text = ((MWNumericArray)(depthBottom / (depthBottom + depth))).ToString();
            }
        }

        private void setFoldingParams()
        {
            Folding folding = survey.Foldings.ToList<Folding>().Find(x => x.Num_snapshot == Session.getSessionItem<int>("snapshot"));
            if (folding != null)
            {
                gb_local_folding_params.Visible = true;

                tbMaxAmp.Text = ((MWNumericArray)folding.Max_amplitude).ToString();
                tbMinAmp.Text = ((MWNumericArray)folding.Min_amplitude).ToString();
                tbMeanAmp.Text = ((MWNumericArray)folding.Mean_amplitude).ToString();
                tbN.Text = ((MWNumericArray)folding.N).ToString();
            }
        }

        private void setCorrelationParams()
        {
            Correlation correlation_left = survey.Correlations.ToList<Correlation>().Find(x => x.Num_second_snapshot == Session.getSessionItem<int>("snapshot"));
            Correlation correlation_right = survey.Correlations.ToList<Correlation>().Find(x => x.Num_first_snapshot == Session.getSessionItem<int>("snapshot"));
            if (Session.getSessionItem<int>("snapshot") == 1)
            {
                tb_left_correlation.Text = "Нет";
                tb_right_correlation.Text = ((MWNumericArray)correlation_right.Сoefficient).ToString();

            }
            else if (Session.getSessionItem<int>("snapshot") == 19)
            {

                tb_left_correlation.Text = ((MWNumericArray)correlation_left.Сoefficient).ToString();
                tb_right_correlation.Text = "Нет";

            }
            else
            {

                tb_left_correlation.Text = ((MWNumericArray)correlation_left.Сoefficient).ToString();
                tb_right_correlation.Text = ((MWNumericArray)correlation_right.Сoefficient).ToString();
            }
        }

        private void setCriticalPointsParams()
        {
            Critical_points critical_points_left = survey.Critical_points.ToList<Critical_points>().Find(x => x.Num_second_snapshot == Session.getSessionItem<int>("snapshot"));
            Critical_points critical_points_right = survey.Critical_points.ToList<Critical_points>().Find(x => x.Num_first_snapshot == Session.getSessionItem<int>("snapshot"));
            if (Session.getSessionItem<int>("snapshot") == 1)
            {
                tb_cp_left.Text = "Нет";
                tb_cp_right.Text = ((MWNumericArray)critical_points_right.Count).ToString();

            }
            else if (Session.getSessionItem<int>("snapshot") == 19)
            {

                tb_cp_left.Text = ((MWNumericArray)critical_points_left.Count).ToString();
                tb_cp_right.Text = "Нет";

            }
            else
            {
                tb_cp_left.Text = ((MWNumericArray)critical_points_left.Count).ToString();
                tb_cp_right.Text = ((MWNumericArray)critical_points_right.Count).ToString();
            }
        }

        private void webTrackBar1_ValueChanged(object sender, decimal value)
        {
            Session.setSessionItem<int>("snapshot", (int)(value + 1));
            this.printForm();
        }

        private void FrameBox_Click(object sender, EventArgs e)
        {

        }

        private void Form_info_snaphot_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btn_create_new_survey_Click(object sender, EventArgs e)
        {
            pictureBoxScroll.ZoomIn();
        }

        private void webButton1_Click(object sender, EventArgs e)
        {
            pictureBoxScroll.ZoomOut();
        }

        private void btn_3d_Click(object sender, EventArgs e)
        {
            ScilabWrapper.open3DForm(Session.getSessionItem<String>("video_filename"));
        }

        private void webButton2_Click(object sender, EventArgs e)
        {
            pictureBoxScroll.resetFrameImage();
        }
    }
}
