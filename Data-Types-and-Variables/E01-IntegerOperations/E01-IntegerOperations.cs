using System;

namespace E01_IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNubmer = int.Parse(Console.ReadLine());
            int secondNubmer = int.Parse(Console.ReadLine());
            int thirdNubmer = int.Parse(Console.ReadLine());
            int forthNubmer = int.Parse(Console.ReadLine());

            int sum = (firstNubmer + secondNubmer) / thirdNubmer * forthNubmer;


            Console.WriteLine(sum);
        }
    }
}
