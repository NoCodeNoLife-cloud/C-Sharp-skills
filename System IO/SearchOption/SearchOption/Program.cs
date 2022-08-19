using System;
using System.IO;

namespace SearchOptionDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            if (!File.Exists("../../res.txt"))
            {
                File.Create("../../res.txt");
            }

            using (FileStream fileStream = new FileStream("../../res.txt", FileMode.Open, FileAccess.Write))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    // Specify the directory you want to manipulate.
                    string path = @"d:\";
                    string searchPattern = "c*";

                    DirectoryInfo di = new DirectoryInfo(path);
                    DirectoryInfo[] directories = di.GetDirectories(searchPattern, SearchOption.TopDirectoryOnly);

                    FileInfo[] files = di.GetFiles(searchPattern, SearchOption.TopDirectoryOnly);

                    streamWriter.WriteLine("Directories that begin with the letter \"c\" in {0}", path);
                    foreach (DirectoryInfo dir in directories)
                    {
                        streamWriter.WriteLine("{0,-25} {1,25}", dir.FullName, dir.LastWriteTime);
                    }

                    streamWriter.WriteLine();
                    streamWriter.WriteLine("Files that begin with the letter \"c\" in {0}", path);
                    foreach (FileInfo file in files)
                    {
                        streamWriter.WriteLine("{0,-25} {1,25}", file.Name, file.LastWriteTime);
                    }
                }
            }
        }
    }
}