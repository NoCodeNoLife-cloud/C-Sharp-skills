using System;

namespace deep_copy
{
    public class MyClass : ICloneable
    {
        private double x;
        private double y;

        public double X
        {
            get => x;
            set => y = value;
        }

        public double Y
        {
            get => y;
            set => y = value;
        }

        public MyClass()
        {
            x = y = 0;
        }

        public MyClass(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public object Clone()
        {
            return new MyClass(x, y);
        }

        public override string ToString()
        {
            return $"{nameof(x)}: {x}, {nameof(y)}: {y}";
        }
    }
}