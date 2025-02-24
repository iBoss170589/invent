// Decompiled with JetBrains decompiler
// Type: Dbasic.DDouble
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

using System;


namespace Dbasic
{
    public struct DDouble
    {
        private double d;

        public DDouble(double d)
        {
            this.d = d;
        }

        public static double operator *(double a, DDouble b) => Math.Pow(a, b.d);

        public static implicit operator double(DDouble m) => m.d;
    }
}
