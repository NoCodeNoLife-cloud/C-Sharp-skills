using System;

namespace events_trigger
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyEvent myEvent = new MyEvent("this is information");
            myEvent.myEvent += (sender, myArgs) => { Console.Out.WriteLine($"#1 {myArgs.Info}"); };
            myEvent.myEvent += (sender, myArgs) => { Console.Out.WriteLine($"#2 {myArgs.Info}"); };
            myEvent.RunEvent();
        }
    }

    /// <summary>
    /// 带有参数
    /// </summary>
    public class MyArgs
    {
        public string Info { get; set; }

        public MyArgs(string info)
        {
            Info = info;
        }
    }

    public class MyEvent
    {
        public event EventHandler<MyArgs> myEvent;
        public MyArgs myArgs { get; set; }

        public MyEvent(string inFo)
        {
            myArgs = new MyArgs(inFo);
        }

        public void RunEvent()
        {
            myEvent(this, myArgs);
        }
    }
}