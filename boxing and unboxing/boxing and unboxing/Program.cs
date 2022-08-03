using System;

namespace boxing_and_unboxing
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // class
            // boxing
            MyClass myClass = new MyClass();
            myClass.value = 15;
            Object wrapper = myClass;
            myClass.value = 20;
            // unboxing
            MyClass myClassUnpack = (MyClass) wrapper;
            Console.Out.WriteLine($"{myClassUnpack.value}");

            // interface
            // boxing
            MyInterfaceDerived myInterfaceDerived = new MyInterfaceDerived();
            myInterfaceDerived.value = 15;
            MyInterface myInterface = myInterfaceDerived;
            myInterfaceDerived.value = 20;
            // unboxing
            MyInterfaceDerived myInterfaceDerivedUnpack = (MyInterfaceDerived) myInterface;
            Console.Out.WriteLine($"{myInterfaceDerivedUnpack.value}");
            
            // struct
            // boxing
            MyStruct myStruct = new MyStruct();
            myStruct.value = 15;
            Object wrapper1 = myStruct;
            myStruct.value = 20;
            // unboxing
            MyStruct myStructUnpack = (MyStruct) myStruct;
            Console.Out.WriteLine($"{myStructUnpack.value}");
        }
    }

    public class MyClass
    {
        public int value;
    }

    public struct MyStruct
    {
        public double value;
    }

    public interface MyInterface
    {
    }

    public class MyInterfaceDerived : MyInterface
    {
        public int value;
    }
}