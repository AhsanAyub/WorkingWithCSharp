using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using DataLayer;

namespace PatientCare
{
    public partial class NewPatientEntry : Form
    {
        private PatientEntity patient = new PatientEntity();
        private PatientData _pd = new PatientData();
        private string dName = "", dUserName = "";
        
        private bool completeStatus = false;

        public NewPatientEntry(string DoctorName, string DoctorUserName)
        {
            InitializeComponent();
            dName = DoctorName;
            dUserName = DoctorUserName;
        }

        private void NewPatientEntry_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void getFullName_TextChanged(object sender, EventArgs e)
        {
            patient.patientName = getFullName.Text;
        }

        private void getPatientID_TextChanged(object sender, EventArgs e)
        {
            patient.patiendID = Convert.ToInt32(getPatientID.Text);
        }

        private void getAge_TextChanged(object sender, EventArgs e)
        {
            patient.patientAge = Convert.ToInt32(getAge.Text);
        }

        private void getGender_TextChanged(object sender, EventArgs e)
        {
            patient.patientGender = getGender.Text;
        }

        private void getAddress_TextChanged(object sender, EventArgs e)
        {
            patient.patientAddress = getAddress.Text;
        }

        private void doneProcess_Click(object sender, EventArgs e)
        {
            if (_pd.insertRow(patient))
            {
                MessageBox.Show("Information Saved!");
                completeStatus = true;
                
                getAddress.Text = "";
                getPatientID.Text = "";
                getAge.Text = "";
                getFullName.Text = "";
                getGender.Text = "";

                new PatientTreatment(dName, dUserName, patient.patientName, patient.patiendID).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Unseccessful Attempt!");
                getAddress.Text = "";
                getPatientID.Text = "";
                getAge.Text = "";
                getFullName.Text = "";
                getGender.Text = "";
                return;
            }
        }

        private void exitProcess_Click(object sender, EventArgs e)
        {
            if(completeStatus)
                MessageBox.Show("Exiting by saving information");
            else
                MessageBox.Show("Aborting the process");

            new ArrivalOfPattient(dName, dUserName).Show();
            this.Close();
        }
    }
}