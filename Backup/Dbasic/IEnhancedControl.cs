// Decompiled with JetBrains decompiler
// Type: Dbasic.IEnhancedControl
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

#nullable disable
namespace Dbasic
{
  public interface IEnhancedControl
  {
    string propName { get; }

    void AddRunTimeEvent(string eventName, string subName);
  }
}
