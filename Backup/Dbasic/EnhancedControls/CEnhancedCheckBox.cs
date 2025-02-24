// Decompiled with JetBrains decompiler
// Type: Dbasic.EnhancedControls.CEnhancedCheckBox
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace Dbasic.EnhancedControls
{
  public class CEnhancedCheckBox : CheckBox, IEnhancedControl, IText, IEnabled, IChecked
  {
    public string name;
    private b4p b4p;
    private b4p.del0 delClick;

    public CEnhancedCheckBox(b4p b4p) => this.b4p = b4p;

    public string propName => this.name;

    public void AddRunTimeEvent(string eventName, string subName)
    {
      try
      {
        switch (eventName)
        {
          case "click":
            this.delClick = (b4p.del0) this.b4p.htSubs[(object) subName];
            this.Click += new EventHandler(this.ClickEvent);
            break;
        }
      }
      catch
      {
        throw new Exception("Error assigning event to " + this.name.Remove(0, 1) + ".\nCheck the number of arguments of each event sub.");
      }
    }

    private void ClickEvent(object sender, EventArgs e)
    {
      if (this.Parent is Form)
      {
        if (this.Parent is CEnhancedForm && !((CEnhancedForm) this.Parent).activeState)
          return;
      }
      else
      {
        Control control = (Control) this;
        while (!(control.Parent is Form))
          control = control.Parent;
        if (control.Parent is CEnhancedForm && !((CEnhancedForm) control.Parent).activeState)
          return;
      }
      this.b4p.sender = this.name;
      string str = this.delClick();
    }

    public void AddEvents()
    {
      try
      {
        if (!this.b4p.htSubs.Contains((object) (this.name + "_click")))
          return;
        this.delClick = (b4p.del0) this.b4p.htSubs[(object) (this.name + "_click")];
        this.Click += new EventHandler(this.ClickEvent);
      }
      catch
      {
        throw new Exception("Error assigning event to " + this.name.Remove(0, 1) + ".\nCheck the number of arguments of each event sub.");
      }
    }

    virtual bool IEnabled.get_Enabled() => this.Enabled;

    virtual void IEnabled.set_Enabled([In] bool obj0) => this.Enabled = obj0;

    virtual bool IChecked.get_Checked() => this.Checked;

    virtual void IChecked.set_Checked([In] bool obj0) => this.Checked = obj0;
  }
}
