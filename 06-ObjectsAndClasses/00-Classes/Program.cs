using System;

namespace _00_Classes
{
    internal class Program
    {
        static void Main()
        {
            var cat = new Cat("Ivan", 10);
            var cat2 = new Cat("Ivan");

            cat.Color = "Black";

            Console.WriteLine(cat.FullName);

        }
    }
}
