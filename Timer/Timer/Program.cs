using System;
using System.Threading;
using System.Timers;
using Timer = System.Timers.Timer;

namespace Timer_demo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Timer timer = new Timer(1000);
            timer.Elapsed += new ElapsedEventHandler(func);
            timer.Start();
            System.Threading.Thread.Sleep(5000);
        }

        public static void func(Object source, ElapsedEventArgs e)
        {
            Console.Out.Write("exec ");
        }
    }
}