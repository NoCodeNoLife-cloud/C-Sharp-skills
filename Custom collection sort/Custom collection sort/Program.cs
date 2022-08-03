using System;
using System.Collections.Generic;

namespace Custom_collection_sort
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            List<Point> list = new List<Point>();
            for (int i = 0; i < 20; i++)
            {
                list.Add(new Point(random.Next(0, 5) /*+ random.NextDouble()*/, random.Next(0, 5) /*+ random.NextDouble()*/));
            }

            list.Sort(new PointComparer().Compare);
            foreach (Point item in list)
            {
                Console.Out.WriteLine($"{item}");
            }
        }
    }
}