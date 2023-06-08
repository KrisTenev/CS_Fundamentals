using System;
using System.Collections.Generic;
using System.Linq;

namespace E06_Courses
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split(" : ");

            while (input[0] != "end")
            {
                string courseName = input[0];
                string studentName = input[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>() { studentName };
                }
                else
                {
                    courses[courseName].Add(studentName);
                }

                input = Console.ReadLine().Split(" : ");
            }

            var result = courses.OrderByDescending(x => x.Value.Count).ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");

                Console.WriteLine(string.Join(Environment.NewLine, kvp.Value.OrderBy(x => x).Select(x => $"-- {x}")));
            }

            //// FOR JUDGE:
            //foreach (var kvp in courses)
            //{
            //    Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");

            //    Console.WriteLine(string.Join(Environment.NewLine, kvp.Value.Select(x => $"-- {x}")));
            //}
        }
    }
}
