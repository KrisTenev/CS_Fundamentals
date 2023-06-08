using System;
using System.Linq;

namespace E02_CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            
            
            string[] array1 = input1.Split();
            string[] array2 = input2.Split();

            //Console.WriteLine(array1.Length);
            //Console.WriteLine(array2.Length);

            foreach (string s2 in array2)
            {
                //short way
                    //if (array1.Contains(s2))
                    //{
                    //    Console.Write(s2 + " ");
                    //}
                foreach (string s1 in array1)
                {
                    if (s2 == s1) 
                    {
                        Console.Write(s2 + " ");
                    }
                }
            }
        }
    }
}
