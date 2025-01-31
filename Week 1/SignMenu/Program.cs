﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "E:\\Study Work\\UET\\Study\\Semester 2\\OOP\\lab\\Week 2\\SignMenu\\textfile.txt";
            string[] names = new string[5];
            string[] password = new string[5];

           //readData(path, names, password);

           //Console.WriteLine("Names: ");
           //for (int x = 0; x < names.Length; x++)
           //{
           //    Console.WriteLine(names[x]);
           //}
           //Console.WriteLine("Password: ");
           //for (int x = 0; x < password.Length; x++)
           //{
           //    Console.WriteLine(password[x]);
           //}
           //Console.Read();

            int option;
            do
            {
                readData(path, names, password);
                Console.Clear();
                option = menu();
                Console.Clear();
                if (option == 1)
                {
                    Console.WriteLine("Enter Name: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter Password: ");
                    string p = Console.ReadLine();
                    signIn(n, p, names, password);
                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter New Name: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter New Password: ");
                    string p = Console.ReadLine();
                    signUp(path, n, p);
                }
            }
            while (option < 3);
            Console.Read();
        }
        static int menu()
        {
            int option;
            Console.WriteLine("1. SignIn");
            Console.WriteLine("2. SignUp");
            Console.WriteLine("Enter Option");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }

        static void readData(string path, string[] names, string[] password)
        {
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    names[x] = parseData(record, 1);
                    password[x] = parseData(record, 2);
                    x++;
                    if (x >= 5)
                    {
                        break;
                    }
                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
        }


        static void signIn(string n, string p, string[] names, string [] password)
        {
            bool flag = false;
            for (int x = 0; x < 5; x++)
            {
                if (n == names[x] && p == password[x])
                {
                    Console.WriteLine("Valid User");
                    flag = true;
                }
                if (flag == false)
                {
                    Console.WriteLine("Invalid User");
                }
                Console.ReadKey();
            }
        }

        static void signUp(string path, string n, string p)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.Write("\n" + n + "," + p + ",");
            file.Flush();
            file.Close();
        }
    }
}
