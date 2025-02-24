// Decompiled with JetBrains decompiler
// Type: Dbasic.CStreamReader
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

using System;
using System.IO;
using System.Text;


namespace Dbasic
{
    public class CStreamReader : StreamReader, IStream
    {
        public CStreamReader(string path, Encoding encoding) : base(path, encoding)
        {
        }

        public void Flush() => throw new Exception("Readonly stream cannot be flushed.");
    }
}
