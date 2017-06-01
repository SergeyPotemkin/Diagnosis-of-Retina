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
    public partial class Form_progressBar : Form
    {
        public Form_progressBar()
        {
            InitializeComponent();

            label2.Visible = true;
            label1.Visible = true;
            label1.Text = "1";
            label8.Text = "Обработано кадров видео:";

            timer1.Start();
        }

        private void Form_progressBar_Load(object sender, EventArgs e)
        {
            label2.Visible = true;
            label1.Visible = true;
            label1.Text = "1";
            label8.Text = "Обработано кадров видео:";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Text == "20")
            {
                if (label8.Text == "Подготовка результатов.") label8.Text = "Подготовка результатов..";
                else if (label8.Text == "Подготовка результатов..") label8.Text = "Подготовка результатов...";
                else if (label8.Text == "Подготовка результатов...") label8.Text = "Подготовка результатов.";
            }
            else if (label1.Text == "19")
            {
                label2.Visible = false;
                label1.Visible = false;
                label8.Text = "Подготовка результатов...";
                progressBar1.Visible = false;
                label1.Text = (Convert.ToInt32(label1.Text) + 1).ToString();
            }
            else
            {
                Random rand = new Random();
                int randNum = rand.Next(1,6);
                timer1.Interval = randNum*1000;
                progressBar1.Visible = true;
                progressBar1.Value = 0;
                label1.Text = (Convert.ToInt32(label1.Text) + 1).ToString();
                for (int k = 1; k < randNum;k++ )
                {
                    progressBar1.Increment(+(100/k));
                }
            }

            if (Session.isHaveSession("survey"))
            {
                this.Close();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
