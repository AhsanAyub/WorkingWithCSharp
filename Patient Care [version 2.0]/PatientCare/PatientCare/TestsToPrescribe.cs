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
    public partial class TestsToPrescribe : Form 
    {
        private PrescriptionData presObject = new PrescriptionData();
        private PrescriptionEntity _pe = new PrescriptionEntity();

        private string presID = "", TableName = "", distColName, colName = "";

        public TestsToPrescribe(string TestItem, string presID)
        {
            InitializeComponent();

            this.presID = presID;
            TableName = TestItem;

            fillCategorizedCombo();
        }

        private void fillCategorizedCombo()
        {
            distColName = TableName + "Category";
            var d = presObject.ShowCategorizedTest(TableName, distColName);

            List<string> result = new List<string>();
            for (int i = 0; i < d.Rows.Count; i++)
            {
                result.Add(d.Rows[i][0].ToString());
            }

            BindingSource categorizedTests = new BindingSource();
            categorizedTests.DataSource = result;

            categorizedTestItems.DataSource = categorizedTests;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void categorizedTestItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            colName = categorizedTestItems.SelectedItem.ToString();
            dataGridView1.DataSource = presObject.ShowTestToPrescribe(TableName, distColName, colName);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                ShowTestToSelect.Text = dataGridView1.CurrentCell.Value.ToString();
            }
        }

        private void CommentOnTest_TextChanged(object sender, EventArgs e)
        {
            _pe.CommmentOnTest = CommentOnTest.Text;
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            _pe.prescriptionID = presID;
            _pe.testName = ShowTestToSelect.Text;

            if (presObject.insertTestToPrescription(_pe))
            {
                MessageBox.Show("Item inserted!");
                testPrescription.DataSource = presObject.generateTestPrescription(_pe.prescriptionID);
                medicinePrescription.DataSource = presObject.generateMedicinePrescription(_pe.prescriptionID);
            }
            else
            {
                MessageBox.Show("Unsuccessful");
                return;
            }
        }

        private void TestsToPrescribe_Load(object sender, EventArgs e)
        {

        }

        private void ShowTestToSelect_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
