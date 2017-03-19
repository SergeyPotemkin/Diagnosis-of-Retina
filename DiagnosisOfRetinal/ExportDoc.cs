using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using WebCheckBox = Skin.Controles.WebCheckBox;
using MathWorks.MATLAB.NET.Arrays;
using System.Diagnostics;

namespace DiagnosisOfRetinal
{
    public partial class ExportDoc : Skin.Controles.W10Form
    {
        private List<WebCheckBox> global_checks;
        private List<WebCheckBox> local_checks;
        private bool global_Focused = true;
        private bool local_Focused = true;
        private string DefaultName = "OCT_Survey_" + DateTime.Now.ToString("dd_MM_yyyy HH_mm_ss");
        private string DefaultPath = Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
        DocumentReport document;
        Survey survey;

        public ExportDoc()
        {
            InitializeComponent();

            try
            {
                survey = Session.getSessionItem<Survey>("survey");
            }
            catch (NullReferenceException) { MessageBox.Show("Обследование не загружено. Пожалуйста, загрузите обследование."); Close(); }

            init_Controls();

            global_checks = new List<WebCheckBox>();
            local_checks = new List<WebCheckBox>();

            global_checks.Add(scl_param);
            global_checks.Add(chole_param);

            local_checks.Add(scl_loc_param);
            local_checks.Add(corn_loc_param);
            local_checks.Add(freq_loc_param);
        }

        private void init_Controls()
        {
            try
            {
                file_save_path.Text = DefaultPath;
            }
            catch { file_save_path.Text = String.Empty; }

            file_save_name.Text = DefaultName;

            for (int i = 1; i <= 19; i++)
            {
                params_selection.Items.Add("Срез № " + i.ToString());
                if (File.Exists(System.IO.Path.GetFullPath(@"scan\") + "frame" + i.ToString() + ".jpg"))
                    image_selection.Items.Add("Срез ОКТ № " + i.ToString());
            }
            if (image_selection.Items.Count == 0)
                no_images.Visible = true;

        }

        private void glb_param_CheckedChanged(object sender, EventArgs e)
        {
            if (global_Focused)
            {
                if (glb_param.Checked)
                {
                    foreach (var each in global_checks)
                    {
                        global_Focused = false;
                        each.CheckState = CheckState.Unchecked;
                        global_Focused = false;
                        glb_param.CheckState = CheckState.Unchecked;
                    }
                }
                else
                {
                    foreach (var each in global_checks)
                    {
                        global_Focused = false;
                        each.CheckState = CheckState.Checked;
                        global_Focused = false;
                        glb_param.CheckState = CheckState.Checked;
                    }
                }
                global_Focused = true;
            }
            else
            {
                global_Focused = true;
            }
            //if (glb_param.Checked == false)
            //{
            //    global_Focused = false;
            //    scl_param.CheckState = CheckState.Checked;
            //    global_Focused = false;
            //    chole_param.CheckState = CheckState.Checked;
            //    glb_param.CheckState = CheckState.Checked;
            //    //new CancelEventArgs().Cancel = true;
            //}
            //else
            //{
            //    global_Focused = false;
            //    scl_param.CheckState = CheckState.Unchecked;
            //    global_Focused = false;
            //    chole_param.CheckState = CheckState.Unchecked;
            //    glb_param.CheckState = CheckState.Unchecked;
            //}
            //global_Focused = true;
        }

        private void scl_param_CheckedChanged(object sender, EventArgs e)
        {
            glb_check(scl_param);
        }

        private void chole_param_CheckedChanged(object sender, EventArgs e)
        {
            glb_check(chole_param);
        }


        private void glb_check(WebCheckBox ch_box)
        {
            if (global_Focused)
            {
                bool setCheck = false;
                foreach (var each in global_checks)
                {
                    if (each == ch_box)
                    {
                        setCheck = setCheck || !each.Checked;
                    }
                    else
                    {
                        setCheck = setCheck || each.Checked;
                    }
                }
                InspectCheck(glb_param, setCheck, ref global_Focused);
            }
            else
            {
                global_Focused = true;
            }
        }

        private void InspectCheck(WebCheckBox _check, bool setCheck, ref bool Focused)
        {
            if (_check.CheckState != CheckState.Checked && setCheck == true)
            {
                Focused = false;
                _check.CheckState = CheckState.Checked;
            }
            else if (_check.CheckState != CheckState.Unchecked && setCheck == false)
            {
                Focused = false;
                _check.CheckState = CheckState.Unchecked;
            }
            else
            {
                Focused = true;
                return;
            }
        }

        private void loc_param_CheckedChanged(object sender, EventArgs e)
        {
            if (local_Focused)
            {
                if (loc_param.Checked)
                {
                    foreach (var each in local_checks)
                    {
                        local_Focused = false;
                        each.CheckState = CheckState.Unchecked;
                    }
                }
                else
                {
                    foreach (var each in local_checks)
                    {
                        local_Focused = false;
                        each.CheckState = CheckState.Checked;
                    }
                }
                local_Focused = true;
            }
            else
            {
                local_Focused = true;
            }
        }

        private void scl_loc_param_CheckedChanged(object sender, EventArgs e)
        {
            loc_check(scl_loc_param);
        }

        private void corn_loc_param_CheckedChanged(object sender, EventArgs e)
        {
            loc_check(corn_loc_param);
        }

        private void freq_loc_param_CheckedChanged(object sender, EventArgs e)
        {
            loc_check(freq_loc_param);
        }

        private void loc_check(WebCheckBox ch_box)
        {
            if (local_Focused)
            {
                bool setCheck = false;
                foreach (var each in local_checks)
                {
                    if (each == ch_box)
                    {
                        setCheck = setCheck || !each.Checked;
                    }
                    else
                    {
                        setCheck = setCheck || each.Checked;
                    }
                }
                InspectCheck(loc_param, setCheck, ref local_Focused);
            }
            else
            {
                local_Focused = true;
            }
        }

        private Word.Paragraph setStrongText(Word.Paragraph oPara1)
        {
            //oPara1.Range.Font.Bold = 1;
            oPara1.Range.Font.Size = 14;
            return oPara1;
        }

        private Word.Paragraph setNormalText(Word.Paragraph oPara1)
        {
            //oPara1.Range.Font.Bold = 0;
            oPara1.Range.Font.Size = 11;
            return oPara1;
        }

        //private void CreateDocReport()
        //{
        //    object oSaveChanges = Word.WdSaveOptions.wdDoNotSaveChanges;
        //    object oMissing = System.Reflection.Missing.Value;

        //    Word._Application oWord;
        //    Word._Document oDoc;
        //    oWord = new Word.Application();
        //    oWord.Visible = false;
        //    oWord.Application.DisplayAlerts = Word.WdAlertLevel.wdAlertsNone;
        //    oDoc = oWord.Documents.Add(ref oMissing, ref oMissing,
        //        ref oMissing, ref oMissing);

        //    Word.Paragraph oPara1;
        //    oPara1 = oDoc.Paragraphs.Add();
        //    oPara1.Range.Font.Name = "Times New Roman";
        //    oPara1.Format.SpaceAfter = 12; //12 pt spacing after paragraph.
        //    oPara1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
        //    setNormalText(oPara1);

        //    setStrongText(oPara1);
        //    oPara1.Range.Text = "Дата/время проведения обследования: " + DateTime.Now.ToString("dd:MM:yyyy") + " / " + DateTime.Now.ToString("hh:mm:ss");
        //    oPara1.Range.InsertParagraphAfter();
        //    setStrongText(oPara1);
        //    oPara1.Range.Text = "Врач: " + Session.getSessionItem<Doctor>("doctor").Surname + " " + Session.getSessionItem<Doctor>("doctor").Name + " " + Session.getSessionItem<Doctor>("doctor").Middlename;
        //    oPara1.Range.InsertParagraphAfter();

        //    oPara1 = oDoc.Paragraphs.Add();
        //    setStrongText(oPara1);
        //    oPara1.Range.Text = "Пациент: " + Session.getSessionItem<Patient>("patient").Surname + " " + Session.getSessionItem<Patient>("patient").Name + " " + Session.getSessionItem<Patient>("patient").Middlename;
        //    oPara1.Range.InsertParagraphAfter();

        //    setStrongText(oPara1);
        //    oPara1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
        //    oPara1 = oDoc.Paragraphs.Add();
        //    oPara1.Range.Text = "Результаты компьютерного обследования Diagnosis Of Retina";
        //    oPara1.Range.InsertParagraphAfter();



        //    Image file1;
        //    using (var file = new FileStream(@"scan\frame10.jpg", FileMode.Open, FileAccess.Read, FileShare.Inheritable))
        //    {
        //        Image file2 = Image.FromStream(file);
        //        file1 = file2;
        //    }
        //    if (file1 != null)
        //    {
        //        setNormalText(oPara1);
        //        oPara1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
        //        oPara1 = oDoc.Paragraphs.Add();
        //        oPara1.Range.Text = "Снимок центрального среза ОКТ:";
        //        oPara1.Range.InsertParagraphAfter();

        //        oPara1 = oDoc.Paragraphs.Add();
        //        String path = System.IO.Path.GetFullPath(@"scan\") + "frame10.jpg";
        //        Word.InlineShape oImage = oDoc.Content.InlineShapes.AddPicture(path, Type.Missing, Type.Missing, oPara1.Range);

        //    }






        //    //Session.getSessionItem<int>("snapshot")

        //    //oPara1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

        //    for (int i = 0; i <= 18; i++)
        //    {
        //        Session.setSessionItem<int>("snapshot", (int)(i));
        //    }


        //    String fileName = "Survey_OCT_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.TimeOfDay.Hours + "_" + DateTime.Now.TimeOfDay.Minutes;
        //    oDoc.SaveAs2(fileName, Word.WdSaveFormat.wdFormatDocument);
        //    //oDoc.SaveAs2("Обследование_",Word.WdSaveFormat.wdFormatPDF);
        //    oWord.Quit(ref oSaveChanges);

        //}

        private void webButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                file_save_path.Text = fbd.SelectedPath;
            }
        }

        private bool CheckAccess()
        {
            try
            {
                File.Create(file_save_path.Text + @"\" + DefaultName).Dispose();
                File.Delete(file_save_path.Text + @"\" + DefaultName);

                char[] invalidChars = Path.GetInvalidFileNameChars();
                foreach (char ch in file_save_name.Text)
                {
                    foreach (char ch1 in invalidChars)
                        if (ch == ch1)
                        {
                            MessageBox.Show("В имени файла присутствуют недопустимые символы");
                            return false;
                        }
                }
                return true;
            }
            catch (DirectoryNotFoundException) { MessageBox.Show("Директория была удалена. Сохранение в несуществующую директорию невозможно."); file_save_path.Text = DefaultPath; return false; }
            catch { MessageBox.Show("Сохранение в данную директорию невозможно из-за ограничений прав доступа. Рекомендуется выбрать директорию Документы"); file_save_path.Text = DefaultPath; return false; }

        }

        private void check_name_auto_CheckedChanged(object sender, EventArgs e)
        {
            if (check_name_auto.Checked) { file_save_name.ReadOnly = false; file_save_name.BackColor = Color.White; } else { file_save_name.ReadOnly = true; file_save_name.BackColor = Color.AliceBlue; file_save_name.Text = DefaultName; }
        }

        public void postChecksdocx()
        {
            if (check_open_folder.Checked == true)
            {
                try
                {
                    Process.Start("explorer.exe", file_save_path.Text);
                }
                catch { }
            }
            if (check_open_report.Checked == true)
            {
                //try
                //{
                Word.Application oWord = new Word.Application();
                oWord.Visible = true;
                oWord.Documents.Open(file_save_path.Text +@"\"+ file_save_name.Text + ".docx", ReadOnly:false, Visible:true);
                //}
                //catch { MessageBox.Show("Невозможно открыть созданный документ. Возможно, на машине не установлено приложение Word."); }
            }
        }

        private void btn_save_docx_Click(object sender, EventArgs e)
        {
            if (loc_param.Checked == true && params_selection.SelectedItems.Count == 0)
            {
                MessageBox.Show("Не выбрано ни одного среза для отображения локальных параметров");
                return;
            }
            //сначала проверка на то, можно ли сюда записывать файл
            if (CheckAccess())
            {
                document = new docx_Report(file_save_path.Text, file_save_name.Text);
                GenerateDocumentBody(document);
                postChecksdocx();

            }
        }

        private void GenerateDocumentBody(DocumentReport document)
        {
            document.CreateDocument();

            //обернуть создание документа в try, могут не существовать какие-нибудь поля

            //вставка основной информации
            document.InsertTopHeader("Отчет о проведении компьютерного обследования");
            document.InsertBreak();
            document.InsertStyledLine("Дата/время проведения обследования: ", DateTime.Now.ToString("dd.MM.yyyy / HH:mm:ss"));
            document.InsertStyledLine("Врач: ", Session.getSessionItem<Doctor>("doctor").Surname + " " + Session.getSessionItem<Doctor>("doctor").Name + " " + Session.getSessionItem<Doctor>("doctor").Middlename);
            document.InsertStyledLine("Пациент: ", Session.getSessionItem<Patient>("patient").Surname + " " + Session.getSessionItem<Patient>("patient").Name + " " + Session.getSessionItem<Patient>("patient").Middlename);
            document.InsertBreak();
            document.InsertCenterHeader("Результаты компьютерного обследования");
            document.InsertCenterHeader("«Diagnosis of Retina»");

            //вставка глобальных параметров
            Dictionary<string, string> glob_params = new Dictionary<string, string>();
            if (scl_param.Checked == true)
            {
                if (survey.Global_correlation != null)
                    glob_params.Add("Корреляция", ((MWNumericArray)survey.Global_correlation).ToScalarDouble().ToString("0.####"));
                if (survey.Global_critical_points != null)
                    glob_params.Add("Критические точки", ((MWNumericArray)survey.Global_critical_points).ToScalarDouble().ToString("0.####"));
                if (survey.Global_max_amplitude != null)
                    glob_params.Add("Амплитуда (макс.)", ((MWNumericArray)survey.Global_max_amplitude).ToScalarDouble().ToString("0.####"));
                if (survey.Global_min_amplitude != null)
                    glob_params.Add("Амплитуда (мин.)", ((MWNumericArray)survey.Global_min_amplitude).ToScalarDouble().ToString("0.####"));
                if (survey.Global_mean_amplitude != null)
                    glob_params.Add("Средняя амплитуда", ((MWNumericArray)survey.Global_mean_amplitude).ToScalarDouble().ToString("0.####"));
                if (survey.Global_n != null)
                    glob_params.Add("Частота", ((MWNumericArray)survey.Global_n).ToScalarDouble().ToString("0.####"));
                if (survey.Global_sum_variability != null)
                    glob_params.Add("Суммарная изменчивость", ((MWNumericArray)survey.Global_sum_variability).ToScalarDouble().ToString("0.####"));
                if (survey.Global_median_variability != null)
                    glob_params.Add("Средняя изменчивость", ((MWNumericArray)survey.Global_median_variability).ToScalarDouble().ToString("0.####"));
            }

            Dictionary<string, string> glob_hole_params = new Dictionary<string, string>();
            if (chole_param.Checked == true)
            {
                if (survey.Global_fovea_length != null)
                    glob_hole_params.Add("Ширина", ((MWNumericArray)survey.Global_fovea_length).ToScalarDouble().ToString("0.####"));
                if (survey.Global_fovea_depth_top != null)
                    glob_hole_params.Add("Глубина", ((MWNumericArray)survey.Global_fovea_depth_top).ToScalarDouble().ToString("0.####"));
                if (survey.Global_fovea_depth_bot != null && survey.Global_fovea_depth_top != null)
                    glob_hole_params.Add("Отношение", ((MWNumericArray)(survey.Global_fovea_depth_bot / (survey.Global_fovea_depth_bot + survey.Global_fovea_depth_top))).ToScalarDouble().ToString("0.####"));
                if (survey.Global_fovea_depth_bot != null)
                    glob_hole_params.Add("Глубина под ямкой", ((MWNumericArray)survey.Global_fovea_depth_bot).ToScalarDouble().ToString("0.####"));
                if (survey.Global_fovea_coef_normality != null)
                    glob_hole_params.Add("Нормальность", ((MWNumericArray)survey.Global_fovea_coef_normality).ToScalarDouble().ToString("0.####"));
                if (survey.Global_fovea_coef_symmetry != null)
                    glob_hole_params.Add("Симметричность", ((MWNumericArray)survey.Global_fovea_coef_symmetry).ToScalarDouble().ToString("0.####"));
            }

            if (glob_params.Count != 0 || glob_hole_params.Count != 0)
                document.InsertLeftHeader("Глобальные параметры");

            if (glob_params.Count != 0)
                {
                    document.InsertLeftHeader("Складчатость");
                    document.InsertTable(glob_params);
                }
            if (glob_hole_params.Count != 0)
                {
                    document.InsertLeftHeader("Центральная ямка");
                    document.InsertTable(glob_hole_params);
                }

            //вставка локальных параметров и картинок, если нужно
            int saveSnap = Session.getSessionItem<int>("snapshot");

            List<int> idxs = new List<int>();
            foreach (string each in image_selection.SelectedItems)
            {
                try
                {
                    string sub = each.Substring(11, each.Length - 11);
                    idxs.Add(Int32.Parse(sub));
                }
                catch (ArgumentOutOfRangeException) { }
                idxs.OrderBy(i => i);
            }

            List<int> param_idx = new List<int>();
            foreach (string each in params_selection.SelectedItems)
            {
                try
                {
                    string sub = each.Substring(7, each.Length - 7);
                    param_idx.Add(Int32.Parse(sub));
                }
                catch (ArgumentOutOfRangeException) { }
                param_idx.OrderBy(i => i);
            }

            document.InsertBreak();
            if (loc_param.Checked == true)
                document.InsertLeftHeader("Локальные параметры");

            for (int i = 1; i <= 19; i++)
            {
                if (idxs.Count > 0)
                {
                    if (idxs.Contains(i))
                    {
                        idxs.Remove(i);
                        int idx = i;
                        Session.setSessionItem<int>("snapshot", idx);
                        try
                        {
                            using (var file = new FileStream(@"scan\frame" + Session.getSessionItem<int>("snapshot").ToString() + ".jpg", FileMode.Open, FileAccess.Read, FileShare.Read))
                            {
                                Image image;
                                using (var img = new FileStream(@"scan\frame" + Session.getSessionItem<int>("snapshot").ToString() + ".jpg", FileMode.Open, FileAccess.Read, FileShare.Read))
                                {
                                    image = Image.FromStream(img);
                                }
                                document.InsertLeftHeader("Снимок среза ОКТ № " + idx);
                                document.InsertImage(file, image);
                            }
                        }
                        catch (FileNotFoundException) { }
                    }
                }

                if (scl_loc_param.Checked == true)
                {
                    if (param_idx.Count > 0)
                    {
                        if (param_idx.Contains(i))
                        {
                            Dictionary<string, string> scl_loc_params = new Dictionary<string, string>();
                            Folding folding = survey.Foldings.ToList<Folding>().Find(x => x.Num_snapshot == i);
                            Critical_points critical_points_left = survey.Critical_points.ToList<Critical_points>().Find(x => x.Num_second_snapshot == i);
                            Critical_points critical_points_right = survey.Critical_points.ToList<Critical_points>().Find(x => x.Num_first_snapshot == i);
                            Correlation correlation_left = survey.Correlations.ToList<Correlation>().Find(x => x.Num_second_snapshot == i);
                            Correlation correlation_right = survey.Correlations.ToList<Correlation>().Find(x => x.Num_first_snapshot == i);
                            if (folding != null)
                            {
                                scl_loc_params.Add("Амплитуда (макс.)", ((MWNumericArray)folding.Max_amplitude).ToScalarDouble().ToString("0.####"));
                                scl_loc_params.Add("Средняя амплитуда", ((MWNumericArray)folding.Mean_amplitude).ToScalarDouble().ToString("0.####"));
                                scl_loc_params.Add("Амплитуда (мин.)", ((MWNumericArray)folding.Min_amplitude).ToScalarDouble().ToString("0.####"));
                                scl_loc_params.Add("Частота", ((MWNumericArray)folding.N).ToScalarDouble().ToString("0.####"));
                               
                            }

                            if (correlation_left != null)
                            {
                                scl_loc_params.Add("Корреляция (с левым)", ((MWNumericArray)correlation_left.Сoefficient).ToScalarDouble().ToString("0.####"));
                            }
                            if (correlation_right != null)
                            {
                                scl_loc_params.Add("Корреляция (с правым)", ((MWNumericArray)correlation_right.Сoefficient).ToScalarDouble().ToString("0.####"));
                            }
                            if(critical_points_left != null)
                            {
                                scl_loc_params.Add("Критические точки (с левым)", ((MWNumericArray)critical_points_left.Count).ToScalarDouble().ToString("0.####"));
                            }
                            if(critical_points_right != null)
                            {
                                scl_loc_params.Add("Критические точки (с правым)", ((MWNumericArray)critical_points_right.Count).ToScalarDouble().ToString("0.####"));
                            }

                            if (scl_loc_params.Count > 0 )
                                document.InsertLeftHeader("Локальные параметры для среза ОКТ № " + i);

                            if (scl_loc_params.Count != 0)
                            {
                                document.InsertLeftHeader("Складчатость");
                                document.InsertTable(scl_loc_params);
                            }

                            //Dictionary<string, string> corn_loc_params = new Dictionary<string, string>();
                            //Corner_variability corner_variability = survey.Corner_variability.ToList<Corner_variability>().Find(x => x.Num_snapshot == i);
                            //if (corner_variability != null)
                            //{

                            //}


                        }
                    }
                }


                if (corn_loc_param.Checked == true)
                {
                    if (param_idx.Count > 0)
                    {
                        if (param_idx.Contains(i))
                        {
                            Dictionary<string, string> corn_loc_params = new Dictionary<string, string>();
                            Corner_variability corner = survey.Corner_variability.ToList<Corner_variability>().Find(x => x.Num_snapshot == i);
                            if (corner != null)
                            {
                                corn_loc_params.Add("Суммарная изменчивость", ((MWNumericArray)corner.Sum_variability).ToScalarDouble().ToString("0.####"));
                                corn_loc_params.Add("Максимлаьная изменчивость", ((MWNumericArray)corner.Max_variability).ToScalarDouble().ToString("0.####"));
                                corn_loc_params.Add("Средняя изменчивость", ((MWNumericArray)corner.Median_variability).ToScalarDouble().ToString("0.####"));
                            }


                            if (corn_loc_params.Count != 0)
                            {
                                document.InsertLeftHeader("Угловая изменчивость");
                                document.InsertTable(corn_loc_params);
                            }

                        }
                    }
                }

                if (freq_loc_param.Checked == true)
                {
                    if (param_idx.Count > 0)
                    {
                        if (param_idx.Contains(i))
                        {
                            Dictionary<string, string> freq_loc_params = new Dictionary<string, string>();
                            Fourier_params freq = survey.Fourier_params.ToList<Fourier_params>().Find(x => x.Num_snapshot == i);
                            if (freq != null)
                            {
                                freq_loc_params.Add("Количество колебаний", ((MWNumericArray)freq.Middle_freq_amount).ToScalarDouble().ToString("0.####"));
                                freq_loc_params.Add("Максимлаьная амплитуда", ((MWNumericArray)freq.Middle_freq_amp).ToScalarDouble().ToString("0.####"));
                                freq_loc_params.Add("Средняя амплитуда", ((MWNumericArray)freq.Middle_freq_mean).ToScalarDouble().ToString("0.####"));
                            }


                            if (freq_loc_params.Count != 0)
                            {
                                document.InsertLeftHeader("Низкочастотные колебания");
                                document.InsertTable(freq_loc_params);
                            }

                        }
                    }
                }
                param_idx.Remove(i);

                Session.setSessionItem<int>("snapshot", saveSnap);

            }
            document.SaveDocument();
        }

        private void btn_save_doc_Click(object sender, EventArgs e)
        {
            if (loc_param.Checked == true && params_selection.SelectedItems.Count == 0)
            {
                MessageBox.Show("Не выбрано ни одного среза для отображения локальных параметров");
                return;
            }
            //сначала проверка на то, можно ли сюда записывать файл
            if (CheckAccess())
            {
                string docxpath = file_save_path.Text + @"\" + file_save_name.Text + ".docx";
                string docpath = file_save_path.Text + @"\" + file_save_name.Text + ".doc";
                try
                {
                    document = new docx_Report(file_save_path.Text, file_save_name.Text);
                    GenerateDocumentBody(document);
                    object oSaveChanges = Word.WdSaveOptions.wdDoNotSaveChanges;
                    object oMissing = System.Reflection.Missing.Value;


                    Word._Application oWord;
                    Word._Document oDoc;
                    oWord = new Word.Application();
                    oWord.Visible = false;
                    oWord.Application.DisplayAlerts = Word.WdAlertLevel.wdAlertsNone;
                    oDoc = oWord.Documents.Open(docxpath);
                    oDoc.SaveAs2(docpath, Word.WdSaveFormat.wdFormatDocument);
                    oWord.Quit(ref oSaveChanges);
                }
                catch { }


                try
                {
                    File.Delete(docxpath);
                }
                catch { }
                postChecksdoc();

            }
        }


        public void postChecksdoc()
        {
            if (check_open_folder.Checked == true)
            {
                try
                {
                    Process.Start("explorer.exe", file_save_path.Text);
                }
                catch { }
            }
            if (check_open_report.Checked == true)
            {
                //try
                //{
                Word.Application oWord = new Word.Application();
                oWord.Visible = true;
                oWord.Documents.Open(file_save_path.Text + @"\" + file_save_name.Text + ".doc", ReadOnly: false, Visible: true);
                //}
                //catch { MessageBox.Show("Невозможно открыть созданный документ. Возможно, на машине не установлено приложение Word."); }
            }
        }

        private void btn_save_pdf_Click(object sender, EventArgs e)
        {
            if (loc_param.Checked == true && params_selection.SelectedItems.Count == 0)
            {
                MessageBox.Show("Не выбрано ни одного среза для отображения локальных параметров");
                return;
            }
            //сначала проверка на то, можно ли сюда записывать файл
            if (CheckAccess())
            {
                string docxpath = file_save_path.Text + @"\" + file_save_name.Text + ".docx";
                string docpath = file_save_path.Text + @"\" + file_save_name.Text + ".pdf";
                try
                {
                    document = new docx_Report(file_save_path.Text, file_save_name.Text);
                    GenerateDocumentBody(document);
                    object oSaveChanges = Word.WdSaveOptions.wdDoNotSaveChanges;
                    object oMissing = System.Reflection.Missing.Value;


                    Word._Application oWord;
                    Word._Document oDoc;
                    oWord = new Word.Application();
                    oWord.Visible = false;
                    oWord.Application.DisplayAlerts = Word.WdAlertLevel.wdAlertsNone;
                    oDoc = oWord.Documents.Open(docxpath);
                    oDoc.SaveAs2(docpath, Word.WdSaveFormat.wdFormatPDF);
                    oWord.Quit(ref oSaveChanges);
                }
                catch { }


                try
                {
                    File.Delete(docxpath);
                }
                catch { }
                postChecksdoc();

            }
        }


        public void postCheckspdf()
        {
            if (check_open_folder.Checked == true)
            {
                try
                {
                    Process.Start("explorer.exe", file_save_path.Text);
                }
                catch { }
            }
        }
    }
}
