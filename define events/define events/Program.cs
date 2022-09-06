using System;
using System.Threading;

namespace define_events
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Connection myConnection1 = new Connection();
            myConnection1.Name = "First connection.";
            Connection myConnection2 = new Connection();
            myConnection2.Name = "Second connection.";
            myConnection1.MessageArrived +=
                delegate(object source, MessageArrivedEventArgs e)
                {
                    Console.Out.WriteLine($"Message arrived from:{((Connection) source).Name}");
                    Console.Out.WriteLine($"Message Text: {e.Message}");
                };
            myConnection2.MessageArrived +=
                delegate(object source, MessageArrivedEventArgs e)
                {
                    Console.Out.WriteLine($"Message arrived from:{((Connection) source).Name}");
                    Console.Out.WriteLine($"Message Text: {e.Message}");
                };
            myConnection1.Connect();
            myConnection2.Connect();
            System.Threading.Thread.Sleep(10000);
        }
    }
}