using System;

namespace E03_Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());


            //Solution #1
            int cources = people / capacity;

            bool extraCource = people % capacity != 0;

            if (extraCource)
            {
                cources++;
            }

            Console.WriteLine(cources);


            //Solution #2
            int cources2 = (int)Math.Ceiling((double)people / capacity);
            //Console.WriteLine(cources2);

        }
    }
}
