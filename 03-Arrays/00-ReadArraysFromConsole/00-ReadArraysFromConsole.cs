using System;
using System.Linq;

namespace _00_ReadArraysFromConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // For known lenght array
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            string[] texts = new string[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

                texts[i] = Console.ReadLine();
            }
            Console.WriteLine(numbers[0]);
            Console.WriteLine(texts[0]);

            //For single line array

            //Ivan Ivanka Pesho Maria Ana
            string line = Console.ReadLine();
            string[] names = line.Split();

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            //Ivan, Ivanka, Pesho, Maria, Ana
            string[] namesSplitOption = line.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //5 10 20 30 50 60
                //long way
            string lineN = Console.ReadLine();

            string[] numberAsText = lineN.Split(" ");

            int[] numbersX = new int[numberAsText.Length];

            for (int i = 0; i < numbersX.Length; i++)
            {
                numbersX[i] = int.Parse(numberAsText[i]);
            }

                //fast way
            int[] lineFI = Console.ReadLine().Split().Select(int.Parse).ToArray();
            double[] lineFD = Console.ReadLine().Split().Select(double.Parse).ToArray();

        }
    }
}
