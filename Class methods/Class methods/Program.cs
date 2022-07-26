using System;

namespace Class_methods
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyClassBase myClassBase = new MyClassDerived();
            myClassBase.AbstractMethod();
            myClassBase.VirtualMethod();
            Console.Out.WriteLine(Console.Out.NewLine);

            MyClassDerived myClassDerived = new MyClassDerived();
            myClassDerived.AbstractMethod();
            myClassDerived.VirtualMethod();
            myClassDerived.HideMethod(); // be different with virtual method
            Console.Out.WriteLine(Console.Out.NewLine);

            MyClassFinallyDerived myClassFinallyDerived = new MyClassFinallyDerived();
            myClassFinallyDerived.HideMethod();
        }
    }
}