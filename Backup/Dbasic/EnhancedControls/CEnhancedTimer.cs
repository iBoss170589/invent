// Decompiled with JetBrains decompiler
// Type: Dbasic.EnhancedControls.CEnhancedTimer
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

using System;
using System.Windows.Forms;

#nullable disable
namespace Dbasic.EnhancedControls
{
  public class CEnhancedTimer : Timer, IEnhancedControl, IEnabled
  {
    public string name;
    private b4p b4p;
    private b4p.del0 delTick;

    public CEnhancedTimer(b4p b4p) => this.b4p = b4p;

    public string propName => this.name;

    public void AddEvents()
    {
      try
      {
        if (!this.b4p.htSubs.Contains((object) (this.name + "_tick")))
          return;
        this.delTick = (b4p.del0) this.b4p.htSubs[(object) (this.name + "_tick")];
        this.Tick += new EventHandler(this.TickEvent);
      }
      catch
      {
        throw new Exception("Error assigning event to " + this.name.Remove(0, 1) + ".\nCheck the number of arguments of each event sub.");
      }
    }

    public void AddRunTimeEvent(string eventName, string subName)
    {
      switch (eventName)
      {
        case "tick":
          this.delTick = (b4p.del0) this.b4p.htSubs[(object) subName];
          this.Tick += new EventHandler(this.TickEvent);
          break;
      }
    }

    private void TickEvent(object sender, EventArgs e)
    {
      this.b4p.sender = this.name;
      string str = this.delTick();
    }

    string IEnhancedControl.propName => this.name;
  }
}
