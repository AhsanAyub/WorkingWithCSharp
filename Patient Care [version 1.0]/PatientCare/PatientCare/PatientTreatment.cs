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
    public partial class PatientTreatment : Form
    {
        private PrescriptionEntity NewPrescription = new PrescriptionEntity();
        private PrescriptionData presData = new PrescriptionData();

        private string dName = "", pName = "", dUserName = "";
        private int pID;

        public PatientTreatment(string DoctorName, string DoctorUserName, string PatientName, int PatientID)
        {
            InitializeComponent();
            
            dName = DoctorName;
            dUserName = DoctorUserName;
            pName = PatientName;
            pID = PatientID;

            setDoctorName.Text = dName;
            setPatientName.Text = pName;

            textBoxExt1.Text = DateTime.Now.ToString("yyyy-M-d");


            initNewPrescription();
        }

        private void initNewPrescription()
        {
            NewPrescription.prescriptionID = DateTime.Now.ToString("yyyyMMddHHmmss");
            NewPrescription.DoctorToPrescribe = dUserName;
            NewPrescription.PrescribedPatient = pID;
            NewPrescription.prescriptionDate = textBoxExt1.Text;

            if (presData.newPrescription(NewPrescription))
            {
                MessageBox.Show("New Prescription is saved!");
            }
            else
                MessageBox.Show("ERROR, no prescription is saved!");
        }

        private void PatientTreatment_Load(object sender, EventArgs e)
        {

        }

        private void prescribingMedicine_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            MedicineToPrescribe _MTP = new MedicineToPrescribe(NewPrescription.prescriptionID);

            _MTP.MdiParent = this;
            _MTP.Show();

        }

        private void viewHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            SearchingPatientTreatment _SPT = new SearchingPatientTreatment(pName, pID);

            _SPT.MdiParent = this;
            _SPT.Show();
        }

        private void medicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            MedicineToPrescribe _MTP = new MedicineToPrescribe(NewPrescription.prescriptionID);

            _MTP.MdiParent = this;
            _MTP.Show();
        }

        private void diagonisticTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            TestsToPrescribe _TTP = new TestsToPrescribe(NewPrescription.prescriptionID);

            _TTP.MdiParent = this;
            _TTP.Show();
        }

        private void prescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            ShowPrescription _SP = new ShowPrescription(NewPrescription.prescriptionID);

            _SP.MdiParent = this;
            _SP.Show();
        }

        private void arrangeFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}