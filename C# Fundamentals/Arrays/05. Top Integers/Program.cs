﻿using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] inputArr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            for (long i = 0; i < inputArr.Length; i++)
            {
                bool isItBigger = true;
                for (long j = i + 1; j < inputArr.Length; j++)
                {
                    if (inputArr[i] <= inputArr[j])
                    {
                        isItBigger = false;
                    }
                }

                if (isItBigger)
                {
                    Console.Write(inputArr[i] + " ");
                }
            }
        }
    }
}
