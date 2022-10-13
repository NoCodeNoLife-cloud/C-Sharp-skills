using System;
using System.Threading;

namespace MutexDemo
{
    public class Demo
    {
        public void function(Object o)
        {
            Mutex mutex = new Mutex(false, "mutex");
            mutex.WaitOne();
            Thread.Sleep(1000);
            Console.Out.WriteLine("wait...");
            mutex.ReleaseMutex();
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            Demo demo = new Demo();
            for (int i = 0; i < 4; i++)
            {
                ThreadPool.QueueUserWorkItem(demo.function);
            }

            Thread.Sleep(5000);
        }
    }
}