using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace E05_SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            Dictionary<string, string> carData = new Dictionary<string, string>();

            for (int i = 1; i <= numberOfCommands; i++)
            {
                string[] commands = Console.ReadLine().Split(' ');

                string command = commands[0];
                string username = commands[1];

                if (command == "register")
                {
                    string licensePlateNumber = commands[2];

                    if (!carData.ContainsKey(username))
                    {
                        carData[username] = licensePlateNumber;

                        Console.WriteLine($"{username} registered {carData[username]} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                }
                else if (command == "unregister")
                {
                    if (!carData.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        carData.Remove(username);

                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            string outputFormat = "{0} => {1}";
            
            Console.WriteLine(string.Join(Environment.NewLine, carData.Select(x => string.Format(outputFormat, x.Key, x.Value))));
            
            //Console.WriteLine(string.Join(Environment.NewLine, carData.Select(x => $"{x.Key} => {x.Value}")));
        }
    }
}
