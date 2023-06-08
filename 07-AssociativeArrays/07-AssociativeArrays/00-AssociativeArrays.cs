using System;
using System.Collections;
using System.Collections.Generic;

namespace _07_AssociativeArrays
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            var dictSort = new SortedDictionary<string, int>();

            //dict[key] = value;

            dict["Ivan"] = 1;
            dict["Gosho"] = 2;
            dict["Ana"] = 3;
            dict["Pesho"] = 4;

            dictSort["Ivan"] = 1;
            dictSort["Gosho"] = 2;
            dictSort["Ana"] = 3;
            dictSort["Pesho"] = 4;

            foreach (var item in dict)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
                Console.WriteLine();
            }

            Console.WriteLine("--------------------------------------------");
            
            foreach (var item in dictSort)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
                Console.WriteLine();
            }            
            
            Console.WriteLine("--------------------------------------------");
            
            foreach (var key in dict.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("--------------------------------------------");

            Console.WriteLine(string.Join(", ", dict.Keys));
            Console.WriteLine(string.Join(", ", dict.Values));

            Console.WriteLine("--------------------------------------------");

            int goshoValue = dict["Gosho"];

            Console.WriteLine(goshoValue);

            Console.WriteLine("--------------------------------------------");

            dict.Add("Misho", 200);
            dict.Remove("Ana");
            dict.ContainsKey("Pesho");      //  True/False
            dict.ContainsValue(200);        //  True/False
        }
    }
}
