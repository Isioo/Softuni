using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            char[] userToChar = user.ToCharArray();

            int passLength = 0;
            int passCount = 0;
            int key = 0;

            char[] keyArr = new char[userToChar.Length];
            for (int i = userToChar.Length - 1; i >= 0; i--)
            {
                keyArr[key] = userToChar[i];
                key++;
            }

            while (passCount != 4)
            {
                string pass = Console.ReadLine();
                char[] passToChar = pass.ToCharArray();

                for (int i = 0; i < passToChar.Length; i++)
                {
                    if (passToChar[i] == keyArr[i])
                    {
                        passLength += 1;
                    }
                }

                if (passLength == passToChar.Length)
                {
                    Console.WriteLine($"User {user} logged in.");
                    return;
                }
                else if (passCount != 3)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                passLength = 0;
                passCount += 1;
            }
            Console.WriteLine($"User {user} blocked!");
        }
    }
}
