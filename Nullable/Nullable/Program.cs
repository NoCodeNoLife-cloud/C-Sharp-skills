using System;
using System.Data.SqlTypes;

namespace Nullable
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            System.Nullable<int> a = 5;
            System.Nullable<int> b = a * 25;
            Console.Out.WriteLine($"b={b}");

            int b_1 = (int) a * 25;
            Console.Out.WriteLine($"b_1={b_1}");

            int b_2 = a.Value * 25;
            Console.Out.WriteLine($"b_2={b_2}");

            // set a null
            a = null;

            int? b_3 = a * 5;
            Console.Out.WriteLine($"b_3={b_3}"); // a=null

            int? b_5 = a * 5 ?? 100; // a*5==null?a*5:100
            Console.Out.WriteLine($"b_5={b_5}"); // a is null so use default value 100

            Customer customer = null;
            customer?.func();// not throw exception
        }
    }

    public class Customer
    {
        public void func()
        {
            Console.Out.WriteLine("hello");
        }
    }
}