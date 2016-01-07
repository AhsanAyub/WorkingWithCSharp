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
        private PatientEntity _pe = new PatientEntity();
        private PatientData _pd = new PatientData();
        private DoctorEntity doctor = new DoctorEntity();
        
        private string dName = "", dUserName = "";
        
        private bool completeStatus = false;

        public NewPatientEntry(DoctorEntity _de)
        {
            InitializeComponent();
            doctor = _de;
        }

        private void initPatientEntity()
        {
            _pe.patiendID = Convert.ToInt32(getPatientID.Text);
            _pe.patientName = getFullName.Text;
            _pe.patientAge = Convert.ToInt32(getAge.Text);
            _pe.patientGender = getGender.Text;
            _pe.patientAddress = getAddress.Text;
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
            try
            {
                patient.patiendID = Convert.ToInt32(getPatientID.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void getAge_TextChanged(object sender, EventArgs e)
        {
            try
            {
                patient.patientAge = Convert.ToInt32(getAge.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

                initPatientEntity();
                
                MdiParent.Close();

                MainMDIForm obj = new MainMDIForm(doctor);
                obj.getPatient(_pe);
                obj.Show();
                
                this.Hide();
            }
            else
            {
                MessageBox.Show("Unseccessful Attempt!");
                getAddress.Text = "";
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

            this.Close();
        }
    }
}