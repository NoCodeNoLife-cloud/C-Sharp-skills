﻿using System;
using System.Collections.Generic;
using ICollectionDemo;

namespace ICollectionDemo
{
    public class BoxSameVol : EqualityComparer<Box>
    {
        public override bool Equals(Box b1, Box b2)
        {
            if ((b1.Height * b1.Length * b1.Width) ==
                (b2.Height * b2.Length * b2.Width))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode(Box bx)
        {
            int hCode = bx.Height ^ bx.Length ^ bx.Width;
            Console.WriteLine("HC: {0}", hCode.GetHashCode());
            return hCode.GetHashCode();
        }
    }
}