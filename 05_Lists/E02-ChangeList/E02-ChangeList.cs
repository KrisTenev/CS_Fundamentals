using System;
using System.Collections.Generic;
using System.Linq;

namespace E02_ChangeList
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();


            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                if (command[0] == "Delete")
                {
                    DeleteNumbers(numbers, int.Parse(command[1]));
                }
                if (command[0] == "Insert")
                {
                    InsertNumberOnPosition(numbers, int.Parse(command[1]), int.Parse(command[2]));
                }

                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        static void DeleteNumbers(List<int> numbers, int element)
        {
            while (numbers.Contains(element))
            {
                numbers.Remove(element);
            }
        }
        static void InsertNumberOnPosition(List<int> numbers, int element, int position)
        {
            numbers.Insert(position, element);
        }
    }
}
