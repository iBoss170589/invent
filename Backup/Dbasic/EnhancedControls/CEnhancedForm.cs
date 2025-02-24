// Decompiled with JetBrains decompiler
// Type: Dbasic.EnhancedControls.CEnhancedForm
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace Dbasic.EnhancedControls
{
  public class CEnhancedForm : Form, IEnhancedControl, IImage, IEnabled, IText
  {
    public Graphics graphics;
    public MainMenu mainMenu1;
    public string name;
    public Bitmap bitmap;
    public Rectangle destRect;
    public bool activeState;
    public bool cancelClose;
    public bool hideEventAdded;
    public Bitmap foreBitmap;
    public Graphics foreGraphics;
    public bool foreLayer;
    public ImageAttributes imageAttr = new ImageAttributes();
    private b4p b4p;
    private SolidBrush brush = new SolidBrush(Color.Black);
    private Pen pen = new Pen(Color.Black);
    private ImageAttributes backAttr = new ImageAttributes();
    private b4p.del1 delKeyDown;
    private b4p.del2 delMouseDown;
    private b4p.del2 delMouseMove;
    private b4p.del2 delMouseUp;
    private b4p.del0 delClose;
    private b4p.del0 delShow;

    public CEnhancedForm(b4p b4p)
    {
      this.b4p = b4p;
      this.InitializeComponent();
      this.MinimizeBox = false;
      try
      {
        if (b4p.icon != "")
          this.Icon = new Icon(Assembly.GetExecutingAssembly().GetManifestResourceStream(b4p.icon));
      }
      catch
      {
      }
      this.ClientSize = new Size(b4p.screenX, b4p.screenY);
      this.MaximumSize = this.Size;
      this.MinimumSize = this.MaximumSize;
      this.Name = nameof (CEnhancedForm);
      this.StartPosition = FormStartPosition.CenterScreen;
      Other.SetScale(false, b4p.autoScale, (Form) this, b4p);
      this.destRect = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
      this.bitmap = new Bitmap((int) ((double) this.ClientSize.Width / 1.0), (int) ((double) this.ClientSize.Height / 1.0));
      this.graphics = Graphics.FromImage((Image) this.bitmap);
    }

    public void show()
    {
      if (this.b4p.mainForm == null)
        this.b4p.mainForm = this;
      this.b4p.shownForm = this;
      if (!this.hideEventAdded)
      {
        this.Closing += new CancelEventHandler(this.HideForm);
        this.hideEventAdded = true;
      }
      if (this.b4p.htSubs.Contains((object) (this.name + "_show")))
        this.ShowEvent();
      if (this.b4p.alFormsDisplayOrder.Count > 0 && this.b4p.alFormsDisplayOrder[this.b4p.alFormsDisplayOrder.Count - 1] == this)
        return;
      this.Show();
      if (this.b4p.alFormsDisplayOrder.Count > 0)
        ((Control) this.b4p.alFormsDisplayOrder[this.b4p.alFormsDisplayOrder.Count - 1]).Hide();
      if (this == this.b4p.mainForm)
        this.b4p.alFormsDisplayOrder.Clear();
      else
        this.b4p.alFormsDisplayOrder.Remove((object) this);
      this.b4p.alFormsDisplayOrder.Add((object) this);
      this.activeState = true;
    }

    public void AddMenu()
    {
      if (this.mainMenu1.MenuItems.Count != 1)
        return;
      this.MaximumSize = new Size(10000, 10000);
      this.MinimumSize = new Size(0, 0);
      this.ClientSize = new Size(this.b4p.screenX, this.b4p.screenY);
      this.MaximumSize = this.MinimumSize = this.Size;
    }

    public void close()
    {
      if (this != this.b4p.mainForm && !this.b4p.alFormsDisplayOrder.Contains((object) this))
        return;
      this.Close();
    }

    private void HideForm(object sender, CancelEventArgs e)
    {
      if (this == this.b4p.mainForm)
      {
        if (!this.b4p.quitFlag)
        {
          if (this.b4p.htSubs.Contains((object) (this.b4p.mainForm.name + "_close")))
            this.CloseEvent();
          if (!this.b4p.quitFlag && this.b4p.mainForm.cancelClose)
          {
            e.Cancel = true;
            return;
          }
        }
        if (this.b4p.mainForm != null)
          this.b4p.CloseProgram();
      }
      if (this.b4p.quitFlag)
        return;
      if (this.b4p.htSubs.Contains((object) (this.name + "_close")))
        this.CloseEvent();
      if (this.cancelClose)
      {
        e.Cancel = true;
      }
      else
      {
        e.Cancel = true;
        this.Hide();
        this.b4p.alFormsDisplayOrder.Remove((object) this);
        ((Control) this.b4p.alFormsDisplayOrder[this.b4p.alFormsDisplayOrder.Count - 1]).Show();
      }
    }

    private void InitializeComponent()
    {
      this.mainMenu1 = new MainMenu();
      this.SuspendLayout();
      this.AutoScaleMode = AutoScaleMode.Inherit;
      this.ClientSize = new Size(240, 266);
      this.Menu = this.mainMenu1;
      this.MinimizeBox = false;
      this.Name = nameof (CEnhancedForm);
      this.ResumeLayout(false);
    }

    public void FixedInvalidate(Rectangle c) => this.Invalidate(c);

    protected override void OnPaint(PaintEventArgs e)
    {
      e.Graphics.DrawImage((Image) this.bitmap, this.destRect, 0, 0, this.bitmap.Width, this.bitmap.Height, GraphicsUnit.Pixel, this.backAttr);
      if (!this.foreLayer)
        return;
      e.Graphics.DrawImage((Image) this.foreBitmap, this.destRect, 0, 0, this.bitmap.Width, this.bitmap.Height, GraphicsUnit.Pixel, this.imageAttr);
    }

    protected override void OnPaintBackground(PaintEventArgs pevent)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (this.bitmap != null)
        this.bitmap.Dispose();
      if (this.foreBitmap != null)
        this.foreBitmap.Dispose();
      base.Dispose(disposing);
    }

    public string propName => this.name;

    public Bitmap MyBitmap
    {
      get => this.bitmap;
      set
      {
        if (value == null)
        {
          this.graphics.FillRectangle((Brush) new SolidBrush(this.BackColor), 0, 0, this.Width, this.Height);
        }
        else
        {
          Rectangle srcRect = new Rectangle(0, 0, value.Width, value.Height);
          this.graphics.DrawImage((Image) value, new Rectangle(0, 0, this.bitmap.Width, this.bitmap.Height), srcRect, GraphicsUnit.Pixel);
        }
        this.Refresh();
      }
    }

    private void KeyDownEvent(object sender, KeyEventArgs e)
    {
      this.b4p.sender = this.name;
      string str = this.delKeyDown(((int) e.KeyCode).ToString((IFormatProvider) b4p.cul));
    }

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

    private void ShowEvent()
    {
      this.delShow = (b4p.del0) this.b4p.htSubs[(object) (this.name + "_show")];
      this.b4p.sender = this.name;
      string str = this.delShow();
    }

    private void CloseEvent()
    {
      this.cancelClose = false;
      this.delClose = (b4p.del0) this.b4p.htSubs[(object) (this.name + "_close")];
      this.b4p.sender = this.name;
      string str = this.delClose();
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
        if (this.b4p.htSubs.Contains((object) (this.name + "_mouseup")))
        {
          this.delMouseUp = (b4p.del2) this.b4p.htSubs[(object) (this.name + "_mouseup")];
          this.MouseUp += new MouseEventHandler(this.MouseUpEvent);
        }
        if (!this.b4p.htSubs.Contains((object) (this.name + "_keypress")))
          return;
        this.delKeyDown = (b4p.del1) this.b4p.htSubs[(object) (this.name + "_keypress")];
        this.KeyDown += new KeyEventHandler(this.KeyDownEvent);
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
          case "keypress":
            this.delKeyDown = (b4p.del1) this.b4p.htSubs[(object) subName];
            this.KeyDown += new KeyEventHandler(this.KeyDownEvent);
            break;
        }
      }
      catch
      {
        throw new Exception("Error assigning event to " + this.name.Remove(0, 1) + ".\nCheck the number of arguments of each event sub.");
      }
    }

    public override Color BackColor
    {
      get => base.BackColor;
      set
      {
        base.BackColor = value;
        this.graphics.FillRectangle((Brush) new SolidBrush(this.BackColor), 0, 0, this.Width, this.Height);
        this.Refresh();
      }
    }

    public void circle(Graphics g, int x1, int y1, int r, Color color, bool fill)
    {
      Rectangle c = new Rectangle(x1 - r, y1 - r, 2 * r + 1, 2 * r + 1);
      if (fill)
      {
        this.brush.Color = color;
        g.FillEllipse((Brush) this.brush, x1 - r, y1 - r, 2 * r, 2 * r);
      }
      else
      {
        this.pen.Color = color;
        g.DrawEllipse(this.pen, x1 - r, y1 - r, 2 * r, 2 * r);
      }
      ++c.Height;
      ++c.Width;
      this.FixedInvalidate(c);
    }

    public void line(
      Graphics g,
      int x1,
      int y1,
      int x2,
      int y2,
      Color color,
      bool box,
      bool fill)
    {
      Rectangle rectangle = new Rectangle(Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x2 - x1), Math.Abs(y2 - y1));
      if (box)
      {
        if (!fill)
        {
          this.pen.Color = color;
          g.DrawRectangle(this.pen, rectangle);
        }
        else
        {
          this.brush.Color = color;
          g.FillRectangle((Brush) this.brush, rectangle);
        }
      }
      else
      {
        this.pen.Color = color;
        g.DrawLine(this.pen, x1, y1, x2, y2);
      }
      ++rectangle.Height;
      ++rectangle.Width;
      this.FixedInvalidate(rectangle);
    }

    public void drawString(
      Graphics g,
      string s,
      double fontSize,
      int x1,
      int y1,
      int x2,
      int y2,
      Color col)
    {
      Rectangle rectangle = new Rectangle(Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x2 - x1), Math.Abs(y2 - y1));
      this.brush.Color = col;
      g.DrawString(s, new Font(this.Font.Name, (float) (fontSize / 1.0), this.Font.Style), (Brush) this.brush, (RectangleF) rectangle);
      ++rectangle.Height;
      ++rectangle.Width;
      this.FixedInvalidate(rectangle);
    }

    public void drawImage(Graphics g, Bitmap bitmap, int x1, int y1)
    {
      Rectangle c = new Rectangle(x1, y1, bitmap.Width, bitmap.Height);
      g.DrawImage((Image) bitmap, x1, y1, new Rectangle(0, 0, bitmap.Width, bitmap.Height), GraphicsUnit.Pixel);
      ++c.Height;
      ++c.Width;
      this.FixedInvalidate(c);
    }

    public void drawImage(Graphics g, Bitmap bitmap, int x1, int y1, int x2, int y2)
    {
      Rectangle rectangle = new Rectangle(Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x2 - x1), Math.Abs(y2 - y1));
      g.DrawImage((Image) bitmap, rectangle, new Rectangle(0, 0, bitmap.Width, bitmap.Height), GraphicsUnit.Pixel);
      ++rectangle.Height;
      ++rectangle.Width;
      this.FixedInvalidate(rectangle);
    }

    public void polygon(Graphics g, double[,] xy, int start, int count, Color col, bool fill)
    {
      Point[] p = new Point[count];
      int num1;
      int num2 = num1 = p[0].X = (int) xy[start, 0];
      int num3;
      int num4 = num3 = p[0].Y = (int) xy[start, 1];
      for (int index = 1; index < count; ++index)
      {
        num2 = Math.Min(num2, p[index].X = (int) xy[start + index, 0]);
        num1 = Math.Max(num1, p[index].X);
        num4 = Math.Min(num4, p[index].Y = (int) xy[start + index, 1]);
        num3 = Math.Max(num3, p[index].Y);
      }
      this.FinishPolygon(g, p, num2, num4, num1, num3, fill, col);
    }

    public void polygon(
      Graphics g,
      double[] x,
      int startX,
      double[] y,
      int startY,
      int count,
      Color col,
      bool fill)
    {
      Point[] p = new Point[count];
      int num1;
      int num2 = num1 = p[0].X = (int) x[startX];
      int num3;
      int num4 = num3 = p[0].Y = (int) y[startY];
      for (int index = 1; index < count; ++index)
      {
        num2 = Math.Min(num2, p[index].X = (int) x[startX + index]);
        num1 = Math.Max(num1, p[index].X);
        num4 = Math.Min(num4, p[index].Y = (int) y[startY + index]);
        num3 = Math.Max(num3, p[index].Y);
      }
      this.FinishPolygon(g, p, num2, num4, num1, num3, fill, col);
    }

    public void polygon(Graphics g, string[,] xy, int start, int count, Color col, bool fill)
    {
      Point[] p = new Point[count];
      int num1;
      int num2 = num1 = p[0].X = (int) double.Parse(xy[start, 0], (IFormatProvider) b4p.cul);
      int num3;
      int num4 = num3 = p[0].Y = (int) double.Parse(xy[start, 1], (IFormatProvider) b4p.cul);
      for (int index = 1; index < count; ++index)
      {
        num2 = Math.Min(num2, p[index].X = (int) double.Parse(xy[start + index, 0], (IFormatProvider) b4p.cul));
        num1 = Math.Max(num1, p[index].X);
        num4 = Math.Min(num4, p[index].Y = (int) double.Parse(xy[start + index, 1], (IFormatProvider) b4p.cul));
        num3 = Math.Max(num3, p[index].Y);
      }
      this.FinishPolygon(g, p, num2, num4, num1, num3, fill, col);
    }

    public void polygon(
      Graphics g,
      string[] x,
      int startX,
      string[] y,
      int startY,
      int count,
      Color col,
      bool fill)
    {
      Point[] p = new Point[count];
      int num1;
      int num2 = num1 = p[0].X = (int) double.Parse(x[startX], (IFormatProvider) b4p.cul);
      int num3;
      int num4 = num3 = p[0].Y = (int) double.Parse(y[startY], (IFormatProvider) b4p.cul);
      for (int index = 1; index < count; ++index)
      {
        num2 = Math.Min(num2, p[index].X = (int) double.Parse(x[startX + index], (IFormatProvider) b4p.cul));
        num1 = Math.Max(num1, p[index].X);
        num4 = Math.Min(num4, p[index].Y = (int) double.Parse(y[startY + index], (IFormatProvider) b4p.cul));
        num3 = Math.Max(num3, p[index].Y);
      }
      this.FinishPolygon(g, p, num2, num4, num1, num3, fill, col);
    }

    private void FinishPolygon(
      Graphics g,
      Point[] p,
      int xMin,
      int yMin,
      int xMax,
      int yMax,
      bool fill,
      Color col)
    {
      Rectangle c = new Rectangle(xMin, yMin, xMax - xMin + 1, yMax - yMin + 1);
      if (fill)
      {
        this.brush.Color = col;
        g.FillPolygon((Brush) this.brush, p);
      }
      else
      {
        this.pen.Color = col;
        g.DrawPolygon(this.pen, p);
      }
      this.FixedInvalidate(c);
    }

    public bool ForeLayer
    {
      get => this.foreLayer;
      set
      {
        this.foreLayer = value;
        if (!this.foreLayer || this.foreBitmap != null)
          return;
        this.foreBitmap = new Bitmap((int) ((double) this.ClientSize.Width / 1.0), (int) ((double) this.ClientSize.Height / 1.0));
        this.foreGraphics = Graphics.FromImage((Image) this.foreBitmap);
        this.foreGraphics.FillRectangle((Brush) this.b4p.foreBrush, this.destRect);
        this.imageAttr.SetColorKey(this.b4p.transColor, this.b4p.transColor);
      }
    }

    string IEnhancedControl.propName => this.name;

    virtual bool IEnabled.get_Enabled() => this.Enabled;

    virtual void IEnabled.set_Enabled([In] bool obj0) => this.Enabled = obj0;
  }
}
