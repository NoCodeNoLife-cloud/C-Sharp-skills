using System;

namespace class_demo
{
    public class BaseClass
    {
        public class NestedClass
        {
            public void Functional()
            {
                Console.Out.WriteLine("this is inner function");
            }

            public NestedClass()
            {
                Console.Out.WriteLine("this is inner class");
            }
        }

        /// <summary>
        /// value
        /// </summary>
        private int x;

        public double y;

        /// <summary>
        /// default constructor
        /// </summary>
        public BaseClass()
        {
            x = 0;
            y = 0;
        }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public BaseClass(int x, double y)
        {
            Console.Out.WriteLine("call constructor");
            this.x = x;
            this.y = y;
        }

        ~BaseClass()
        {
            Console.Out.WriteLine("call destructor");
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

        static public void Function()
        {
            Console.Out.WriteLine("Hello World");
        }
    }
}