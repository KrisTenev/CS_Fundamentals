using System;
using System.Collections.Generic;
using System.Linq;

namespace E03_HouseParty
{
    internal class Program
    {
        static void Main()
        {
            int commandNumber = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();

            for (int i = 1; i <= commandNumber; i++)
            {
                string[] peopleIntention = Console.ReadLine().Split();
                if (peopleIntention[2] == "going!")
                {
                    if (guests.Contains(peopleIntention[0]))
                    {
                        Console.WriteLine($"{peopleIntention[0]} is already in the list!");
                    }
                    else
                    {
                        guests.Add(peopleIntention[0]);
                    }
                }
                else
                {
                    if (!guests.Contains(peopleIntention[0]))
                    {
                        Console.WriteLine($"{peopleIntention[0]} is not in the list!");
                    }
                    else
                    {
                        guests.Remove(peopleIntention[0]);
                    }
                }
            }

            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(guests[i]);
            }
        }
    }
}
