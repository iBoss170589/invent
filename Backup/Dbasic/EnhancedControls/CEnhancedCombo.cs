// Decompiled with JetBrains decompiler
// Type: Dbasic.EnhancedControls.CEnhancedCombo
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace Dbasic.EnhancedControls
{
  public class CEnhancedCombo : ComboBox, IEnhancedControl, IEnabled, IText
  {
    public string name;
    private b4p b4p;
    private b4p.del0 delGotFocus;
    private b4p.del0 delLostFocus;
    private b4p.del2 delIndexChanged;

    public CEnhancedCombo(b4p b4p) => this.b4p = b4p;

    public string propName => this.name;

    public void AddRunTimeEvent(string eventName, string subName)
    {
      try
      {
        switch (eventName)
        {
          case "gotfocus":
            this.delGotFocus = (b4p.del0) this.b4p.htSubs[(object) subName];
            this.GotFocus += new EventHandler(this.GotFocusEvent);
            break;
          case "lostfocus":
            this.delLostFocus = (b4p.del0) this.b4p.htSubs[(object) subName];
            this.LostFocus += new EventHandler(this.LostFocusEvent);
            break;
          case "selectionchanged":
            this.delIndexChanged = (b4p.del2) this.b4p.htSubs[(object) subName];
            this.SelectedIndexChanged += new EventHandler(this.SelectedIndexChangedEvent);
            break;
        }
      }
      catch
      {
        throw new Exception("Error assigning event to " + this.name.Remove(0, 1) + ".\nCheck the number of arguments of each event sub.");
      }
    }

    private void GotFocusEvent(object sender, EventArgs e)
    {
      this.b4p.sender = this.name;
      string str = this.delGotFocus();
    }

    private void LostFocusEvent(object sender, EventArgs e)
    {
      this.b4p.sender = this.name;
      string str = this.delLostFocus();
    }

    private void SelectedIndexChangedEvent(object sender, EventArgs e)
    {
      this.b4p.sender = this.name;
      string str = this.delIndexChanged(this.SelectedIndex.ToString((IFormatProvider) b4p.cul), this.SelectedIndex > -1 ? this.SelectedItem.ToString() : "");
    }

    public void AddEvents()
    {
      try
      {
        if (this.b4p.htSubs.Contains((object) (this.name + "_gotfocus")))
        {
          this.delGotFocus = (b4p.del0) this.b4p.htSubs[(object) (this.name + "_gotfocus")];
          this.GotFocus += new EventHandler(this.GotFocusEvent);
        }
        if (this.b4p.htSubs.Contains((object) (this.name + "_lostfocus")))
        {
          this.delLostFocus = (b4p.del0) this.b4p.htSubs[(object) (this.name + "_lostfocus")];
          this.LostFocus += new EventHandler(this.LostFocusEvent);
        }
        if (!this.b4p.htSubs.Contains((object) (this.name + "_selectionchanged")))
          return;
        this.delIndexChanged = (b4p.del2) this.b4p.htSubs[(object) (this.name + "_selectionchanged")];
        this.SelectedIndexChanged += new EventHandler(this.SelectedIndexChangedEvent);
      }
      catch
      {
        throw new Exception("Error assigning event to " + this.name.Remove(0, 1) + ".\nCheck the number of arguments of each event sub.");
      }
    }

    virtual bool IEnabled.get_Enabled() => this.Enabled;

    virtual void IEnabled.set_Enabled([In] bool obj0) => this.Enabled = obj0;
  }
}
