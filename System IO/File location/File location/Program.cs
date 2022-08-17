using System;
using System.IO;

namespace File_location
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 生成文件
            FileStream file = File.Create("./test.txt");
            // 文件原始路径
            Console.Out.WriteLine(file.Name);
        }
    }
}