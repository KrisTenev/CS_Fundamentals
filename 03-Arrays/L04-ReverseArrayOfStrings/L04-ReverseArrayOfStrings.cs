using System;

namespace L04_ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            //If only want to print Arr in reverce order
            for (int i = 0; i < arr.Length; i++) 
            {
                Console.Write(arr[arr.Length - i -1] + " ");
            }
            Console.WriteLine();

            //If second array is required by:
                 //input: |0|1|2|3|4|

            string[] result = new string[arr.Length];       // |x|x|x|x|x|      

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = arr[arr.Length - i - 1];        // i=0 result[0] = arr[4] |4|x|x|x|x|
            }                                           

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }

            Console.WriteLine();

            //Manually reverce same array:
            for (int i = 0; i < arr.Length / 2; i++)
            {
                    //input: |0|1|2|3|4|
                    //arr.Length / 2 = 5 / 2 = 2 rotations of the FOR loop

                string firstElement = arr[i];
                string lastElement = arr[arr.Length - i - 1];   //last array element i=0 => arr[4] = 4; i=1 => arr[3] = 3

                arr[i] = lastElement;                           //first element is overriden with last element i=0 |4|1|2|3|4|;  i=1 |4|3|2|3|4|
                arr[arr.Length - i -1] = firstElement;          //last element is overriden with 1st element   i=0 |4|1|2|3|0|;  i=1 |4|3|2|1|0|

            }

            for (int i = 0; i < arr.Length; i++)                // print array
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();



        }
    }
}
