using System;

namespace IDisposeable_Demo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            {
                MyBaseClass myBaseClass = new MyBaseClass();
                myBaseClass.Dispose();
            }
        }
    }

    class MyBaseClass : IDisposable
    {
        private bool isDisposed;

        public MyBaseClass()
        {
            isDisposed = false;
        }

        public void Dispose()
        {
            Console.Out.WriteLine("dispose MyBaseClass");
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    Console.Out.WriteLine($"cleanup managed objects by calling");
                }
            }

            isDisposed = true;
        }

        ~MyBaseClass()
        {
            Dispose(false);
        }
    }
}