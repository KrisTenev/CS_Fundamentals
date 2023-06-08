using System;

namespace E04_PasswordValidator
{
    internal class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();

            PrintResult(password);
        }

        static void PrintResult(string input)
        {

            bool isLenghtValid = CheckPasswordLenght(input);
            bool areSymbolsValid = CheckForSpecialSymbols(input);
            bool areTwoDigits = CheckForTwoDigts(input);


            if (!isLenghtValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!areSymbolsValid)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!areTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isLenghtValid && areSymbolsValid && areTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool CheckPasswordLenght(string input)
        {
            if (input.Length >= 6 && input.Length <= 10)
            {
                return true;
            }

            return false;
        }

        static bool CheckForSpecialSymbols(string input)
        {
            foreach (char symbol in input)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }

            return true;
        }

        static bool CheckForTwoDigts(string input)
        {
            int countDigits = 0;

            foreach (var symbol in input)
            {
                if (char.IsDigit(symbol))
                {
                    countDigits++;

                    if (countDigits == 2)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
