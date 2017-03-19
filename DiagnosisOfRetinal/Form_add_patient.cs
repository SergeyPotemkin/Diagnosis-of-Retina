using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DiagnosisOfRetinal
{
    public partial class Form_add_patient : Skin.Controles.W10Form
    {
        private PatientDAO patientDAO = new PatientDAO();
        private long lastAddPatientId = 0;

        List<Patient> patients;

        public Form_add_patient()
        {
            InitializeComponent();
            update_patients_list();
        }

        public void update_patients_list()
        {
            //patients_id_list = new List<int>();
            patients = patientDAO.get_all_patients();
            cb_Patients.Items.Clear();
            foreach (Patient patient in patients)
            {
                cb_Patients.Items.Add(patient.Surname + " " + patient.Name + " " + patient.Middlename+"( №"+patient.Card_number+" )");
                if (patient.ID == lastAddPatientId)
                    cb_Patients.SelectedIndex = cb_Patients.Items.Count - 1;
            }
        }


        private bool checkRequaredInput()
        {
            if (Validation.isText(tb_surname.Text) &&
                Validation.isText(tb_name.Text) &&
                Validation.isText(tb_middlename.Text) &&
                (Validation.isNumber(tb_phone_patient.Text) || tb_phone_patient.Text == "") &&
                Validation.isNumber(tb_card_patient.Text) )
                return true;
            else return false;
        }

        private void btnSaveEnabled()
        {
            if (checkRequaredInput())
            {
                btn_save_new_employee.Enabled = true;
            }
            else btn_save_new_employee.Enabled = false;
        }

        private void btn_add_new_patient_Click(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(426, 600);
            this.MinimumSize = new System.Drawing.Size(426, 600);
            this.Height = 600;
            btn_add_new_patient.Enabled = false;
            btnSaveEnabled();
        }

        private void btn_cancel_add_new_patient_Click(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(426, 162);
            this.MaximumSize = new System.Drawing.Size(426, 162);
            this.Height = 162;
            btn_add_new_patient.Enabled = true;
        }

        private void tb_name_Leave(object sender, EventArgs e)
        {
            if (Validation.isText(tb_name.Text))
                changeCheck(pictureBox6, pictureBox1);
            else
                changeCheck(pictureBox1, pictureBox6);
        }

        private void tb_middlename_Leave(object sender, EventArgs e)
        {
            if (Validation.isText(tb_middlename.Text))
                changeCheck(pictureBox7, pictureBox2);
            else
                changeCheck(pictureBox2, pictureBox7);
        }

        private void tb_surname_Leave(object sender, EventArgs e)
        {
            if (Validation.isText(tb_surname.Text))
                changeCheck(pictureBox8, pictureBox3);
            else
                changeCheck(pictureBox3, pictureBox8);
        }

        private void tb_card_patient_Leave(object sender, EventArgs e)
        {
            if (Validation.isNumber(tb_card_patient.Text))
                changeCheck(pictureBox14, pictureBox11);
            else
                changeCheck(pictureBox11, pictureBox14);
        }

        private void tb_phone_Leave(object sender, EventArgs e)
        {
            if (Validation.isNumber(tb_phone_patient.Text) || tb_phone_patient.Text == "")
                changeCheck(pictureBox4, pictureBox5);
            else
                changeCheck(pictureBox5, pictureBox4);
        }

        private void changeCheck(PictureBox p1, PictureBox p2) //первый аргумент - символ который отбражать, второй аргемет - котоый скрыть
        {
            p1.Visible = true;
            p2.Visible = false;
            btnSaveEnabled();
        }

        private void Form_add_patient_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(426, 162);
            this.MinimumSize = new System.Drawing.Size(426, 162);
            this.Height = 162;
        }

        private void btn_save_new_employee_Click(object sender, EventArgs e)
        {
            Patient new_patient = new Patient();
            new_patient.Surname = tb_surname.Text;
            new_patient.Name = tb_name.Text;
            new_patient.Middlename = tb_middlename.Text;
            new_patient.Card_number = Convert.ToInt32(tb_card_patient.Text);
            new_patient.Adres = tb_address_patient.Text;
            if (Validation.isNumber(tb_phone_patient.Text))
                new_patient.Phone = Convert.ToDecimal(tb_phone_patient.Text);
            new_patient.Date_of_Birth = dp_date_patient.Value;
            lastAddPatientId = patientDAO.insert(new_patient);
            if (lastAddPatientId != -1)
            {
                MessageBox.Show("Пациент успешно добавлен!");
                update_patients_list();
                resetAddInputs();
                btn_cancel_add_new_patient_Click(sender, e);
            }
            else
                MessageBox.Show("Ошибка добавления!");
        }

        private void resetAddInputs()
        {
            tb_surname.Text = null;
            tb_name.Text = null;
            tb_middlename.Text = null;
            dp_date_patient.Text = null;
            tb_address_patient.Text = null;
            tb_phone_patient.Text = null;
            tb_card_patient.Text = null;

            pictureBox7.Visible = false;
            pictureBox14.Visible = false;
            pictureBox8.Visible = false;
            pictureBox6.Visible = false;
        }

        private void btn_open_patient_Click(object sender, EventArgs e)
        {
            try{
                Session.setSessionItem<Patient>("patient", patients[cb_Patients.SelectedIndex]);
                Session.removeSessionItem("survey");
                this.Close();
            }catch(Exception){
                MessageBox.Show("Данного пациента не обнаружено в базе");
            }
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
    }
}
