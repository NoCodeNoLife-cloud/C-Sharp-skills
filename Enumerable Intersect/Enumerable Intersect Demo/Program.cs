using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Enumerable_Intersect_Demo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] id1 = {44, 26, 92, 30, 71, 38};
            int[] id2 = {39, 59, 83, 47, 26, 4, 30};

            IEnumerator<int> enumerator = (from i in id1.Intersect(id2) orderby i ascending select i).GetEnumerator();
        }
    }
}