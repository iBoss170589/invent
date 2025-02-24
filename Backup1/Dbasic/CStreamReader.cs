// Decompiled with JetBrains decompiler
// Type: Dbasic.CStreamReader
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

using System;
using System.IO;
using System.Text;

#nullable disable
namespace Dbasic
{
  public class CStreamReader(string path, Encoding encoding) : StreamReader(path, encoding), IStream
  {
    public void Flush() => throw new Exception("Readonly stream cannot be flushed.");
  }
}
