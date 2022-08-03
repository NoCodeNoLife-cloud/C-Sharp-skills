using System;

namespace operator_overloading
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyClass myClass1 = new MyClass(3, 4);
            MyClass myClass2 = new MyClass(8, 9);
            Console.Out.WriteLine($"myClass1-myClass2={myClass1 - myClass2}");
            Console.Out.WriteLine($"myClass1+myClass2={myClass1 + myClass2}");

            Console.Out.WriteLine($"{(new MyClass(1, 1) < (new MyClass(1, 2)))}");
            Console.Out.WriteLine($"{(new MyClass(1, 1) > (new MyClass(1, 0)))}");
            Console.Out.WriteLine($"{(new MyClass(0, 1) >= (new MyClass(0, 1)))}");
            Console.Out.WriteLine($"{(new MyClass(0, 1) <= (new MyClass(0, 1)))}");
            Console.Out.WriteLine($"{(new MyClass(0, 1) == (new MyClass(0, 1)))}");
            Console.Out.WriteLine($"{(new MyClass(0, 1) != (new MyClass(0, 2)))}");
        }
    }
}