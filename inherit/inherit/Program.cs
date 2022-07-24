using System;

namespace inherit
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BaseClass baseClass = new BaseClass();
            Console.Out.WriteLine();
            DerivedClass derivedClass = new DerivedClass();
        }
    }
}