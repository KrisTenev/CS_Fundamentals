using System;
using System.Collections.Generic;
using System.Linq;

namespace E08_AnonymousThreat
{
    internal class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split().ToList();

            string[] command = Console.ReadLine().Split();

            //•	merge {startIndex} {endIndex}
            //•	divide {index} {partitions}

            while (command[0] != "3:1")
            {
                int startIndex = -1;
                int endIndex = -1;
                int index = -1;
                int partitions = 0;

                if (command[0] == "merge")
                {
                    startIndex = int.Parse(command[1]);
                    endIndex = int.Parse(command[2]);

                    input = MergeElements(input, startIndex, endIndex);

                }
                else if (command[0] == "divide")
                {
                    index = int.Parse(command[1]);
                    partitions = int.Parse(command[2]);

                    List<string> tempDivider = new List<string>();

                    string currentElement = input[index];
                    int elementsCount = currentElement.Length / partitions;

                    for (int i = 0; i < partitions; i++)
                    {
                        tempDivider.Add(currentElement.Substring(0, elementsCount));
                        currentElement = currentElement.Remove(0, elementsCount);
                    }

                    input.RemoveAt(index);
                    input.InsertRange(index, tempDivider);

                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", input));
        }

        static List<string> MergeElements(List<string> list, int startIndex, int endIndex)
        {
            string mergedValues = string.Empty;

            if (startIndex > list.Count - 1)
            {
                return list;
            }

            if (endIndex > list.Count - 1)
            {
                endIndex = list.Count - 1;
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                mergedValues += list[i];
            }

            list[startIndex] = mergedValues;
            list.RemoveRange(startIndex + 1, endIndex - startIndex);

            return list;
        }

    }
}
