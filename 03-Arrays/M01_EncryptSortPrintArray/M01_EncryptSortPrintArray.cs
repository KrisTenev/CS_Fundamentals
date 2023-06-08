using System;
using System.Linq;

namespace M01_EncryptSortPrintArray
{
    internal class M01_EncryptSortPrintArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long total = 0;

            long[] encryptedNames = new long[n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string vowels = "auoeiAUOEI";
                total = 0;

                for (int j = 0; j <= input.Length - 1; j++)
                {
                    char currentSymbol = input[j];

                    if (vowels.Contains(currentSymbol))
                    {
                        total += currentSymbol * input.Length;
                    }

                    else
                    {
                        total += currentSymbol / input.Length;
                    }                    
                }

                encryptedNames[i] = total;                
            }

            Array.Sort(encryptedNames);
            Console.WriteLine(string.Join("\n", encryptedNames));

        }
    }
}
