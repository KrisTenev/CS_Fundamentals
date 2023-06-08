using System;

namespace E03_Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string weekDay = Console.ReadLine();

            double singlePrice = 0;

            switch (groupType)
            {
                case "Students":

                    switch (weekDay)
                    {
                        case "Friday":
                            singlePrice = 8.45;
                            break;
                        case "Saturday":
                            singlePrice = 9.80;
                            break;
                        case "Sunday":
                            singlePrice = 10.46;
                            break;
                    }
                    break;

                case "Business":
                    switch (weekDay)
                    {
                        case "Friday":
                            singlePrice = 10.90;
                            break;
                        case "Saturday":
                            singlePrice = 15.60;
                            break;
                        case "Sunday":
                            singlePrice = 16;
                            break;
                    }
                    break;

                case "Regular":
                    switch (weekDay)
                    {
                        case "Friday":
                            singlePrice = 15;
                            break;
                        case "Saturday":
                            singlePrice = 20;
                            break;
                        case "Sunday":
                            singlePrice = 22.50;
                            break;
                    }
                    break;


            }

            double totalPrice = group * singlePrice;
            double finalPirce = totalPrice;

            if (groupType.Equals("Students") && group >= 30)
            {
                finalPirce = totalPrice * 0.85;
            }
            if (groupType.Equals("Business") && group >= 100) 
            {
                finalPirce = totalPrice - 10 * singlePrice;
            }
            if (groupType.Equals("Regular") && group >= 10 && group <= 20)
            {
                finalPirce = totalPrice * 0.95;
            }

            Console.WriteLine("Total price: {0:f2}",finalPirce);
        }
    }
}
