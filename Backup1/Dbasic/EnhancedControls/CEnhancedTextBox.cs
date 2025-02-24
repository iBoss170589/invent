// Decompiled with JetBrains decompiler
// Type: Dbasic.EnhancedControls.CEnhancedTextBox
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace Dbasic.EnhancedControls
{
  public class CEnhancedTextBox : TextBox, IEnhancedControl, IText, IEnabled
  {
    public string name;
    public bool handled;
    private b4p b4p;
    private b4p.del1 delKeyPress;
    private b4p.del0 delGotFocus;
    private b4p.del0 delLostFocus;

    public CEnhancedTextBox(b4p b4p)
    {
      this.b4p = b4p;
      this.AcceptsReturn = true;
      this.AcceptsTab = true;
      this.WordWrap = true;
    }

    public string propName => this.name;

    private void KeyPressEvent(object sender, KeyPressEventArgs e)
    {
      this.handled = false;
      this.b4p.sender = this.name;
      string str = this.delKeyPress(e.KeyChar.ToString((IFormatProvider) b4p.cul));
      if (!this.handled)
        return;
      e.Handled = true;
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
        if (!this.b4p.htSubs.Contains((object) (this.name + "_keypress")))
          return;
        this.delKeyPress = (b4p.del1) this.b4p.htSubs[(object) (this.name + "_keypress")];
        this.KeyPress += new KeyPressEventHandler(this.KeyPressEvent);
      }
      catch
      {
        throw new Exception("Error assigning event to " + this.name.Remove(0, 1) + ".\nCheck the number of arguments of each event sub.");
      }
    }

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
          case "keypress":
            this.delKeyPress = (b4p.del1) this.b4p.htSubs[(object) subName];
            this.KeyPress += new KeyPressEventHandler(this.KeyPressEvent);
            break;
        }
      }
      catch
      {
        throw new Exception("Error assigning event to " + this.name.Remove(0, 1) + ".\nCheck the number of arguments of each event sub.");
      }
    }

    public bool multiline
    {
      get => this.Multiline;
      set
      {
        if (value)
        {
          this.Multiline = true;
          this.ScrollBars = ScrollBars.Vertical;
        }
        else
        {
          this.Multiline = false;
          this.ScrollBars = ScrollBars.None;
        }
      }
    }

    virtual bool IEnabled.get_Enabled() => this.Enabled;

    virtual void IEnabled.set_Enabled([In] bool obj0) => this.Enabled = obj0;
  }
}
