using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculate = new Calculator(8,9);
            Console.WriteLine(calculate.multiply());
        }
    }
}
