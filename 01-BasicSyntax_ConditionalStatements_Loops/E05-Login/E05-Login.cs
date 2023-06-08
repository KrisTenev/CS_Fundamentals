using System;

namespace E05_Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = "";

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];

            }

            int tries = 1;
            bool isLogged = false;

            while (tries < 4)
            {
                //if (tries == 4)
                //{
                //    Console.WriteLine($"User {username} blocked!");
                //    break;
                //}

                string inputPassword = Console.ReadLine();

                if (inputPassword.Equals(password))
                {
                    isLogged = true;
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }

                tries++;
            }

            if (!isLogged)
            {
                Console.WriteLine($"User {username} blocked!");
            }




            //for (int i = 0; i < 3; i++)
            //{
            //    string inputPassword = Console.ReadLine();

            //    if (inputPassword.Equals(password))
            //    {
            //        Console.WriteLine($"User {username} logged in.");
            //        return;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Incorrect password. Try again.");
            //    }
            //}

            //string lastPassword = Console.ReadLine();

            //if (lastPassword == password)
            //{
            //    Console.WriteLine($"User {username} logged in.");
            //}
            //else
            //{
            //    Console.WriteLine($"User {username} blocked!");
            //}

        }
    }
}
