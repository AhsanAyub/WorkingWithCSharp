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

namespace PatientCare
{
    public partial class ShowPrescription : Form
    {
        private PrescriptionData presData = new PrescriptionData();

        private string selectedMedicine = "", selectedTest = "", presID = "";

        public ShowPrescription(string presID)
        {
            InitializeComponent();

            this.presID = presID;

            deleteMed.Enabled = false;
            deleteTest.Enabled = false;

            LoadMedicinePrescription(presID);
            LoadTestPrescription(presID);
        }

        private void TestingMDI_Load(object sender, EventArgs e)
        {

        }

        private void LoadMedicinePrescription(string key)
        {
            medicinePrescription.DataSource = presData.generateMedicinePrescription(key);
        }

        private void LoadTestPrescription(string key)
        {
            testPrescription.DataSource = presData.generateTestPrescription(key);
        }

        private void medicinePrescription_CellCClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deleteMed_Click(object sender, EventArgs e)
        {
            if (presData.deletePrescribedMedicine(selectedMedicine, presID))
            {
                MessageBox.Show("Medicine is deleted!");
                LoadMedicinePrescription(presID);
            }
            else
            {
                MessageBox.Show("Error DELETING item!");
                return;
            }
        }

        private void testPrescription_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void deleteTest_Click(object sender, EventArgs e)
        {
            if (presData.deletePrescribedTest(selectedTest, presID))
            {
                MessageBox.Show("Test item is deleted!");
                LoadTestPrescription(presID);
            }
            else
            {
                MessageBox.Show("Error DELETING item!");
                return;
            }
        }

        private void medicinePrescription_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (medicinePrescription.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                presID = medicinePrescription.CurrentCell.Value.ToString();
                int rowIndex = medicinePrescription.CurrentCell.RowIndex;
                selectedMedicine = medicinePrescription.Rows[rowIndex].Cells[1].Value.ToString();
                deleteMed.Enabled = true;
            }
            else
                return;
        }

        private void testPrescription_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (testPrescription.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                presID = testPrescription.CurrentCell.Value.ToString();
                int rowIndex = testPrescription.CurrentCell.RowIndex;
                selectedTest = testPrescription.Rows[rowIndex].Cells[1].Value.ToString();
                deleteTest.Enabled = true;
            }
            else
                return;
        }
    }
}
