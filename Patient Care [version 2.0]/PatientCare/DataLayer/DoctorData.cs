using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Data.SqlClient;
using System.Data;
using Framework;

namespace DataLayer
{
    public class DoctorData
    {
        private DataAccess ObjectOfDataAccess = new DataAccess();
        
        private bool AdditionOfParameters(DoctorEntity tempObject, string Command)
        {
            SqlCommand command = new SqlCommand(Command);

            SqlParameter UserNameParameter = new SqlParameter("@dUserName", SqlDbType.NVarChar, 50);
            UserNameParameter.Value = tempObject.doctorUserName;
            SqlParameter PasswordParameter = new SqlParameter("@dPassword", SqlDbType.NVarChar, 50);
            PasswordParameter.Value = tempObject.doctorPassword;
            SqlParameter NameParameter = new SqlParameter("@dName", SqlDbType.NVarChar, 100);
            NameParameter.Value = tempObject.doctorName;
            SqlParameter DoctorSpecialityParameter = new SqlParameter("@dSpeciality", SqlDbType.NVarChar, 50);
            DoctorSpecialityParameter.Value = tempObject.doctorSpeciality;

            //Adding parameters
            command.Parameters.Add(UserNameParameter);
            command.Parameters.Add(PasswordParameter);
            command.Parameters.Add(NameParameter);
            command.Parameters.Add(DoctorSpecialityParameter);

            if (ObjectOfDataAccess.ExecuteCommand(command) == 1)
                return true;
            else
                return false;
        }

        public bool insertRow(DoctorEntity tempObject)
        {
            string insertCommand = "INSERT INTO doctor (dUserName, dPassword, dName, dSpeciality)" +
            " VALUES (@dUserName, @dPassword, @dName, @dSpeciality)";

            //executing command
            return AdditionOfParameters(tempObject, insertCommand);
        }

        public bool updateRow(DoctorEntity tempObject)
        {
            string updateCommand = "UPDATE doctor SET dPassword = @dPassword, dName = @dName, dSpeciality = @dSpeciality" +
            "WHERE dUserName = @dUserName";
            //executing command
            return AdditionOfParameters(tempObject, updateCommand);
        }

        public DataTable ToCheckLoginCredentials(DoctorEntity tempObject)
        {
            string checkCommand = "SELECT * FROM doctor WHERE dUserName = @dUserName AND dPassword = @dPassword";

            SqlCommand command = new SqlCommand(checkCommand);

            SqlParameter UserNameParameter = new SqlParameter("@dUserName", SqlDbType.NVarChar, 50);
            UserNameParameter.Value = tempObject.doctorUserName;
            SqlParameter PasswordParameter = new SqlParameter("@dPassword", SqlDbType.NVarChar, 50);
            PasswordParameter.Value = tempObject.doctorPassword;

            //Adding command
            command.Parameters.Add(UserNameParameter);
            command.Parameters.Add(PasswordParameter);

            var d = ObjectOfDataAccess.Query(command);
            if (d.Rows.Count == 1)
            {
                //Login Success
                //string userName = d.Rows[0][2].ToString();

                /*(List<DoctorEntity> doctor = new List<DoctorEntity>();
                for (int i = 0; i < d.Rows.Count; i++)
                {
                    DoctorEntity _de = new DoctorEntity();

                    _de.doctorUserName = d.Rows[i][0].ToString();
                    _de.doctorPassword = d.Rows[i][1].ToString();
                    _de.doctorName = d.Rows[i][2].ToString();
                    _de.doctorSpeciality = d.Rows[i][3].ToString();

                    doctor.Add(_de);
                }
                
                //return userName;

                return doctor;*/

                return d;
            }

            else
            {
                return null;
            }
        }
    }
}
