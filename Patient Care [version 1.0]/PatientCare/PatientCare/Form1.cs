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
            string result = doctor.ToCheckLoginCredentials(_de);
            if (result.Equals("Unsuccessful"))
            {
                userName.Text = "";
                password.Text = "";
                MessageBox.Show("Pleasy, TRY AGAIN!");
                return;
            }

            MessageBox.Show(result);

            this.Hide();
            ArrivalOfPattient obj = new ArrivalOfPattient(result, _de.doctorUserName);
            obj.Show();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new DoctorRegistration().Show(); //Opening Registration Process
        }
    }
}
