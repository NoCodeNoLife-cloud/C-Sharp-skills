using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Distinct_Demo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 13; i++)
            {
                list.Add(random.Next(0, 10));
            }

            IEnumerator<int> enumerator = (from i in list.Distinct() orderby i ascending select i).GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Out.Write($"{enumerator.Current} ");
            }
        }
    }
}