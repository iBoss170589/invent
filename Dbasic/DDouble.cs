namespace Dbasic
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct DDouble
    {
        private double d;
        public DDouble(double d)
        {
            this.d = d;
        }

        public static double operator *(double a, DDouble b) => 
            Math.Pow(a, (double) b);

        public static implicit operator double(DDouble m) => 
            m.d;
    }
}

