namespace overloaded_operator
{
    public class Demo
    {
        private int x;

        public Demo(int x)
        {
            this.x = x;
        }

        public override string ToString()
        {
            return $"{nameof(x)}: {x}";
        }

        public static Demo operator +(Demo demo1, Demo demo2)
        {
            return new Demo(demo1.x + demo2.x);
        }
    }
}