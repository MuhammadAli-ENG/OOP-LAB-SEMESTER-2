using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            int balance_var;
            int deposite = 0;
            int withdraw = 0;
           
            string opt = "-1";
            while (opt != "5")
            {
                balance_var = atm.balance;
                opt = AtmMenu();
                if (opt == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Enter the amount to deposite: ");
                    deposite = Convert.ToInt32(Console.ReadLine());
                    atm.Deposite(deposite);
                    atm.make_history(balance_var, deposite, "Deposited");
                }
                else if (opt == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Enter the amount to withdraw: ");
                    withdraw = Convert.ToInt32(Console.ReadLine());
                    if (withdraw > balance_var)
                    {
                        Console.WriteLine("You cannot withdraw the amount!!! Press any key to go back.");
                        Console.ReadKey();
                    }
                    else
                    {
                        atm.Withdraw(withdraw);
                        Console.WriteLine("Successfully withdraw..Press any key to go back.");
                        Console.ReadKey();
                        atm.make_history(balance_var, withdraw, "Withdrawed");

                    }
                }
                else if (opt == "3")
                {
                    Console.Clear();
                    atm.Checkbalance();
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
                else if (opt == "4")
                {
                    Console.Clear();
                    atm.ShowTransactionHistory();
                    Console.ReadKey();
                }
                else if (opt == "5")
                {
                    Console.WriteLine("Program End");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }

            }
        }
        static string AtmMenu()
        {
            Console.Clear ();
            Console.WriteLine("=== ATM Management ===");
            Console.WriteLine("1)  Deposite Cash");
            Console.WriteLine("2)  Withdraw Cash");
            Console.WriteLine("3)  Check Balance");
            Console.WriteLine("4)  Transaction History");
            Console.WriteLine("5)  End Program");
            Console.WriteLine("\n Enter your option: ");
            string choice = Console.ReadLine();
            return choice;
        }
    }
}
