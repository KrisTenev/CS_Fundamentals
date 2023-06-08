using System;

namespace _00_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] texts = Console.ReadLine().Split();

            foreach (string text in texts)
            {
                Console.WriteLine(text);
            }

        }
    }
}
