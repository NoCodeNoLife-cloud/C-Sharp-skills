using System;

namespace IEquatableDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyClass myClass = new MyClass(1);
            MyClass myClass2 = new MyClass(1);
            if (myClass.Equals(myClass2))
            {
                Console.Out.WriteLine("true");
            }
            else
            {
                Console.Out.WriteLine("false");
            }

            MyClass myClass3 = new MyClass(2);
            if (myClass.Equals(myClass3))
            {
                Console.Out.WriteLine("true");
            }
            else
            {
                Console.Out.WriteLine("false");
            }
        }
    }

    public class MyClass : IEquatable<MyClass>
    {
        public int X { get; set; }

        public MyClass(int x)
        {
            this.X = x;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public bool Equals(MyClass other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("other");
            }
            else
            {
                if (other.X == this.X)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}