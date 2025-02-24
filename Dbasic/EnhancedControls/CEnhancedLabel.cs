namespace Dbasic.EnhancedControls
{
    using Dbasic;
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class CEnhancedLabel : Control, IEnhancedControl, IText, IEnabled
    {
        public string name;
        public bool transparent;
        private Rectangle destRect;
        private Brush bgdBrush;
        private Brush textBrush;
        private StringFormat stringFormat;
        private Dbasic.b4p b4p;
        private Brush currentBrush;
        private Brush disabledBrush;

        public CEnhancedLabel(Dbasic.b4p b4p)
        {
            this.b4p = b4p;
            this.stringFormat = new StringFormat();
            this.destRect = new Rectangle(0, 0, base.Width, base.Height);
            this.textBrush = new SolidBrush(this.ForeColor);
            this.bgdBrush = new SolidBrush(this.BackColor);
            this.disabledBrush = new SolidBrush(SystemColors.InactiveCaptionText);
            base.Enabled = false;
            base.TabStop = false;
            this.currentBrush = this.textBrush;
        }

        bool IEnabled.get_Enabled() => 
            base.Enabled;

        void IEnabled.set_Enabled(bool flag1)
        {
            base.Enabled = flag1;
        }

        void IEnhancedControl.AddRunTimeEvent(string eventName, string subName)
        {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            this.destRect.Width = base.Width;
            this.destRect.Height = base.Height;
            if (!this.transparent)
            {
                graphics.FillRectangle(this.bgdBrush, this.destRect);
            }
            else if (base.Parent is Panel)
            {
                graphics.FillRectangle(new SolidBrush(base.Parent.BackColor), 0, 0, base.Width, base.Height);
            }
            else if (base.Parent is CEnhancedForm)
            {
                CEnhancedForm parent = (CEnhancedForm) base.Parent;
                graphics.DrawImage(parent.bitmap, new Rectangle(0, 0, base.Width, base.Height), new Rectangle((int) (((double) base.Left) / 1.0), (int) (((double) base.Top) / 1.0), (int) (((double) base.Width) / 1.0), (int) (((double) base.Height) / 1.0)), GraphicsUnit.Pixel);
            }
            graphics.DrawString(base.Text, this.Font, this.currentBrush, this.destRect, this.stringFormat);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
        }

        public override Color ForeColor
        {
            get => 
                base.ForeColor;
            set
            {
                Brush brush = new SolidBrush(value);
                if (this.currentBrush == this.textBrush)
                {
                    this.currentBrush = brush;
                }
                this.textBrush = brush;
                base.ForeColor = value;
            }
        }

        public override Color BackColor
        {
            get => 
                base.BackColor;
            set
            {
                this.bgdBrush = new SolidBrush(value);
                base.BackColor = value;
            }
        }

        public bool Transparent
        {
            get => 
                this.transparent;
            set => 
                this.transparent = value;
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

        public string propName =>
            this.name;

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

        public bool MyEnabled
        {
            get => 
                this.currentBrush != this.disabledBrush;
            set
            {
                if (!value)
                {
                    this.currentBrush = this.disabledBrush;
                }
                else
                {
                    this.currentBrush = this.textBrush;
                }
                this.Refresh();
            }
        }
    }
}

