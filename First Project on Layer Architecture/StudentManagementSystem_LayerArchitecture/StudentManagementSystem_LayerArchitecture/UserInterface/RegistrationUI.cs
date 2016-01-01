using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentManagementSystem_LayerArchitecture.DataLayer;
using StudentManagementSystem_LayerArchitecture.Entities;
using System.Data;

namespace StudentManagementSystem_LayerArchitecture.UserInterface
{
    class RegistrationUI
    {
        //Creating a prviate studentData object as it should be accessible from only studentUI class
        private registrationData registration = new registrationData();

        public void init()
        {
            do
            {
                Console.WriteLine("Commands for Registration:");
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
            Console.Write("Enter Serial (which will be Deleted!): ");
            int Serial = int.Parse(Console.ReadLine());

            registration.deleteRow(Serial);

            Query();
        }

        public void insertRow()
        {
            RegistrationProcess RegistrationProcessToInsert = new RegistrationProcess();
            Console.Write("Enter Course Name: ");
            RegistrationProcessToInsert.CourseName = Console.ReadLine();
            Console.Write("Enter Student Name: ");
            RegistrationProcessToInsert.StudentName = Console.ReadLine();
            
            registration.insertRow(RegistrationProcessToInsert);

            Query();
        }

        public void updateRow()
        {
            RegistrationProcess RegistrationProcessToUpdate = new RegistrationProcess();

            Console.Write("Enter Serial: ");
            RegistrationProcessToUpdate.Serial = int.Parse(Console.ReadLine());
            Console.Write("Enter Course Name: ");
            RegistrationProcessToUpdate.CourseName = Console.ReadLine();
            Console.Write("Enter Student Name: ");
            RegistrationProcessToUpdate.StudentName = Console.ReadLine();

            registration.updateRow(RegistrationProcessToUpdate);

            Query();
        }

        public void Query()
        {
            DataTable dt = registration.Query();

            ShowStudentTable.ShowTable(dt);
        }
    }
}
