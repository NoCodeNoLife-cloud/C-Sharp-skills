using System.Diagnostics;

namespace assert
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int i = 10;
            Debug.Assert(i < 10,"value","i>=10");
        }
    }
}