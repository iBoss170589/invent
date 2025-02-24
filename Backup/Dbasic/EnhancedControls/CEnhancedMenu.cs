// Decompiled with JetBrains decompiler
// Type: Dbasic.EnhancedControls.CEnhancedMenu
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace Dbasic.EnhancedControls
{
  public class CEnhancedMenu : MenuItem, IEnhancedControl, IEnabled, IText, IChecked
  {
    public string name;
    private b4p b4p;
    private b4p.del0 delClick;

    public CEnhancedMenu(b4p b4p) => this.b4p = b4p;

    public string propName => this.name;

    public void AddToObject(string parent)
    {
      object htControl = this.b4p.htControls[(object) parent];
      if (htControl is CEnhancedForm)
      {
        ((CEnhancedForm) htControl).mainMenu1.MenuItems.Add((MenuItem) this);
        ((CEnhancedForm) htControl).AddMenu();
      }
      else
        ((Menu) htControl).MenuItems.Add((MenuItem) this);
    }

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

    private void ClickEvent(object sender, EventArgs e)
    {
      this.b4p.sender = this.name;
      string str = this.delClick();
    }

    virtual bool IEnabled.get_Enabled() => this.Enabled;

    virtual void IEnabled.set_Enabled([In] bool obj0) => this.Enabled = obj0;

    virtual string IText.get_Text() => this.Text;

    virtual void IText.set_Text([In] string obj0) => this.Text = obj0;

    virtual bool IChecked.get_Checked() => this.Checked;

    virtual void IChecked.set_Checked([In] bool obj0) => this.Checked = obj0;
  }
}
