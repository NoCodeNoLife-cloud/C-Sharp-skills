using System;

namespace function
{
    internal class Program
    {
        /// <summary>
        /// static function without return and parameter  
        /// </summary>
        private static void Function()
        {
            Console.Out.WriteLine("this is function");
        }

        /// <summary>
        /// function with return value but no parameter
        /// </summary>
        /// <returns></returns>
        private static int Function2()
        {
            return 2;
        }

        /// <summary>
        /// function with paramter but no return value
        /// </summary>
        /// <param name="i"></param>
        private static void Function3(int i)
        {
            Console.Out.WriteLine($"Math.Sqrt({i}) = {Math.Sqrt(i)}");
        }

        /// <summary>
        /// function pass value by reference
        /// </summary>
        /// <param name="i"></param>
        private static void Function4(ref int i)
        {
            i = 100;
        }

        /// <summary>
        /// Lambda function
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private static int Function5(int x, int y) => x * y;

        /// <summary>
        /// function use params
        /// </summary>
        /// <param name="vec"></param>
        /// <returns></returns>
        private static int sumVector(params int[] vec)
        {
            int res = 0;
            foreach (int item in vec)
            {
                res += item;
            }

            return res;
        }

        /// <summary>
        /// function use out parameter
        /// </summary>
        /// <param name="res"></param>
        /// <param name="vec"></param>
        private static void sumVector(out int res, params int[] vec)
        {
            res = 0;
            foreach (int item in vec)
            {
                res += item;
            }
        }

        public static void Main(string[] args)
        {
            Function();
            Console.Out.WriteLine($"this is function{Function2()}");
            Function3(9);
            int i = 10;
            Function4(ref i);
            Console.Out.WriteLine($"{i}");
            Console.Out.WriteLine($"{Function5(5, 10)}");
            Console.Out.WriteLine($"{sumVector(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)}");
            sumVector(out i, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.Out.WriteLine($"{i}");
        }
    }
}