// Decompiled with JetBrains decompiler
// Type: Dbasic.CStreamRandom
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

using System.IO;


namespace Dbasic
{
    public class CStreamRandom : FileStream, IStream
    {
        public CStreamRandom(string path, FileMode fileMode, FileAccess fileAccess) : base(path, fileMode, fileAccess)
        {
        }
    }
}
