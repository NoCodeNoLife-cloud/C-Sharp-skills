using System;

namespace Type_inference
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var i = 4;
            var d = 4.5;
            var s = "hello";

            if (i is int)
            {
                Console.Out.WriteLine(($"{i.GetType()}"));
            }

            if (d.GetType() == typeof(double))
            {
                Console.Out.WriteLine(($"{d.GetType()}"));
            }

            if (s is string)
            {
                Console.Out.WriteLine(($"{s.GetType()}"));
            }

            MyClass myClass = new MyClass();
            if (myClass.GetType() == typeof(MyClass))
            {
                Console.Out.WriteLine(($"{myClass.GetType()}"));
            }
        }
    }
}