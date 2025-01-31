using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Name = "Buddy";
            myDog.Age = 10;

            myDog.Bark();
            myDog.Eat("dog food");
            int humanYears = myDog.ConvertToHumanYears();
            Console.WriteLine($"{myDog.Name}'s age in human years: {humanYears}");

            Console.ReadKey();
        }
    }
}
