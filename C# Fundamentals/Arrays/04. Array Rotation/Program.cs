using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numberRotations = int.Parse(Console.ReadLine());


            if (numberRotations == array.Length)
            {
                Console.WriteLine(string.Join(" ", array));
                return;
            }
            else if (numberRotations > array.Length)
            {
                numberRotations = numberRotations - array.Length;
            }

            int[] b = new int[numberRotations];
            Array.Copy(array, 0, b, 0, numberRotations);

            int[] c = new int[array.Length - numberRotations];
            Array.Copy(array, numberRotations, c, 0, array.Length - numberRotations);

            Console.WriteLine($"{String.Concat(String.Join(" ", c))} {String.Concat(String.Join(" ", b))}");
        }
    }
}
