using System;
using System.Collections.Generic;
using System.Linq;

namespace E06_CardsGame
{
    internal class Program
    {
        static void Main()
        {
            List<int> firstHand = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondHand = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (firstHand.Count > 0 && secondHand.Count > 0)
            {
                string currentWinner = PlayerBiggerCard(firstHand[0], secondHand[0]);

                if (currentWinner == "first")
                {
                    firstHand.Add(secondHand[0]);
                    secondHand.RemoveAt(0);

                    firstHand.Insert(firstHand.Count - 1, firstHand[0]);
                    firstHand.RemoveAt(0);
                }
                if (currentWinner == "second")
                {
                    secondHand.Add(firstHand[0]);
                    firstHand.RemoveAt(0);

                    secondHand.Insert(secondHand.Count - 1, secondHand[0]);
                    secondHand.RemoveAt(0);
                }
                if (currentWinner == null)
                {
                    firstHand.RemoveAt(0);
                    secondHand.RemoveAt(0);
                }                
            }

            if (firstHand.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstHand.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondHand.Sum()}");
            }
        }

        static string PlayerBiggerCard(int card1, int cart2)
        {
            string player;
            if (card1 > cart2)
            {
                player = "first";
            }
            else if (card1 < cart2)
            {
                player = "second";
            }
            else
            {
                player = null;
            }

            return player;
        }
    }
}
