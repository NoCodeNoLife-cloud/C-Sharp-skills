using System;

namespace structDemo
{
    internal class Program
    {
        struct Demo
        {
            private int x;
            private double y;
            private string z;

            public Demo(int x, double y, string z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }

            public override string ToString()
            {
                return $"{nameof(x)}: {x}, {nameof(y)}: {y}, {nameof(z)}: {z}";
            }
        }

        public static void Main(string[] args)
        {
            Demo demo = new Demo(1, 10.45, "hello");
            Console.Out.WriteLine($"{demo}");
        }
    }
}