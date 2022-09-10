using System;

namespace IEqualityComparerDemo
{
    public class Box
    {
        public Box(int h, int l, int w)
        {
            this.Height = h;
            this.Length = l;
            this.Width = w;
        }

        public int Height { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }

        public override String ToString()
        {
            return String.Format("({0}, {1}, {2})", Height, Length, Width);
        }
    }
}