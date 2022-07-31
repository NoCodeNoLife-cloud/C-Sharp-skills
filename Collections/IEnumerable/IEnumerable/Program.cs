using System;
using System.Collections;

namespace IEnumerableDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            foreach (string item in SimpleList())
            {
                Console.Out.WriteLine($"{item}");
            }
        }

        public static IEnumerable SimpleList()
        {
            yield return "string 1";
            yield return "string 2";
            yield return "string 3";
        }
    }
}