using System;
using System.IO;

namespace Directory_move
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string sourceDirectory = @"H:\programe\GitHub-project-warehouse-manager\C-Sharp-skills\System IO\Directory move\Directory move\bin\NewDirectory1";
            string archiveDirectory = @"H:\programe\GitHub-project-warehouse-manager\C-Sharp-skills\System IO\Directory move\Directory move\bin\NewDirectory2";

            try
            {
                var txtFiles = Directory.EnumerateFiles(sourceDirectory, "*.txt");

                foreach (string currentFile in txtFiles)
                {
                    string fileName = currentFile.Substring(sourceDirectory.Length + 1);
                    Directory.Move(currentFile, Path.Combine(archiveDirectory, fileName));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}