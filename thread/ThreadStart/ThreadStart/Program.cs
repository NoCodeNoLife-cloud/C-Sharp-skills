using System;
using System.Threading;

namespace ThreadStartDemo
{
    internal class Program
    {
        static void Main()
        {
            Thread t1 = new Thread(new ThreadStart(ThreadMain));
            t1.Start();
            Console.WriteLine("this is the main thread.");
        }

        static void ThreadMain()
        {
            Console.WriteLine("Running in a thread.");
        }
    }
}