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
using Framework;

namespace PatientCare
{
    public partial class MainMDIForm : Form
    {
        private PrescriptionEntity _pe = new PrescriptionEntity();
        private DoctorEntity _de = new DoctorEntity();
        private PatientEntity patient = new PatientEntity();
        private PrescriptionData presData = new PrescriptionData();

        private string PatientName = "", PatientGender = "", PatientAddress = "";
        private int PatientID, PatientAge;
        
        public void getPatient(PatientEntity _pe)
        { 
            patient = _pe;
            initPatientEntity();
            PatientID = _pe.patiendID;
            PatientAge = _pe.patientAge;
            PatientName = _pe.patientName;
            PatientGender = _pe.patientGender;
            PatientAddress = _pe.patientAddress;
        }
        private void initPatientEntity()
        {
            setPatientID.Text = patient.patiendID.ToString();
            setPatientName.Text = patient.patientName;
            setPatientAge.Text = patient.patientAge.ToString();
            setPatientGender.Text = patient.patientGender;
            setPatientAddress.Text = patient.patientAddress;

            _pe.prescriptionID = DateTime.Now.ToString("yyyyMMddHHmmss");
            _pe.prescriptionDate = DateTime.Now.ToString("yyyy-M-d");
            _pe.DoctorToPrescribe = _de.doctorUserName;
            _pe.PrescribedPatient = patient.patiendID;

            if (presData.newPrescription(_pe))
            {
                MessageBox.Show("New Prescription is saved!");
            }
            else
                MessageBox.Show("ERROR, no prescription is saved!");
        }
        private void initDoctorEntity()
        {
            setDoctorUserName.Text = _de.doctorUserName;
            setDoctorName.Text = _de.doctorName;
            setDoctorSpeciality.Text = _de.doctorSpeciality;
        }

        public MainMDIForm(DoctorEntity doctor)
        {
            InitializeComponent();

            _de = doctor;
            initDoctorEntity();
        }

        private void LoadMedicinesForm(string key)
        {
            this.IsMdiContainer = true;

            MedicineToPrescribe _MTP = new MedicineToPrescribe(key, _pe.prescriptionID);

            _MTP.MdiParent = this;
            _MTP.Show();
        }

        private void LoadTestsForm(string key)
        {
            this.IsMdiContainer = true;

            TestsToPrescribe TTP_RnI = new TestsToPrescribe(key, _pe.prescriptionID);

            TTP_RnI.MdiParent = this;
            TTP_RnI.Show();
        }

        private void antiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadMedicinesForm("Antimicrobial");
        }

        private void cardiovascularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadMedicinesForm("Cardiovascular");
        }

        private void gastrointestinalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadMedicinesForm("Gastrointestinal");
        }

        private void respiratorySystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadMedicinesForm("RespiratorySystem");
        }

        private void MainMDIForm_Load(object sender, EventArgs e)
        {

        }

        private void newPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            NewPatientEntry NPN = new NewPatientEntry(_de);

            NPN.MdiParent = this;
            NPN.Show();
        }


        private void oldPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            OldPatientEntry OPN = new OldPatientEntry(_de);

            OPN.MdiParent = this;
            OPN.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            SearchingPatientTreatment SPT = new SearchingPatientTreatment(patient);

            SPT.MdiParent = this;
            SPT.Show();
        }

        private void prescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            ShowPrescription SP = new ShowPrescription(_pe.prescriptionID);

            SP.MdiParent = this;
            SP.Show();
        }

        private void removeDrugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            ShowPrescription SPtoRemoveDrug = new ShowPrescription(_pe.prescriptionID);

            SPtoRemoveDrug.MdiParent = this;
            SPtoRemoveDrug.Show();
        }

        private void addTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void radiologicalAndImagingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoadTestsForm("RadiologicalAndImaging");
        }

        private void laboratoryServicesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoadTestsForm("LaboratoryServices");
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Signing out & closing the applicaiton");
            System.Windows.Forms.Application.Exit();
        }

        private void removeTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            ShowPrescription SPtoRemoveTest = new ShowPrescription(_pe.prescriptionID);

            SPtoRemoveTest.MdiParent = this;
            SPtoRemoveTest.Show();
        }
    }
}