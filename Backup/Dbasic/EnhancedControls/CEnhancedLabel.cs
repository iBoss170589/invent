// Decompiled with JetBrains decompiler
// Type: Dbasic.EnhancedControls.CEnhancedLabel
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace Dbasic.EnhancedControls
{
  public class CEnhancedLabel : Control, IEnhancedControl, IText, IEnabled
  {
    public string name;
    public bool transparent;
    private Rectangle destRect;
    private Brush bgdBrush;
    private Brush textBrush;
    private StringFormat stringFormat;
    private b4p b4p;
    private Brush currentBrush;
    private Brush disabledBrush;

    public CEnhancedLabel(b4p b4p)
    {
      this.b4p = b4p;
      this.stringFormat = new StringFormat();
      this.destRect = new Rectangle(0, 0, this.Width, this.Height);
      this.textBrush = (Brush) new SolidBrush(this.ForeColor);
      this.bgdBrush = (Brush) new SolidBrush(this.BackColor);
      this.disabledBrush = (Brush) new SolidBrush(SystemColors.InactiveCaptionText);
      this.Enabled = false;
      this.TabStop = false;
      this.currentBrush = this.textBrush;
    }

    protected override void OnPaintBackground(PaintEventArgs pevent)
    {
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      Graphics graphics = e.Graphics;
      this.destRect.Width = this.Width;
      this.destRect.Height = this.Height;
      if (!this.transparent)
        graphics.FillRectangle(this.bgdBrush, this.destRect);
      else if (this.Parent is Panel)
        graphics.FillRectangle((Brush) new SolidBrush(this.Parent.BackColor), 0, 0, this.Width, this.Height);
      else if (this.Parent is CEnhancedForm)
      {
        CEnhancedForm parent = (CEnhancedForm) this.Parent;
        graphics.DrawImage((Image) parent.bitmap, new Rectangle(0, 0, this.Width, this.Height), new Rectangle((int) ((double) this.Left / 1.0), (int) ((double) this.Top / 1.0), (int) ((double) this.Width / 1.0), (int) ((double) this.Height / 1.0)), GraphicsUnit.Pixel);
      }
      graphics.DrawString(base.Text, this.Font, this.currentBrush, (RectangleF) this.destRect, this.stringFormat);
    }

    public override Color ForeColor
    {
      get => base.ForeColor;
      set
      {
        Brush brush = (Brush) new SolidBrush(value);
        if (this.currentBrush == this.textBrush)
          this.currentBrush = brush;
        this.textBrush = brush;
        base.ForeColor = value;
      }
    }

    public override Color BackColor
    {
      get => base.BackColor;
      set
      {
        this.bgdBrush = (Brush) new SolidBrush(value);
        base.BackColor = value;
      }
    }

    public bool Transparent
    {
      get => this.transparent;
      set => this.transparent = value;
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

    public string propName => this.name;

    public ContentAlignment TextAlign
    {
      set
      {
        switch (value)
        {
          case ContentAlignment.TopLeft:
            this.stringFormat.Alignment = StringAlignment.Near;
            break;
          case ContentAlignment.TopCenter:
            this.stringFormat.Alignment = StringAlignment.Center;
            break;
          case ContentAlignment.TopRight:
            this.stringFormat.Alignment = StringAlignment.Far;
            break;
        }
        this.Refresh();
      }
    }

    void IEnhancedControl.AddRunTimeEvent(string eventName, string subName)
    {
    }

    public bool MyEnabled
    {
      get => this.currentBrush != this.disabledBrush;
      set
      {
        this.currentBrush = value ? this.textBrush : this.disabledBrush;
        this.Refresh();
      }
    }

    virtual bool IEnabled.get_Enabled() => this.Enabled;

    virtual void IEnabled.set_Enabled([In] bool obj0) => this.Enabled = obj0;
  }
}
