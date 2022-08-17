using System;
using System.IO;

namespace BufferedStream_demo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            if (!File.Exists("../../Program.cs"))
            {
                return;
            }

            FileStream fileStream = File.Open("../../Program.cs", FileMode.Open);
            
            // constructor
            BufferedStream bufferedStream = new BufferedStream(fileStream, 10);
            // CanRead
            Console.Out.WriteLine($"CanRead {bufferedStream.CanRead}");
            // CanSeek
            Console.Out.WriteLine($"CanSeek {bufferedStream.CanSeek}");
            // CanTimeout
            Console.Out.WriteLine($"CanTimeout {bufferedStream.CanTimeout}");
            // CanWrite
            Console.Out.WriteLine($"CanWrite {bufferedStream.CanWrite}");
            // Length
            Console.Out.WriteLine($"Length {bufferedStream.Length}");
            // Position
            Console.Out.WriteLine($"Position {bufferedStream.Position}");
            // ReadTimeout
            // Console.Out.WriteLine($"ReadTimeout {bufferedStream.ReadTimeout}");
            // WriteTimeout
            // Console.Out.WriteLine($"WriteTimeout {bufferedStream.WriteTimeout}");

            int temp;
            while ((temp = bufferedStream.ReadByte()) != -1)
            {
                // Write
                Console.Out.Write(Convert.ToChar(temp));
            }

            // Close
            bufferedStream.Close();


            FileStream fileStream1 = File.Open("../../text.txt", FileMode.Create);
            bufferedStream = new System.IO.BufferedStream(fileStream1, 10);
            string info = "hello world";
            foreach (char item in info)
            {
                // WriteByte
                bufferedStream.WriteByte(Convert.ToByte(item));
                // Flush()
                bufferedStream.Flush();
            }

            // Close()
            bufferedStream.Close();
        }
    }
}