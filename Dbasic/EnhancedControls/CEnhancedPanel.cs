namespace Dbasic.EnhancedControls
{
    using Dbasic;
    using System;
    using System.Windows.Forms;

    public class CEnhancedPanel : Panel, IEnhancedControl, IEnabled
    {
        public string name;
        private Dbasic.b4p b4p;
        private Dbasic.b4p.del2 delMouseDown;
        private Dbasic.b4p.del2 delMouseMove;
        private Dbasic.b4p.del2 delMouseUp;

        public CEnhancedPanel(Dbasic.b4p b4p)
        {
            this.b4p = b4p;
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
                string str = eventName;
                if (str != null)
                {
                    if (str != "mousedown")
                    {
                        if (str == "mousemove")
                        {
                            goto Label_0064;
                        }
                        if (str == "mouseup")
                        {
                            goto Label_0094;
                        }
                    }
                    else
                    {
                        this.delMouseDown = (Dbasic.b4p.del2) this.b4p.htSubs[subName];
                        base.MouseDown += new MouseEventHandler(this.MouseDownEvent);
                    }
                }
                return;
            Label_0064:
                this.delMouseMove = (Dbasic.b4p.del2) this.b4p.htSubs[subName];
                base.MouseMove += new MouseEventHandler(this.MouseMoveEvent);
                return;
            Label_0094:
                this.delMouseUp = (Dbasic.b4p.del2) this.b4p.htSubs[subName];
                base.MouseUp += new MouseEventHandler(this.MouseUpEvent);
            }
            catch
            {
                throw new Exception("Error assigning event to " + this.name.Remove(0, 1) + ".\nCheck the number of arguments of each event sub.");
            }
        }

        bool IEnabled.get_Enabled() => 
            base.Enabled;

        void IEnabled.set_Enabled(bool flag1)
        {
            base.Enabled = flag1;
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

        public string propName =>
            this.name;
    }
}

