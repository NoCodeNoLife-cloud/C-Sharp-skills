using System;
using System.Threading;

namespace TimerDemo
{
    internal class Program
    {
        static void TimeAction(object o)
        {
            Console.WriteLine("System.Threading.Timer {0:T}", DateTime.Now);
        }

        public static void Main(string[] args)
        {
            var t1 = new System.Threading.Timer(TimeAction, null, TimeSpan.FromSeconds(2), TimeSpan.FromSeconds(3));

            Thread.Sleep(15000);

            t1.Dispose();
        }
    }
}