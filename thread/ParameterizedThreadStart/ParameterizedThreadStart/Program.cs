using System;
using System.Threading;

namespace ParameterizedThreadStart
{
    public struct Data
    {
        public string Message;
    }

    internal class Program
    {
        static void ThreadMainWithParameters(object o)
        {
            Data d = (Data) o;
            Console.WriteLine("Running in a thread, received {0}", d.Message);
        }

        public static void Main(string[] args)
        {
            var d = new Data {Message = "Information1"};
            var t2 = new Thread(ThreadMainWithParameters);
            t2.Start(d);
        }
    }
}