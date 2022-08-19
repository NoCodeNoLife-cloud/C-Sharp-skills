﻿using System.IO;

namespace StreamWriterDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (StreamReader streamReader = new StreamReader("../../Program.cs"))
            {
                using (StreamWriter streamWriter = new StreamWriter("../../res.txt"))
                {
                    string temp;
                    while ((temp = streamReader.ReadLine()) != null)
                    {
                        streamWriter.WriteLine(temp);
                    }
                }
            }
        }
    }
}