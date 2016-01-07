using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataLayer;
using Entities;

namespace PatientCare
{
    public partial class Form1 : Form
    {

        private DoctorData doctor = new DoctorData();
        private DoctorEntity _de = new DoctorEntity();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _de.doctorUserName = userName.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _de.doctorPassword = password.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var d = doctor.ToCheckLoginCredentials(_de);


            if (d == null)
            {
                MessageBox.Show("Pleasy, TRY AGAIN!");
                return;
            }

            else
            {
                userName.Text = "";
                password.Text = "";

                _de.doctorUserName = d.Rows[0][0].ToString();
                _de.doctorPassword = d.Rows[0][1].ToString();
                _de.doctorName = d.Rows[0][2].ToString();
                _de.doctorSpeciality = d.Rows[0][3].ToString();

                MainMDIForm obj = new MainMDIForm(_de);
                obj.Show();

                this.Hide();
            }

        }
            
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new DoctorRegistration().Show(); //Opening Registration Process

            this.Hide();

        }
    }
}
