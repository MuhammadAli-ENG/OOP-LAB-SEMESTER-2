using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float lenght;
            float area;
            string str;
            Console.WriteLine("Enter lenght: ");
            str = Console.ReadLine();
            lenght = float.Parse(str);
            area = lenght * lenght;
            Console.WriteLine("The Area is: ");
            Console.Write(area);
            Console.ReadKey();

        }
    }
}
