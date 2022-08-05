using System;

namespace define_events
{
    public class MessageArrivedEventArgs : EventArgs
    {
        private string _message;

        public string Message { get; set; }

        public MessageArrivedEventArgs()
        {
            _message = "No message sent.";
        }

        public MessageArrivedEventArgs(string newMessage)
        {
            _message = newMessage;
        }
    }
}