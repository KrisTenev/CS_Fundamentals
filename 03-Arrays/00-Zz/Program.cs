using System;
using System.Linq;

namespace _00_Zz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input INT:
            //4
            //100
            //200
            //300
            //400

            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                //int nextNumber = int.Parse(Console.ReadLine());
                //numbers[i] = nextNumber;
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(numbers[0]);


            //input STRING:
            //4
            //Ivan
            //Ivanka
            //Pesho
            //Petranka

            int p = int.Parse(Console.ReadLine());
            string[] names = new string[p];
            for (int i = 0; i < p; i++)
            {
                names[i] = Console.ReadLine();
            }

            //Element count unknown
            //4 5 6 7 9 0 4 -2 44 99
            //Ivan Ivanka Pesho Petranka
            //.Split() create array from elemnts devided by " "

            string value = Console.ReadLine();
            string[] values = value.Split();
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            //Read line of INT and store as int
            //4 5 6 7 9 0 4 -2 44 99
            string number = Console.ReadLine();
            string[] numbersAsText = value.Split();

            int[] numbersAsInt = new int[numbersAsText.Length];
            for (int i = 0; i < numbersAsInt.Length; i++)
            {
                numbersAsInt[i] = int.Parse(numbersAsText[i]);
            }

            //short
            int[] numbs = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }
    }
}
