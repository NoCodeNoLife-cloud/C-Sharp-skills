using System;

namespace as_operator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // actually is Cow type
            Cow cow = new Cow();
            // boxing
            Animal animal = cow;
            // then as Cow
            Cow res = cow as Cow;
            // check
            if (res != null)
            {
                Console.Out.WriteLine("not null");
            }
            else
            {
                Console.Out.WriteLine("is null");
            }
        }
    }
}