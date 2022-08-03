using System;

namespace implement_generic_classes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Node<int> node = new Node<int>();
            node.X = 40;
            node.Y = 100;
            Console.Out.WriteLine($"{node}");
        }
    }
}