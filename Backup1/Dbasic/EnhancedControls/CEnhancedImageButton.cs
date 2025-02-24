// Decompiled with JetBrains decompiler
// Type: Dbasic.EnhancedControls.CEnhancedImageButton
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace Dbasic.EnhancedControls
{
  public class CEnhancedImageButton : Control, IEnhancedControl, IImage, IEnabled, IText
  {
    public string name;
    private bool bPushed;
    private SolidBrush pushedBrush = new SolidBrush(Color.LightGray);
    private bool transparent = true;
    private Bitmap bitmap;
    private Bitmap button;
    private Graphics g;
    public ImageAttributes imageAttr = new ImageAttributes();
    public string imageMode = "cnormalimage";
    private Pen pen = new Pen(Color.Black);
    private SolidBrush textBrush = new SolidBrush(Color.Black);
    private SolidBrush brush = new SolidBrush(Color.Black);
    private Rectangle destRect;
    private b4p b4p;
    private b4p.del0 delClick;
    private b4p.del0 delMouseDown;
    private b4p.del0 delMouseUp;

    public CEnhancedImageButton(b4p b4p)
    {
      this.b4p = b4p;
      this.Font = new Font(this.Font.Name, this.Font.Size, FontStyle.Bold);
    }

    protected override void OnPaintBackground(PaintEventArgs pevent)
    {
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      int num = 0;
      if (this.bPushed)
        num = (int) b4p.scaleX;
      if (this.button == null || this.button.Size != this.Size)
      {
        if (this.button != null)
          this.button.Dispose();
        this.button = new Bitmap(this.Width, this.Height);
        this.g = Graphics.FromImage((Image) this.button);
        this.destRect = new Rectangle(0, 0, this.button.Width, this.button.Height);
      }
      if (!this.transparent)
      {
        if (this.brush.Color != this.BackColor)
          this.brush.Color = this.BackColor;
        if (this.bPushed)
          this.g.FillRectangle((Brush) this.pushedBrush, 0, 0, this.Width, this.Height);
        else
          this.g.FillRectangle((Brush) this.brush, 0, 0, this.Width, this.Height);
      }
      else if (this.Parent is Panel)
        this.g.FillRectangle((Brush) new SolidBrush(this.Parent.BackColor), 0, 0, this.Width, this.Height);
      else
        this.g.DrawImage((Image) ((CEnhancedForm) this.Parent).bitmap, new Rectangle(0, 0, this.Width, this.Height), new Rectangle((int) ((double) this.Left / 1.0), (int) ((double) this.Top / 1.0), (int) ((double) this.Width / 1.0), (int) ((double) this.Height / 1.0)), GraphicsUnit.Pixel);
      if (this.bitmap != null)
      {
        switch (this.imageMode.ToLower(b4p.cul))
        {
          case "ccenterimage":
            this.g.DrawImage((Image) this.bitmap, new Rectangle(this.Width / 2 - (int) ((double) (this.bitmap.Width / 2) * 1.0) + num, this.Height / 2 - (int) ((double) (this.bitmap.Height / 2) * 1.0) + num, (int) ((double) this.bitmap.Width * 1.0), (int) ((double) this.bitmap.Height * 1.0)), 0, 0, this.bitmap.Width, this.bitmap.Height, GraphicsUnit.Pixel, this.imageAttr);
            break;
          case "cstretchimage":
            this.g.DrawImage((Image) this.bitmap, new Rectangle(num, num, this.Width, this.Height), 0, 0, this.bitmap.Width, this.bitmap.Height, GraphicsUnit.Pixel, this.imageAttr);
            break;
          default:
            this.g.DrawImage((Image) this.bitmap, new Rectangle(num, num, (int) ((double) this.bitmap.Width * 1.0), (int) ((double) this.bitmap.Height * 1.0)), 0, 0, this.bitmap.Width, this.bitmap.Height, GraphicsUnit.Pixel, this.imageAttr);
            break;
        }
      }
      SizeF sizeF = this.g.MeasureString(this.Text, this.Font);
      if (this.textBrush.Color != this.ForeColor)
        this.textBrush.Color = this.ForeColor;
      this.g.DrawString(base.Text, this.Font, (Brush) this.textBrush, (float) (((double) this.Width - (double) sizeF.Width) / 2.0) + (float) num, (float) (((double) this.Height - (double) sizeF.Height) / 2.0) + (float) num);
      e.Graphics.DrawImage((Image) this.button, this.destRect, this.destRect, GraphicsUnit.Pixel);
    }

    public override string Text
    {
      get => base.Text;
      set
      {
        base.Text = value;
        this.Refresh();
      }
    }

    protected override void OnDoubleClick(EventArgs e) => this.OnClick(e);

    protected override void OnMouseDown(MouseEventArgs e)
    {
      base.OnMouseDown(e);
      this.bPushed = true;
      this.Invalidate();
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
      base.OnMouseUp(e);
      this.bPushed = false;
      this.Invalidate();
    }

    public bool Transparent
    {
      get => this.transparent;
      set
      {
        if (value && this.bitmap != null)
          this.imageAttr.SetColorKey(this.bitmap.GetPixel(0, 0), this.bitmap.GetPixel(0, 0));
        else
          this.imageAttr.ClearColorKey();
        this.transparent = value;
      }
    }

    public Bitmap MyBitmap
    {
      get => this.bitmap;
      set
      {
        this.bitmap = value != null ? new Bitmap((Image) value) : (Bitmap) null;
        if (value != null && this.transparent)
          this.imageAttr.SetColorKey(this.bitmap.GetPixel(0, 0), this.bitmap.GetPixel(0, 0));
        this.Refresh();
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (this.textBrush != null)
        this.textBrush.Dispose();
      if (this.pen != null)
        this.pen.Dispose();
      if (this.button != null)
        this.button.Dispose();
      if (this.brush != null)
        this.brush.Dispose();
      base.Dispose(disposing);
    }

    public string propName => this.name;

    public void AddRunTimeEvent(string eventName, string subName)
    {
      switch (eventName)
      {
        case "click":
          this.delClick = (b4p.del0) this.b4p.htSubs[(object) subName];
          this.Click += new EventHandler(this.ClickEvent);
          break;
        case "buttondown":
          this.delMouseDown = (b4p.del0) this.b4p.htSubs[(object) subName];
          this.MouseDown += new MouseEventHandler(this.MouseDownEvent);
          break;
        case "buttonup":
          this.delMouseUp = (b4p.del0) this.b4p.htSubs[(object) subName];
          this.MouseUp += new MouseEventHandler(this.MouseUpEvent);
          break;
      }
    }

    private void ClickEvent(object sender, EventArgs e)
    {
      this.b4p.sender = this.name;
      string str = this.delClick();
    }

    private void MouseUpEvent(object sender, MouseEventArgs e)
    {
      this.b4p.sender = this.name;
      string str = this.delMouseUp();
    }

    private void MouseDownEvent(object sender, MouseEventArgs e)
    {
      this.b4p.sender = this.name;
      string str = this.delMouseDown();
    }

    public void AddEvents()
    {
      try
      {
        if (this.b4p.htSubs.Contains((object) (this.name + "_click")))
        {
          this.delClick = (b4p.del0) this.b4p.htSubs[(object) (this.name + "_click")];
          this.Click += new EventHandler(this.ClickEvent);
        }
        if (this.b4p.htSubs.Contains((object) (this.name + "_buttondown")))
        {
          this.delMouseDown = (b4p.del0) this.b4p.htSubs[(object) (this.name + "_buttondown")];
          this.MouseDown += new MouseEventHandler(this.MouseDownEvent);
        }
        if (!this.b4p.htSubs.Contains((object) (this.name + "_buttonup")))
          return;
        this.delMouseUp = (b4p.del0) this.b4p.htSubs[(object) (this.name + "_buttonup")];
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
