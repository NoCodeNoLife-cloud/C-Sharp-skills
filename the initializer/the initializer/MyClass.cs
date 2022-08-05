namespace the_initializer
{
    public class MyClass
    {
        public int X { get; set; }
        public double Y { get; set; }

        public override string ToString()
        {
            return $"{nameof(X)}: {X}, {nameof(Y)}: {Y}";
        }
    }
}