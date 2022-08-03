using System;

namespace Custom_collection_sort
{
    public class Point : IComparable
    {
        private double _x;
        private double _y;

        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public Point() : this(0.0, 0.0)
        {
        }

        public int CompareTo(object obj)
        {
            Point point = (Point) obj;
            if (_x == point._x)
            {
                if (_y < point._y)
                {
                    return 1;
                }
                else if (_y == point._y)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else if (_x < point._x)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return $"{nameof(_x)}: {_x}, {nameof(_y)}: {_y}";
        }
    }
}