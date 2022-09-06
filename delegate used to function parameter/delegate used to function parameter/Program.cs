using System;

namespace delegate_used_to_function_parameter
{
    internal class Program
    {
        public delegate void Function();

        public static void Main(string[] args)
        {
            Run(Print);
        }

        public static void Run(Function func)
        {
            func();
        }

        public static void Print()
        {
            Console.Out.WriteLine("hello world");
        }
    }
}