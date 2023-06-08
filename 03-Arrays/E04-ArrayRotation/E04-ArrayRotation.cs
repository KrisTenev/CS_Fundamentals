using System;

namespace E04_ArrayRotation
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();

            int rotations = int.Parse(Console.ReadLine());

            //string[] result = new string[input.Length];

            for (int i = 1; i <= rotations % input.Length; i++)

            //optimisation (rotations % input.Length)
            // if one array is roteted euqial to his lenght times, it will be back to initial value
            // |1|2|3|4| -> after 4 times elemet[3] = 4 will be on same place => all others also
            // so it is even not needed to rotate the array at all
            // if it is rotated 2*rotations => same
            // if it is rotated 2*rotations + N => only N rolations are fine for valid result

            {
                string firstElement = input[0];

                for (int j = 0; j < input.Length - 1; j++)
                {
                    input[j] = input[j + 1];
                }

                input[input.Length - 1] = firstElement;
            }

            Console.WriteLine(string.Join(" ", input));

            
            Console.WriteLine(rotations % input.Length);
        }
    }
}
