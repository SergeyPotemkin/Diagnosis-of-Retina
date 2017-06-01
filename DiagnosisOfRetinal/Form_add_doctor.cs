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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagnosisOfRetinal
{
    public partial class Form_add_doctor : Skin.Controles.W10Form
    {
        private DoctorDAO docDAO = new DoctorDAO();
        private long lastAddDoctorId = 0;

        List<Doctor> doctors;

        public Form_add_doctor()
        {
            InitializeComponent();
            update_doctors_list();
        }

        public void update_doctors_list()
        {
            this.doctors = docDAO.get_all_doctors();
            cb_Doctors.Items.Clear();
            foreach (Doctor doctor in doctors)
            {
                cb_Doctors.Items.Add(doctor.Surname + " " + doctor.Name + " " + doctor.Middlename);
                if(doctor.ID == lastAddDoctorId)
                    cb_Doctors.SelectedIndex = cb_Doctors.Items.Count - 1;
            }
        }

        private void Form_search_doctor_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(375, 162);
            this.MinimumSize = new System.Drawing.Size(375, 162);
            this.Height = 162;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(375, 500);
            this.MinimumSize = new System.Drawing.Size(375, 500);
            this.Height = 500;
            btn_add_new_employee.Enabled = false;
            btnSaveEnabled();
        }

        private void webIconLabel1_Click(object sender, EventArgs e)
        {

        }

        private void webIconLabel2_Click(object sender, EventArgs e)
        {

        }


        private void btn_cancel_add_new_employee_Click(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(375, 162);
            this.MaximumSize = new System.Drawing.Size(375, 162);
            this.Height = 162;
            btn_add_new_employee.Enabled = true;
        }

        private void tb_middlename_Leave_1(object sender, EventArgs e)
        {
            if (Validation.isText(tb_middlename.Text))
                changeCheck(pictureBox7, pictureBox2);
            else
                changeCheck(pictureBox2, pictureBox7);
        }

        private void tb_name_Leave_1(object sender, EventArgs e)
        {
            if (Validation.isText(tb_name.Text))
                changeCheck(pictureBox6, pictureBox1);
            else
                changeCheck(pictureBox1, pictureBox6);
        }

        private void tb_surname_Leave(object sender, EventArgs e)
        {
            if (Validation.isText(tb_surname.Text))
                changeCheck(pictureBox8, pictureBox3);
            else
                changeCheck(pictureBox3, pictureBox8);
        }

        private bool checkRequaredInput()
        {
            if (Validation.isText(tb_surname.Text) &&
                Validation.isText(tb_name.Text) &&
                Validation.isText(tb_middlename.Text))
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

        private void resetAddInputs()
        {
            tb_surname.Text = null;
            tb_name.Text = null;
            tb_middlename.Text = null;
            cb_position.Text = null;
            cb_rang.Text = null;

            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;

        }

        private void btn_save_new_employee_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.Surname = tb_surname.Text;
            doctor.Name = tb_name.Text;
            doctor.Middlename = tb_middlename.Text;
            doctor.Position = cb_position.Text;
            doctor.Rank = cb_rang.Text;
            lastAddDoctorId = docDAO.insert(doctor);
            if (lastAddDoctorId != -1)
            {
                MessageBox.Show("Сотрудник успешно добавлен!");
                update_doctors_list();
                resetAddInputs();
                btn_cancel_add_new_employee_Click(sender,e);
            }
            else
                MessageBox.Show("Ошибка добавления!");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Session.setSessionItem<Doctor>("doctor", doctors[cb_Doctors.SelectedIndex]);
                this.Hide();
                new Form_main(this).Show();
            }catch(Exception){
                MessageBox.Show("Данного сотрудника не обнаружено в базе");
            }
        }

        private void changeCheck(PictureBox p1, PictureBox p2) //первый аргумент - символ который отбражать, второй аргемет - котоый скрыть
        {
            p1.Visible = true;
            p2.Visible = false;
            btnSaveEnabled();
        }
    }
}
