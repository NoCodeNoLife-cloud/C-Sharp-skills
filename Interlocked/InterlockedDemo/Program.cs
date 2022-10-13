using System;
using System.Threading;

namespace InterlockedDemo
{
    public class Demo
    {
        private int count = 0;

        public void DoThis(Object o)
        {
            lock (this)
            {
                Interlocked.Increment(ref count);
                Thread.Sleep(1000);
                Console.Out.WriteLine("count = " + count);
            }
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            Demo demo = new Demo();
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(demo.DoThis);
            }

            Thread.Sleep(10000);
        }
    }
}