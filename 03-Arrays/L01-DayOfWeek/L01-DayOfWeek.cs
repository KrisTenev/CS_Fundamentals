using System;

namespace L01_DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] daysOfWeek = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            if (1 <= n && n <= 7)
            {
                Console.WriteLine(daysOfWeek[n - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}
