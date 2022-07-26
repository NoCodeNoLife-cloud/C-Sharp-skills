using System;

namespace Class_fields
{
    public class Test
    {
        // default valued
        private readonly int _x = 0;
        private static int _y = 1;
        private const int _z = 2;// const value must initialize here
        private int _w = 3;

        /// <summary>
        /// readonly properties
        /// </summary>
        public int X => _x;

        /// <summary>
        /// static properties
        /// </summary>
        public static int Y
        {
            get => _y;
            set => _y = value;
        }

        /// <summary>
        /// is not properties
        /// </summary>
        /// <returns></returns>
        public int Z() => _z;

        /// <summary>
        /// simple private value properties
        /// </summary>
        public int W
        {
            get => _w;
            set => _w = value;
        }

        /// <summary>
        /// constructor value
        /// </summary>
        /// <param name="x"></param>
        /// <param name="w"></param>
        public Test(int x, int y, int w)
        {
            _x = x;// readonly
            _y = y;// static
            // _z = 100;  ERROR: const value can't change
            _w = w;// so _w = 3 not effect
        }

        public override string ToString()
        {
            return $"{nameof(_x)}: {_x}";
        }

        /// <summary>
        /// change the value
        /// </summary>
        public void Alter()
        {
            // _x = 5;   readonly
            _y = 100;
            // _z = 4;   const
            _w = 101;
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            // Default value: _x = 0, _y = 1, _z = 2, _w = 3
            Test test = new Test(1000, 5, 10001);
            // init:_x = 1000, _y = 5, _z = 2, _w = 10001
            Console.Out.WriteLine($"{test.X} {Test.Y} {test.Z()} {test.W}");
            test.Alter();
            // _x = 1000, _y = 100, _z = 2, _w = 101
            Console.Out.WriteLine($"{test.X} {Test.Y} {test.Z()} {test.W}");
        }
    }
}