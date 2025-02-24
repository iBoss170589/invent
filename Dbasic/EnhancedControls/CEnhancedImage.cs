namespace Dbasic.EnhancedControls
{
    using Dbasic;
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class CEnhancedImage : PictureBox, IEnhancedControl, IImage, IEnabled
    {
        public string name;
        public string picFile = "";
        public string imageMode = "CNormalImage";
        private Dbasic.b4p b4p;
        private Dbasic.b4p.del0 delClick;

        public CEnhancedImage(Dbasic.b4p b4p)
        {
            this.b4p = b4p;
            base.SizeMode = PictureBoxSizeMode.Normal;
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
                string str;
                if (((str = eventName) != null) && (str == "click"))
                {
                    this.delClick = (Dbasic.b4p.del0) this.b4p.htSubs[subName];
                    base.Click += new EventHandler(this.ClickEvent);
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
            this.delClick();
        }

        bool IEnabled.get_Enabled() => 
            base.Enabled;

        void IEnabled.set_Enabled(bool flag1)
        {
            base.Enabled = flag1;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }

        public string propName =>
            this.name;

        public Bitmap MyBitmap
        {
            get => 
                (Bitmap) base.Image;
            set => 
                base.Image = value;
        }

        public string MyImageMode
        {
            get => 
                this.imageMode;
            set
            {
                switch (value.ToLower(Dbasic.b4p.cul))
                {
                    case "cstretchimage":
                        base.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;

                    case "ccenterimage":
                        base.SizeMode = PictureBoxSizeMode.CenterImage;
                        break;

                    default:
                        base.SizeMode = PictureBoxSizeMode.Normal;
                        break;
                }
                this.imageMode = value;
            }
        }
    }
}

