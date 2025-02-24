namespace FormLib
{
    using System;
    using System.Drawing;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Windows.Forms;

    public class FormLib : IDisposable
    {
        private Form frm;
        private object CRunner;
        private int width;
        private int height;
        private EventHandler Resize;
        private object[] eventObject;
        private EventHandler Activate;
        private object[] activateObject;
        private EventHandler Deactivate;
        private object[] deactivateObject;
        public int alLeft = 1;
        public int alCenter = 2;
        public int alRight = 3;
        private double fixX = 1.0;
        private double fixY = 1.0;

        public event EventHandler Activate;

        public event EventHandler Deactivate;

        public event EventHandler Resize;

        public FormLib(Form frm, object B4PObject1)
        {
            this.eventObject = new object[] { this, "Resize" };
            this.activateObject = new object[] { this, "Activate" };
            this.deactivateObject = new object[] { this, "Deactivate" };
            this.frm = frm;
            this.width = frm.Width;
            this.height = frm.Height;
            this.frm.Resize += new EventHandler(this.frm_Resize);
            this.frm.Activated += new EventHandler(this.frm_Activated);
            this.frm.Deactivate += new EventHandler(this.frm_Deactivate);
            this.CRunner = B4PObject1;
            this.fixX = Thread.GetData(Thread.GetNamedDataSlot("fixX"));
            this.fixY = Thread.GetData(Thread.GetNamedDataSlot("fixY"));
        }

        public void AddContextMenu(Control ControlName, System.Windows.Forms.ContextMenu ContextMenu)
        {
            ControlName.ContextMenu = ContextMenu;
        }

        public void ChangeFont(Control ControlName, string FontName)
        {
            Font font = ControlName.Font;
            ControlName.Font = new Font(FontName, font.Size, font.Style);
        }

        public void ChangeParent(Control Control, Control Parent)
        {
            Control.Parent = Parent;
        }

        public void Dispose()
        {
            this.Resize = null;
        }

        private void frm_Activated(object sender, EventArgs e)
        {
            if (this.Activate != null)
            {
                this.Activate(this.activateObject, null);
            }
        }

        private void frm_Deactivate(object sender, EventArgs e)
        {
            if (this.Deactivate != null)
            {
                this.Deactivate(this.deactivateObject, null);
            }
        }

        private void frm_Resize(object sender, EventArgs e)
        {
            this.MyResize();
        }

        public void FullScreen(bool RemoveTitle)
        {
            this.FullScreen(true, RemoveTitle);
        }

        public void FullScreen(bool RemoveMenu, bool RemoveTitle)
        {
            if (RemoveMenu)
            {
                this.frm.Menu = null;
            }
            if (RemoveTitle)
            {
                this.frm.MaximizeBox = false;
                this.frm.MinimizeBox = false;
                this.frm.ControlBox = false;
                this.frm.FormBorderStyle = FormBorderStyle.None;
                this.frm.WindowState = FormWindowState.Maximized;
            }
        }

        private void MyResize()
        {
            if (((this.frm.Width != this.width) || (this.frm.Height != this.height)) && (this.frm.Height >= 80))
            {
                System.Type type = this.frm.GetType();
                FieldInfo field = type.GetField("bitmap");
                Bitmap image = new Bitmap((int) (((double) this.frm.ClientSize.Width) / this.fixX), (int) (((double) this.frm.ClientSize.Height) / this.fixY));
                Graphics graphics = Graphics.FromImage(image);
                graphics.FillRectangle(new SolidBrush(this.frm.BackColor), 0, 0, this.frm.Width, this.frm.Height);
                object obj2 = field.GetValue(this.frm);
                if (obj2 != null)
                {
                    ((Bitmap) obj2).Dispose();
                }
                field.SetValue(this.frm, image);
                type.GetField("graphics").SetValue(this.frm, graphics);
                Rectangle rectangle = new Rectangle(0, 0, this.frm.Width, this.frm.Height);
                type.GetField("destRect").SetValue(this.frm, rectangle);
                if ((bool) type.GetField("foreLayer").GetValue(this.frm))
                {
                    Bitmap bitmap2 = new Bitmap(this.frm.Width, this.frm.Height);
                    Graphics graphics2 = Graphics.FromImage(bitmap2);
                    graphics2.FillRectangle((SolidBrush) this.CRunner.GetType().GetField("foreBrush").GetValue(this.CRunner), rectangle);
                    object obj3 = type.GetField("foreBitmap").GetValue(this.frm);
                    if (obj3 != null)
                    {
                        ((Bitmap) obj3).Dispose();
                    }
                    type.GetField("foreBitmap").SetValue(this.frm, bitmap2);
                    type.GetField("foreGraphics").SetValue(this.frm, graphics2);
                }
                this.width = this.frm.Width;
                this.height = this.frm.Height;
                this.frm.Refresh();
                if (this.Resize != null)
                {
                    this.Resize(this.eventObject, null);
                }
            }
        }

        public void RemoveContextMenu(Control ControlName)
        {
            ControlName.ContextMenu = null;
        }

        public void SetFontStyle(Control ControlName, bool Bold, bool UnderLine, bool Italic, bool StrikeOut)
        {
            FontStyle regular = FontStyle.Regular;
            if (Bold)
            {
                regular |= FontStyle.Bold;
            }
            if (UnderLine)
            {
                regular |= FontStyle.Underline;
            }
            if (Italic)
            {
                regular |= FontStyle.Italic;
            }
            if (StrikeOut)
            {
                regular |= FontStyle.Strikeout;
            }
            ControlName.Font = new Font(ControlName.Font.Name, ControlName.Font.Size, regular);
        }

        public void SetPasswordTextBox(TextBox textBox)
        {
            textBox.PasswordChar = '*';
        }

        public void TextAlignment(Control Control, int Alignment)
        {
            if (Control is TextBox)
            {
                TextBox box = (TextBox) Control;
                int height = box.Height;
                box.Multiline = true;
                box.Height = height;
                switch (Alignment)
                {
                    case 1:
                        box.TextAlign = HorizontalAlignment.Left;
                        return;

                    case 2:
                        box.TextAlign = HorizontalAlignment.Center;
                        return;

                    case 3:
                        box.TextAlign = HorizontalAlignment.Right;
                        return;
                }
            }
            else
            {
                PropertyInfo property = Control.GetType().GetProperty("TextAlign", typeof(ContentAlignment));
                if (property == null)
                {
                    throw new Exception("Only Labels and TextBoxes support text alignment.");
                }
                switch (Alignment)
                {
                    case 1:
                        property.SetValue(Control, ContentAlignment.TopLeft, null);
                        return;

                    case 2:
                        property.SetValue(Control, ContentAlignment.TopCenter, null);
                        return;

                    case 3:
                        property.SetValue(Control, ContentAlignment.TopRight, null);
                        return;
                }
            }
        }

        public double DLLVersion =>
            2.51;

        public bool MinimizeBox
        {
            get => 
                this.frm.MinimizeBox;
            set => 
                this.frm.MinimizeBox = value;
        }
    }
}

