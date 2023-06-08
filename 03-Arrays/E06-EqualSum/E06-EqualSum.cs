using System;
using System.Linq;

namespace E06_EqualSum
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = numbers.Sum();

            for (int i = 0; i < numbers.Length; i++)
            {
                rightSum -= numbers[i];

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }

                leftSum += numbers[i];
            }

            Console.WriteLine("no");

            /*My solution
             * 
             *
            int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
             
            int sumLeft = 0;
            int sumRight = 0;

            bool isExist = false;

            for (int i = 0; i <= inputs.Length - 1; i++)
            {
                //Sum right numbers
                for (int j = i + 1; j < inputs.Length; j++)
                {
                    sumRight += inputs[j];
                }

                //Sum left numbers
                for (int k = i - 1; k >= 0; k--)
                {
                    sumLeft += inputs[k];
                }

                if (sumRight == sumLeft)
                {
                    Console.WriteLine(i);
                    isExist = true;
                    break;
                }

                sumLeft = 0;
                sumRight = 0;

            }

            if (!isExist)
            {
                Console.WriteLine("no");
            }
            */
        }
    }
}
