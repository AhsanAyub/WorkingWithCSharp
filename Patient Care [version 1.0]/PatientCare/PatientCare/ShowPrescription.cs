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

        public ShowPrescription(string presID)
        {
            InitializeComponent();

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
    }
}
