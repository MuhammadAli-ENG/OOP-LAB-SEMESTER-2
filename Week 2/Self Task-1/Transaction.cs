using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Task_1
{
    public class Transaction
    {
        public int TransactionId;
        public string ProductName;
        public int Amount;
        public string Date;
        public string Time;

        public Transaction()
        {

        }

        public Transaction(Transaction transation)
        {
            TransactionId = transation.TransactionId;
            ProductName = transation.ProductName;
            Amount = transation.Amount;
            Date = transation.Date;
            Time = transation.Time;
        }
    }
}
