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
    public class PatientData
    {
        private DataAccess ObjectOfDataAccess = new DataAccess();

        private bool AdditionOfParameters(PatientEntity tempObject, string Command)
        {
            SqlCommand command = new SqlCommand(Command);

            SqlParameter PatientID = new SqlParameter("@pID", SqlDbType.Int);
            PatientID.Value = tempObject.patiendID;
            SqlParameter PatientFullName = new SqlParameter("@pName", SqlDbType.NVarChar, 100);
            PatientFullName.Value = tempObject.patientName;
            SqlParameter PatientAge = new SqlParameter("@pAge", SqlDbType.Int);
            PatientAge.Value = tempObject.patientAge;
            SqlParameter PatientGender = new SqlParameter("@pGender", SqlDbType.NVarChar, 7);
            PatientGender.Value = tempObject.patientGender;
            SqlParameter PatientAddress = new SqlParameter("@pAddress", SqlDbType.NVarChar);
            PatientAddress.Value = tempObject.patientAddress;

            //Adding parameters
            command.Parameters.Add(PatientID);
            command.Parameters.Add(PatientFullName);
            command.Parameters.Add(PatientAge);
            command.Parameters.Add(PatientGender);
            command.Parameters.Add(PatientAddress);


            if (ObjectOfDataAccess.ExecuteCommand(command) == 1)
                return true;
            else
                return false;
        }

        public bool insertRow(PatientEntity tempObject)
        {
            string insertCommand = "INSERT INTO patient (pID, pName, pAge, pGender, pAddress)" +
            " VALUES (@pID, @pName, @pAge, @pGender, @pAddress)";

            //executing command
            return AdditionOfParameters(tempObject, insertCommand);
        }

        public bool updateRow(PatientEntity tempObject)
        {
            string updateCommand = "UPDATE patient SET pAge = @pAge, pName = @pName, pGender = @pGender, pAddress = @pAddress" +
            "WHERE pID = @pID";
            //executing command
            return AdditionOfParameters(tempObject, updateCommand);
        }

        /*public DataTable ToCheckSearchCredentials(PatientEntity tempObject)
        {
            string checkCommand = "SELECT * FROM patient WHERE pName = @pName OR pID = @pID";

            SqlCommand command = new SqlCommand(checkCommand);

            SqlParameter PatientNameParameter = new SqlParameter("@pName", SqlDbType.NVarChar, 100);
            PatientNameParameter.Value = tempObject.patientName;
            SqlParameter PatientIDdParameter = new SqlParameter("@pID", SqlDbType.Int);
            PatientIDdParameter.Value = tempObject.patiendID;

            //Adding command
            command.Parameters.Add(PatientNameParameter);
            command.Parameters.Add(PatientIDdParameter);

            var d = ObjectOfDataAccess.Query(command);
            if (d.Rows.Count > 0)
            {
                //Login Success
                string userName = d.Rows[0][2].ToString();
                //return userName;
                return d;
            }
            else
            {
                return null;
            }
        }*/

        public List<PatientEntity> SearchPatient(string key)
        {
            string checkCommand = "SELECT * FROM patient WHERE pName like @pName";

            SqlCommand command = new SqlCommand(checkCommand);

            SqlParameter PatientNameParameter = new SqlParameter("@pName", SqlDbType.NVarChar, 100);
            PatientNameParameter.Value = "%" + key + "%";

            //Adding command
            command.Parameters.Add(PatientNameParameter); 

            var d = ObjectOfDataAccess.Query(command);
            List<PatientEntity> pel = new List<PatientEntity>();
            for (int i = 0; i < d.Rows.Count; i++)
            {
                PatientEntity pe = new PatientEntity();
                
                pe.patiendID = Convert.ToInt32(d.Rows[i][0]);
                pe.patientName = d.Rows[i][1].ToString();
                pe.patientAge = Convert.ToInt32(d.Rows[i][2]);
                pe.patientGender = d.Rows[i][3].ToString();
                pe.patientAddress = d.Rows[i][4].ToString();

                pel.Add(pe);
            }
                return pel;
        }

    }
}
