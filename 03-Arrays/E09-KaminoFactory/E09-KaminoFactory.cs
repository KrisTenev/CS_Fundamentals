using System;
using System.Linq;

namespace E09_KaminoFactory
{
    internal class Program
    {
        static void Main()
        {
            int dnaLength = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int dnaInput = 0;

            int bestLenght = 1;
            int bestIndex = int.MaxValue;
            int bestSum = 0;

            int bestDnaSample = 0;
            int[] bestDna = new int[dnaLength];

            int bestLenghtDna = 0;
            int bestIndexDna = 0;
            int bestSumDna = 0;

            while (input != "Clone them!")
            {
                //1!0!1!1!0
                //0!1!1!0!0

                int[] dna = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                dnaInput++;

                int currLeght = 1;
                int currIndex = 0;
                int currSum = dna.Sum();

                for (int i = 0; i < dna.Length - 1; i++)
                {
                    if (dna[i] == dna[i + 1] && dna[i] == 1)
                    {
                        currLeght++;

                        if (currLeght > bestLenght)
                        {
                            bestLenght = currLeght;
                            bestLenghtDna = dnaInput;
                            currIndex = i;
                        }
                        if (currIndex < bestIndex)
                        {
                            bestIndex = currIndex;
                            bestIndexDna = dnaInput;
                        }
                        if (currSum > bestSum)
                        {
                            bestSum = currSum;
                            bestSumDna = dnaInput;
                        }
                    }

                }

                if (dnaInput == 1)
                {
                    bestDnaSample = dnaInput;
                    bestDna = dna;
                } 

                if (bestLenghtDna < bestIndexDna)
                {
                    bestDnaSample = dnaInput;
                    bestDna = dna;
                }
                else if (bestIndexDna < bestSumDna)
                {
                    bestDnaSample = dnaInput;
                    bestDna = dna;
                }

                input = Console.ReadLine();
            }

            //Console.WriteLine(bestLenghtDna);
            //Console.WriteLine(bestIndexDna);
            //Console.WriteLine(bestSumDna);


            Console.WriteLine($"Best DNA sample {bestDnaSample} with sum: {bestDna.Sum()}.");
            Console.WriteLine(string.Join(" ", bestDna));


        }
    }
}
