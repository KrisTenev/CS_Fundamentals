using System;
using System.Collections.Generic;
using System.Linq;

namespace E05_BombNumbers
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int specialBombNumber = bombNumbers[0];
            int power = bombNumbers[1];


            while (numbers.Contains(specialBombNumber))
            {
                int specialBombIndex = numbers.IndexOf(specialBombNumber);

                if (specialBombIndex >= numbers.Count() - 1)
                {
                    break;
                }
                numbers.RemoveRange(specialBombIndex + 1, power);

                for (int i = 1; i <= power; i++)
                {
                    specialBombIndex = numbers.IndexOf(specialBombNumber);
                    if (specialBombIndex == 0)
                    {
                        break;
                    }
                    else
                    {
                        numbers.RemoveAt(specialBombIndex - 1);
                    }

                }

                numbers.Remove(specialBombNumber);
            }

            Console.WriteLine(numbers.Sum());
            //Console.WriteLine(String.Join(" ", numbers));

        }
    }
}
