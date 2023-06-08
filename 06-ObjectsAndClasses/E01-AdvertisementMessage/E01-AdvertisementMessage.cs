using System;
using System.Collections.Generic;

namespace E01_AdvertisementMessage
{
    internal class Program
    {
        static void Main()
        {
            int messagesCount = int.Parse(Console.ReadLine());

            List<string> phrases = new List<string>
           {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            List<string> events = new List<string>
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            List<string> authors = new List<string>
                {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            List<string> cities = new List<string>
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            //{phrase} {event} {author} – {city}
            string phrase;
            string @event;
            string author;
            string city;                

            Random rnd = new Random();

            for (int i = 0; i < messagesCount; i++)
            {
                phrase = phrases[rnd.Next(0, phrases.Count)];
                @event = events[rnd.Next(0, @events.Count)];
                author = authors[rnd.Next(0, authors.Count)];
                city = cities[rnd.Next(0, cities.Count)];

                Console.WriteLine($"{phrase} {@event} {author} – {city}");
            }
        }
    }
}
