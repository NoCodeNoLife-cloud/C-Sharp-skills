using System;

namespace string_type
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // assign
            string str = "Hello World";

            // ToCharArray
            char[] chars = str.ToCharArray();
            foreach (char item in chars)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.Write(Console.Out.NewLine);

            // Length
            Console.Out.WriteLine($"this string is {str.Length} length");

            // toggle case
            // upper
            Console.Out.WriteLine($"{str.ToUpper()}");
            // lower
            Console.Out.WriteLine($"{str.ToLower()}");

            string stringWithSpace = " Hello World  ";
            if (stringWithSpace.Trim() == str)
            {
                Console.Out.WriteLine("stringWithSpace.Trim() == str");
            }

            // add space
            Console.Out.WriteLine($"str.PadLeft(15) = {{{str.PadLeft(15)}}}");
            Console.Out.WriteLine($"str.PadRight(15) = {{{str.PadRight(15)}}}");

            // fill character
            Console.Out.WriteLine($"str.PadLeft(15),'-' = {{{str.PadLeft(15, '-')}}}");
            Console.Out.WriteLine($"str.PadRight(15),'-' = {{{str.PadRight(15, '-')}}}");
        }
    }
}