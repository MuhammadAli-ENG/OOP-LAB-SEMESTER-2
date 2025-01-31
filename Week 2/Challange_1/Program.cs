using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            string name;
            float m_marks, i_marks, e_marks;
            string opt = "-1";
            while (opt != "6")
            {
                opt = MainMenu();
                if (opt == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Enter Name of Student: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter Marks in Matric: ");
                    m_marks = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Marks in Intermediate: ");
                    i_marks = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Marks in ECAT: ");
                    e_marks = float.Parse(Console.ReadLine());
                    student.AddStudent(name, m_marks, i_marks, e_marks);
                    Console.WriteLine("Student has been added successfully now, calculate its aggregate!!! press any key to continue.");
                    Console.ReadKey();
                }
                else if (opt == "2")
                {
                    Console.Clear();
                    student.ShowStudents();
                    Console.WriteLine("Press any key to go back.");
                    Console.ReadKey();
                }
                else if (opt == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Enter the RegNo of Student: ");
                    int regno = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The Agrregate of student with RollNo \'{0}\' is \"{1}\" ",regno ,student.CalculateAllAgg(regno));
                    Console.WriteLine("Press any key to go back");
                    Console.ReadKey();
                }
                else if (opt == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Press any key to Calculate total aggregate of all students. First calculate aggregate of all students!!!");
                    Console.ReadKey ();
                    Console.WriteLine("\n\nThe Aggregate of all students is \"{0}\" ", student.ShowTotalAgg());
                    Console.ReadKey () ;
                }
                else if (opt == "5")
                {
                    Console.Clear();
                    Console.WriteLine("Press any key to see Top students!!");
                    Console.ReadKey ();
                    Console.WriteLine("\nPress any key to go back!!!");
                    Console.ReadKey ();
                }
                else if (opt == "6")
                {
                    Console.WriteLine("Program Ended!!!!!!!!");

                }
            }


        }

        static string MainMenu()
        {
            string str;
            Console.Clear();
            Console.WriteLine("=== Student Management System ===");
            Console.WriteLine("1)   Add Student");
            Console.WriteLine("2)   Show all Students");
            Console.WriteLine("3)   Calculate Aggregate");
            Console.WriteLine("4)   Show Total Aggregate");
            Console.WriteLine("5)   Top Students");
            Console.WriteLine("6)   Exit Program");
            Console.Write("\n  Enter Your option: ");
            str = Console.ReadLine();
            return str;
        }
    }
}
