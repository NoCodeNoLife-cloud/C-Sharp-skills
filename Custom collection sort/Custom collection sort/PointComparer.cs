using System;
using System.Collections;

namespace Custom_collection_sort
{
    public class PointComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Point && y is Point)
            {
                return ((Point) x).CompareTo(y);
            }
            else
            {
                throw new ArgumentException("error");
            }
        }
    }
}