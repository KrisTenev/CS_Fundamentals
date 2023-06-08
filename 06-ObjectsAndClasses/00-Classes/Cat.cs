using System;
using System.Collections.Generic;
using System.Text;

namespace _00_Classes
{
    internal class Cat
    {
        //Constructor
        public Cat(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Cat(string name)
        {
            Name = name;
        }

        //Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public bool IsSleeping { get; set; }

        public string FullName
        {
            get
            {
                return Name + " " + Color;
            }
        }

        //Methods
        public string SayHello()
        {
            if (IsSleeping)
            {
                return "Zzz";
            }
            else
            {
                return "Mew";
            }

        }
    }
}
