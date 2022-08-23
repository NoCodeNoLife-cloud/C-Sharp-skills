using System.Linq;
using static System.Console;

namespace OrderQueryResults
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] names = {"Alonso", "Zheng", "Smith", "Jones", "Smythe", "Small", "Ruiz", "Hsieh", "Jorgenson", "Ilyich", "Singh", "Samba", "Fatimah"};

            var queryResults =
                from n in names
                where n.StartsWith("S")
                orderby n
                select n;

            WriteLine("Names beginning with S:");

            foreach (var item in queryResults)
            {
                WriteLine(item);
            }
        }
    }
}