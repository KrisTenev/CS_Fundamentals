using System;
using System.Linq;
using System.Collections.Generic;

namespace E04_Students
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List <Students> students = new List<Students>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string firstName = input[0];
                string secondName = input[1];
                double grade = double.Parse(input[2]);

                students.Add(new Students(firstName, secondName, grade));
            }

            students = students.OrderByDescending(x => x.Grade).ToList();

            foreach (Students item in students)
            {
                Console.WriteLine("{0} {1}: {2:F2}",item.FirstName,item.SecondName,item.Grade);
            }
        }

        public class Students
        {
            public Students(string firstName, string secondName, double grade)
            {
                this.FirstName = firstName;
                this.SecondName = secondName;
                this.Grade = grade;
            }

            public string FirstName { get; set; }
            public string SecondName { get; set; }
            public double Grade { get; set; }
        }
    }
}
