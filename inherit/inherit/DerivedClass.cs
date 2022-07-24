using System;

namespace inherit
{
    public class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            Console.Out.WriteLine("call derived constructor");
        }
    }
}