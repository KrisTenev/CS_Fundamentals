using System;
using System.Linq;

namespace E03_Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] array1 = new string[n];
            string[] array2 = new string[n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputs = input.Split();

                if (i % 2 == 0) 
                {
                    array1[i] = inputs[0];
                    array2[i] = inputs[1];
                }
                else
                {
                    array1[i] = inputs[1];
                    array2[i] = inputs[0];
                }

            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine(string.Join(" ",array2));
            
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(array2[i] + " ");
            //}
        }
    }
}
