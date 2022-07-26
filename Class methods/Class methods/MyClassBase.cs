using System;

namespace Class_methods
{
    /// <summary>
    /// can't be implement
    /// </summary>
    public abstract class MyClassBase
    {
        /// <summary>
        /// be override
        /// </summary>
        public virtual void VirtualMethod()
        {
            Console.Out.WriteLine("this is virtual method");
        }

        /// <summary>
        /// this is abstract method
        /// no function body
        /// </summary>
        public abstract void AbstractMethod();
    }
}