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
    public partial class MedicineToPrescribe : Form
    {
        private string TableName = "", distColName, colName = "";
        private PrescriptionData presObject = new PrescriptionData();
        private PrescriptionEntity _pe = new PrescriptionEntity();

        private string presID = "";

        public MedicineToPrescribe(string DrugItem, string presID)
        {
            InitializeComponent();
            this.presID = presID;
            _pe.prescriptionID = presID;
            TableName = DrugItem;

            fillCategorizedCombo();
        }

        private void fillCategorizedCombo()
        {
            distColName = TableName + "Category";
            var d = presObject.ShowCategorizedMedicine(TableName, distColName);

            List<string> result = new List<string>();
            for (int i = 0; i < d.Rows.Count; i++)
            {
                result.Add(d.Rows[i][0].ToString());
            }

            BindingSource categorizedMeds = new BindingSource();
            categorizedMeds.DataSource = result;

            CategorizedDrugs.DataSource = categorizedMeds;

        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            if (selectedMedicine.Text.Equals("Selected Medicine"))
                return;
            else
            {
                _pe.medicineName = selectedMedicine.Text;
                MessageBox.Show("Medicine is selected");
            }
        }

        private void CategorizedDrugs_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void MedicineToPrescribe_Load(object sender, EventArgs e)
        {
            
        }

        private void ShowDataTableOfTests_Click(object sender, EventArgs e)
        {
            selectedMedicine.Text = "";
            Intake.Text = "";
            comment.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                selectedMedicine.Text = dataGridView1.CurrentCell.Value.ToString();
            }
            else
                return;
        }

        private void Intake_TextChanged(object sender, EventArgs e)
        {
            if (Intake.Text.Equals("Intake of Medicine") || Intake.Text.Equals(null))
            {
                return;
            }
            else
                _pe.intakePeriod = Intake.Text;
        }

        private void Days_TextChanged(object sender, EventArgs e)
        {
            _pe.NumberOfDays = Convert.ToInt32(Days.Text);
        }

        private void comment_TextChanged(object sender, EventArgs e)
        {
            if (comment.Equals(null))
                _pe.CommentOnPrescrition = "Auto generate comment";
            else
                _pe.CommentOnPrescrition = comment.Text;
        }

        private void addMedicine_Click(object sender, EventArgs e)
        {
            _pe.prescriptionID = presID;

            _pe.medicineName = selectedMedicine.Text;

            if (presObject.insertMedicineToPrescription(_pe))
            {
                MessageBox.Show("Medicine is selected!");
                medicinePrescription.DataSource = presObject.generateMedicinePrescription(_pe.prescriptionID);
                testPrescription.DataSource = presObject.generateTestPrescription(_pe.prescriptionID);
            }
            else
            {
                MessageBox.Show("Unsuccessful");
                return;
            }
        }

        private void CategorizedDrugs_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            colName = this.CategorizedDrugs.GetItemText(this.CategorizedDrugs.SelectedItem);
            dataGridView1.DataSource = presObject.ShowMedicineToPrescribe(TableName, distColName, colName);
        }
    }
}