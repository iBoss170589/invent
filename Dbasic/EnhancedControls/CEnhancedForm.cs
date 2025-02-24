namespace Dbasic.EnhancedControls
{
    using Dbasic;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Reflection;
    using System.Windows.Forms;

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
        private Dbasic.b4p b4p;
        private SolidBrush brush = new SolidBrush(Color.Black);
        private Pen pen = new Pen(Color.Black);
        private ImageAttributes backAttr = new ImageAttributes();
        private Dbasic.b4p.del1 delKeyDown;
        private Dbasic.b4p.del2 delMouseDown;
        private Dbasic.b4p.del2 delMouseMove;
        private Dbasic.b4p.del2 delMouseUp;
        private Dbasic.b4p.del0 delClose;
        private Dbasic.b4p.del0 delShow;

        public CEnhancedForm(Dbasic.b4p b4p)
        {
            this.b4p = b4p;
            this.InitializeComponent();
            base.MinimizeBox = false;
            try
            {
                if (b4p.icon != "")
                {
                    base.Icon = new Icon(Assembly.GetExecutingAssembly().GetManifestResourceStream(b4p.icon));
                }
            }
            catch
            {
            }
            base.ClientSize = new Size(b4p.screenX, b4p.screenY);
            this.MaximumSize = base.Size;
            this.MinimumSize = this.MaximumSize;
            base.Name = "CEnhancedForm";
            base.StartPosition = FormStartPosition.CenterScreen;
            Other.SetScale(false, Dbasic.b4p.autoScale, this, b4p);
            this.destRect = new Rectangle(0, 0, base.ClientSize.Width, base.ClientSize.Height);
            this.bitmap = new Bitmap((int) (((double) base.ClientSize.Width) / 1.0), (int) (((double) base.ClientSize.Height) / 1.0));
            this.graphics = Graphics.FromImage(this.bitmap);
        }

        public void AddEvents()
        {
            try
            {
                if (this.b4p.htSubs.Contains(this.name + "_mousedown"))
                {
                    this.delMouseDown = (Dbasic.b4p.del2) this.b4p.htSubs[this.name + "_mousedown"];
                    base.MouseDown += new MouseEventHandler(this.MouseDownEvent);
                }
                if (this.b4p.htSubs.Contains(this.name + "_mousemove"))
                {
                    this.delMouseMove = (Dbasic.b4p.del2) this.b4p.htSubs[this.name + "_mousemove"];
                    base.MouseMove += new MouseEventHandler(this.MouseMoveEvent);
                }
                if (this.b4p.htSubs.Contains(this.name + "_mouseup"))
                {
                    this.delMouseUp = (Dbasic.b4p.del2) this.b4p.htSubs[this.name + "_mouseup"];
                    base.MouseUp += new MouseEventHandler(this.MouseUpEvent);
                }
                if (this.b4p.htSubs.Contains(this.name + "_keypress"))
                {
                    this.delKeyDown = (Dbasic.b4p.del1) this.b4p.htSubs[this.name + "_keypress"];
                    base.KeyDown += new KeyEventHandler(this.KeyDownEvent);
                }
            }
            catch
            {
                throw new Exception("Error assigning event to " + this.name.Remove(0, 1) + ".\nCheck the number of arguments of each event sub.");
            }
        }

        public void AddMenu()
        {
            if (this.mainMenu1.MenuItems.Count == 1)
            {
                this.MaximumSize = new Size(0x2710, 0x2710);
                this.MinimumSize = new Size(0, 0);
                base.ClientSize = new Size(this.b4p.screenX, this.b4p.screenY);
                this.MaximumSize = this.MinimumSize = base.Size;
            }
        }

        public void AddRunTimeEvent(string eventName, string subName)
        {
            try
            {
                string str = eventName;
                if (str != null)
                {
                    if (str != "mousedown")
                    {
                        if (str == "mousemove")
                        {
                            goto Label_0077;
                        }
                        if (str == "mouseup")
                        {
                            goto Label_00A7;
                        }
                        if (str == "keypress")
                        {
                            goto Label_00D7;
                        }
                    }
                    else
                    {
                        this.delMouseDown = (Dbasic.b4p.del2) this.b4p.htSubs[subName];
                        base.MouseDown += new MouseEventHandler(this.MouseDownEvent);
                    }
                }
                return;
            Label_0077:
                this.delMouseMove = (Dbasic.b4p.del2) this.b4p.htSubs[subName];
                base.MouseMove += new MouseEventHandler(this.MouseMoveEvent);
                return;
            Label_00A7:
                this.delMouseUp = (Dbasic.b4p.del2) this.b4p.htSubs[subName];
                base.MouseUp += new MouseEventHandler(this.MouseUpEvent);
                return;
            Label_00D7:
                this.delKeyDown = (Dbasic.b4p.del1) this.b4p.htSubs[subName];
                base.KeyDown += new KeyEventHandler(this.KeyDownEvent);
            }
            catch
            {
                throw new Exception("Error assigning event to " + this.name.Remove(0, 1) + ".\nCheck the number of arguments of each event sub.");
            }
        }

        public void circle(Graphics g, int x1, int y1, int r, Color color, bool fill)
        {
            Rectangle c = new Rectangle(x1 - r, y1 - r, (2 * r) + 1, (2 * r) + 1);
            if (fill)
            {
                this.brush.Color = color;
                g.FillEllipse(this.brush, (int) (x1 - r), (int) (y1 - r), (int) (2 * r), (int) (2 * r));
            }
            else
            {
                this.pen.Color = color;
                g.DrawEllipse(this.pen, (int) (x1 - r), (int) (y1 - r), (int) (2 * r), (int) (2 * r));
            }
            c.Height++;
            c.Width++;
            this.FixedInvalidate(c);
        }

        public void close()
        {
            if ((this == this.b4p.mainForm) || this.b4p.alFormsDisplayOrder.Contains(this))
            {
                base.Close();
            }
        }

        private void CloseEvent()
        {
            this.cancelClose = false;
            this.delClose = (Dbasic.b4p.del0) this.b4p.htSubs[this.name + "_close"];
            this.b4p.sender = this.name;
            this.delClose();
        }

        bool IEnabled.get_Enabled() => 
            base.Enabled;

        void IEnabled.set_Enabled(bool flag1)
        {
            base.Enabled = flag1;
        }

        protected override void Dispose(bool disposing)
        {
            if (this.bitmap != null)
            {
                this.bitmap.Dispose();
            }
            if (this.foreBitmap != null)
            {
                this.foreBitmap.Dispose();
            }
            base.Dispose(disposing);
        }

        public void drawImage(Graphics g, Bitmap bitmap, int x1, int y1)
        {
            Rectangle c = new Rectangle(x1, y1, bitmap.Width, bitmap.Height);
            g.DrawImage(bitmap, x1, y1, new Rectangle(0, 0, bitmap.Width, bitmap.Height), GraphicsUnit.Pixel);
            c.Height++;
            c.Width++;
            this.FixedInvalidate(c);
        }

        public void drawImage(Graphics g, Bitmap bitmap, int x1, int y1, int x2, int y2)
        {
            Rectangle destRect = new Rectangle(Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs((int) (x2 - x1)), Math.Abs((int) (y2 - y1)));
            g.DrawImage(bitmap, destRect, new Rectangle(0, 0, bitmap.Width, bitmap.Height), GraphicsUnit.Pixel);
            destRect.Height++;
            destRect.Width++;
            this.FixedInvalidate(destRect);
        }

        public void drawString(Graphics g, string s, double fontSize, int x1, int y1, int x2, int y2, Color col)
        {
            Rectangle layoutRectangle = new Rectangle(Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs((int) (x2 - x1)), Math.Abs((int) (y2 - y1)));
            this.brush.Color = col;
            g.DrawString(s, new Font(this.Font.Name, (float) (fontSize / 1.0), this.Font.Style), this.brush, layoutRectangle);
            layoutRectangle.Height++;
            layoutRectangle.Width++;
            this.FixedInvalidate(layoutRectangle);
        }

        private void FinishPolygon(Graphics g, Point[] p, int xMin, int yMin, int xMax, int yMax, bool fill, Color col)
        {
            Rectangle c = new Rectangle(xMin, yMin, (xMax - xMin) + 1, (yMax - yMin) + 1);
            if (fill)
            {
                this.brush.Color = col;
                g.FillPolygon(this.brush, p);
            }
            else
            {
                this.pen.Color = col;
                g.DrawPolygon(this.pen, p);
            }
            this.FixedInvalidate(c);
        }

        public void FixedInvalidate(Rectangle c)
        {
            base.Invalidate(c);
        }

        private void HideForm(object sender, CancelEventArgs e)
        {
            if (this == this.b4p.mainForm)
            {
                if (!this.b4p.quitFlag)
                {
                    if (this.b4p.htSubs.Contains(this.b4p.mainForm.name + "_close"))
                    {
                        this.CloseEvent();
                    }
                    if (!this.b4p.quitFlag && this.b4p.mainForm.cancelClose)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
                if (this.b4p.mainForm != null)
                {
                    this.b4p.CloseProgram();
                }
            }
            if (!this.b4p.quitFlag)
            {
                if (this.b4p.htSubs.Contains(this.name + "_close"))
                {
                    this.CloseEvent();
                }
                if (this.cancelClose)
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = true;
                    base.Hide();
                    this.b4p.alFormsDisplayOrder.Remove(this);
                    ((Form) this.b4p.alFormsDisplayOrder[this.b4p.alFormsDisplayOrder.Count - 1]).Show();
                }
            }
        }

        private void InitializeComponent()
        {
            this.mainMenu1 = new MainMenu();
            base.SuspendLayout();
            base.AutoScaleMode = AutoScaleMode.Inherit;
            base.ClientSize = new Size(240, 0x10a);
            base.Menu = this.mainMenu1;
            base.MinimizeBox = false;
            base.Name = "CEnhancedForm";
            base.ResumeLayout(false);
        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            this.b4p.sender = this.name;
            this.delKeyDown(((int) e.KeyCode).ToString(Dbasic.b4p.cul));
        }

        public void line(Graphics g, int x1, int y1, int x2, int y2, Color color, bool box, bool fill)
        {
            Rectangle rect = new Rectangle(Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs((int) (x2 - x1)), Math.Abs((int) (y2 - y1)));
            if (box)
            {
                if (!fill)
                {
                    this.pen.Color = color;
                    g.DrawRectangle(this.pen, rect);
                }
                else
                {
                    this.brush.Color = color;
                    g.FillRectangle(this.brush, rect);
                }
            }
            else
            {
                this.pen.Color = color;
                g.DrawLine(this.pen, x1, y1, x2, y2);
            }
            rect.Height++;
            rect.Width++;
            this.FixedInvalidate(rect);
        }

        private void MouseDownEvent(object sender, MouseEventArgs e)
        {
            this.b4p.sender = this.name;
            double num = ((double) e.X) / 1.0;
            double num2 = ((double) e.Y) / 1.0;
            this.delMouseDown(num.ToString(Dbasic.b4p.cul), num2.ToString(Dbasic.b4p.cul));
        }

        private void MouseMoveEvent(object sender, MouseEventArgs e)
        {
            this.b4p.sender = this.name;
            double num = ((double) e.X) / 1.0;
            double num2 = ((double) e.Y) / 1.0;
            this.delMouseMove(num.ToString(Dbasic.b4p.cul), num2.ToString(Dbasic.b4p.cul));
        }

        private void MouseUpEvent(object sender, MouseEventArgs e)
        {
            this.b4p.sender = this.name;
            double num = ((double) e.X) / 1.0;
            double num2 = ((double) e.Y) / 1.0;
            this.delMouseUp(num.ToString(Dbasic.b4p.cul), num2.ToString(Dbasic.b4p.cul));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawImage(this.bitmap, this.destRect, 0, 0, this.bitmap.Width, this.bitmap.Height, GraphicsUnit.Pixel, this.backAttr);
            if (this.foreLayer)
            {
                e.Graphics.DrawImage(this.foreBitmap, this.destRect, 0, 0, this.bitmap.Width, this.bitmap.Height, GraphicsUnit.Pixel, this.imageAttr);
            }
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
        }

        public void polygon(Graphics g, double[,] xy, int start, int count, Color col, bool fill)
        {
            int num;
            int num2;
            int num6;
            int num7;
            Point[] p = new Point[count];
            p[0].X = num6 = xy[start, 0];
            int num3 = num = num6;
            p[0].Y = num7 = xy[start, 1];
            int num4 = num2 = num7;
            for (int i = 1; i < count; i++)
            {
                int num8;
                int num9;
                p[i].X = num8 = xy[start + i, 0];
                num3 = Math.Min(num3, num8);
                num = Math.Max(num, p[i].X);
                p[i].Y = num9 = xy[start + i, 1];
                num4 = Math.Min(num4, num9);
                num2 = Math.Max(num2, p[i].Y);
            }
            this.FinishPolygon(g, p, num3, num4, num, num2, fill, col);
        }

        public void polygon(Graphics g, string[,] xy, int start, int count, Color col, bool fill)
        {
            int num;
            int num2;
            int num6;
            int num7;
            Point[] p = new Point[count];
            p[0].X = num6 = double.Parse(xy[start, 0], Dbasic.b4p.cul);
            int num3 = num = num6;
            p[0].Y = num7 = double.Parse(xy[start, 1], Dbasic.b4p.cul);
            int num4 = num2 = num7;
            for (int i = 1; i < count; i++)
            {
                int num8;
                int num9;
                p[i].X = num8 = double.Parse(xy[start + i, 0], Dbasic.b4p.cul);
                num3 = Math.Min(num3, num8);
                num = Math.Max(num, p[i].X);
                p[i].Y = num9 = double.Parse(xy[start + i, 1], Dbasic.b4p.cul);
                num4 = Math.Min(num4, num9);
                num2 = Math.Max(num2, p[i].Y);
            }
            this.FinishPolygon(g, p, num3, num4, num, num2, fill, col);
        }

        public void polygon(Graphics g, double[] x, int startX, double[] y, int startY, int count, Color col, bool fill)
        {
            int num;
            int num2;
            int num6;
            int num7;
            Point[] p = new Point[count];
            p[0].X = num6 = x[startX];
            int num3 = num = num6;
            p[0].Y = num7 = y[startY];
            int num4 = num2 = num7;
            for (int i = 1; i < count; i++)
            {
                int num8;
                int num9;
                p[i].X = num8 = x[startX + i];
                num3 = Math.Min(num3, num8);
                num = Math.Max(num, p[i].X);
                p[i].Y = num9 = y[startY + i];
                num4 = Math.Min(num4, num9);
                num2 = Math.Max(num2, p[i].Y);
            }
            this.FinishPolygon(g, p, num3, num4, num, num2, fill, col);
        }

        public void polygon(Graphics g, string[] x, int startX, string[] y, int startY, int count, Color col, bool fill)
        {
            int num;
            int num2;
            int num6;
            int num7;
            Point[] p = new Point[count];
            p[0].X = num6 = double.Parse(x[startX], Dbasic.b4p.cul);
            int num3 = num = num6;
            p[0].Y = num7 = double.Parse(y[startY], Dbasic.b4p.cul);
            int num4 = num2 = num7;
            for (int i = 1; i < count; i++)
            {
                int num8;
                int num9;
                p[i].X = num8 = double.Parse(x[startX + i], Dbasic.b4p.cul);
                num3 = Math.Min(num3, num8);
                num = Math.Max(num, p[i].X);
                p[i].Y = num9 = double.Parse(y[startY + i], Dbasic.b4p.cul);
                num4 = Math.Min(num4, num9);
                num2 = Math.Max(num2, p[i].Y);
            }
            this.FinishPolygon(g, p, num3, num4, num, num2, fill, col);
        }

        public void show()
        {
            if (this.b4p.mainForm == null)
            {
                this.b4p.mainForm = this;
            }
            this.b4p.shownForm = this;
            if (!this.hideEventAdded)
            {
                base.Closing += new CancelEventHandler(this.HideForm);
                this.hideEventAdded = true;
            }
            if (this.b4p.htSubs.Contains(this.name + "_show"))
            {
                this.ShowEvent();
            }
            if ((this.b4p.alFormsDisplayOrder.Count <= 0) || (this.b4p.alFormsDisplayOrder[this.b4p.alFormsDisplayOrder.Count - 1] != this))
            {
                base.Show();
                if (this.b4p.alFormsDisplayOrder.Count > 0)
                {
                    ((Form) this.b4p.alFormsDisplayOrder[this.b4p.alFormsDisplayOrder.Count - 1]).Hide();
                }
                if (this == this.b4p.mainForm)
                {
                    this.b4p.alFormsDisplayOrder.Clear();
                }
                else
                {
                    this.b4p.alFormsDisplayOrder.Remove(this);
                }
                this.b4p.alFormsDisplayOrder.Add(this);
                this.activeState = true;
            }
        }

        private void ShowEvent()
        {
            this.delShow = (Dbasic.b4p.del0) this.b4p.htSubs[this.name + "_show"];
            this.b4p.sender = this.name;
            this.delShow();
        }

        public string propName =>
            this.name;

        public Bitmap MyBitmap
        {
            get => 
                this.bitmap;
            set
            {
                if (value == null)
                {
                    this.graphics.FillRectangle(new SolidBrush(this.BackColor), 0, 0, base.Width, base.Height);
                }
                else
                {
                    Rectangle srcRect = new Rectangle(0, 0, value.Width, value.Height);
                    this.graphics.DrawImage(value, new Rectangle(0, 0, this.bitmap.Width, this.bitmap.Height), srcRect, GraphicsUnit.Pixel);
                }
                this.Refresh();
            }
        }

        public override Color BackColor
        {
            get => 
                base.BackColor;
            set
            {
                base.BackColor = value;
                this.graphics.FillRectangle(new SolidBrush(this.BackColor), 0, 0, base.Width, base.Height);
                this.Refresh();
            }
        }

        public bool ForeLayer
        {
            get => 
                this.foreLayer;
            set
            {
                this.foreLayer = value;
                if (this.foreLayer && (this.foreBitmap == null))
                {
                    this.foreBitmap = new Bitmap((int) (((double) base.ClientSize.Width) / 1.0), (int) (((double) base.ClientSize.Height) / 1.0));
                    this.foreGraphics = Graphics.FromImage(this.foreBitmap);
                    this.foreGraphics.FillRectangle(this.b4p.foreBrush, this.destRect);
                    this.imageAttr.SetColorKey(this.b4p.transColor, this.b4p.transColor);
                }
            }
        }

        string IEnhancedControl.propName =>
            this.name;
    }
}

