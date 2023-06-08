using System;

namespace E01_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());

            int[] train = new int[wagons];

            int totalPeople = 0;

            for (int i = 0; i < wagons; i++)
            {
                int people = int.Parse(Console.ReadLine());
                train[i] = people;

                totalPeople += train[i];        //totalPeople += people;
            }

            foreach (int wagon in train)
            {
                Console.Write(wagon + " ");
            }

            //int sum = train.Sum();

            Console.WriteLine();
            Console.WriteLine(totalPeople);



        }
    }
}
