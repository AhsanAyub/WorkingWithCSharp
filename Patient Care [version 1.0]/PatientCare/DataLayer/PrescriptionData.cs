using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Framework;
using System.Data.SqlClient;
using System.Data;

namespace DataLayer
{
    public class PrescriptionData
    {
        private DataAccess ObjectOfDataAccess = new DataAccess();

        public bool newPrescription(PrescriptionEntity tempObject)
        {
            string insertQuery = "INSERT INTO prescription (presID, pDate, dUserName, pID)" +
                " values  (@presID, @pDate, @dUserName, @pID)";

            SqlCommand command = new SqlCommand(insertQuery);

            SqlParameter PrescriptionID = new SqlParameter("@presID", SqlDbType.NVarChar, 20);
            PrescriptionID.Value = tempObject.prescriptionID;
            SqlParameter PrescriptionDate= new SqlParameter("@pDate", SqlDbType.NVarChar, 20);
            PrescriptionDate.Value = tempObject.prescriptionDate;
            SqlParameter DoctorUserName = new SqlParameter("@dUserName", SqlDbType.NVarChar, 50);
            DoctorUserName.Value = tempObject.DoctorToPrescribe;
            SqlParameter PatientID = new SqlParameter("@pID", SqlDbType.Int);
            PatientID.Value = tempObject.PrescribedPatient;

            command.Parameters.Add(PrescriptionID);
            command.Parameters.Add(PrescriptionDate);
            command.Parameters.Add(DoctorUserName);
            command.Parameters.Add(PatientID);

            if (ObjectOfDataAccess.ExecuteCommand(command) == 1)
                return true;
            else
                return false;
        }

        public DataTable ShowCategorizedMedicine(string TableName, string DistinctColumnName)
        {
            string query = "SELECT DISTINCT " + DistinctColumnName + " FROM " + TableName + ";";

            SqlCommand command = new SqlCommand(query);

            var d = ObjectOfDataAccess.Query(command);
            if (d.Rows.Count > 0)
            {
                return d;
            }
            else
            {
                return null;
            }
        }

        public DataTable ShowMedicineToPrescribe(string TableName, string DistinctColumnName, string key)
        {
            string query = "SELECT * FROM " + TableName + " where " + DistinctColumnName + " = '" + key + "';";

            SqlCommand command = new SqlCommand(query);

            var d = ObjectOfDataAccess.Query(command);
            if (d.Rows.Count > 0)
            {
                return d;
            }
            else
            {
                return null;
            }
        }

        public bool insertMedicineToPrescription(PrescriptionEntity tempObject)
        {
            string insertCommand = "INSERT INTO MedicineForPrescription (MedGenericName, Intake, Days, Comment, presID)"
                + " values (@MedGenericName, @Intake, @Days, @Comment, @presID)";

            SqlCommand command = new SqlCommand(insertCommand);

            SqlParameter MedGenericName = new SqlParameter("@MedGenericName", SqlDbType.NVarChar, 100);
            MedGenericName.Value = tempObject.medicineName;
            SqlParameter MedIntake = new SqlParameter("@Intake", SqlDbType.NVarChar, 50);
            MedIntake.Value = tempObject.intakePeriod;
            SqlParameter MedDays = new SqlParameter("@Days", SqlDbType.Int);
            MedDays.Value = tempObject.NumberOfDays;
            SqlParameter MedComment = new SqlParameter("@Comment", SqlDbType.NVarChar, 100);
            MedComment.Value = tempObject.CommentOnPrescrition;
            SqlParameter PrescriptionID = new SqlParameter("@presID", SqlDbType.NVarChar, 20);
            PrescriptionID.Value = tempObject.prescriptionID;

            command.Parameters.Add(MedGenericName);
            command.Parameters.Add(MedIntake);
            command.Parameters.Add(MedDays);
            command.Parameters.Add(MedComment);
            command.Parameters.Add(PrescriptionID);

            if (ObjectOfDataAccess.ExecuteCommand(command) == 1)
                return true;
            else
                return false;
        }

        public DataTable ShowCategorizedTest(string TableName, string DistinctColumnName)
        {
            string query = "SELECT DISTINCT " + DistinctColumnName + " FROM " + TableName + ";";

            SqlCommand command = new SqlCommand(query);

            var d = ObjectOfDataAccess.Query(command);
            if (d.Rows.Count > 0)
            {
                return d;
            }
            else
            {
                return null;
            }
        }

        public DataTable ShowTestToPrescribe(string TableName, string DistinctColumnName, string key)
        {
            string query = "SELECT * FROM " + TableName + " where " + DistinctColumnName + " = '" + key + "';";

            SqlCommand command = new SqlCommand(query);

            var d = ObjectOfDataAccess.Query(command);
            if (d.Rows.Count > 0)
            {
                return d;
            }
            else
            {
                return null;
            }
        }

        public bool insertTestToPrescription(PrescriptionEntity tempObject)
        {
            string insertCommand = "INSERT INTO TestForPrescription (testName, testComment, presID)"
                + " values (@testName, @testComment, @presID)";

            SqlCommand command = new SqlCommand(insertCommand);

            SqlParameter TestName = new SqlParameter("@testName", SqlDbType.NVarChar, 100);
            TestName.Value = tempObject.testName;
            SqlParameter TestComment = new SqlParameter("@testComment", SqlDbType.NVarChar, 100);
            TestComment.Value = tempObject.CommmentOnTest;
            SqlParameter PrescriptionID = new SqlParameter("@presID", SqlDbType.NVarChar, 20);
            PrescriptionID.Value = tempObject.prescriptionID;

            command.Parameters.Add(TestName);
            command.Parameters.Add(TestComment);
            command.Parameters.Add(PrescriptionID);

            if (ObjectOfDataAccess.ExecuteCommand(command) == 1)
                return true;
            else
                return false;
        }

        public DataTable FillingDataOnPatientTreatment(PrescriptionEntity tempObject, string sysDate)
        {
            string query = "SELECT * FROM prescription WHERE pDate <= '"+ sysDate + "' AND pID = " + tempObject.PrescribedPatient + ";";

            SqlCommand command = new SqlCommand(query);

            var d = ObjectOfDataAccess.Query(command);
            
            if (d.Rows.Count > 0)
            {
                return d;
            }
            else
            {
                return null;
            }
        }

        public DataTable generateMedicinePrescription(string key)
        {
            string query = "SELECT MedicineForPrescription.MedGenericName, MedicineForPrescription.Intake,"
                            + " MedicineForPrescription.Days, MedicineForPrescription.Comment"
                            + " FROM prescription"
                            + " JOIN MedicineForPrescription"
                            + " ON MedicineForPrescription.presID = prescription.presID"
                            + " WHERE prescription.presID = '" + key + "';";

            SqlCommand command = new SqlCommand(query);

            var d = ObjectOfDataAccess.Query(command);
            if (d.Rows.Count > 0)
            {
                return d;
            }
            else
            {
                return null;
            }
        }

        public DataTable generateTestPrescription(string key)
        {
            string query = "SELECT TestForPrescription.testName, TestForPrescription.testComment"
                            + " FROM prescription"
                            + " JOIN TestForPrescription"
                            + " ON TestForPrescription.presID = prescription.presID"
                            + " WHERE prescription.presID = '" + key + "';";

            SqlCommand command = new SqlCommand(query);

            var d = ObjectOfDataAccess.Query(command);
            if (d.Rows.Count > 0)
            {
                return d;
            }
            else
            {
                return null;
            }
        }
    }
}