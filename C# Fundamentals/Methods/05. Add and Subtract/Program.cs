﻿using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            int SumRes = Sum(numOne, numTwo);
            int result = Substract(SumRes, numThree);
            Console.WriteLine(result);

        }

        static int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }

        static int Substract(int a, int b)
        {
            int result = a - b;
            return result;
        }
    }
}
