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
        private int patientID;
        private string patientName = "", selectedDate = "", presID = "";
        private PrescriptionEntity oldPres = new PrescriptionEntity();
        private PrescriptionData oldPresData = new PrescriptionData();


        public SearchingPatientTreatment(string pName, int pID)
        {
            InitializeComponent();

            patientName = pName;
            patientID = pID;
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
                
                int rowIndex = dataGridView1.CurrentCell.RowIndex; //.Value.ToString().Remove(9);
                
                selectedDate = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString().Remove(9);
                SelectedPrescribedDate.Text = selectedDate;

                PrescribedDoctor.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            }
            /*if (dataGridView1.CurrentCell.ColumnIndex.Equals(1) && e.RowIndex != -1)
            {
                selectedDate = dataGridView1.CurrentCell.Value.ToString();
                SelectedPrescribedDate.Text = selectedDate.Remove(9);
            }
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(2) && e.RowIndex != -1)
            {
                PrescribedDoctor.Text = dataGridView1.CurrentCell.Value.ToString();
            }*/
        }
    }
}
