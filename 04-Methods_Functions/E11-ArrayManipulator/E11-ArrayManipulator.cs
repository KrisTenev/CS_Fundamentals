using System;
using System.Linq;

namespace E11_ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                if (command.Contains("exchange"))
                {
                    string[] splitCommand = command.Split();
                    int index = int.Parse(splitCommand[1]);

                    if (index < 0 || index > numbers.Length - 1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    Exchange(index, numbers);

                    //Console.WriteLine(string.Join(" ", numbers));
                }

                else if (command.Contains("max"))
                {
                    int resultFromDevision = GetResultFromModuleDevision(command);
                    PrintMaxEvenOddNumberIndex(numbers, resultFromDevision);
                }

                else if (command.Contains("min"))
                {
                    int resultFromDevision = GetResultFromModuleDevision(command);
                    PrintMinEvenOddNumberIndex(numbers, resultFromDevision);
                }


                else if (command.Contains("first"))
                {
                    int resultFromDevision = GetResultFromModuleDevision(command);
                    PrintFirstEvenOddElements(command, numbers, resultFromDevision);
                }

                else if (command.Contains("last"))
                {
                    int resultFromDevision = GetResultFromModuleDevision(command);
                    PrintLastEvenOddElements(command, numbers, resultFromDevision);
                }
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        static void Exchange(int index, int[] arr)
        {
            int[] tmp = new int[index + 1];

            //Array.Copy(arr, tmp, index);

            for (int i = 0; i <= tmp.Length - 1; i++)
            {
                tmp[i] = arr[i];
            }

            int currentIndex = 0;

            for (int i = index + 1; i <= arr.Length - 1; i++)
            //start from next element --> till end
            {
                arr[currentIndex] = arr[i];
                currentIndex++;
            }

            for (int i = 0; i <= tmp.Length - 1; i++)
            //start from tmp[0] --> till tmp[x]
            {
                arr[currentIndex] = tmp[i];
                currentIndex++;
            }
        }

        private static void PrintMaxEvenOddNumberIndex(int[] arr, int resultFromDevision)
        {
            int maxNumber = int.MinValue;
            int maxNumberIndex = -1;
            bool hasMax = false;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNumber = arr[i];

                if (arr[i] % 2 == resultFromDevision && maxNumber <= currentNumber)
                {
                    hasMax = true;
                    maxNumber = currentNumber;
                    maxNumberIndex = i;
                }
            }

            if (hasMax)
            {
                Console.WriteLine(maxNumberIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void PrintMinEvenOddNumberIndex(int[] arr, int resultFromDevision)
        {
            int minNumber = int.MaxValue;
            int minNumberIndex = -1;
            bool hasMin = false;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNumber = arr[i];

                if (arr[i] % 2 == resultFromDevision && minNumber >= currentNumber)
                {
                    hasMin = true;
                    minNumber = arr[i];
                    minNumberIndex = i;
                }
            }

            if (hasMin)
            {
                Console.WriteLine(minNumberIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void PrintFirstEvenOddElements(string command, int[] arr, int resultFromDevision)
        {
            string[] splitCommand = command.Split();
            int count = int.Parse(splitCommand[1]);

            if (count > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int[] first = new int[count];
            int counter = 0;
            int countEvenOdd = 0;

            for (int i = 0; i < count; i++)
            {
                for (int j = counter; j < arr.Length; j++)
                {
                    if (arr[j] % 2 == resultFromDevision)
                    {
                        countEvenOdd++;
                        first[i] = arr[j];
                        counter = j + 1;
                        break;
                    }
                }
            }

            int[] print = new int[countEvenOdd];
            for (int i = 0; i < countEvenOdd; i++)
            {
                print[i] = first[i];
            }

            if (countEvenOdd == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", print)}]");
            }


        }

        static void PrintLastEvenOddElements(string command, int[] arr, int resultFromDevision)
        {
            string[] splitCommand = command.Split();
            int count = int.Parse(splitCommand[1]);

            if (count > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int[] last = new int[count];
            int counter = arr.Length - 1;
            int countEvenOdd = 0;

            for (int i = 0; i < count; i++)
            {
                for (int j = counter; j >= 0; j--)
                {
                    if (arr[j] % 2 == resultFromDevision)
                    {
                        countEvenOdd++;
                        last[i] = arr[j];
                        counter = j - 1;
                        break;
                    }
                }
            }

            int[] print = new int[countEvenOdd];
            for (int i = 0; i < countEvenOdd; i++)
            {
                print[i] = last[i];
            }

            if (countEvenOdd == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", print)}]");
            }
        }

        private static int GetResultFromModuleDevision(string command)
        {
            int resultFromDevision = -1;

            if (command.Contains("even"))
            {
                resultFromDevision = 0;
            }
            else
            {
                resultFromDevision = 1;

            }

            return resultFromDevision;
        }
    }
}