using System;

namespace overloading_conversion_operator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyClass1 myClass1 = new MyClass1(15);
            MyClass2 myClass2 = (MyClass2) myClass1;
            Console.Out.WriteLine($"{myClass2}");

            MyClass2 myClass3 = new MyClass2(15.2);
            MyClass1 myClass4 = (MyClass1) myClass3;
            Console.Out.WriteLine($"{myClass4}");
        }
    }
}