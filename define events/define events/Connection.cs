using System;
using System.Timers;

namespace define_events
{
    // public delegate void MessageHandler(string messageText);

    public class Connection
    {
        private static readonly Random random = new Random();

        private readonly Timer _pollTimer;

        public Connection()
        {
            _pollTimer = new Timer(100);
            _pollTimer.Elapsed += CheckForMessage;
        }

        public string Name { get; set; }

        public event EventHandler<MessageArrivedEventArgs> MessageArrived;

        public void Connect()
        {
            _pollTimer.Start();
        }

        public void Disconnnect()
        {
            _pollTimer.Stop();
        }

        private void CheckForMessage(object source, ElapsedEventArgs e)
        {
            Console.Out.WriteLine("Checking for new message.");
            if (random.Next(9) == 0 && MessageArrived != null)
            {
                MessageArrived(this, new MessageArrivedEventArgs("Hello Mami!"));
            }
        }
    }
}