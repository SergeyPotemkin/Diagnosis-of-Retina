namespace DiagnosisOfRetinal
{
    partial class Form_add_doctor
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_add_doctor));
            this.btnLogin = new Skin.Controles.WebButton();
            this.btn_add_new_employee = new Skin.Controles.WebButton();
            this.cb_Doctors = new System.Windows.Forms.ComboBox();
            this.lbl_add_new_employee = new Skin.Controles.WebIconLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_surname = new Skin.Controles.WebTexBoxSingle();
            this.tb_middlename = new Skin.Controles.WebTexBoxSingle();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb_rang = new System.Windows.Forms.ComboBox();
            this.cb_position = new System.Windows.Forms.ComboBox();
            this.btn_cancel_add_new_employee = new Skin.Controles.WebButton();
            this.btn_save_new_employee = new Skin.Controles.WebButton();
            this.webIconLabel6 = new Skin.Controles.WebIconLabel();
            this.webIconLabel5 = new Skin.Controles.WebIconLabel();
            this.webIconLabel4 = new Skin.Controles.WebIconLabel();
            this.webIconLabel2 = new Skin.Controles.WebIconLabel();
            this.tb_name = new Skin.Controles.WebTexBoxSingle();
            this.webIconLabel3 = new Skin.Controles.WebIconLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = Skin.Colores.Natural.Azul;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Depth = 0;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(303, 62);
            this.btnLogin.MouseLocation = new System.Drawing.Point(0, 0);
            this.btnLogin.MouseState = Skin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(60, 40);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Вход";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btn_add_new_employee
            // 
            this.btn_add_new_employee.BackColor = Skin.Colores.Natural.Azul;
            this.btn_add_new_employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_new_employee.Depth = 0;
            this.btn_add_new_employee.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_add_new_employee.ForeColor = System.Drawing.Color.White;
            this.btn_add_new_employee.IconShow = true;
            this.btn_add_new_employee.IconType = Skin.IconType.user_plus;
            this.btn_add_new_employee.Location = new System.Drawing.Point(11, 108);
            this.btn_add_new_employee.MouseLocation = new System.Drawing.Point(0, 0);
            this.btn_add_new_employee.MouseState = Skin.MouseState.HOVER;
            this.btn_add_new_employee.Name = "btn_add_new_employee";
            this.btn_add_new_employee.Size = new System.Drawing.Size(352, 44);
            this.btn_add_new_employee.TabIndex = 0;
            this.btn_add_new_employee.Text = "Добавить нового сотрудника";
            this.btn_add_new_employee.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_Doctors
            // 
            this.cb_Doctors.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Doctors.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Doctors.BackColor = System.Drawing.SystemColors.Window;
            this.cb_Doctors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Doctors.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cb_Doctors.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cb_Doctors.FormattingEnabled = true;
            this.cb_Doctors.Location = new System.Drawing.Point(11, 67);
            this.cb_Doctors.Name = "cb_Doctors";
            this.cb_Doctors.Size = new System.Drawing.Size(286, 29);
            this.cb_Doctors.TabIndex = 0;
            // 
            // lbl_add_new_employee
            // 
            this.lbl_add_new_employee.Depth = 0;
            this.lbl_add_new_employee.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lbl_add_new_employee.ForeColor = System.Drawing.Color.Teal;
            this.lbl_add_new_employee.IconColor = Skin.Colores.Natural.Azul;
            this.lbl_add_new_employee.IconSize = 25;
            this.lbl_add_new_employee.IconType = Skin.IconType.male;
            this.lbl_add_new_employee.Location = new System.Drawing.Point(6, 36);
            this.lbl_add_new_employee.MouseLocation = new System.Drawing.Point(0, 0);
            this.lbl_add_new_employee.MouseState = Skin.MouseState.HOVER;
            this.lbl_add_new_employee.Name = "lbl_add_new_employee";
            this.lbl_add_new_employee.Size = new System.Drawing.Size(237, 29);
            this.lbl_add_new_employee.TabIndex = 8;
            this.lbl_add_new_employee.Text = "Выберите сотрудника:";
            this.lbl_add_new_employee.Click += new System.EventHandler(this.webIconLabel1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_surname);
            this.groupBox1.Controls.Add(this.tb_middlename);
            this.groupBox1.Controls.Add(this.pictureBox8);
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.cb_rang);
            this.groupBox1.Controls.Add(this.cb_position);
            this.groupBox1.Controls.Add(this.btn_cancel_add_new_employee);
            this.groupBox1.Controls.Add(this.btn_save_new_employee);
            this.groupBox1.Controls.Add(this.webIconLabel6);
            this.groupBox1.Controls.Add(this.webIconLabel5);
            this.groupBox1.Controls.Add(this.webIconLabel4);
            this.groupBox1.Controls.Add(this.webIconLabel2);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.webIconLabel3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(12, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 330);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о новом сотруднике:";
            // 
            // tb_surname
            // 
            this.tb_surname.Depth = 0;
            this.tb_surname.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tb_surname.LineFocus = Skin.Colores.Natural.A700azul;
            this.tb_surname.Location = new System.Drawing.Point(149, 141);
            this.tb_surname.MouseState = Skin.MouseState.HOVER;
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.PasswordChar = '\0';
            this.tb_surname.PlaceHolder = "";
            this.tb_surname.Size = new System.Drawing.Size(172, 30);
            this.tb_surname.TabIndex = 3;
            this.tb_surname.TabStop = false;
            this.tb_surname.Tema = true;
            this.tb_surname.Leave += new System.EventHandler(this.tb_surname_Leave);
            // 
            // tb_middlename
            // 
            this.tb_middlename.Depth = 0;
            this.tb_middlename.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tb_middlename.LineFocus = Skin.Colores.Natural.A700azul;
            this.tb_middlename.Location = new System.Drawing.Point(149, 96);
            this.tb_middlename.MouseState = Skin.MouseState.HOVER;
            this.tb_middlename.Name = "tb_middlename";
            this.tb_middlename.PasswordChar = '\0';
            this.tb_middlename.PlaceHolder = "";
            this.tb_middlename.Size = new System.Drawing.Size(172, 30);
            this.tb_middlename.TabIndex = 2;
            this.tb_middlename.TabStop = false;
            this.tb_middlename.Tema = true;
            this.tb_middlename.Leave += new System.EventHandler(this.tb_middlename_Leave_1);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.InitialImage")));
            this.pictureBox8.Location = new System.Drawing.Point(325, 145);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(20, 18);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 29;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.InitialImage")));
            this.pictureBox7.Location = new System.Drawing.Point(325, 100);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 18);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 28;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.InitialImage")));
            this.pictureBox6.Location = new System.Drawing.Point(325, 51);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 18);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 27;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(325, 145);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(325, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(325, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // cb_rang
            // 
            this.cb_rang.BackColor = System.Drawing.SystemColors.Window;
            this.cb_rang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_rang.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cb_rang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cb_rang.FormattingEnabled = true;
            this.cb_rang.Items.AddRange(new object[] {
            "Доктор",
            "Ассистент"});
            this.cb_rang.Location = new System.Drawing.Point(149, 237);
            this.cb_rang.Name = "cb_rang";
            this.cb_rang.Size = new System.Drawing.Size(174, 29);
            this.cb_rang.TabIndex = 5;
            // 
            // cb_position
            // 
            this.cb_position.BackColor = System.Drawing.SystemColors.Window;
            this.cb_position.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_position.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cb_position.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cb_position.FormattingEnabled = true;
            this.cb_position.Items.AddRange(new object[] {
            "Врач",
            "Мед.сестра"});
            this.cb_position.Location = new System.Drawing.Point(151, 189);
            this.cb_position.Name = "cb_position";
            this.cb_position.Size = new System.Drawing.Size(172, 29);
            this.cb_position.TabIndex = 4;
            // 
            // btn_cancel_add_new_employee
            // 
            this.btn_cancel_add_new_employee.BackColor = Skin.Colores.Natural.Azul;
            this.btn_cancel_add_new_employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel_add_new_employee.Depth = 0;
            this.btn_cancel_add_new_employee.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_cancel_add_new_employee.ForeColor = System.Drawing.Color.White;
            this.btn_cancel_add_new_employee.Location = new System.Drawing.Point(6, 275);
            this.btn_cancel_add_new_employee.MouseLocation = new System.Drawing.Point(0, 0);
            this.btn_cancel_add_new_employee.MouseState = Skin.MouseState.HOVER;
            this.btn_cancel_add_new_employee.Name = "btn_cancel_add_new_employee";
            this.btn_cancel_add_new_employee.Size = new System.Drawing.Size(161, 44);
            this.btn_cancel_add_new_employee.TabIndex = 6;
            this.btn_cancel_add_new_employee.Text = "Отмена";
            this.btn_cancel_add_new_employee.Click += new System.EventHandler(this.btn_cancel_add_new_employee_Click);
            // 
            // btn_save_new_employee
            // 
            this.btn_save_new_employee.BackColor = Skin.Colores.Natural.Azul;
            this.btn_save_new_employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_new_employee.Depth = 0;
            this.btn_save_new_employee.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_save_new_employee.ForeColor = System.Drawing.Color.White;
            this.btn_save_new_employee.Location = new System.Drawing.Point(173, 275);
            this.btn_save_new_employee.MouseLocation = new System.Drawing.Point(0, 0);
            this.btn_save_new_employee.MouseState = Skin.MouseState.HOVER;
            this.btn_save_new_employee.Name = "btn_save_new_employee";
            this.btn_save_new_employee.Size = new System.Drawing.Size(161, 44);
            this.btn_save_new_employee.TabIndex = 7;
            this.btn_save_new_employee.Text = "Сохранить";
            this.btn_save_new_employee.Click += new System.EventHandler(this.btn_save_new_employee_Click);
            // 
            // webIconLabel6
            // 
            this.webIconLabel6.Depth = 0;
            this.webIconLabel6.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.webIconLabel6.ForeColor = System.Drawing.Color.Teal;
            this.webIconLabel6.IconColor = Skin.Colores.Natural.Azul;
            this.webIconLabel6.IconSize = 27;
            this.webIconLabel6.IconType = Skin.IconType.arrow_circle_o_right;
            this.webIconLabel6.Location = new System.Drawing.Point(6, 239);
            this.webIconLabel6.MouseLocation = new System.Drawing.Point(0, 0);
            this.webIconLabel6.MouseState = Skin.MouseState.HOVER;
            this.webIconLabel6.Name = "webIconLabel6";
            this.webIconLabel6.Size = new System.Drawing.Size(150, 27);
            this.webIconLabel6.TabIndex = 19;
            this.webIconLabel6.Text = "Звание:";
            // 
            // webIconLabel5
            // 
            this.webIconLabel5.Depth = 0;
            this.webIconLabel5.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.webIconLabel5.ForeColor = System.Drawing.Color.Teal;
            this.webIconLabel5.IconColor = Skin.Colores.Natural.Azul;
            this.webIconLabel5.IconSize = 27;
            this.webIconLabel5.IconType = Skin.IconType.arrow_circle_o_right;
            this.webIconLabel5.Location = new System.Drawing.Point(6, 191);
            this.webIconLabel5.MouseLocation = new System.Drawing.Point(0, 0);
            this.webIconLabel5.MouseState = Skin.MouseState.HOVER;
            this.webIconLabel5.Name = "webIconLabel5";
            this.webIconLabel5.Size = new System.Drawing.Size(150, 27);
            this.webIconLabel5.TabIndex = 17;
            this.webIconLabel5.Text = "Должность:";
            // 
            // webIconLabel4
            // 
            this.webIconLabel4.Depth = 0;
            this.webIconLabel4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.webIconLabel4.ForeColor = System.Drawing.Color.Teal;
            this.webIconLabel4.IconColor = Skin.Colores.Natural.Azul;
            this.webIconLabel4.IconSize = 27;
            this.webIconLabel4.IconType = Skin.IconType.arrow_circle_o_right;
            this.webIconLabel4.Location = new System.Drawing.Point(6, 143);
            this.webIconLabel4.MouseLocation = new System.Drawing.Point(0, 0);
            this.webIconLabel4.MouseState = Skin.MouseState.HOVER;
            this.webIconLabel4.Name = "webIconLabel4";
            this.webIconLabel4.Size = new System.Drawing.Size(150, 27);
            this.webIconLabel4.TabIndex = 16;
            this.webIconLabel4.Text = "Фамилия:";
            // 
            // webIconLabel2
            // 
            this.webIconLabel2.Depth = 0;
            this.webIconLabel2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.webIconLabel2.ForeColor = System.Drawing.Color.Teal;
            this.webIconLabel2.IconColor = Skin.Colores.Natural.Azul;
            this.webIconLabel2.IconSize = 27;
            this.webIconLabel2.IconType = Skin.IconType.arrow_circle_o_right;
            this.webIconLabel2.Location = new System.Drawing.Point(6, 96);
            this.webIconLabel2.MouseLocation = new System.Drawing.Point(0, 0);
            this.webIconLabel2.MouseState = Skin.MouseState.HOVER;
            this.webIconLabel2.Name = "webIconLabel2";
            this.webIconLabel2.Size = new System.Drawing.Size(150, 27);
            this.webIconLabel2.TabIndex = 15;
            this.webIconLabel2.Text = "Отчество:";
            // 
            // tb_name
            // 
            this.tb_name.Depth = 0;
            this.tb_name.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tb_name.LineFocus = Skin.Colores.Natural.A700azul;
            this.tb_name.Location = new System.Drawing.Point(149, 47);
            this.tb_name.MouseState = Skin.MouseState.HOVER;
            this.tb_name.Name = "tb_name";
            this.tb_name.PasswordChar = '\0';
            this.tb_name.PlaceHolder = "";
            this.tb_name.Size = new System.Drawing.Size(172, 30);
            this.tb_name.TabIndex = 1;
            this.tb_name.TabStop = false;
            this.tb_name.Tema = true;
            this.tb_name.Leave += new System.EventHandler(this.tb_name_Leave_1);
            // 
            // webIconLabel3
            // 
            this.webIconLabel3.Depth = 0;
            this.webIconLabel3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.webIconLabel3.ForeColor = System.Drawing.Color.Teal;
            this.webIconLabel3.IconColor = Skin.Colores.Natural.Azul;
            this.webIconLabel3.IconSize = 27;
            this.webIconLabel3.IconType = Skin.IconType.arrow_circle_o_right;
            this.webIconLabel3.Location = new System.Drawing.Point(6, 47);
            this.webIconLabel3.MouseLocation = new System.Drawing.Point(0, 0);
            this.webIconLabel3.MouseState = Skin.MouseState.HOVER;
            this.webIconLabel3.Name = "webIconLabel3";
            this.webIconLabel3.Size = new System.Drawing.Size(150, 27);
            this.webIconLabel3.TabIndex = 10;
            this.webIconLabel3.Text = "Имя:";
            // 
            // Form_add_doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_add_new_employee);
            this.Controls.Add(this.cb_Doctors);
            this.Controls.Add(this.btn_add_new_employee);
            this.Controls.Add(this.btnLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(375, 500);
            this.MinimumSize = new System.Drawing.Size(375, 500);
            this.Name = "Form_add_doctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор сотрудника";
            this.Load += new System.EventHandler(this.Form_search_doctor_Load);
            this.Controls.SetChildIndex(this.btnLogin, 0);
            this.Controls.SetChildIndex(this.btn_add_new_employee, 0);
            this.Controls.SetChildIndex(this.cb_Doctors, 0);
            this.Controls.SetChildIndex(this.lbl_add_new_employee, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Skin.Controles.WebButton btnLogin;
        private Skin.Controles.WebButton btn_add_new_employee;
        private System.Windows.Forms.ComboBox cb_Doctors;
        private Skin.Controles.WebIconLabel lbl_add_new_employee;
        private System.Windows.Forms.GroupBox groupBox1;
        private Skin.Controles.WebIconLabel webIconLabel5;
        private Skin.Controles.WebIconLabel webIconLabel4;
        private Skin.Controles.WebIconLabel webIconLabel2;
        private Skin.Controles.WebTexBoxSingle tb_name;
        private Skin.Controles.WebIconLabel webIconLabel3;
        private Skin.Controles.WebButton btn_cancel_add_new_employee;
        private Skin.Controles.WebButton btn_save_new_employee;
        private Skin.Controles.WebIconLabel webIconLabel6;
        private System.Windows.Forms.ComboBox cb_rang;
        private System.Windows.Forms.ComboBox cb_position;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private Skin.Controles.WebTexBoxSingle tb_surname;
        private Skin.Controles.WebTexBoxSingle tb_middlename;
    }
}

