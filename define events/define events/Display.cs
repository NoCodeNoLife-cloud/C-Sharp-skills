using System;

namespace define_events
{
    public class Display
    {
        public void DisplayMessage(object source, MessageArrivedEventArgs e)
        {
            Console.Out.WriteLine($"Message arrived from:{((Connection) source).Name}");
            Console.Out.WriteLine($"Message Text: {e.Message}");
        }
    }
}