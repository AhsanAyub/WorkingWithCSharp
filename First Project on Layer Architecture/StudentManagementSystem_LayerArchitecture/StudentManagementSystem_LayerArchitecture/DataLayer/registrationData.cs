using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentManagementSystem_LayerArchitecture.Entities;
using System.Data.SqlClient;
using System.Data;
using StudentManagementSystem_LayerArchitecture.Framework;

namespace StudentManagementSystem_LayerArchitecture.DataLayer
{
    class registrationData
    {
        DataAccess ObjectOfDataAccess = new DataAccess();
        public void insertRow(RegistrationProcess tempObject)
        {
            string insertCommand = "INSERT INTO registration (CourseName, StudentName) VALUES (@CourseName, @StudentName)";
            SqlCommand command = new SqlCommand(insertCommand);
            SqlParameter CourseNameParameter = new SqlParameter("@CourseName", SqlDbType.NVarChar, 50);
            CourseNameParameter.Value = tempObject.CourseName;
            SqlParameter StudentNameParameter = new SqlParameter("@StudentName", SqlDbType.NVarChar, 50);
            StudentNameParameter.Value = tempObject.StudentName;

            command.Parameters.Add(CourseNameParameter);
            command.Parameters.Add(StudentNameParameter);

            ObjectOfDataAccess.ExecuteCommand(command);
        }

        public void updateRow(RegistrationProcess tempObject)
        {
            string updateCommand = "UPDATE registration SET CourseName = @CourseName, StudentName = @StudentName WHERE Serial = @Serial";
            SqlCommand command = new SqlCommand(updateCommand);
            SqlParameter CourseNameParameter = new SqlParameter("@CourseName", SqlDbType.NVarChar, 50);
            CourseNameParameter.Value = tempObject.CourseName;
            SqlParameter StudentNameParameter = new SqlParameter("@StudentName", SqlDbType.NVarChar, 50);
            StudentNameParameter.Value = tempObject.StudentName;
            SqlParameter SerialParameter = new SqlParameter("@Serial", SqlDbType.Int);
            SerialParameter.Value = tempObject.Serial;

            command.Parameters.Add(SerialParameter);
            command.Parameters.Add(CourseNameParameter);
            command.Parameters.Add(StudentNameParameter);

            ObjectOfDataAccess.ExecuteCommand(command);
        }

        public void deleteRow(int Serial)
        {
            string deleteCommand = "DELETE registration WHERE Serial = @Serial";
            SqlCommand command = new SqlCommand(deleteCommand);
            SqlParameter idParameter = new SqlParameter("@Serial", SqlDbType.Int);
            idParameter.Value = Serial;
            command.Parameters.Add(idParameter);

            ObjectOfDataAccess.ExecuteCommand(command);
        }

        public DataTable Query()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM registration");
            return ObjectOfDataAccess.Query(command);
        }

        public List<RegistrationProcess> GetList()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM registration");
            DataTable dt = ObjectOfDataAccess.Query(command);

            List<RegistrationProcess> registrationList = new List<RegistrationProcess>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                RegistrationProcess obj = new RegistrationProcess();
                obj.Serial = int.Parse(dt.Rows[i][0].ToString());
                obj.CourseName = dt.Rows[i][1].ToString();
                obj.StudentName = dt.Rows[i][2].ToString();

                registrationList.Add(obj);
            }

            return registrationList;
        }
    }
}