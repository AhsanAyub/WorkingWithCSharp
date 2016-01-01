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
        private string TableName = "", distColName, colName = "";
        private PrescriptionData presObject = new PrescriptionData();
        private PrescriptionEntity _pe = new PrescriptionEntity();

        private string presID = "";

        public TestsToPrescribe(string presID)
        {
            InitializeComponent();

            this.presID = presID;

            initDiagnosticTests();
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

        private void initDiagnosticTests()
        {
            List<string> TestCategories = new List<string>();
            TestCategories.Add("LaboratoryServices");
            TestCategories.Add("RadiologicalAndImaging");

            BindingSource tests = new BindingSource();
            tests.DataSource = TestCategories;

            testItems.DataSource = tests;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void testItems_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            TableName = testItems.SelectedItem.ToString();
            fillCategorizedCombo();
        }

        private void categorizedTestItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            colName = categorizedTestItems.SelectedItem.ToString();
        }

        private void buttonAdv1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = presObject.ShowTestToPrescribe(TableName, distColName, colName);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                ShowTestToSelect.Text = dataGridView1.CurrentCell.Value.ToString();
            }
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            if (ShowTestToSelect.Text.Equals("Selected Medicine"))
                return;
            else
            {
                _pe.testName = ShowTestToSelect.Text;
                MessageBox.Show("Test is selected");
            }
        }

        private void CommentOnTest_TextChanged(object sender, EventArgs e)
        {
            _pe.CommmentOnTest = CommentOnTest.Text;
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            _pe.prescriptionID = presID;

            if (presObject.insertTestToPrescription(_pe))
            {
                MessageBox.Show("Item inserted!");
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
    }
}
