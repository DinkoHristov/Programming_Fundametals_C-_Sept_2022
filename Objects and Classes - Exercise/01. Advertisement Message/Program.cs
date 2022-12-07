using System;

namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberMessages = int.Parse(Console.ReadLine());

            Random random = new Random();

            string finalMessage = string.Empty;

            for (int i = 1; i <= numberMessages; i++)
            {
                string phrase = Phrase();
                string events = Events();
                string author = Authors();
                string city = Cities();

                FinalRandomMessage(phrase, events, author, city);
            }
        }

        static string Phrase()
        {
            string[] phrases = { "Excellent product.", "Such a great product.",
                "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can’t live without this product." };

            Random random = new Random();
            int randomNumber = random.Next(0, phrases.Length);

            string randomPhrase = phrases[randomNumber];

            return randomPhrase;
        }

        static string Events()
        {
            string[] events = { "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!" };

            Random random = new Random();
            int randomNumber = random.Next(0, events.Length);

            string randomEvent = events[randomNumber];

            return randomEvent;
        }

        static string Authors()
        {
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            Random random = new Random();
            int randomNumber = random.Next(0, authors.Length);

            string randomAuthor = authors[randomNumber];

            return randomAuthor;
        }

        static string Cities()
        {
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random random = new Random();
            int randomNumber = random.Next(0, cities.Length);

            string randomCity = cities[randomNumber];

            return randomCity;
        }

        static void FinalRandomMessage(string phrase, string events, string author, string city)
        {
            Console.WriteLine($"{phrase} {events} {author} – {city}.");
        }
    }
}
