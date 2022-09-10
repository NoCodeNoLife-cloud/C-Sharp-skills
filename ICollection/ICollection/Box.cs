using System;

namespace ICollectionDemo
{
    public class Box : IEquatable<Box>
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

        // Defines equality using the
        // BoxSameDimensions equality comparer.
        public bool Equals(Box other)
        {
            if (new BoxSameDimensions().Equals(this, other))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}