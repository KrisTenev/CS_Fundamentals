using System;

namespace E07_NxNMatrix
{
    internal class Program
    {
        static void Main()
        {
            int matrixDimention = int.Parse(Console.ReadLine());

            PrintMatrix(matrixDimention);
        }

        static void PrintMatrix(int n)
        {
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    numbers[j] = n;
                    
                }
                Console.WriteLine(string.Join(" ", numbers));
            }
        
        }
    }
}
