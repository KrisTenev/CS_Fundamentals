using System;
using System.Collections.Generic;
using System.Linq;

namespace E01_Train
{
    internal class Program
    {
        static void Main()
        {

            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command.Contains("Add"))
                {
                    string[] addWagon = command.Split();
                    wagons.Add(int.Parse(addWagon[1]));
                }
                else
                {
                    int fit = int.Parse(command);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + fit <= maxCapacity)
                        {
                            wagons[i] += fit;
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", wagons));

        }
    }
}
