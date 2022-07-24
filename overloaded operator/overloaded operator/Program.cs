using System;

namespace overloaded_operator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Demo demo1 = new Demo(5);
            Demo demo2 = new Demo(4);
            Demo demo3 = demo1 + demo2;
            Console.Out.WriteLine($"{demo3}");
        }
    }
}