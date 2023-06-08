using System;

namespace E06_MiddleCharacters
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            FindMiddleChar(input);
        }

        static void FindMiddleChar(string input)
        {
            if (input.Length % 2 == 0)
            {
                char first = input[input.Length / 2 - 1];
                char second = input[input.Length / 2];

                Console.WriteLine(first + "" + second);
            }
            else
            {
                Console.WriteLine(input[input.Length / 2]);
            }
        
        }

    }
}
