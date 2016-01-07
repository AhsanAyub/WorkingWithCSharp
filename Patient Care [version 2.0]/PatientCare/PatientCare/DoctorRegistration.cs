using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using Entities;

namespace PatientCare
{
    public partial class DoctorRegistration : Form
    {
        private DoctorData dd = new DoctorData();
        private DoctorEntity de = new DoctorEntity();
        private DoctorEntity _de = new DoctorEntity();

        public DoctorRegistration()
        {
            InitializeComponent();
        }

        private void initDoctorEntity()
        {
            _de.doctorUserName = dUserName.Text;
            _de.doctorName = dName.Text;
            _de.doctorPassword = dPassword.Text;
            _de.doctorSpeciality = dSpeciality.Text;
        }

        private void dName_TextChanged(object sender, EventArgs e)
        {
            if (dName.Text != null)
                de.doctorName = dName.Text;
        }

        private void dUserName_TextChanged(object sender, EventArgs e)
        {
            if (dUserName.Text != null)
                de.doctorUserName = dUserName.Text;
        }

        private void dPassword_TextChanged(object sender, EventArgs e)
        {
            if (dPassword.Text != null)
                de.doctorPassword = dPassword.Text;
        }

        private void dSpeciality_TextChanged(object sender, EventArgs e)
        {
            if (dSpeciality.Text != null)
                de.doctorSpeciality = dSpeciality.Text;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (dd.insertRow(de))
            {
                MessageBox.Show("Information Saved!");
                initDoctorEntity();
                dName.Text = "";
                dUserName.Text = "";
                dPassword.Text = "";
                dSpeciality.Text = "";

                MainMDIForm obj = new MainMDIForm(_de);
                obj.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Unsuccessful attempt - TRY AGAIN!");
                return;
            }
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            new Form1().Show();

            this.Close();
        }

        private void DoctorRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
