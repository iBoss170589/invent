// Decompiled with JetBrains decompiler
// Type: Dbasic.EnhancedControls.CEnhancedImage
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace Dbasic.EnhancedControls
{
  public class CEnhancedImage : PictureBox, IEnhancedControl, IImage, IEnabled
  {
    public string name;
    public string picFile = "";
    public string imageMode = "CNormalImage";
    private b4p b4p;
    private b4p.del0 delClick;

    public CEnhancedImage(b4p b4p)
    {
      this.b4p = b4p;
      this.SizeMode = PictureBoxSizeMode.Normal;
    }

    public string propName => this.name;

    public Bitmap MyBitmap
    {
      get => (Bitmap) this.Image;
      set => this.Image = (Image) value;
    }

    protected override void OnPaintBackground(PaintEventArgs e) => base.OnPaintBackground(e);

    protected override void OnPaint(PaintEventArgs e) => base.OnPaint(e);

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

    public string MyImageMode
    {
      get => this.imageMode;
      set
      {
        switch (value.ToLower(b4p.cul))
        {
          case "cstretchimage":
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            break;
          case "ccenterimage":
            this.SizeMode = PictureBoxSizeMode.CenterImage;
            break;
          default:
            this.SizeMode = PictureBoxSizeMode.Normal;
            break;
        }
        this.imageMode = value;
      }
    }

    virtual bool IEnabled.get_Enabled() => this.Enabled;

    virtual void IEnabled.set_Enabled([In] bool obj0) => this.Enabled = obj0;
  }
}
