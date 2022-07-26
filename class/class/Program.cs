using System;

namespace class_demo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BaseClass.Function();
            // create class
            BaseClass baseClass = new BaseClass(3, 2.7);
            // format string
            Console.Out.WriteLine($"{baseClass}");
            // Classes are reference types
            BaseClass copy = baseClass;
            // change copy value not origin value
            copy.X = 100;
            copy.Y = 300;
            Console.Out.WriteLine($"{baseClass}");
            Console.Out.WriteLine(Console.Out.NewLine);

            BaseClass.NestedClass nestedClass = new BaseClass.NestedClass();
            nestedClass.Functional();
        }
    }
}