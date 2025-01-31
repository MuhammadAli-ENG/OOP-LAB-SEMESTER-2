﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_task_1
{
    public class Dog
    {
        public string Name;
        public int Age;

        public void Bark() {
            Console.WriteLine($"{Name} is barking!");
        }
        public void Eat(string food)
        {
            Console.WriteLine($"{Name} is eating {food}.");
        }

        public int ConvertToHumanYears()
        {
            return Age * 7;
        }
    }
}
