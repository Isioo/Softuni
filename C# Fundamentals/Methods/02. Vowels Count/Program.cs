using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            PrintVoweIsCount(text);
        }

        static void PrintVoweIsCount(string text)
        {
            int count = 0;
            foreach (char c in text.ToLower())
            {
                bool isVowel = IsVowel(c);

                if (isVowel)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        static bool IsVowel(char character)
        {
            bool isVowel = false;
            switch (character)
            {
                case 'a':
                case 'o':
                case 'e':
                case 'u':
                case 'i':
                    isVowel = true;
                    break;
            }
            return isVowel;
        }
    }
}
