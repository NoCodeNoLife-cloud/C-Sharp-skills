using System;

namespace deep_copy
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyClass myClass = new MyClass(4, 5);
            // shallow copy
            MyClass shallow = myClass;
            shallow.X = 10;
            // also myClass changed
            Console.Out.WriteLine($"{myClass}");

            // deep copy
            MyClass deep = (MyClass) myClass.Clone();
            deep.X = 20;
            // myClass not changed
            Console.Out.WriteLine($"{myClass}");
        }
    }
}