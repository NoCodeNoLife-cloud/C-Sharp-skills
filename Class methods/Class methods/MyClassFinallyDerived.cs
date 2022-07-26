using System;

namespace Class_methods
{
    public sealed class MyClassFinallyDerived : MyClassDerived
    {
        new public void HideMethod()
        {
            // call base class method
            base.HideMethod();
            Console.Out.WriteLine("this is override hide mothod");
        }
    }
}