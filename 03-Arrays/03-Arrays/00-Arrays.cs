using System;

namespace _03_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "some text";

            //aray from 10 elements
                //define array

            //type[] name = new array[Lenght]
            string[] texts = new string[10];

            texts[0] = text;
            texts[6] = "cat";
            texts[8] = "dog";
            texts[3] = "bird";

            //read index from array
            string thirdText = texts[3];
            string noText = texts[2];

            //print array element
            Console.WriteLine(texts[6]);

            //print array length
            Console.WriteLine(texts.Length);

            //
            int[] numbers = new int[50];
            int number1 = numbers[0];
            Console.WriteLine(number1);
            Console.WriteLine(numbers.Length);

            Console.WriteLine();

            //numbers 1 to 100
            int[] numbers100 = new int[100];
            for (int i = 0; i < numbers100.Length; i++)
            {
                numbers100[i] = i + 1;
                Console.WriteLine(numbers100[i]);
            }

            Console.WriteLine();

            //pre-defined array
            string[] days =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            //Join - print all elements in row with spaces
            string dayResult = string.Join(", ", days);
            Console.WriteLine(dayResult);
            Console.WriteLine();

            Console.WriteLine();

        }
    }
}
