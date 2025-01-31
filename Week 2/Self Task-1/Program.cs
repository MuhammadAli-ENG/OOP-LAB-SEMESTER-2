using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transaction transaction1 = new Transaction();
            transaction1.TransactionId = 1;
            transaction1.ProductName = "Product_1";
            transaction1.Amount = 100;
            transaction1.Time = "3:05 PM";
            transaction1.Date = "1/29/2025";

            Transaction transaction2 = new Transaction(transaction1);
            Console.WriteLine(transaction1.Time);
            Console.WriteLine(transaction2.Time);
        }
    }
}
