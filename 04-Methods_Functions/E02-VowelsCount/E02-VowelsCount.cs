using System;

namespace E02_VowelsCount
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();
            PrintVowelsCount(input);
        }

        static void PrintVowelsCount(string word)
        {
            int vowelsCount = 0;
            string vowels = "auoei";

            for (int i = 0; i < word.Length; i++)
            {
                char currSymbol = word[i];

                if (vowels.Contains(currSymbol))
                {
                    vowelsCount++;
                }
            }
            Console.WriteLine(vowelsCount);
        }
    }
}
