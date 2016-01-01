using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentManagementSystem_LayerArchitecture.UserInterface;

namespace StudentManagementSystem_LayerArchitecture
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Select Process:");
                Console.WriteLine("==========================");
                Console.WriteLine("Student Entry:\t1,");
                Console.WriteLine("Student Registration:\t2,");
                Console.WriteLine("Exit:\t0");
                Console.WriteLine("==========================");
                Console.Write("Enter Command Here: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        studentUI sUI = new studentUI();
                        sUI.init();
                        break;
                    case "2":
                        RegistrationUI rUI = new RegistrationUI();
                        rUI.init();
                        break;
                    case "0":
                        return;
                }
                Console.WriteLine("==========================");
                Console.WriteLine("Press Enter to Continue...");
            } while (true);
        }
    }
}