using System;
using System.Collections.Specialized;

namespace BitVector32Demo
{
    internal class Program
    {
        public static void Test1()
        {
            // Creates and initializes a BitVector32 with all bit flags set to FALSE.
            BitVector32 myBV = new BitVector32(0);

            // Creates masks to isolate each of the first five bit flags.
            int myBit1 = BitVector32.CreateMask();
            int myBit2 = BitVector32.CreateMask(myBit1);
            int myBit3 = BitVector32.CreateMask(myBit2);
            int myBit4 = BitVector32.CreateMask(myBit3);
            int myBit5 = BitVector32.CreateMask(myBit4);

            // Sets the alternating bits to TRUE.
            Console.WriteLine("Setting alternating bits to TRUE:");
            Console.WriteLine("   Initial:         {0}", myBV.ToString());
            myBV[myBit1] = true;
            Console.WriteLine("   myBit1 = TRUE:   {0}", myBV.ToString());
            myBV[myBit3] = true;
            Console.WriteLine("   myBit3 = TRUE:   {0}", myBV.ToString());
            myBV[myBit5] = true;
            Console.WriteLine("   myBit5 = TRUE:   {0}", myBV.ToString());
        }

        public static void Test2()
        {
            // Creates and initializes a BitVector32 with all bit flags set to FALSE.
            BitVector32 myBV = new BitVector32(0);

            // Creates masks to isolate each of the first five bit flags.
            int myBit1 = BitVector32.CreateMask();
            int myBit2 = BitVector32.CreateMask(myBit1);
            int myBit3 = BitVector32.CreateMask(myBit2);
            int myBit4 = BitVector32.CreateMask(myBit3);
            int myBit5 = BitVector32.CreateMask(myBit4);

            // Sets the alternating bits to TRUE.
            Console.WriteLine("Setting alternating bits to TRUE:");
            Console.WriteLine("   Initial:         {0}", myBV.ToString());
            myBV[myBit1] = true;
            Console.WriteLine("   myBit1 = TRUE:   {0}", myBV.ToString());
            myBV[myBit3] = true;
            Console.WriteLine("   myBit3 = TRUE:   {0}", myBV.ToString());
            myBV[myBit5] = true;
            Console.WriteLine("   myBit5 = TRUE:   {0}", myBV.ToString());
        }

        public static void Main(string[] args)
        {
            Test1();
            Test2();
        }
    }
}