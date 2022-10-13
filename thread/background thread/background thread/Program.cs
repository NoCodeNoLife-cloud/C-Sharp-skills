using System;
using System.Threading;

namespace background_thread
{
    internal class Program
    {
        static void Main()
        {
            var t1 = new Thread(ThreadMain)
            {
                Name = "MyNewThread1", IsBackground = false
            };
            t1.Start();
            Console.WriteLine("Main thread ending now...");
        }

        static void ThreadMain()
        {
            Console.WriteLine("Thread {0} started", Thread.CurrentThread.Name);
            Thread.Sleep(3000);
            Console.WriteLine("Thread {0} completed", Thread.CurrentThread.Name);
        }
    }
}