using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentManagementSystem_LayerArchitecture.DataLayer;
using StudentManagementSystem_LayerArchitecture.Entities;
using System.Data;

namespace StudentManagementSystem_LayerArchitecture.UserInterface
{
    class studentUI
    {
        //Creating a prviate studentData object as it should be accessible from only studentUI class
        private studentData student = new studentData();

        public void init()
        {
            do
            {
                Console.WriteLine("Commands for Student:");
                Console.WriteLine("==========================");
                Console.WriteLine("Query:\t1,");
                Console.WriteLine("Insert:\t2,");
                Console.WriteLine("Update:\t3,");
                Console.WriteLine("Delete:\t4,");
                Console.WriteLine("Go Back:\t0");
                Console.WriteLine("==========================");
                Console.Write("Enter Command Here: ");
                string input = Console.ReadLine();
                
                switch (input)
                {
                    case "1":
                        Query();
                        break;
                    case "2":
                        insertRow();
                        break;
                    case "3":
                        updateRow();
                        break;
                    case "4":
                        deleteRow();
                        break;
                    case "0":
                        return;
                }
                Console.WriteLine("==========================");
                Console.WriteLine("Press Enter to Continue...");
                Console.ReadLine();
            } while (true);
        }

        public void deleteRow()
        {
            Console.Write("Enter ID (which will be Deleted!): ");
            int studentID = int.Parse(Console.ReadLine());

            student.deleteRow(studentID);

            Query();
        }

        public void insertRow()
        {
            StudentEntity StudentEntityToInsert = new StudentEntity();
            Console.Write("Enter Student's Name: ");
            StudentEntityToInsert.studentName = Console.ReadLine();

            student.insertRow(StudentEntityToInsert);

            Query();
        }

        public void updateRow()
        {
            StudentEntity StudentEntityToUpdate = new StudentEntity();
            
            Console.Write("Enter Student ID: ");
            StudentEntityToUpdate.studentID = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            StudentEntityToUpdate.studentName = Console.ReadLine();

            student.updateRow(StudentEntityToUpdate);

            Query();
        }

        public void Query()
        {
            DataTable dt = student.Query();

            ShowStudentTable.ShowTable(dt);
        }
    }
}
