using System;
using System.Diagnostics;

namespace Debug_WriteLine
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Trace.WriteLine("this is debug information");
            Debug.WriteLine("this is debug information");
            Console.WriteLine("this is console information");
        }
    }
}