using System;
using System.Collections.Generic;

namespace the_initializer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Object constructor
            MyClass myClass = new MyClass {X = 10, Y = 20};
            Console.Out.WriteLine($"{myClass}");

            // Collection constructor
            List<MyClass> lists = new List<MyClass>
            {
                new MyClass {X = 10, Y = 3},
                new MyClass {X = 80, Y = 37},
                new MyClass {X = 69, Y = 46},
            };

            foreach (var item in lists)
            {
                Console.Out.WriteLine($"{item}");
            }
        }
    }
}