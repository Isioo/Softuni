using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split(separator: " ");
            string[] arrTwo = Console.ReadLine().Split(separator: " ");

            foreach (string elementTwo in arrTwo)
            {
                for (int i = 0; i < arrOne.Length; i++)
                {
                    string elementOne = arrOne[i];
                    if (elementTwo == elementOne)
                    {
                        Console.Write(elementOne + " ");
                        break;
                    }

                }
            }
        }
    }
}
