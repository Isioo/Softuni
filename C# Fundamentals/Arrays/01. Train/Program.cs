using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int people = int.Parse(Console.ReadLine());
                numbers[i] = people;
                sum += people;

            }
            Console.WriteLine(string.Join(separator: " ", numbers));
            Console.WriteLine(sum);
        }
    }
}
