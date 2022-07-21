using System;

namespace NumericalTransformation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            short s = 5;
            int i = 10;
            double d = 30.56D;
            long l = 181845525L;
            float f = 52.155F;
            string str = "hello world";
            Console.Out.WriteLine("{0} {1} {2} {3} {4} {5}", s, i, d, l, f, str);

            // type convert
            double di = Convert.ToDouble(i);
            long li = Convert.ToInt64(i);
            Console.Out.WriteLine("{0} {1}", di, li);
            // and so on...

            // type parse
            string str1 = i.ToString();
            long sl = System.Int64.Parse(str1);
            Console.Out.WriteLine("{0} {1}", str1, sl);
            // and so on
        }
    }
}