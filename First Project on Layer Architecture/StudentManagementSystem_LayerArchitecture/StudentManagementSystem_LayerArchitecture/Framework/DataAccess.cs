using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace StudentManagementSystem_LayerArchitecture.Framework
{
    class DataAccess
    {
        string connectionString = "Data Source=AHSAN_ENVY\\SQLEXPRESS;Initial Catalog=student;Integrated Security=True;Pooling=False";
        
        public void ExecuteCommand(SqlCommand command)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            command.Connection = connection;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        
        public DataTable Query(SqlCommand query)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            query.Connection = connection;
            SqlDataAdapter da = new SqlDataAdapter(query);
            connection.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();

            return dt;
        }
    }
}
