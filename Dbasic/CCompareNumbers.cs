// Decompiled with JetBrains decompiler
// Type: Dbasic.CCompareNumbers
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

using System;
using System.Collections;

namespace Dbasic
{
  public class CCompareNumbers : IComparer
  {
    public int Compare(object x, object y)
    {
      return double.Parse(x.ToString(), (IFormatProvider) b4p.cul).CompareTo(double.Parse(y.ToString(), (IFormatProvider) b4p.cul));
    }
  }
}
