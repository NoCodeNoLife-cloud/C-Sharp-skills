﻿using System;
using System.Linq;
using static System.Console;

namespace LargeNumberQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = generateLotsOfNumbers(12345678);

            WriteLine("Numbers less than 1000:");

            var queryResults =
                    from n in numbers
                    where n < 1000
                    select n
                ;

            foreach (var item in queryResults)
            {
                WriteLine(item);
            }
        }


        private static int[] generateLotsOfNumbers(int count)
        {
            Random generator = new Random(0);
            int[] result = new int[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = generator.Next();
                //WriteLine(i + " " + result[i]);
            }

            return result;
        }
    }
}