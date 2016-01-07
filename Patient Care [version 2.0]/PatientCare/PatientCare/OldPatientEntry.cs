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
    public partial class OldPatientEntry : Form
    {
        private PatientData _pd = new PatientData();
        private PatientEntity patient = new PatientEntity();
        private DoctorEntity doctor = new DoctorEntity();

        private bool isPatientSelect = false;
        
        private string dName = "", dUserName = "";

        public OldPatientEntry(DoctorEntity _de)
        {
            InitializeComponent();
            doctor = _de;    
        }

        private void getPName_TextChanged(object sender, EventArgs e)
        {
            patient.patientName = getPName.Text;
        }

        private void getPatientID_TextChanged(object sender, EventArgs e)
        {
            patient.patiendID = Int32.Parse(getPatientID.Text);
        }

        private void searchDirectoryOfPatient_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _pd.SearchPatient(getPName.Text);
        }

        private void goTreatment_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            PatientEntity pe = dataGridView1.SelectedRows[0].DataBoundItem as PatientEntity;
            MessageBox.Show(pe.patientName + " is selected!");

            MdiParent.Close();

            MainMDIForm obj = new MainMDIForm(doctor);
            obj.getPatient(pe);
            obj.Show();

            this.Hide();
        }

        private void abortOperation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OldPatientEntry_Load(object sender, EventArgs e)
        {

        }

    }
}
