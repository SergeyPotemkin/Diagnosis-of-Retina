namespace DiagnosisOfRetinal
{
    partial class Form_info_snaphot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_info_snaphot));
            this.gb_snapshot = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FrameBox = new System.Windows.Forms.PictureBox();
            this.lbl_no_videofile = new System.Windows.Forms.Label();
            this.webTrackBar1 = new Skin.Controles.WebTrackBar();
            this.gb_local_fovea_params = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSymmetry = new Skin.Controles.WebTexbox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNormality = new Skin.Controles.WebTexbox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDivision = new Skin.Controles.WebTexbox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDepthBottom = new Skin.Controles.WebTexbox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDepth = new Skin.Controles.WebTexbox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbWidth = new Skin.Controles.WebTexbox();
            this.gb_local_folding_params = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbMinAmp = new Skin.Controles.WebTexbox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbN = new Skin.Controles.WebTexbox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMeanAmp = new Skin.Controles.WebTexbox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbMaxAmp = new Skin.Controles.WebTexbox();
            this.gb_local_correlation_params = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_right_correlation = new Skin.Controles.WebTexbox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_left_correlation = new Skin.Controles.WebTexbox();
            this.gb_old_survey = new System.Windows.Forms.GroupBox();
            this.lb_view = new System.Windows.Forms.ListBox();
            this.gb_local_critical_points = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_cp_right = new Skin.Controles.WebTexbox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_cp_left = new Skin.Controles.WebTexbox();
            this.btn_create_new_survey = new Skin.Controles.WebButton();
            this.webButton1 = new Skin.Controles.WebButton();
            this.btn_3d = new Skin.Controles.WebButton();
            this.webButton2 = new Skin.Controles.WebButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb_snapshot.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FrameBox)).BeginInit();
            this.gb_local_fovea_params.SuspendLayout();
            this.gb_local_folding_params.SuspendLayout();
            this.gb_local_correlation_params.SuspendLayout();
            this.gb_old_survey.SuspendLayout();
            this.gb_local_critical_points.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_snapshot
            // 
            this.gb_snapshot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_snapshot.Controls.Add(this.panel1);
            this.gb_snapshot.Controls.Add(this.webTrackBar1);
            this.gb_snapshot.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gb_snapshot.ForeColor = System.Drawing.Color.Teal;
            this.gb_snapshot.Location = new System.Drawing.Point(11, 34);
            this.gb_snapshot.Name = "gb_snapshot";
            this.gb_snapshot.Size = new System.Drawing.Size(801, 458);
            this.gb_snapshot.TabIndex = 12;
            this.gb_snapshot.TabStop = false;
            this.gb_snapshot.Text = "Снимок №";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.FrameBox);
            this.panel1.Controls.Add(this.lbl_no_videofile);
            this.panel1.Location = new System.Drawing.Point(19, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 375);
            this.panel1.TabIndex = 28;
            // 
            // FrameBox
            // 
            this.FrameBox.Location = new System.Drawing.Point(3, 3);
            this.FrameBox.Name = "FrameBox";
            this.FrameBox.Size = new System.Drawing.Size(754, 372);
            this.FrameBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FrameBox.TabIndex = 28;
            this.FrameBox.TabStop = false;
            // 
            // lbl_no_videofile
            // 
            this.lbl_no_videofile.AutoSize = true;
            this.lbl_no_videofile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_no_videofile.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbl_no_videofile.Location = new System.Drawing.Point(294, 133);
            this.lbl_no_videofile.Name = "lbl_no_videofile";
            this.lbl_no_videofile.Size = new System.Drawing.Size(132, 21);
            this.lbl_no_videofile.TabIndex = 27;
            this.lbl_no_videofile.Text = "Нет видеофайла!";
            // 
            // webTrackBar1
            // 
            this.webTrackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webTrackBar1.Location = new System.Drawing.Point(19, 410);
            this.webTrackBar1.Maximum = 18;
            this.webTrackBar1.Minimum = 0;
            this.webTrackBar1.Name = "webTrackBar1";
            this.webTrackBar1.Size = new System.Drawing.Size(760, 36);
            this.webTrackBar1.TabIndex = 13;
            this.webTrackBar1.TrackColor = Skin.Colores.Natural.Azul;
            this.webTrackBar1.Value = 0;
            this.webTrackBar1.ValueChanged += new Skin.Controles.ValueChangedHandler(this.webTrackBar1_ValueChanged);
            // 
            // gb_local_fovea_params
            // 
            this.gb_local_fovea_params.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_local_fovea_params.Controls.Add(this.label5);
            this.gb_local_fovea_params.Controls.Add(this.tbSymmetry);
            this.gb_local_fovea_params.Controls.Add(this.label4);
            this.gb_local_fovea_params.Controls.Add(this.tbNormality);
            this.gb_local_fovea_params.Controls.Add(this.label3);
            this.gb_local_fovea_params.Controls.Add(this.tbDivision);
            this.gb_local_fovea_params.Controls.Add(this.label2);
            this.gb_local_fovea_params.Controls.Add(this.tbDepthBottom);
            this.gb_local_fovea_params.Controls.Add(this.label1);
            this.gb_local_fovea_params.Controls.Add(this.tbDepth);
            this.gb_local_fovea_params.Controls.Add(this.label11);
            this.gb_local_fovea_params.Controls.Add(this.tbWidth);
            this.gb_local_fovea_params.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gb_local_fovea_params.ForeColor = System.Drawing.Color.Teal;
            this.gb_local_fovea_params.Location = new System.Drawing.Point(817, 257);
            this.gb_local_fovea_params.Name = "gb_local_fovea_params";
            this.gb_local_fovea_params.Size = new System.Drawing.Size(256, 288);
            this.gb_local_fovea_params.TabIndex = 12;
            this.gb_local_fovea_params.TabStop = false;
            this.gb_local_fovea_params.Text = "Параметры ц. ям.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.CadetBlue;
            this.label5.Location = new System.Drawing.Point(16, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 21);
            this.label5.TabIndex = 50;
            this.label5.Text = "Симметричность:";
            // 
            // tbSymmetry
            // 
            this.tbSymmetry.BackColor = System.Drawing.SystemColors.Window;
            this.tbSymmetry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSymmetry.Lines = new string[0];
            this.tbSymmetry.Location = new System.Drawing.Point(171, 204);
            this.tbSymmetry.Name = "tbSymmetry";
            this.tbSymmetry.PasswordChar = '\0';
            this.tbSymmetry.PlaceHolder = "";
            this.tbSymmetry.ReadOnly = true;
            this.tbSymmetry.Size = new System.Drawing.Size(66, 20);
            this.tbSymmetry.TabIndex = 49;
            this.tbSymmetry.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.CadetBlue;
            this.label4.Location = new System.Drawing.Point(16, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 48;
            this.label4.Text = "Нормальность:";
            // 
            // tbNormality
            // 
            this.tbNormality.BackColor = System.Drawing.SystemColors.Window;
            this.tbNormality.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbNormality.Lines = new string[0];
            this.tbNormality.Location = new System.Drawing.Point(171, 169);
            this.tbNormality.Name = "tbNormality";
            this.tbNormality.PasswordChar = '\0';
            this.tbNormality.PlaceHolder = "";
            this.tbNormality.ReadOnly = true;
            this.tbNormality.Size = new System.Drawing.Size(66, 20);
            this.tbNormality.TabIndex = 47;
            this.tbNormality.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.CadetBlue;
            this.label3.Location = new System.Drawing.Point(16, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 46;
            this.label3.Text = "Отношение:";
            // 
            // tbDivision
            // 
            this.tbDivision.BackColor = System.Drawing.SystemColors.Window;
            this.tbDivision.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbDivision.Lines = new string[0];
            this.tbDivision.Location = new System.Drawing.Point(171, 133);
            this.tbDivision.Name = "tbDivision";
            this.tbDivision.PasswordChar = '\0';
            this.tbDivision.PlaceHolder = "";
            this.tbDivision.ReadOnly = true;
            this.tbDivision.Size = new System.Drawing.Size(66, 20);
            this.tbDivision.TabIndex = 45;
            this.tbDivision.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(16, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "Глубина под ямкой:";
            // 
            // tbDepthBottom
            // 
            this.tbDepthBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbDepthBottom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbDepthBottom.Lines = new string[0];
            this.tbDepthBottom.Location = new System.Drawing.Point(171, 97);
            this.tbDepthBottom.Name = "tbDepthBottom";
            this.tbDepthBottom.PasswordChar = '\0';
            this.tbDepthBottom.PlaceHolder = "";
            this.tbDepthBottom.ReadOnly = true;
            this.tbDepthBottom.Size = new System.Drawing.Size(66, 20);
            this.tbDepthBottom.TabIndex = 43;
            this.tbDepthBottom.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(16, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 42;
            this.label1.Text = "Глубина:";
            // 
            // tbDepth
            // 
            this.tbDepth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbDepth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbDepth.Lines = new string[0];
            this.tbDepth.Location = new System.Drawing.Point(171, 62);
            this.tbDepth.Name = "tbDepth";
            this.tbDepth.PasswordChar = '\0';
            this.tbDepth.PlaceHolder = "";
            this.tbDepth.ReadOnly = true;
            this.tbDepth.Size = new System.Drawing.Size(66, 20);
            this.tbDepth.TabIndex = 41;
            this.tbDepth.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.CadetBlue;
            this.label11.Location = new System.Drawing.Point(16, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 21);
            this.label11.TabIndex = 40;
            this.label11.Text = "Ширина:";
            // 
            // tbWidth
            // 
            this.tbWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbWidth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbWidth.Lines = new string[0];
            this.tbWidth.Location = new System.Drawing.Point(171, 28);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.PasswordChar = '\0';
            this.tbWidth.PlaceHolder = "";
            this.tbWidth.ReadOnly = true;
            this.tbWidth.Size = new System.Drawing.Size(66, 20);
            this.tbWidth.TabIndex = 35;
            this.tbWidth.TabStop = false;
            // 
            // gb_local_folding_params
            // 
            this.gb_local_folding_params.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_local_folding_params.Controls.Add(this.label14);
            this.gb_local_folding_params.Controls.Add(this.tbMinAmp);
            this.gb_local_folding_params.Controls.Add(this.label9);
            this.gb_local_folding_params.Controls.Add(this.tbN);
            this.gb_local_folding_params.Controls.Add(this.label10);
            this.gb_local_folding_params.Controls.Add(this.tbMeanAmp);
            this.gb_local_folding_params.Controls.Add(this.label12);
            this.gb_local_folding_params.Controls.Add(this.tbMaxAmp);
            this.gb_local_folding_params.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gb_local_folding_params.ForeColor = System.Drawing.Color.Teal;
            this.gb_local_folding_params.Location = new System.Drawing.Point(818, 257);
            this.gb_local_folding_params.Name = "gb_local_folding_params";
            this.gb_local_folding_params.Size = new System.Drawing.Size(256, 289);
            this.gb_local_folding_params.TabIndex = 51;
            this.gb_local_folding_params.TabStop = false;
            this.gb_local_folding_params.Text = "Параметры складчатости:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.CadetBlue;
            this.label14.Location = new System.Drawing.Point(16, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 21);
            this.label14.TabIndex = 46;
            this.label14.Text = "Мин. амплитуда:";
            // 
            // tbMinAmp
            // 
            this.tbMinAmp.BackColor = System.Drawing.SystemColors.Window;
            this.tbMinAmp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbMinAmp.Lines = new string[0];
            this.tbMinAmp.Location = new System.Drawing.Point(171, 62);
            this.tbMinAmp.Name = "tbMinAmp";
            this.tbMinAmp.PasswordChar = '\0';
            this.tbMinAmp.PlaceHolder = "";
            this.tbMinAmp.ReadOnly = true;
            this.tbMinAmp.Size = new System.Drawing.Size(66, 20);
            this.tbMinAmp.TabIndex = 45;
            this.tbMinAmp.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.CadetBlue;
            this.label9.Location = new System.Drawing.Point(16, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 21);
            this.label9.TabIndex = 44;
            this.label9.Text = "Частота:";
            // 
            // tbN
            // 
            this.tbN.BackColor = System.Drawing.SystemColors.Window;
            this.tbN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbN.Lines = new string[0];
            this.tbN.Location = new System.Drawing.Point(171, 128);
            this.tbN.Name = "tbN";
            this.tbN.PasswordChar = '\0';
            this.tbN.PlaceHolder = "";
            this.tbN.ReadOnly = true;
            this.tbN.Size = new System.Drawing.Size(66, 20);
            this.tbN.TabIndex = 43;
            this.tbN.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.CadetBlue;
            this.label10.Location = new System.Drawing.Point(16, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 21);
            this.label10.TabIndex = 42;
            this.label10.Text = "Средняя амплитуда:";
            // 
            // tbMeanAmp
            // 
            this.tbMeanAmp.BackColor = System.Drawing.SystemColors.Window;
            this.tbMeanAmp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbMeanAmp.Lines = new string[0];
            this.tbMeanAmp.Location = new System.Drawing.Point(171, 93);
            this.tbMeanAmp.Name = "tbMeanAmp";
            this.tbMeanAmp.PasswordChar = '\0';
            this.tbMeanAmp.PlaceHolder = "";
            this.tbMeanAmp.ReadOnly = true;
            this.tbMeanAmp.Size = new System.Drawing.Size(66, 20);
            this.tbMeanAmp.TabIndex = 41;
            this.tbMeanAmp.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.CadetBlue;
            this.label12.Location = new System.Drawing.Point(16, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 21);
            this.label12.TabIndex = 40;
            this.label12.Text = "Макс. амплитуда:";
            // 
            // tbMaxAmp
            // 
            this.tbMaxAmp.BackColor = System.Drawing.SystemColors.Window;
            this.tbMaxAmp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbMaxAmp.Lines = new string[0];
            this.tbMaxAmp.Location = new System.Drawing.Point(171, 28);
            this.tbMaxAmp.Name = "tbMaxAmp";
            this.tbMaxAmp.PasswordChar = '\0';
            this.tbMaxAmp.PlaceHolder = "";
            this.tbMaxAmp.ReadOnly = true;
            this.tbMaxAmp.Size = new System.Drawing.Size(66, 20);
            this.tbMaxAmp.TabIndex = 35;
            this.tbMaxAmp.TabStop = false;
            // 
            // gb_local_correlation_params
            // 
            this.gb_local_correlation_params.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_local_correlation_params.Controls.Add(this.label7);
            this.gb_local_correlation_params.Controls.Add(this.tb_right_correlation);
            this.gb_local_correlation_params.Controls.Add(this.label8);
            this.gb_local_correlation_params.Controls.Add(this.tb_left_correlation);
            this.gb_local_correlation_params.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gb_local_correlation_params.ForeColor = System.Drawing.Color.Teal;
            this.gb_local_correlation_params.Location = new System.Drawing.Point(817, 258);
            this.gb_local_correlation_params.Name = "gb_local_correlation_params";
            this.gb_local_correlation_params.Size = new System.Drawing.Size(255, 289);
            this.gb_local_correlation_params.TabIndex = 52;
            this.gb_local_correlation_params.TabStop = false;
            this.gb_local_correlation_params.Text = "Параметры корреляции:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.CadetBlue;
            this.label7.Location = new System.Drawing.Point(16, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 21);
            this.label7.TabIndex = 42;
            this.label7.Text = "С правым кадром:";
            // 
            // tb_right_correlation
            // 
            this.tb_right_correlation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_right_correlation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_right_correlation.Lines = new string[0];
            this.tb_right_correlation.Location = new System.Drawing.Point(171, 62);
            this.tb_right_correlation.Name = "tb_right_correlation";
            this.tb_right_correlation.PasswordChar = '\0';
            this.tb_right_correlation.PlaceHolder = "";
            this.tb_right_correlation.ReadOnly = true;
            this.tb_right_correlation.Size = new System.Drawing.Size(66, 20);
            this.tb_right_correlation.TabIndex = 41;
            this.tb_right_correlation.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.CadetBlue;
            this.label8.Location = new System.Drawing.Point(16, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 21);
            this.label8.TabIndex = 40;
            this.label8.Text = "С левым кадром:";
            // 
            // tb_left_correlation
            // 
            this.tb_left_correlation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tb_left_correlation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_left_correlation.Lines = new string[0];
            this.tb_left_correlation.Location = new System.Drawing.Point(171, 28);
            this.tb_left_correlation.Name = "tb_left_correlation";
            this.tb_left_correlation.PasswordChar = '\0';
            this.tb_left_correlation.PlaceHolder = "";
            this.tb_left_correlation.ReadOnly = true;
            this.tb_left_correlation.Size = new System.Drawing.Size(66, 20);
            this.tb_left_correlation.TabIndex = 35;
            this.tb_left_correlation.TabStop = false;
            // 
            // gb_old_survey
            // 
            this.gb_old_survey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_old_survey.Controls.Add(this.lb_view);
            this.gb_old_survey.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gb_old_survey.ForeColor = System.Drawing.Color.Teal;
            this.gb_old_survey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gb_old_survey.Location = new System.Drawing.Point(818, 33);
            this.gb_old_survey.Name = "gb_old_survey";
            this.gb_old_survey.Size = new System.Drawing.Size(256, 218);
            this.gb_old_survey.TabIndex = 14;
            this.gb_old_survey.TabStop = false;
            this.gb_old_survey.Text = "Варианты представления:";
            // 
            // lb_view
            // 
            this.lb_view.BackColor = System.Drawing.SystemColors.Window;
            this.lb_view.ForeColor = System.Drawing.Color.Teal;
            this.lb_view.FormattingEnabled = true;
            this.lb_view.ItemHeight = 21;
            this.lb_view.Items.AddRange(new object[] {
            "Обычный вид",
            "Параметры ц. ям.",
            "Корреляция кадров",
            "Критические точки",
            "Частотная составляющая"});
            this.lb_view.Location = new System.Drawing.Point(10, 28);
            this.lb_view.Name = "lb_view";
            this.lb_view.Size = new System.Drawing.Size(229, 172);
            this.lb_view.TabIndex = 0;
            this.lb_view.SelectedIndexChanged += new System.EventHandler(this.lb_old_survey_SelectedIndexChanged);
            // 
            // gb_local_critical_points
            // 
            this.gb_local_critical_points.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_local_critical_points.Controls.Add(this.label6);
            this.gb_local_critical_points.Controls.Add(this.tb_cp_right);
            this.gb_local_critical_points.Controls.Add(this.label13);
            this.gb_local_critical_points.Controls.Add(this.tb_cp_left);
            this.gb_local_critical_points.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gb_local_critical_points.ForeColor = System.Drawing.Color.Teal;
            this.gb_local_critical_points.Location = new System.Drawing.Point(818, 258);
            this.gb_local_critical_points.Name = "gb_local_critical_points";
            this.gb_local_critical_points.Size = new System.Drawing.Size(255, 289);
            this.gb_local_critical_points.TabIndex = 53;
            this.gb_local_critical_points.TabStop = false;
            this.gb_local_critical_points.Text = "Критические точки:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.CadetBlue;
            this.label6.Location = new System.Drawing.Point(16, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 21);
            this.label6.TabIndex = 42;
            this.label6.Text = "С правым кадром:";
            // 
            // tb_cp_right
            // 
            this.tb_cp_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_cp_right.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_cp_right.Lines = new string[0];
            this.tb_cp_right.Location = new System.Drawing.Point(171, 62);
            this.tb_cp_right.Name = "tb_cp_right";
            this.tb_cp_right.PasswordChar = '\0';
            this.tb_cp_right.PlaceHolder = "";
            this.tb_cp_right.ReadOnly = true;
            this.tb_cp_right.Size = new System.Drawing.Size(66, 20);
            this.tb_cp_right.TabIndex = 41;
            this.tb_cp_right.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.CadetBlue;
            this.label13.Location = new System.Drawing.Point(16, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 21);
            this.label13.TabIndex = 40;
            this.label13.Text = "С левым кадром:";
            // 
            // tb_cp_left
            // 
            this.tb_cp_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tb_cp_left.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_cp_left.Lines = new string[0];
            this.tb_cp_left.Location = new System.Drawing.Point(171, 28);
            this.tb_cp_left.Name = "tb_cp_left";
            this.tb_cp_left.PasswordChar = '\0';
            this.tb_cp_left.PlaceHolder = "";
            this.tb_cp_left.ReadOnly = true;
            this.tb_cp_left.Size = new System.Drawing.Size(66, 20);
            this.tb_cp_left.TabIndex = 35;
            this.tb_cp_left.TabStop = false;
            // 
            // btn_create_new_survey
            // 
            this.btn_create_new_survey.BackColor = Skin.Colores.Natural.Azul;
            this.btn_create_new_survey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create_new_survey.Depth = 0;
            this.btn_create_new_survey.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_create_new_survey.ForeColor = System.Drawing.Color.White;
            this.btn_create_new_survey.IconShow = true;
            this.btn_create_new_survey.IconType = Skin.IconType.plus;
            this.btn_create_new_survey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_create_new_survey.Location = new System.Drawing.Point(12, 498);
            this.btn_create_new_survey.MouseLocation = new System.Drawing.Point(0, 0);
            this.btn_create_new_survey.MouseState = Skin.MouseState.HOVER;
            this.btn_create_new_survey.Name = "btn_create_new_survey";
            this.btn_create_new_survey.Size = new System.Drawing.Size(210, 44);
            this.btn_create_new_survey.TabIndex = 54;
            this.btn_create_new_survey.Text = "Увеличить масштаб";
            this.btn_create_new_survey.Click += new System.EventHandler(this.btn_create_new_survey_Click);
            // 
            // webButton1
            // 
            this.webButton1.BackColor = Skin.Colores.Natural.Azul;
            this.webButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.webButton1.Depth = 0;
            this.webButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.webButton1.ForeColor = System.Drawing.Color.White;
            this.webButton1.IconShow = true;
            this.webButton1.IconType = Skin.IconType.minus;
            this.webButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.webButton1.Location = new System.Drawing.Point(228, 498);
            this.webButton1.MouseLocation = new System.Drawing.Point(0, 0);
            this.webButton1.MouseState = Skin.MouseState.HOVER;
            this.webButton1.Name = "webButton1";
            this.webButton1.Size = new System.Drawing.Size(210, 44);
            this.webButton1.TabIndex = 55;
            this.webButton1.Text = "Уменьшить масштаб";
            this.webButton1.Click += new System.EventHandler(this.webButton1_Click);
            // 
            // btn_3d
            // 
            this.btn_3d.BackColor = Skin.Colores.Natural.Azul;
            this.btn_3d.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_3d.Depth = 0;
            this.btn_3d.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_3d.ForeColor = System.Drawing.Color.White;
            this.btn_3d.IconShow = true;
            this.btn_3d.IconStyle = Skin.Controles.WebButton.Style.Flat;
            this.btn_3d.IconType = Skin.IconType.cube;
            this.btn_3d.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_3d.Location = new System.Drawing.Point(601, 498);
            this.btn_3d.MouseLocation = new System.Drawing.Point(0, 0);
            this.btn_3d.MouseState = Skin.MouseState.HOVER;
            this.btn_3d.Name = "btn_3d";
            this.btn_3d.Size = new System.Drawing.Size(210, 44);
            this.btn_3d.TabIndex = 56;
            this.btn_3d.Text = "3D модель";
            this.btn_3d.Click += new System.EventHandler(this.btn_3d_Click);
            // 
            // webButton2
            // 
            this.webButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.webButton2.BackColor = Skin.Colores.Natural.Azul;
            this.webButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.webButton2.Depth = 0;
            this.webButton2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.webButton2.ForeColor = System.Drawing.Color.White;
            this.webButton2.IconType = Skin.IconType.None;
            this.webButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.webButton2.Location = new System.Drawing.Point(444, 498);
            this.webButton2.MouseLocation = new System.Drawing.Point(0, 0);
            this.webButton2.MouseState = Skin.MouseState.HOVER;
            this.webButton2.Name = "webButton2";
            this.webButton2.Size = new System.Drawing.Size(53, 44);
            this.webButton2.TabIndex = 58;
            this.webButton2.Text = "1 : 1";
            this.webButton2.Click += new System.EventHandler(this.webButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DiagnosisOfRetinal.Properties.Resources.Безымянный2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(819, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 289);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Расшифровка обозначений:";
            // 
            // Form_info_snaphot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 558);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.webButton2);
            this.Controls.Add(this.btn_3d);
            this.Controls.Add(this.webButton1);
            this.Controls.Add(this.btn_create_new_survey);
            this.Controls.Add(this.gb_local_folding_params);
            this.Controls.Add(this.gb_local_correlation_params);
            this.Controls.Add(this.gb_snapshot);
            this.Controls.Add(this.gb_old_survey);
            this.Controls.Add(this.gb_local_critical_points);
            this.Controls.Add(this.gb_local_fovea_params);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_info_snaphot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Подробнее";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_info_snaphot_FormClosing);
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.Controls.SetChildIndex(this.gb_local_fovea_params, 0);
            this.Controls.SetChildIndex(this.gb_local_critical_points, 0);
            this.Controls.SetChildIndex(this.gb_old_survey, 0);
            this.Controls.SetChildIndex(this.gb_snapshot, 0);
            this.Controls.SetChildIndex(this.gb_local_correlation_params, 0);
            this.Controls.SetChildIndex(this.gb_local_folding_params, 0);
            this.Controls.SetChildIndex(this.btn_create_new_survey, 0);
            this.Controls.SetChildIndex(this.webButton1, 0);
            this.Controls.SetChildIndex(this.btn_3d, 0);
            this.Controls.SetChildIndex(this.webButton2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.gb_snapshot.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FrameBox)).EndInit();
            this.gb_local_fovea_params.ResumeLayout(false);
            this.gb_local_fovea_params.PerformLayout();
            this.gb_local_folding_params.ResumeLayout(false);
            this.gb_local_folding_params.PerformLayout();
            this.gb_local_correlation_params.ResumeLayout(false);
            this.gb_local_correlation_params.PerformLayout();
            this.gb_old_survey.ResumeLayout(false);
            this.gb_local_critical_points.ResumeLayout(false);
            this.gb_local_critical_points.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_snapshot;
        private Skin.Controles.WebTrackBar webTrackBar1;
        private System.Windows.Forms.GroupBox gb_local_fovea_params;
        private System.Windows.Forms.GroupBox gb_old_survey;
        private System.Windows.Forms.ListBox lb_view;
        private System.Windows.Forms.Label label11;
        private Skin.Controles.WebTexbox tbWidth;
        private System.Windows.Forms.Label lbl_no_videofile;
        private System.Windows.Forms.Label label3;
        private Skin.Controles.WebTexbox tbDivision;
        private System.Windows.Forms.Label label2;
        private Skin.Controles.WebTexbox tbDepthBottom;
        private System.Windows.Forms.Label label1;
        private Skin.Controles.WebTexbox tbDepth;
        private System.Windows.Forms.Label label4;
        private Skin.Controles.WebTexbox tbNormality;
        private System.Windows.Forms.Label label5;
        private Skin.Controles.WebTexbox tbSymmetry;
        private System.Windows.Forms.GroupBox gb_local_folding_params;
        private System.Windows.Forms.Label label9;
        private Skin.Controles.WebTexbox tbN;
        private System.Windows.Forms.Label label10;
        private Skin.Controles.WebTexbox tbMeanAmp;
        private System.Windows.Forms.Label label12;
        private Skin.Controles.WebTexbox tbMaxAmp;
        private System.Windows.Forms.GroupBox gb_local_correlation_params;
        private System.Windows.Forms.Label label7;
        private Skin.Controles.WebTexbox tb_right_correlation;
        private System.Windows.Forms.Label label8;
        private Skin.Controles.WebTexbox tb_left_correlation;
        private System.Windows.Forms.GroupBox gb_local_critical_points;
        private System.Windows.Forms.Label label6;
        private Skin.Controles.WebTexbox tb_cp_right;
        private System.Windows.Forms.Label label13;
        private Skin.Controles.WebTexbox tb_cp_left;
        private System.Windows.Forms.Panel panel1;
        private Skin.Controles.WebButton btn_create_new_survey;
        private Skin.Controles.WebButton webButton1;
        private System.Windows.Forms.PictureBox FrameBox;
        private Skin.Controles.WebButton btn_3d;
        private System.Windows.Forms.Label label14;
        private Skin.Controles.WebTexbox tbMinAmp;
        private Skin.Controles.WebButton webButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}