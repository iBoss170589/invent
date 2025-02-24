// Decompiled with JetBrains decompiler
// Type: FormLib.FormLib
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

using System;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;


namespace FormLib
{
  public class FormLib : IDisposable
  {
    private Form frm;
    private object CRunner;
    private int width;
    private int height;
    private object[] eventObject;
    private object[] activateObject;
    private object[] deactivateObject;
    public int alLeft = 1;
    public int alCenter = 2;
    public int alRight = 3;
    private double fixX = 1.0;
    private double fixY = 1.0;

    public event EventHandler Resize;

    public event EventHandler Activate;

    public event EventHandler Deactivate;

    public FormLib(Form frm, object B4PObject1)
    {
      this.eventObject = new object[2]
      {
        (object) this,
        (object) nameof (Resize)
      };
      this.activateObject = new object[2]
      {
        (object) this,
        (object) nameof (Activate)
      };
      this.deactivateObject = new object[2]
      {
        (object) this,
        (object) nameof (Deactivate)
      };
      this.frm = frm;
      this.width = frm.Width;
      this.height = frm.Height;
      this.frm.Resize += new EventHandler(this.frm_Resize);
      this.frm.Activated += new EventHandler(this.frm_Activated);
      this.frm.Deactivate += new EventHandler(this.frm_Deactivate);
      this.CRunner = B4PObject1;
      this.fixX = (double) Thread.GetData(Thread.GetNamedDataSlot(nameof (fixX)));
      this.fixY = (double) Thread.GetData(Thread.GetNamedDataSlot(nameof (fixY)));
    }

    public double DLLVersion => 2.51;

    private void frm_Activated(object sender, EventArgs e)
    {
      if (this.Activate == null)
        return;
      this.Activate((object) this.activateObject, (EventArgs) null);
    }

    private void frm_Deactivate(object sender, EventArgs e)
    {
      if (this.Deactivate == null)
        return;
      this.Deactivate((object) this.deactivateObject, (EventArgs) null);
    }

    public void ChangeParent(Control Control, Control Parent) => Control.Parent = Parent;

    public void SetPasswordTextBox(TextBox textBox) => textBox.PasswordChar = '*';

    public void TextAlignment(Control Control, int Alignment)
    {
      if (Control is TextBox)
      {
        TextBox textBox = (TextBox) Control;
        int height = textBox.Height;
        textBox.Multiline = true;
        textBox.Height = height;
        switch (Alignment)
        {
          case 1:
            textBox.TextAlign = HorizontalAlignment.Left;
            break;
          case 2:
            textBox.TextAlign = HorizontalAlignment.Center;
            break;
          case 3:
            textBox.TextAlign = HorizontalAlignment.Right;
            break;
        }
      }
      else
      {
        PropertyInfo property = Control.GetType().GetProperty("TextAlign", typeof (ContentAlignment));
        if (property == null)
          throw new Exception("Only Labels and TextBoxes support text alignment.");
        switch (Alignment)
        {
          case 1:
            property.SetValue((object) Control, (object) ContentAlignment.TopLeft, (object[]) null);
            break;
          case 2:
            property.SetValue((object) Control, (object) ContentAlignment.TopCenter, (object[]) null);
            break;
          case 3:
            property.SetValue((object) Control, (object) ContentAlignment.TopRight, (object[]) null);
            break;
        }
      }
    }

    private void MyResize()
    {
      if (this.frm.Width == this.width && this.frm.Height == this.height || this.frm.Height < 80)
        return;
      System.Type type = this.frm.GetType();
      FieldInfo field = type.GetField("bitmap");
      Bitmap bitmap1 = new Bitmap((int) ((double) this.frm.ClientSize.Width / this.fixX), (int) ((double) this.frm.ClientSize.Height / this.fixY));
      Graphics graphics1 = Graphics.FromImage((Image) bitmap1);
      graphics1.FillRectangle((Brush) new SolidBrush(this.frm.BackColor), 0, 0, this.frm.Width, this.frm.Height);
      ((Image) field.GetValue((object) this.frm))?.Dispose();
      field.SetValue((object) this.frm, (object) bitmap1);
      type.GetField("graphics").SetValue((object) this.frm, (object) graphics1);
      Rectangle rect = new Rectangle(0, 0, this.frm.Width, this.frm.Height);
      type.GetField("destRect").SetValue((object) this.frm, (object) rect);
      if ((bool) type.GetField("foreLayer").GetValue((object) this.frm))
      {
        Bitmap bitmap2 = new Bitmap(this.frm.Width, this.frm.Height);
        Graphics graphics2 = Graphics.FromImage((Image) bitmap2);
        graphics2.FillRectangle((Brush) this.CRunner.GetType().GetField("foreBrush").GetValue(this.CRunner), rect);
        ((Image) type.GetField("foreBitmap").GetValue((object) this.frm))?.Dispose();
        type.GetField("foreBitmap").SetValue((object) this.frm, (object) bitmap2);
        type.GetField("foreGraphics").SetValue((object) this.frm, (object) graphics2);
      }
      this.width = this.frm.Width;
      this.height = this.frm.Height;
      this.frm.Refresh();
      if (this.Resize == null)
        return;
      this.Resize((object) this.eventObject, (EventArgs) null);
    }

    public void SetFontStyle(
      Control ControlName,
      bool Bold,
      bool UnderLine,
      bool Italic,
      bool StrikeOut)
    {
      FontStyle style = FontStyle.Regular;
      if (Bold)
        style |= FontStyle.Bold;
      if (UnderLine)
        style |= FontStyle.Underline;
      if (Italic)
        style |= FontStyle.Italic;
      if (StrikeOut)
        style |= FontStyle.Strikeout;
      ControlName.Font = new Font(ControlName.Font.Name, ControlName.Font.Size, style);
    }

    public void ChangeFont(Control ControlName, string FontName)
    {
      Font font = ControlName.Font;
      ControlName.Font = new Font(FontName, font.Size, font.Style);
    }

    public void FullScreen(bool RemoveTitle) => this.FullScreen(true, RemoveTitle);

    public void FullScreen(bool RemoveMenu, bool RemoveTitle)
    {
      if (RemoveMenu)
        this.frm.Menu = (MainMenu) null;
      if (!RemoveTitle)
        return;
      this.frm.MaximizeBox = false;
      this.frm.MinimizeBox = false;
      this.frm.ControlBox = false;
      this.frm.FormBorderStyle = FormBorderStyle.None;
      this.frm.WindowState = FormWindowState.Maximized;
    }

    private void frm_Resize(object sender, EventArgs e) => this.MyResize();

    public bool MinimizeBox
    {
      set => this.frm.MinimizeBox = value;
      get => this.frm.MinimizeBox;
    }

    public void AddContextMenu(Control ControlName, System.Windows.Forms.ContextMenu ContextMenu)
    {
      ControlName.ContextMenu = ContextMenu;
    }

    public void RemoveContextMenu(Control ControlName)
    {
      ControlName.ContextMenu = (System.Windows.Forms.ContextMenu) null;
    }

    public void Dispose() => this.Resize = (EventHandler) null;
  }
}
