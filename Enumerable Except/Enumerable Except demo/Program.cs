using System;
using System.Collections.Generic;
using System.Linq;

namespace Enumerable_Except_demo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double[] numbers1 = {2.0, 2.0, 2.1, 2.2, 2.3, 2.3, 2.4, 2.5};
            double[] numbers2 = {2.2};
            IEnumerator<double> enumerator = (from i in numbers1.Except(numbers2) orderby i ascending select i).GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Out.Write($"{enumerator.Current} ");
            }

            //--------------
            Product[] fruits1 =
            {
                new Product {Name = "apple", Code = 9},
                new Product {Name = "orange", Code = 4},
                new Product {Name = "lemon", Code = 12}
            };

            Product[] fruits2 = {new Product {Name = "apple", Code = 9}};

// Get all the elements from the first array
// except for the elements from the second array.

            IEnumerable<Product> except =
                fruits1.Except(fruits2, new ProductComparer());

            foreach (var product in except)
                Console.WriteLine(product.Name + " " + product.Code);
        }
    }
}