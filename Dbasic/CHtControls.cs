// Decompiled with JetBrains decompiler
// Type: Dbasic.CHtControls
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

using System.Collections;
using System.Windows.Forms;


namespace Dbasic
{
  public class CHtControls : Hashtable
  {
    public static bool shouldScale;

    public override void Add(object key, object value)
    {
      base.Add(key, value);
      if (!CHtControls.shouldScale)
        return;
      object c = value;
      if (!(c is Control))
        return;
      Other.ScaleControls((Control) c);
    }
  }
}
