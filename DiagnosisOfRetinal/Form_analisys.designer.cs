namespace DiagnosisOfRetinal
{
    partial class Form_analisys
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_analisys));
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_min = new Skin.Controles.WebRadioButton();
            this.rb_max = new Skin.Controles.WebRadioButton();
            this.rb_all = new Skin.Controles.WebRadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.webButton1 = new Skin.Controles.WebButton();
            this.cb_Patients = new System.Windows.Forms.ComboBox();
            this.webIconLabel3 = new Skin.Controles.WebIconLabel();
            this.webIconLabel1 = new Skin.Controles.WebIconLabel();
            this.webIconLabel2 = new Skin.Controles.WebIconLabel();
            this.webIconLabel4 = new Skin.Controles.WebIconLabel();
            this.gb_global_params = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.gb_global_params.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_EndDate.Location = new System.Drawing.Point(317, 27);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(179, 29);
            this.dtp_EndDate.TabIndex = 8;
            this.dtp_EndDate.CloseUp += new System.EventHandler(this.dtp_EndDate_CloseUp);
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_StartDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_StartDate.Location = new System.Drawing.Point(70, 27);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(177, 29);
            this.dtp_StartDate.TabIndex = 9;
            this.dtp_StartDate.CloseUp += new System.EventHandler(this.dtp_StartDate_CloseUp);
            // 
            // chart1
            // 
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorGrid.IntervalOffset = 0D;
            chartArea1.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 113);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.LabelBackColor = System.Drawing.Color.Yellow;
            series1.Legend = "Legend1";
            series1.LegendText = "График макс. значений";
            series1.Name = "Series1";
            series2.BorderColor = System.Drawing.Color.Black;
            series2.BorderWidth = 10;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.Yellow;
            series2.EmptyPointStyle.IsVisibleInLegend = false;
            series2.LabelBackColor = System.Drawing.Color.Yellow;
            series2.LabelBorderWidth = 10;
            series2.Legend = "Legend1";
            series2.LegendText = "Точки макс. значений";
            series2.MarkerSize = 10;
            series2.Name = "Series2";
            series2.YValuesPerPoint = 2;
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.LabelBackColor = System.Drawing.Color.Yellow;
            series3.Legend = "Legend1";
            series3.LegendText = "График мин. значений";
            series3.Name = "Series3";
            series4.BorderColor = System.Drawing.Color.Black;
            series4.BorderWidth = 10;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Color = System.Drawing.Color.Yellow;
            series4.EmptyPointStyle.IsVisibleInLegend = false;
            series4.LabelBackColor = System.Drawing.Color.Yellow;
            series4.LabelBorderWidth = 10;
            series4.Legend = "Legend1";
            series4.LegendText = "Точки мин. значений";
            series4.MarkerSize = 10;
            series4.Name = "Series4";
            series4.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(723, 418);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title1.Name = "Title1";
            this.chart1.Titles.Add(title1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_min);
            this.panel1.Controls.Add(this.rb_max);
            this.panel1.Controls.Add(this.rb_all);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(6, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 110);
            this.panel1.TabIndex = 11;
            // 
            // rb_min
            // 
            this.rb_min.CheckColor = Skin.Colores.Natural.A700azul;
            this.rb_min.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rb_min.Location = new System.Drawing.Point(3, 70);
            this.rb_min.Name = "rb_min";
            this.rb_min.Size = new System.Drawing.Size(193, 23);
            this.rb_min.TabIndex = 12;
            this.rb_min.Text = "Только минимальные";
            this.rb_min.UseVisualStyleBackColor = true;
            this.rb_min.CheckedChanged += new System.EventHandler(this.webRadioButton1_CheckedChanged);
            // 
            // rb_max
            // 
            this.rb_max.CheckColor = Skin.Colores.Natural.A700azul;
            this.rb_max.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rb_max.Location = new System.Drawing.Point(3, 41);
            this.rb_max.Name = "rb_max";
            this.rb_max.Size = new System.Drawing.Size(204, 23);
            this.rb_max.TabIndex = 12;
            this.rb_max.Text = "Только максимальные";
            this.rb_max.UseVisualStyleBackColor = true;
            this.rb_max.CheckedChanged += new System.EventHandler(this.webRadioButton1_CheckedChanged);
            // 
            // rb_all
            // 
            this.rb_all.CheckColor = Skin.Colores.Natural.A700azul;
            this.rb_all.Checked = true;
            this.rb_all.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rb_all.Location = new System.Drawing.Point(3, 12);
            this.rb_all.Name = "rb_all";
            this.rb_all.Size = new System.Drawing.Size(160, 23);
            this.rb_all.TabIndex = 12;
            this.rb_all.TabStop = true;
            this.rb_all.Text = "Все значения";
            this.rb_all.UseVisualStyleBackColor = true;
            this.rb_all.CheckedChanged += new System.EventHandler(this.webRadioButton1_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(741, 113);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(276, 418);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.ForeColor = System.Drawing.Color.Teal;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(268, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Глобальные параметры";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Window;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Items.AddRange(new object[] {
            "Корреляция",
            "Критические точки",
            "Максимальная амплитуда складок",
            "Минимальная амплитуда складок",
            "Средняя амплитуда складок",
            "Частота складок"});
            this.listBox1.Location = new System.Drawing.Point(3, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(262, 151);
            this.listBox1.TabIndex = 16;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(268, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Локальные параметры";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(268, 214);
            this.tabControl2.TabIndex = 12;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.listBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(260, 188);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Центральная ямка";
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.Window;
            this.listBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 21;
            this.listBox2.Items.AddRange(new object[] {
            "Ширина ц.ям.",
            "Глубина ц.ям.",
            "Отношение ц.ям.",
            "Симметричность ц.ям.",
            "Нормальность ц.ям."});
            this.listBox2.Location = new System.Drawing.Point(3, 6);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(254, 130);
            this.listBox2.TabIndex = 17;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.listBox3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(260, 188);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Складчатость";
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.SystemColors.Window;
            this.listBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 21;
            this.listBox3.Items.AddRange(new object[] {
            "Корреляция",
            "Критические точки",
            "Максимальная амплитуда складок",
            "Минимальная амплитуда складок",
            "Средняя амплитуда складок",
            "Частота складок"});
            this.listBox3.Location = new System.Drawing.Point(3, 6);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(255, 151);
            this.listBox3.TabIndex = 17;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // webButton1
            // 
            this.webButton1.BackColor = Skin.Colores.Natural.Azul;
            this.webButton1.Depth = 0;
            this.webButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.webButton1.ForeColor = System.Drawing.Color.White;
            this.webButton1.Location = new System.Drawing.Point(874, 52);
            this.webButton1.MouseLocation = new System.Drawing.Point(0, 0);
            this.webButton1.MouseState = Skin.MouseState.HOVER;
            this.webButton1.Name = "webButton1";
            this.webButton1.Size = new System.Drawing.Size(143, 55);
            this.webButton1.TabIndex = 13;
            this.webButton1.Text = "Выбрать";
            this.webButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_Patients
            // 
            this.cb_Patients.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Patients.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Patients.BackColor = System.Drawing.SystemColors.Window;
            this.cb_Patients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Patients.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cb_Patients.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cb_Patients.FormattingEnabled = true;
            this.cb_Patients.Location = new System.Drawing.Point(6, 27);
            this.cb_Patients.Name = "cb_Patients";
            this.cb_Patients.Size = new System.Drawing.Size(332, 29);
            this.cb_Patients.TabIndex = 14;
            this.cb_Patients.SelectedIndexChanged += new System.EventHandler(this.cb_Patients_SelectedIndexChanged);
            // 
            // webIconLabel3
            // 
            this.webIconLabel3.Depth = 0;
            this.webIconLabel3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.webIconLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.webIconLabel3.IconColor = Skin.Colores.Natural.Azul;
            this.webIconLabel3.IconSize = 21;
            this.webIconLabel3.IconType = Skin.IconType.user;
            this.webIconLabel3.Location = new System.Drawing.Point(6, 0);
            this.webIconLabel3.MouseLocation = new System.Drawing.Point(0, 0);
            this.webIconLabel3.MouseState = Skin.MouseState.HOVER;
            this.webIconLabel3.Name = "webIconLabel3";
            this.webIconLabel3.Size = new System.Drawing.Size(105, 21);
            this.webIconLabel3.TabIndex = 15;
            this.webIconLabel3.Text = "Пациент:";
            // 
            // webIconLabel1
            // 
            this.webIconLabel1.Depth = 0;
            this.webIconLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.webIconLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.webIconLabel1.IconColor = Skin.Colores.Natural.Azul;
            this.webIconLabel1.IconSize = 21;
            this.webIconLabel1.IconType = Skin.IconType.calendar;
            this.webIconLabel1.Location = new System.Drawing.Point(6, 0);
            this.webIconLabel1.MouseLocation = new System.Drawing.Point(0, 0);
            this.webIconLabel1.MouseState = Skin.MouseState.HOVER;
            this.webIconLabel1.Name = "webIconLabel1";
            this.webIconLabel1.Size = new System.Drawing.Size(138, 21);
            this.webIconLabel1.TabIndex = 15;
            this.webIconLabel1.Text = "Диапазон дат:";
            // 
            // webIconLabel2
            // 
            this.webIconLabel2.Depth = 0;
            this.webIconLabel2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.webIconLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.webIconLabel2.IconColor = Skin.Colores.Natural.Azul;
            this.webIconLabel2.IconSize = 21;
            this.webIconLabel2.IconType = Skin.IconType.None;
            this.webIconLabel2.Location = new System.Drawing.Point(6, 31);
            this.webIconLabel2.MouseLocation = new System.Drawing.Point(0, 0);
            this.webIconLabel2.MouseState = Skin.MouseState.HOVER;
            this.webIconLabel2.Name = "webIconLabel2";
            this.webIconLabel2.Size = new System.Drawing.Size(58, 21);
            this.webIconLabel2.TabIndex = 15;
            this.webIconLabel2.Text = "от";
            // 
            // webIconLabel4
            // 
            this.webIconLabel4.Depth = 0;
            this.webIconLabel4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.webIconLabel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.webIconLabel4.IconColor = Skin.Colores.Natural.Azul;
            this.webIconLabel4.IconSize = 21;
            this.webIconLabel4.IconType = Skin.IconType.None;
            this.webIconLabel4.Location = new System.Drawing.Point(253, 31);
            this.webIconLabel4.MouseLocation = new System.Drawing.Point(0, 0);
            this.webIconLabel4.MouseState = Skin.MouseState.HOVER;
            this.webIconLabel4.Name = "webIconLabel4";
            this.webIconLabel4.Size = new System.Drawing.Size(58, 21);
            this.webIconLabel4.TabIndex = 15;
            this.webIconLabel4.Text = "до";
            // 
            // gb_global_params
            // 
            this.gb_global_params.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_global_params.Controls.Add(this.webIconLabel3);
            this.gb_global_params.Controls.Add(this.cb_Patients);
            this.gb_global_params.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gb_global_params.ForeColor = System.Drawing.Color.Teal;
            this.gb_global_params.Location = new System.Drawing.Point(11, 41);
            this.gb_global_params.Name = "gb_global_params";
            this.gb_global_params.Size = new System.Drawing.Size(348, 66);
            this.gb_global_params.TabIndex = 16;
            this.gb_global_params.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.webIconLabel1);
            this.groupBox1.Controls.Add(this.webIconLabel2);
            this.groupBox1.Controls.Add(this.dtp_StartDate);
            this.groupBox1.Controls.Add(this.webIconLabel4);
            this.groupBox1.Controls.Add(this.dtp_EndDate);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(365, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 66);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // Form_analisys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 536);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_global_params);
            this.Controls.Add(this.webButton1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_analisys";
            this.Text = "Динамика изменения показателей";
            this.Load += new System.EventHandler(this.Form_analisys_Load);
            this.Controls.SetChildIndex(this.chart1, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.webButton1, 0);
            this.Controls.SetChildIndex(this.gb_global_params, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.gb_global_params.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private Skin.Controles.WebRadioButton rb_min;
        private Skin.Controles.WebRadioButton rb_max;
        private Skin.Controles.WebRadioButton rb_all;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private Skin.Controles.WebButton webButton1;
        private System.Windows.Forms.ComboBox cb_Patients;
        private Skin.Controles.WebIconLabel webIconLabel3;
        private Skin.Controles.WebIconLabel webIconLabel1;
        private Skin.Controles.WebIconLabel webIconLabel2;
        private Skin.Controles.WebIconLabel webIconLabel4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.GroupBox gb_global_params;
        private System.Windows.Forms.GroupBox groupBox1;



    }
}