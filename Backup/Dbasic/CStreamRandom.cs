﻿// Decompiled with JetBrains decompiler
// Type: Dbasic.CStreamRandom
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

using System.IO;

#nullable disable
namespace Dbasic
{
  public class CStreamRandom(string path, FileMode fileMode, FileAccess fileAccess) : 
    FileStream(path, fileMode, fileAccess),
    IStream
  {
  }
}
