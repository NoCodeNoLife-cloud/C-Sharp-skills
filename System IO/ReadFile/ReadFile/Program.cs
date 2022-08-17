using System;
using System.IO;
using System.Text;

namespace ReadFile
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            byte[] byteData = new byte[200];
            char[] charData = new char[200];
            try
            {
                FileStream aFile = new FileStream("../../Program.cs", FileMode.Open);
                aFile.Seek(174, SeekOrigin.Begin);
                aFile.Read(byteData, 0, 200);
            }
            catch (IOException e)
            {
                Console.Out.WriteLine(e.StackTrace);
                return;
            }

            Decoder d = Encoding.UTF8.GetDecoder();
            d.GetChars(byteData, 0, byteData.Length, charData, 0);
            Console.Out.WriteLine(charData);
            return;
        }
    }
}