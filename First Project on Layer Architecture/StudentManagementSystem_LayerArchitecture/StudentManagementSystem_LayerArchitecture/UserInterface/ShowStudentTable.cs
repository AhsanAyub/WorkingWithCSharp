using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace StudentManagementSystem_LayerArchitecture.UserInterface
{
    class ShowStudentTable
    {
        public static void ShowTable(DataTable dt)
        {
            for (int j = 0; j < dt.Columns.Count; j++)
            {
                Console.Write(dt.Columns[j].ColumnName);
                Console.Write("\t");
            }
            Console.WriteLine();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    Console.Write(dt.Rows[i][j]);
                    if(j >= 1)
                        Console.Write("\t\t");
                    else
                        Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
    }
}