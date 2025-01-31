using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Task_3
{
    public class ATM
    {
        public int balance;
        public const int arr_size = 3;
        public int count = 0;
        public int[] total_balance = new int[arr_size];
        public int[] transaction = new int[arr_size];
        public string[] transaction_type = new string[arr_size];

        public ATM()
        {
            balance = 30000;
        }


        public int Deposite(int amount)
        {
            balance = balance + amount;
            return balance;
        }

        public int Withdraw(int amount)
        {
            balance = balance - amount;
            return balance;
        }

        public void Checkbalance()
        {
            Console.WriteLine($"Your Current Balance is : {balance}");
        }
        public int Getbalance()
        {
            return balance;
        }
        public void ShowTransactionHistory()
        {
            Console.WriteLine("Following is the transaction history...");
            for(int idx = 0; idx < count; idx++)
            {
                Console.WriteLine("Balance:  {0} || Transaction Amount:   {1} || Transaction Type:    {2}", total_balance[idx], transaction[idx], transaction_type[idx]);
            }
        }
        public void make_history(int t_balance, int amount, string type)
        {
            total_balance[count] = t_balance;
            transaction[count] = amount;
            transaction_type[count] = type;
            count++;
        }


    }
}
