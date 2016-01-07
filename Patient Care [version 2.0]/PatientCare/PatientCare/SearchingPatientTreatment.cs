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
    public partial class SearchingPatientTreatment : Form
    {
        private PrescriptionEntity oldPres = new PrescriptionEntity();
        private PrescriptionData oldPresData = new PrescriptionData();
        
        private int patientID;
        private string patientName = "", selectedDate = "", presID = "";

        public SearchingPatientTreatment(PatientEntity _pe)
        {
            InitializeComponent();

            patientName = _pe.patientName;
            patientID = _pe.patiendID;
            setDate.Text = DateTime.Now.ToString("yyyy-M-d");
            setPatientName.Text = patientName;

            fillCombobox();
        }

        private void fillCombobox()
        { 
            oldPres.PrescribedPatient = patientID;

            dataGridView1.DataSource = oldPresData.FillingDataOnPatientTreatment(oldPres, setDate.Text);
        }
        
        private void SearchingPatientTreatment_Load(object sender, EventArgs e)
        {

        }

        private void ShowPrescription_Click(object sender, EventArgs e)
        {
            medicinePrescription.DataSource = oldPresData.generateMedicinePrescription(presID);
            testPrescription.DataSource = oldPresData.generateTestPrescription(presID);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                presID = dataGridView1.CurrentCell.Value.ToString();
                
                int rowIndex = dataGridView1.CurrentCell.RowIndex;

                selectedDate = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString().Remove(9);
                SelectedPrescribedDate.Text = selectedDate;

                PrescribedDoctor.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            }
        }

        private void SelectedPrescribedDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
