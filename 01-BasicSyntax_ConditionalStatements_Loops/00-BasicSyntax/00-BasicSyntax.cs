using System;

namespace _00_BasicSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // int
            int maxInt = int.MaxValue;

            // long
            long maxLong = long.MaxValue;

            // decimal
            decimal maxDecimal = decimal.MaxValue;

            // float
            float maxFloat = float.MaxValue;

            // double
            double maxDouble = double.MaxValue;
            
            //max bound of numbers
            Console.WriteLine("Maximum real varialbes:");
            Console.WriteLine(maxInt);
            Console.WriteLine(maxLong);
            Console.WriteLine(maxDecimal);
            Console.WriteLine();
            Console.WriteLine("Maximum decimal varialbes:");
            Console.WriteLine(maxFloat);
            Console.WriteLine(maxDouble);
            Console.WriteLine();

            // bool
            bool isTrue = true;

            // string
            Console.WriteLine("String operations:");
            string str = "Pesho";
            int strLenght = str.Length;

            string firstNumber = "123";
            string secondNumber = "123";
            Console.WriteLine();

            Console.WriteLine(".Equals method: ");
            bool firstEqual = firstNumber.Equals("123");
            bool secondtEqual = !secondNumber.Equals(123);
            Console.WriteLine(firstEqual);
            Console.WriteLine(secondtEqual);
            Console.WriteLine();

            // char
            Console.WriteLine("Char operations:");
            char symbol = str[3];               // take index 3 from string "Pesho"
            Console.WriteLine(symbol);
            Console.WriteLine((char)97);        //char from ASCII code
            Console.WriteLine((int)'A');        //shows ASCII code
            Console.WriteLine();

            // var
            Console.WriteLine("Var operations:");
            var int1 = 1;
            var double1 = 2.5;                  // var take by defaut Double
            var float1 = 2.5f;                  // postfix "f" set var to Float

            Console.WriteLine();

            //read from cosole
            Console.WriteLine("Read from Cosole:");
            int num = int.Parse(Console.ReadLine());
            double dnum = double.Parse(Console.ReadLine());
            Console.WriteLine();
            //...

            //write to console + placeholders
            Console.WriteLine("Placeholders:");
            Console.WriteLine("Number is {0}", num);      //placeholder
            Console.WriteLine($"Number is {num}" );       //placeholder
            Console.WriteLine("Number is " + num);        //concatenation
            Console.WriteLine(num);

            Console.WriteLine(num.ToString());           // working on background when use Console...
            Console.WriteLine();

            // if
            Console.WriteLine("IF statement:");
            if (true)
            {
                Console.WriteLine("IF true");
            }
            Console.WriteLine();

            //if, else-if
            Console.WriteLine("ELSE-IF statement:");
            if (true)
            {
                Console.WriteLine("IF true");
            }
            else if (true)
            {

            }
            Console.WriteLine();

            //switch
            Console.WriteLine("SWITCH statement:");
            switch (1)
            {
                case 1:
                case 2:
                    Console.WriteLine("Case 1 true");
                    break;
                case 3:
                    break;
                default:
                    break;
            }
            Console.WriteLine();

            //for
            Console.WriteLine("FOR loop:");
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //while
            Console.WriteLine("WHILE loop:");
            int x = 0;
            while (x < 2)
            {
                Console.WriteLine(x);
                x++;
            }
            Console.WriteLine();

            ////do-while
            //Console.WriteLine("DO-WHILE loop:");
            //do
            //{

            //} while (true);
            //Console.WriteLine();

            ////foreach
            //Console.WriteLine("FOREACH loop:");
            //foreach (var item in collection)
            //{

            //}
            //Console.WriteLine();
        }
    }
}
