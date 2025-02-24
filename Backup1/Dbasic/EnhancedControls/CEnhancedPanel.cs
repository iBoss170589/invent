// Decompiled with JetBrains decompiler
// Type: Dbasic.EnhancedControls.CEnhancedPanel
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace Dbasic.EnhancedControls
{
  public class CEnhancedPanel : Panel, IEnhancedControl, IEnabled
  {
    public string name;
    private b4p b4p;
    private b4p.del2 delMouseDown;
    private b4p.del2 delMouseMove;
    private b4p.del2 delMouseUp;

    public CEnhancedPanel(b4p b4p) => this.b4p = b4p;

    public void AddRunTimeEvent(string eventName, string subName)
    {
      try
      {
        switch (eventName)
        {
          case "mousedown":
            this.delMouseDown = (b4p.del2) this.b4p.htSubs[(object) subName];
            this.MouseDown += new MouseEventHandler(this.MouseDownEvent);
            break;
          case "mousemove":
            this.delMouseMove = (b4p.del2) this.b4p.htSubs[(object) subName];
            this.MouseMove += new MouseEventHandler(this.MouseMoveEvent);
            break;
          case "mouseup":
            this.delMouseUp = (b4p.del2) this.b4p.htSubs[(object) subName];
            this.MouseUp += new MouseEventHandler(this.MouseUpEvent);
            break;
        }
      }
      catch
      {
        throw new Exception("Error assigning event to " + this.name.Remove(0, 1) + ".\nCheck the number of arguments of each event sub.");
      }
    }

    public string propName => this.name;

    private void MouseDownEvent(object sender, MouseEventArgs e)
    {
      this.b4p.sender = this.name;
      string str = this.delMouseDown(((double) e.X / 1.0).ToString((IFormatProvider) b4p.cul), ((double) e.Y / 1.0).ToString((IFormatProvider) b4p.cul));
    }

    private void MouseMoveEvent(object sender, MouseEventArgs e)
    {
      this.b4p.sender = this.name;
      string str = this.delMouseMove(((double) e.X / 1.0).ToString((IFormatProvider) b4p.cul), ((double) e.Y / 1.0).ToString((IFormatProvider) b4p.cul));
    }

    private void MouseUpEvent(object sender, MouseEventArgs e)
    {
      this.b4p.sender = this.name;
      string str = this.delMouseUp(((double) e.X / 1.0).ToString((IFormatProvider) b4p.cul), ((double) e.Y / 1.0).ToString((IFormatProvider) b4p.cul));
    }

    public void AddEvents()
    {
      try
      {
        if (this.b4p.htSubs.Contains((object) (this.name + "_mousedown")))
        {
          this.delMouseDown = (b4p.del2) this.b4p.htSubs[(object) (this.name + "_mousedown")];
          this.MouseDown += new MouseEventHandler(this.MouseDownEvent);
        }
        if (this.b4p.htSubs.Contains((object) (this.name + "_mousemove")))
        {
          this.delMouseMove = (b4p.del2) this.b4p.htSubs[(object) (this.name + "_mousemove")];
          this.MouseMove += new MouseEventHandler(this.MouseMoveEvent);
        }
        if (!this.b4p.htSubs.Contains((object) (this.name + "_mouseup")))
          return;
        this.delMouseUp = (b4p.del2) this.b4p.htSubs[(object) (this.name + "_mouseup")];
        this.MouseUp += new MouseEventHandler(this.MouseUpEvent);
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
