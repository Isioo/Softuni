using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();

            int maxLoad = int.Parse(Console.ReadLine());

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] actions = input.Split().ToArray();

                if (actions[0] == "Add")
                {
                    wagons.Add(int.Parse(actions[1]));
                }
                else
                {
                    int people = int.Parse(actions[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + people <= maxLoad)
                        {
                            wagons[i] += people;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(' ', wagons));
        }
    }
}
