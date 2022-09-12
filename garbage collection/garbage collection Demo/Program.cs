using System;

namespace garbage_collection_Demo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            {
                MyDerivedClass myDerivedClass = new MyDerivedClass();
            }
        }
    }

    class MyBaseClass
    {
        public MyBaseClass()
        {
        }

        ~MyBaseClass()
        {
            Console.Out.WriteLine("delete MyBaseClass");
        }
    }

    class MyDerivedClass : MyBaseClass
    {
        public MyDerivedClass()
        {
        }

        ~MyDerivedClass()
        {
            Console.Out.WriteLine("delete MyDerivedClass");
        }
    }
}