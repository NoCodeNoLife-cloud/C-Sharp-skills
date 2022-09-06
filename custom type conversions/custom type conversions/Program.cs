using System;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace custom_type_conversions
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyClass myClass = new MyClass(5);
            int travers = (int) myClass;
            Console.Out.WriteLine(travers);
        }

        public class MyClass
        {
            private int _x;

            public MyClass(int x)
            {
                this._x = x;
            }

            public static explicit operator int(MyClass myClass)
            {
                return myClass._x;
            }
        }
    }
}