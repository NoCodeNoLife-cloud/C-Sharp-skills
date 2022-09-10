using System.Linq;

namespace Extension_methods_demo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // use linq extend methods
            int[] ints = {10, 45, 15, 39, 21, 26};
            var result = ints.OrderBy(g => g);
            foreach (var i in result)
            {
                System.Console.Write(i + " ");
            }

            // use Custom methods
            string s1 = "Hello Extension Methods";
            int i2 = s1.WordCount();

            string s2 = "Hello Extension Methods";
            int i3 = MyExtensions.WordCount(s2);
        }
    }
}