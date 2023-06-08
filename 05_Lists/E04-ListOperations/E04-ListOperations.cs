using System;
using System.Collections.Generic;
using System.Linq;

namespace E04_ListOperations
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();

            int number = 0;
            int index = -1;            
            int count = 0;

            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Add":
                        //Add {number} – add number at the end.
                        number = int.Parse(command[1]);

                        numbers.Add(number);
                        break;

                    case "Insert":
                        //Insert {number} {index} – insert number at given index.
                        number = int.Parse(command[1]);
                        index = int.Parse(command[2]);

                        bool isIndexValid = IsIndexValid(index, 0, numbers.Count);

                        if (isIndexValid)
                        {
                            numbers.Insert(index, number);
                        }                        
                        break;

                    case "Remove":
                        //Remove {index} – remove at index.
                        index = int.Parse(command[1]);

                        isIndexValid = IsIndexValid(index, 0, numbers.Count);

                        if (isIndexValid)
                        {
                            numbers.RemoveAt(index);
                        }                        
                        break;

                    case "Shift":
                        //Shift left {count} – first number becomes last ‘count’ times.
                        //Shift right {count} – last number becomes first ‘count’ times.

                        count = int.Parse(command[2]);

                        if (command[1] == "left")
                        {
                            for (int i = 1; i <= count % numbers.Count; i++)
                            {
                                numbers.Add(numbers[0]);
                                numbers.RemoveAt(0);
                            }
                        }
                        else
                        {
                            for (int i = 1; i <= count % numbers.Count; i++)
                            {
                                numbers.Insert(0, numbers[numbers.Count - 1]);
                                numbers.RemoveAt(numbers.Count - 1);
                            }
                        }
                        break;

                }

                number = 0;
                index = -1;
                count = 0;

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(String.Join(" ",numbers));
        }

        static bool IsIndexValid(int index, int minRange, int maxRange)
        {
            if (index < minRange || index >= maxRange)
            {
                Console.WriteLine("Invalid index");
                return false;
            }

            return true;
        }
    }
}
