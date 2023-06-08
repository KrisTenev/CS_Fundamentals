using System;
using System.Linq;

namespace MaxElements
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();









            /* Single Row Solution
            
            var seq = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] max = seq.Select((n, i) => new { Value = n, Index = i })
                .OrderBy(s => s.Value)
                .Select((o, i) => new { Value = o.Value, Diff = i - o.Index })
                .GroupBy(s => new { s.Value, s.Diff })
                .OrderByDescending(g => g.Count())
                .First()
                .Select(f => f.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ",max));

            */
        }
    }
}
