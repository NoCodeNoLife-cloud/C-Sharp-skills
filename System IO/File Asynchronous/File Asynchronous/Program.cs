using System;
using System.IO;
using System.Text;

namespace File_Asynchronous
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteToFile();
        }

        static async void WriteToFile()
        {
            byte[] bytesToWrite = Encoding.Unicode.GetBytes("example text to write");
            using (FileStream createdFile = File.Create("../../text.txt", 4096, FileOptions.Asynchronous))
            {
                await createdFile.WriteAsync(bytesToWrite, 0, bytesToWrite.Length);
            }
        }
    }
}