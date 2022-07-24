using System;

namespace class_demo
{
    internal class Program
    {
        private class BaseClass
        {
            /// <summary>
            /// value
            /// </summary>
            private int x;

            public double y;

            /// <summary>
            /// constructor
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            public BaseClass(int x, double y)
            {
                this.x = x;
                this.y = y;
            }

            /// <summary>
            /// override format
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return $"{nameof(x)}: {x}, {nameof(y)}: {y}";
            }

            /// <summary>
            /// properties
            /// </summary>
            public int X
            {
                get => x;
                set => x = value;
            }

            public double Y
            {
                get => y;
                set => y = value;
            }

            static public void function()
            {
                Console.Out.WriteLine("Hello World");
            }
        }

        public static void Main(string[] args)
        {
            BaseClass.function();
            // create class
            BaseClass baseClass = new BaseClass(3, 2.7);
            // format string
            Console.Out.WriteLine($"{baseClass}");
        }
    }
}