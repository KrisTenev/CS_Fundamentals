using System;

namespace E03_CharactersInRange
{
    internal class Program
    {
        static void Main()
        {
            char startSymbol = char.Parse(Console.ReadLine());
            char endSymbol = char.Parse(Console.ReadLine());

            PrintCharactersFromRange(startSymbol, endSymbol);

        }

        static void PrintCharactersFromRange(int startElement, int endElement)
        {
            if (startElement > endElement)
            {
                for (int i = endElement + 1; i < startElement; i++)
                {
                    int symbol = i;
                    Console.Write((char)symbol + " ");
                }
            }
            else
            {
                for (int i = startElement + 1; i < endElement; i++)
                {
                    int symbol = i;
                    Console.Write((char)symbol + " ");
                }
            }
        }
    }
}
