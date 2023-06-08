using System;
using System.Linq;

namespace E08_MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int magicNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputs.Length; i++)
            {

                for (int j = i + 1; j < inputs.Length; j++)
                {
                    int sum = inputs[i] + inputs[j];

                    if (magicNumber == sum)
                    {
                        Console.WriteLine(inputs[i] + " " + inputs[j]);
                    }
                }
            }

        }
    }
}
