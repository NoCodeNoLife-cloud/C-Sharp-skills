using System;
using System.Collections.Generic;
using System.Linq;

namespace Enumerable_Union_Demo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] ints1 = {5, 3, 9, 7, 5, 9, 3, 7};
            int[] ints2 = {8, 3, 6, 4, 4, 9, 1, 0};

            IEnumerator<int> enumerator = (from i in ints1.Union(ints2) orderby i ascending select i).GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Out.Write($"{enumerator.Current} ");
            }

            Console.Out.WriteLine();
            // Comparer

            Product[] store10 =
            {
                new Product {Name = "apple", Code = 9},
                new Product {Name = "orange", Code = 4}
            };

            Product[] store20 =
            {
                new Product {Name = "apple", Code = 9},
                new Product {Name = "lemon", Code = 12}
            };

            //Get the products from the both arrays
            //excluding duplicates.

            IEnumerable<Product> union =
                store10.Union(store20, new ProductComparer());

            foreach (Product product in union)
                Console.WriteLine(product.Name + " " + product.Code);
        }
    }
}