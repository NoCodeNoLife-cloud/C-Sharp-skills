using System;
using System.IO;

namespace PathDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string str = "../../Program.cs";
            //获得文件名
            Console.WriteLine(Path.GetFileName(str));
            //获得文件名但是不包含扩展名
            Console.WriteLine(Path.GetFileNameWithoutExtension(str));
            //获得文件的扩展名
            Console.WriteLine(Path.GetExtension(str));
            //获得文件所在的文件夹的名称
            Console.WriteLine(Path.GetDirectoryName(str));
            //获得文件所在的全路径
            Console.WriteLine(Path.GetFullPath(str));
            //连接两个字符串作为路径
            Console.WriteLine(Path.Combine(@"c:\a\", "b.txt"));
        }
    }
}