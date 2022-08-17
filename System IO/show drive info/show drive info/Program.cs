using System;
using System.IO;

namespace show_drive_info
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            FileStream resFileStream = File.Open("../../res.txt", FileMode.Open);
            StreamWriter streamWriter = new StreamWriter(resFileStream);

            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                streamWriter.WriteLine("Drive {0}", d.Name);
                streamWriter.WriteLine("  Drive type: {0}", d.DriveType);
                if (d.IsReady == true)
                {
                    streamWriter.WriteLine("  Volume label: {0}", d.VolumeLabel);
                    streamWriter.WriteLine("  File system: {0}", d.DriveFormat);
                    streamWriter.WriteLine("  Available space to current user:{0, 15} bytes", d.AvailableFreeSpace);

                    streamWriter.WriteLine("  Total available space:          {0, 15} bytes", d.TotalFreeSpace);

                    streamWriter.WriteLine("  Total size of drive:            {0, 15} bytes ", d.TotalSize);
                }
            }
        }
    }
}