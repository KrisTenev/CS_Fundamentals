using System;

namespace E07__VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            double sumCoins = 0;

            while (!input.Equals("Start"))
            {
                double inputCoins = double.Parse(input);

                if (inputCoins == 0.1 || inputCoins == 0.2 || inputCoins == 0.5 || inputCoins == 1 || inputCoins == 2)
                {
                    sumCoins += inputCoins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {inputCoins}");
                }
                input = Console.ReadLine();
            }

            double itemPrice = 0;
            double totalItemPrice = 0;

            double currentCoins = sumCoins;

            input = Console.ReadLine();

            while (!input.Equals("End"))
            {
                bool isValidItem = true;

                switch (input)
                {
                    //“Nuts”, “Water”, “Crisps”, “Soda”, “Coke”
                    case "Nuts":
                        itemPrice = 2.0;
                        break;

                    case "Water":
                        itemPrice = 0.7;
                        break;

                    case "Crisps":
                        itemPrice = 1.5;
                        break;

                    case "Soda":
                        itemPrice = 0.8;
                        break;

                    case "Coke":
                        itemPrice = 1.0;
                        break;

                    default:
                        Console.WriteLine("Invalid product");
                        itemPrice = 0.0;
                        isValidItem = false;
                        break;
                }

                if (isValidItem)
                {
                    if (currentCoins >= itemPrice)
                    {
                        currentCoins -= itemPrice;
                        totalItemPrice += itemPrice;
                        Console.WriteLine($"Purchased {input.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }

                input = Console.ReadLine();
            }

            double change = sumCoins - totalItemPrice;

            if (change >= 0)
            {
                Console.WriteLine($"Change: {change:F2}");
            }
            else
            {
                Console.WriteLine($"Change: 0.00");
            }
        }
    }
}
