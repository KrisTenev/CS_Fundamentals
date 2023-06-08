using System;

namespace M02_PascalTriangle
{
    internal class M02_PascalTriangle
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            

            //ROWS
            for (int i = 1; i <= n; i++)
            {
                int[] previous = new int[i];
                previous[0] = 1;

                int[] current = new int[previous.Length];


                for (int j = 1; j < previous.Length; j++)
                {
                    current[j] += previous[j - 1] + previous[i - 1];
                }

                previous = current;

                Console.WriteLine(string.Join(" ", current));
            }
        }
    }
}
