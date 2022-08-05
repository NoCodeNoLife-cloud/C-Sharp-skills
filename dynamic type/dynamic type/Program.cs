using System;
using Microsoft.CSharp;
using Microsoft.CSharp.RuntimeBinder;

namespace dynamic_type
{
    internal class Program
    {
        static int callCount = 0;

        static dynamic GetValue()
        {
            if (callCount++ == 0)
            {
                return new MyClass1();
            }

            return new MyClass2();
        }

        public static void Main(string[] args)
        {
            try
            {
                dynamic firstResult = GetValue();
                dynamic secondResult = GetValue();
                Console.Out.WriteLine($"firstResult is: {firstResult.ToString()}");
                Console.Out.WriteLine($"secondResult is: {secondResult.ToString()}");
                Console.Out.WriteLine($"firstResult call: {firstResult.Add(2, 3)}");
                Console.Out.WriteLine($"secondResult is: {secondResult.Add(2, 3)}");
            }
            catch (RuntimeBinderException ex)
            {
                Console.Out.WriteLine($"{ex.Message}");
            }
        }
    }
}