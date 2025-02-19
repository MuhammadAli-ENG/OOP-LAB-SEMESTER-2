﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_2
{
    public class Member
    {
        public string Name { get; set; }
        public int MemberID { get; set; }
        public List<string> BooksBought { get; set; }
        public int NumBooksBought { get; private set; }
        public double MoneyInBank { get; set; }
        public double AmountSpent { get; private set; }

        public Member(string name, int memberId, double moneyInBank)
        {
            Name = name;
            MemberID = memberId;
            MoneyInBank = moneyInBank;
            BooksBought = new List<string>();
            NumBooksBought = 0;
            AmountSpent = 0;
        }

        public void BuyBook(string bookName, double price)
        {
            if (MoneyInBank >= price)
            {
                BooksBought.Add(bookName);
                NumBooksBought++;
                AmountSpent += price;
                MoneyInBank -= price;
                Console.WriteLine($"{Name} bought {bookName} for ${price}.");
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
            }
        }

        public void ShowDetails()
        {
            Console.WriteLine("-----------*****-------------");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Member ID: {MemberID}");
            Console.WriteLine($"Books Bought: {string.Join(", ", BooksBought)}");
            Console.WriteLine($"Number of Books Bought: {NumBooksBought}");
            Console.WriteLine($"Amount Spent: ${AmountSpent}");
            Console.WriteLine($"Money in Bank: ${MoneyInBank}");
            Console.WriteLine("-----------******------------");
        }
    }
}
