using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_MergingLists
{
    internal class P02_MergingLists
    {
        static void Main()
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> resultList = new List<int>();

            //Variant 1
            for (int i = 0; i < Math.Max(firstList.Count, secondList.Count); i++)
            {
                if (i < firstList.Count)
                {
                    resultList.Add(firstList[i]);
                }
                if (i < secondList.Count)
                {
                    resultList.Add(secondList[i]);
                }
            }

            Console.Write(String.Join(" ", resultList));
        }
    }
}
