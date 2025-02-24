// Decompiled with JetBrains decompiler
// Type: Dbasic.EnhancedControls.CEnhancedNumUpDown
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace Dbasic.EnhancedControls
{
  public class CEnhancedNumUpDown : NumericUpDown, IEnhancedControl, IEnabled
  {
    public string name;
    private b4p b4p;
    private b4p.del0 delValueChanged;

    public CEnhancedNumUpDown(b4p b4p)
    {
      this.b4p = b4p;
      this.Maximum = 100M;
      this.Minimum = 0M;
      this.Value = 0M;
    }

    public string propName => this.name;

    public void AddEvents()
    {
      try
      {
        if (!this.b4p.htSubs.Contains((object) (this.name + "_valuechanged")))
          return;
        this.delValueChanged = (b4p.del0) this.b4p.htSubs[(object) (this.name + "_valuechanged")];
        this.ValueChanged += new EventHandler(this.ValueChangedEvent);
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
        case "valuechanged":
          this.delValueChanged = (b4p.del0) this.b4p.htSubs[(object) subName];
          this.ValueChanged += new EventHandler(this.ValueChangedEvent);
          break;
      }
    }

    private void ValueChangedEvent(object sender, EventArgs e)
    {
      this.b4p.sender = this.name;
      string str = this.delValueChanged();
    }

    virtual bool IEnabled.get_Enabled() => this.Enabled;

    virtual void IEnabled.set_Enabled([In] bool obj0) => this.Enabled = obj0;
  }
}
