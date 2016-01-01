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

        public MedicineToPrescribe(string presID)
        {
            InitializeComponent();
            this.presID = presID;

            initMedicines();
        }

        private void fillCategorizedCombo()
        {
            distColName = TableName + "Category";
            var d = presObject.ShowCategorizedMedicine(TableName, distColName);

            List<string> result = new List<string>();
            for (int i = 0; i < d.Rows.Count; i++)
            {
                /*PatientEntity pe = new PatientEntity();

                pe.patiendID = Convert.ToInt32(d.Rows[i][0]);
                pe.patientName = d.Rows[i][1].ToString();
                pe.patientAge = Convert.ToInt32(d.Rows[i][2]);
                pe.patientGender = d.Rows[i][3].ToString();
                pe.patientAddress = d.Rows[i][4].ToString();
                

                //result.Add(pe);*/

                result.Add(d.Rows[i][0].ToString());
            }

            BindingSource categorizedMeds = new BindingSource();
            categorizedMeds.DataSource = result;

            CategorizedDrugs.DataSource = categorizedMeds;

        }

        private void initMedicines()
        {
            List<string> MedicineCategories = new List<string>();
            MedicineCategories.Add("Antimicrobial");
            MedicineCategories.Add("Cardiovascular");
            MedicineCategories.Add("Gastrointestinal");
            MedicineCategories.Add("RespiratorySystem");

            BindingSource meds = new BindingSource();
            meds.DataSource = MedicineCategories;

            DrugItems.DataSource = meds;
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

        private void DrugItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableName = DrugItems.SelectedItem.ToString();
            fillCategorizedCombo();
        }

        private void CategorizedDrugs_SelectedIndexChanged(object sender, EventArgs e)
        {
            colName = CategorizedDrugs.SelectedItem.ToString();
        }

        private void MedicineToPrescribe_Load(object sender, EventArgs e)
        {
            
        }

        private void ShowDataTableOfTests_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = presObject.ShowMedicineToPrescribe(TableName, distColName, colName);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*string PrimaryKey = TableName + "GenericName";
            
            DataTable dt = presObject.ShowMedicineToPrescribe(TableName, distColName, colName);
            
            foreach (DataRow dr in dt.Rows)
            {
                selectedMedice.Text = dr[PrimaryKey].ToString();
            }*/

            if (dataGridView1.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                selectedMedicine.Text = dataGridView1.CurrentCell.Value.ToString();
            }
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
            if (Days.Text.Equals("Days"))
                return;
            else
                _pe.NumberOfDays = Convert.ToInt32(Days.Text);
        }

        private void comment_TextChanged(object sender, EventArgs e)
        {
            _pe.CommentOnPrescrition = comment.Text;
        }

        private void addMedicine_Click(object sender, EventArgs e)
        {
            _pe.prescriptionID = presID;

            if (presObject.insertMedicineToPrescription(_pe))
            {
                MessageBox.Show("Item inserted!");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
                return;
            }
        }
    }
}