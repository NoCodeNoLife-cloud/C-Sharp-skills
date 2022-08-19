using System;
using System.IO;

namespace StreamReaderDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader("../../Program.cs");
            string temp;
            while ((temp = streamReader.ReadLine()) != null)
            {
                Console.Out.WriteLine($"{temp}");
            }
        }
    }
}