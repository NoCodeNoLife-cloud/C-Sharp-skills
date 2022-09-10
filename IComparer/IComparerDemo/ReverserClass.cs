using System.Collections;

namespace IComparerDemo
{
    public class ReverserClass : IComparer
    {
        // Call CaseInsensitiveComparer.Compare with the parameters reversed.
        int IComparer.Compare(object x, object y)
        {
            return new CaseInsensitiveComparer().Compare(y, x);
        }
    }
}