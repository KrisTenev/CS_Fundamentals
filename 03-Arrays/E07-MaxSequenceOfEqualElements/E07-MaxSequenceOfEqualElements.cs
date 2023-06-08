using System;
using System.Linq;

namespace E07_MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main()
        {
            int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //2 1 1 2 3 3 2 2 2 1

            bool isEqual = false;

            int counter = 0;
            int bestCount = 0;
            int startIndex = 0;
            

            for (int i = 0; i < inputs.Length - 1; i++)
            {
                isEqual = inputs[i] == inputs[i + 1];

                if (isEqual)
                {
                    counter++;
                    
                }
                else
                {
                    counter = 0;
                }
                
                if(bestCount < counter)
                {
                    bestCount = counter;
                    startIndex = i - counter + 1;
                }

            }

            int[] result = new int[bestCount + 1];

            for (int i = startIndex; i <= startIndex + bestCount -1; i++)
            {
                for (int j = 0; j < result.Length; j++)
                {
                    result[j] = inputs[i];
                }
            }

            Console.WriteLine(string.Join(" ", result));

            /* Solution #2
             * 
             * 
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxCount = 1;
            int currentCount = 1;
            int number = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                int previousNumber = numbers[i - 1];
                int currentNumber = numbers[i];

                if (previousNumber == currentCount)
                {
                    currentCount++;

                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        number = currentNumber;
                    }
                }
                else
                {
                    currentCount = 1;
                }

            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.WriteLine(number + " ");
            }
            Console.WriteLine();
            */

        }
    }
}
