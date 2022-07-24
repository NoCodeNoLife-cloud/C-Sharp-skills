using System;
using System.Diagnostics;

namespace delegate_demo
{
    internal class Program
    {
        delegate double ProcessDelegate(double param1, double param2);

        static double Multiply(double param1, double param2) => param1 * param2;
        static double Divide(double param1, double param2) => param1 / param2;

        public static void Main(string[] args)
        {
            ProcessDelegate process;
            Console.Out.WriteLine("Enter 2 numbers separated with a comma:");
            string input = Console.In.ReadLine();
            int commaPos = input.IndexOf(',');
            double param1 = Convert.ToDouble(input.Substring(0, commaPos));
            double param2 = Convert.ToDouble(input.Substring(commaPos + 1, input.Length - commaPos - 1));
            Console.Out.WriteLine("Enter M to multiply or D to divide");
            input = Console.In.ReadLine();
            if (input.ToLower() == "m")
            {
                process = new ProcessDelegate(Multiply);
            }
            else if (input.ToLower() == "d")
            {
                process = new ProcessDelegate(Divide);
            }
            else
            {
                Console.Out.WriteLine("input error");
                return;
            }

            Console.Out.WriteLine($"Result: {process(param1, param2)}");
        }
    }
}