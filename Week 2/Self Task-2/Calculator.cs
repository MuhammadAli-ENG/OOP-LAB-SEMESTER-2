using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Task_2
{
    internal class Calculator
    {
        public int a;
        public int b;
        public Calculator(int x, int y)
        {
            a = x;
            b = y;
        }

        public int add()
        {
            return a + b;
        }
        public int subtract()
        {
            return a - b;
        }
        public int multiply()
        {
            return a * b;
        }
        public int divide()
        {
            return a / b;
        }
    }
}
