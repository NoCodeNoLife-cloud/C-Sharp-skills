using System;
using System.IO;
using System.Linq.Expressions;
using System.Text;

namespace MemoryStreamDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            byte[] bytes = Encoding.UTF8.GetBytes("hello");
            MemoryStream memoryStream = new MemoryStream(bytes);
            byte[] res = new byte[50];
            memoryStream.Read(res, 0, bytes.Length);
            foreach (byte item in res)
            {
                Console.Out.Write($"{Convert.ToChar(item)}");
            }
        }
    }
}