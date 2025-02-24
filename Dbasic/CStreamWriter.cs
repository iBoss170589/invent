// Decompiled with JetBrains decompiler
// Type: Dbasic.CStreamWriter
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

using System.IO;
using System.Text;


namespace Dbasic
{
    public class CStreamWriter : StreamWriter, IStream
    {
        public CStreamWriter(string path, bool append, Encoding encoding) : base(path, append, encoding)
        {
        }
    }
}
