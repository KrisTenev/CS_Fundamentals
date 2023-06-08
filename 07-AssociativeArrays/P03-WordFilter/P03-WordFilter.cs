using System;
using System.Linq;

namespace P03_WordFilter
{
    internal class Program
    {
        static void Main()
        {
            var list = Console.ReadLine()
                .Split()
                .Where(x => x.Length % 2 == 0)
                .ToList();
        }
    }
}