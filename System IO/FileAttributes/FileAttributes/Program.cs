using System;
using System.IO;

namespace FileAttributesDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            System.IO.FileAttributes attributes = File.GetAttributes("../../Program.cs");
            if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                Console.WriteLine("read-only file");
            }
            else
            {
                Console.WriteLine("not read-only file");
            }
        }
    }
}