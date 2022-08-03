using System;

namespace is_operator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // interface
            MyInterfaceDerived myInterfaceDerived = new MyInterfaceDerived();
            if (myInterfaceDerived is MyInterfaceDerived)
            {
                Console.Out.WriteLine("myInterfaceDerived is MyInterfaceDerived");
            }

            if (myInterfaceDerived is MyInterface)
            {
                Console.Out.WriteLine("myInterfaceDerived is MyInterface");
            }

            // class
            MyClass myClass = new MyClass();
            if (myClass is MyInterfaceDerived)
            {
                Console.Out.WriteLine("myClass is MyInterfaceDerived");
            }
            if (myClass is MyInterface)
            {
                Console.Out.WriteLine("myClass is MyInterface");
            }
        }
    }
}