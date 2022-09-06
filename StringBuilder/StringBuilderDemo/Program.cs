using System;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace StringBuilderDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            StringBuilder greetingBuilder = new StringBuilder("Hello from all the guys at Wrox Press. ", 150);
            greetingBuilder.AppendFormat("We do hope you enjoy this book as much as we " + "enjoyed writing it");
            Console.Out.WriteLine("Not Encoded:\n" + greetingBuilder);

            for (int i = 'z'; i >= 'a'; i--)
            {
                char old1 = (char) i;
                char new1 = (char) (i + 1);
                greetingBuilder = greetingBuilder.Replace(old1, new1);
            }

            for (int i = 'Z'; i >= 'A'; i--)
            {
                char old1 = (char) i;
                char new1 = (char) (i + 1);
                greetingBuilder = greetingBuilder.Replace(old1, new1);
            }

            Console.Out.WriteLine("Encoded:\n" + greetingBuilder);
            stopwatch.Stop();
            Console.Out.WriteLine($"{stopwatch.Elapsed.Milliseconds}");
        }
    }
}