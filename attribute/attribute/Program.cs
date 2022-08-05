using System;
using System.Diagnostics;

namespace attributeDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Type classType = typeof(DecoratedClass);
            Object[] customAttributes = classType.GetCustomAttributes(true);
            foreach (object item in customAttributes)
            {
                Console.Out.WriteLine($"attribute of type {item} found.");
            }
        }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    class DoesInterestingThingsAttribute : Attribute
    {
        public DoesInterestingThingsAttribute(int howManyTimes) => HowManyTimes = howManyTimes;

        public string WhatDoesItDo { get; set; }
        public int HowManyTimes { get; set; }
    }

    [DoesInterestingThings(1000, WhatDoesItDo = "Voodoo")]
    public class DecoratedClass
    {
    }
}