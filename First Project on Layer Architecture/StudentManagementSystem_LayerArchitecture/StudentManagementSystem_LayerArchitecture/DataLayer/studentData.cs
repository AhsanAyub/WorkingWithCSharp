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
    class studentData
    {
        DataAccess ObjectOfDataAccess = new DataAccess();
        public void insertRow(StudentEntity tempObject)
        {
            string insertCommand = "INSERT INTO student (Name) VALUES (@Name)";
            SqlCommand command = new SqlCommand(insertCommand);
            SqlParameter nameParameter = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            nameParameter.Value = tempObject.studentName;

            //command.Parameters.Add(idParameter);
            command.Parameters.Add(nameParameter);
            
            //executing command
            ObjectOfDataAccess.ExecuteCommand(command);
        }

        public void updateRow(StudentEntity tempObject)
        {
            string updateCommand = "UPDATE student SET Name = @Name WHERE ID = @ID";
            SqlCommand command = new SqlCommand(updateCommand);
            SqlParameter idParameter = new SqlParameter("@ID", SqlDbType.Int);
            idParameter.Value = tempObject.studentID;
            SqlParameter nameParameter = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            nameParameter.Value = tempObject.studentName;

            command.Parameters.Add(idParameter);
            command.Parameters.Add(nameParameter);

            //executing command
            ObjectOfDataAccess.ExecuteCommand(command);
        }

        public void deleteRow(int studentID)
        {
            string deleteCommand = "DELETE student WHERE ID = @ID";
            SqlCommand command = new SqlCommand(deleteCommand);
            SqlParameter idParameter = new SqlParameter("@ID", SqlDbType.Int);
            idParameter.Value = studentID;
            command.Parameters.Add(idParameter);
            
            //executing command
            ObjectOfDataAccess.ExecuteCommand(command);
        }

        public DataTable Query()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM student");
            return ObjectOfDataAccess.Query(command);
        }

        public List<StudentEntity> GetList()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM student");
            DataTable dt = ObjectOfDataAccess.Query(command);

            List<StudentEntity> studentList = new List<StudentEntity>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                StudentEntity obj = new StudentEntity();
                obj.studentID = int.Parse(dt.Rows[i][0].ToString());
                obj.studentName = dt.Rows[i][1].ToString();

                studentList.Add(obj);
            }

            return studentList;
        }
    }
}
