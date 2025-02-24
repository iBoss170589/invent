namespace Dbasic.EnhancedControls
{
    using Dbasic;
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Windows.Forms;

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
        private Dbasic.b4p b4p;
        private Dbasic.b4p.del0 delClick;
        private Dbasic.b4p.del0 delMouseDown;
        private Dbasic.b4p.del0 delMouseUp;

        public CEnhancedImageButton(Dbasic.b4p b4p)
        {
            this.b4p = b4p;
            this.Font = new Font(this.Font.Name, this.Font.Size, FontStyle.Bold);
        }

        public void AddEvents()
        {
            try
            {
                if (this.b4p.htSubs.Contains(this.name + "_click"))
                {
                    this.delClick = (Dbasic.b4p.del0) this.b4p.htSubs[this.name + "_click"];
                    base.Click += new EventHandler(this.ClickEvent);
                }
                if (this.b4p.htSubs.Contains(this.name + "_buttondown"))
                {
                    this.delMouseDown = (Dbasic.b4p.del0) this.b4p.htSubs[this.name + "_buttondown"];
                    base.MouseDown += new MouseEventHandler(this.MouseDownEvent);
                }
                if (this.b4p.htSubs.Contains(this.name + "_buttonup"))
                {
                    this.delMouseUp = (Dbasic.b4p.del0) this.b4p.htSubs[this.name + "_buttonup"];
                    base.MouseUp += new MouseEventHandler(this.MouseUpEvent);
                }
            }
            catch
            {
                throw new Exception("Error assigning event to " + this.name.Remove(0, 1) + ".\nCheck the number of arguments of each event sub.");
            }
        }

        public void AddRunTimeEvent(string eventName, string subName)
        {
            string str = eventName;
            if (str != null)
            {
                if (str != "click")
                {
                    if (str != "buttondown")
                    {
                        if (str == "buttonup")
                        {
                            this.delMouseUp = (Dbasic.b4p.del0) this.b4p.htSubs[subName];
                            base.MouseUp += new MouseEventHandler(this.MouseUpEvent);
                        }
                        return;
                    }
                }
                else
                {
                    this.delClick = (Dbasic.b4p.del0) this.b4p.htSubs[subName];
                    base.Click += new EventHandler(this.ClickEvent);
                    return;
                }
                this.delMouseDown = (Dbasic.b4p.del0) this.b4p.htSubs[subName];
                base.MouseDown += new MouseEventHandler(this.MouseDownEvent);
            }
        }

        private void ClickEvent(object sender, EventArgs e)
        {
            this.b4p.sender = this.name;
            this.delClick();
        }

        bool IEnabled.get_Enabled() => 
            base.Enabled;

        void IEnabled.set_Enabled(bool flag1)
        {
            base.Enabled = flag1;
        }

        protected override void Dispose(bool disposing)
        {
            if (this.textBrush != null)
            {
                this.textBrush.Dispose();
            }
            if (this.pen != null)
            {
                this.pen.Dispose();
            }
            if (this.button != null)
            {
                this.button.Dispose();
            }
            if (this.brush != null)
            {
                this.brush.Dispose();
            }
            base.Dispose(disposing);
        }

        private void MouseDownEvent(object sender, MouseEventArgs e)
        {
            this.b4p.sender = this.name;
            this.delMouseDown();
        }

        private void MouseUpEvent(object sender, MouseEventArgs e)
        {
            this.b4p.sender = this.name;
            this.delMouseUp();
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnClick(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            this.bPushed = true;
            base.Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            this.bPushed = false;
            base.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            SizeF ef;
            int x = 0;
            if (this.bPushed)
            {
                x = Dbasic.b4p.scaleX;
            }
            if ((this.button == null) || (this.button.Size != base.Size))
            {
                if (this.button != null)
                {
                    this.button.Dispose();
                }
                this.button = new Bitmap(base.Width, base.Height);
                this.g = Graphics.FromImage(this.button);
                this.destRect = new Rectangle(0, 0, this.button.Width, this.button.Height);
            }
            if (!this.transparent)
            {
                if (this.brush.Color != this.BackColor)
                {
                    this.brush.Color = this.BackColor;
                }
                if (this.bPushed)
                {
                    this.g.FillRectangle(this.pushedBrush, 0, 0, base.Width, base.Height);
                }
                else
                {
                    this.g.FillRectangle(this.brush, 0, 0, base.Width, base.Height);
                }
            }
            else if (base.Parent is Panel)
            {
                this.g.FillRectangle(new SolidBrush(base.Parent.BackColor), 0, 0, base.Width, base.Height);
            }
            else
            {
                CEnhancedForm parent = (CEnhancedForm) base.Parent;
                this.g.DrawImage(parent.bitmap, new Rectangle(0, 0, base.Width, base.Height), new Rectangle((int) (((double) base.Left) / 1.0), (int) (((double) base.Top) / 1.0), (int) (((double) base.Width) / 1.0), (int) (((double) base.Height) / 1.0)), GraphicsUnit.Pixel);
            }
            if (this.bitmap != null)
            {
                string str = this.imageMode.ToLower(Dbasic.b4p.cul);
                if (str == null)
                {
                    goto Label_02FF;
                }
                if (str != "ccenterimage")
                {
                    if (str == "cstretchimage")
                    {
                        this.g.DrawImage(this.bitmap, new Rectangle(x, x, base.Width, base.Height), 0, 0, this.bitmap.Width, this.bitmap.Height, GraphicsUnit.Pixel, this.imageAttr);
                        goto Label_0364;
                    }
                    goto Label_02FF;
                }
                this.g.DrawImage(this.bitmap, new Rectangle(((base.Width / 2) - ((int) ((this.bitmap.Width / 2) * 1.0))) + x, ((base.Height / 2) - ((int) ((this.bitmap.Height / 2) * 1.0))) + x, (int) (this.bitmap.Width * 1.0), (int) (this.bitmap.Height * 1.0)), 0, 0, this.bitmap.Width, this.bitmap.Height, GraphicsUnit.Pixel, this.imageAttr);
            }
            goto Label_0364;
        Label_02FF:
            this.g.DrawImage(this.bitmap, new Rectangle(x, x, (int) (this.bitmap.Width * 1.0), (int) (this.bitmap.Height * 1.0)), 0, 0, this.bitmap.Width, this.bitmap.Height, GraphicsUnit.Pixel, this.imageAttr);
        Label_0364:
            ef = this.g.MeasureString(this.Text, this.Font);
            if (this.textBrush.Color != this.ForeColor)
            {
                this.textBrush.Color = this.ForeColor;
            }
            this.g.DrawString(base.Text, this.Font, this.textBrush, (float) (((base.Width - ef.Width) / 2f) + x), (float) (((base.Height - ef.Height) / 2f) + x));
            e.Graphics.DrawImage(this.button, this.destRect, this.destRect, GraphicsUnit.Pixel);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
        }

        public override string Text
        {
            get => 
                base.Text;
            set
            {
                base.Text = value;
                this.Refresh();
            }
        }

        public bool Transparent
        {
            get => 
                this.transparent;
            set
            {
                if (value && (this.bitmap != null))
                {
                    this.imageAttr.SetColorKey(this.bitmap.GetPixel(0, 0), this.bitmap.GetPixel(0, 0));
                }
                else
                {
                    this.imageAttr.ClearColorKey();
                }
                this.transparent = value;
            }
        }

        public Bitmap MyBitmap
        {
            get => 
                this.bitmap;
            set
            {
                this.bitmap = (value != null) ? new Bitmap(value) : null;
                if ((value != null) && this.transparent)
                {
                    this.imageAttr.SetColorKey(this.bitmap.GetPixel(0, 0), this.bitmap.GetPixel(0, 0));
                }
                this.Refresh();
            }
        }

        public string propName =>
            this.name;
    }
}

