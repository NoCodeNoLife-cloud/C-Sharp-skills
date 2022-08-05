using System;
using System.Timers;

namespace Lambda_function
{
    public class MyClass
    {
        private readonly Timer _timer;

        public MyClass()
        {
            _timer = new Timer(500);
            // lambda function
            _timer.Elapsed += (object obj, ElapsedEventArgs e) => Console.Out.WriteLine("hello");
            Start();
        }

        public void Start()
        {
            _timer.Start();
        }
    }
}