using System;

namespace Class_methods
{
    public class MyClassDerived : MyClassBase
    {
        /// <summary>
        /// override abstract method
        /// </summary>
        public override void AbstractMethod()
        {
            Console.Out.WriteLine("this is override abstract method");
        }

        /// <summary>
        /// override virtual method
        /// </summary>
        public override void VirtualMethod()
        {
            Console.Out.WriteLine("this is override virtual method");
        }

        /// <summary>
        /// hide method
        /// </summary>
        public void HideMethod()
        {
            // call this class method
            this.VirtualMethod();
            Console.Out.WriteLine("this is hide method");
        }
    }
}