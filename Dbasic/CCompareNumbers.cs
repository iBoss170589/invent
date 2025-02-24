namespace Dbasic
{
    using System;
    using System.Collections;

    public class CCompareNumbers : IComparer
    {
        public int Compare(object x, object y) => 
            double.Parse(x.ToString(), b4p.cul).CompareTo(double.Parse(y.ToString(), b4p.cul));
    }
}

