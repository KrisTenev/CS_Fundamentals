using System;
using System.Collections.Generic;

namespace _05_Lists
{
    internal class L01_Lists
    {
        static void Main()
        {

            List<string> myList = new List<string>();

            myList.Add("First task");   //0
            myList.Add("Second task");  //1
            myList.Add("Third task");   //2
            myList.Add("Forth task");   //3

            myList.Insert(2, "New Second task");



            myList.Contains("Third task"); //bool
            bool hasThirdTask = myList.Contains("Third task");

            int taskIndex = myList.IndexOf("Third task");

            myList.Sort();
            myList.Reverse();

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            List<string> list = new List<string>();
            myList.AddRange(list);

            myList.Remove("Third task");
            myList.RemoveAt(0);
            myList.RemoveAll(i => i.Contains("task"));






        }
    }
}
