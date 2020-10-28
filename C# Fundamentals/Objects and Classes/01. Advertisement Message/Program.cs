using System;

namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] Phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            String[] Events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            String[] Authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            String[] Cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            Random phrases = new Random();
            Random events = new Random();
            Random authors = new Random();
            Random cities = new Random();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int phraseIndex = phrases.Next(0, Phrases.Length);
                int eventIndex = phrases.Next(0, Events.Length);
                int authorIndex = phrases.Next(0, Authors.Length);
                int citiesIndex = phrases.Next(0, Cities.Length);
                Console.WriteLine($"{Phrases[phraseIndex]} {Events[eventIndex]} {Authors[authorIndex]} - {Cities[citiesIndex]}");
            }

        }
    }
}
