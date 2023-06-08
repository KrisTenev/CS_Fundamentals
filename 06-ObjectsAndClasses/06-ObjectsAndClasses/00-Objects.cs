using System;

namespace _06_Objects
{
    internal class Program
    {
        static void Main()
        {
            var cat = new
            {
                Name = "Pesho",
                Age = 20,
                Color = "Black"

            };

            var anotherCat = new
            {
                Name = "Ivan",
                Age = 10
            };

            var catName = cat.Name;

            DateTime date = new DateTime(2022, 10, 10);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
