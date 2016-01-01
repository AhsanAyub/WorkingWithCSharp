using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientCare
{

    public partial class ArrivalOfPattient : Form
    {
        private string dName = "", dUserName = "";

        public ArrivalOfPattient(string DoctorName, string DoctorUserName)
        {
            InitializeComponent();
            dName = DoctorName;
            dUserName = DoctorUserName;
            setDoctorName.Text = dName;
        }

        private void newPatient_Click(object sender, EventArgs e)
        {
            NewPatientEntry NewPatient = new NewPatientEntry(dName, dUserName);
            NewPatient.Show();
            this.Close();
        }

        private void oldPatient_Click(object sender, EventArgs e)
        {
            OldPatientEntry OldPatient = new OldPatientEntry(dName, dUserName);
            OldPatient.Show();
            this.Close();
        }
    }
}
