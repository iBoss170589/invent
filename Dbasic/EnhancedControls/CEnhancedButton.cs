namespace Dbasic.EnhancedControls
{
    using Dbasic;
    using System;
    using System.Windows.Forms;

    public class CEnhancedButton : Button, IEnhancedControl, IEnabled, IText
    {
        public string name;
        private Dbasic.b4p b4p;
        private Dbasic.b4p.del1 delKeyPress;
        private Dbasic.b4p.del0 delClick;

        public CEnhancedButton(Dbasic.b4p b4p)
        {
            this.b4p = b4p;
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
                if (this.b4p.htSubs.Contains(this.name + "_keypress"))
                {
                    this.delKeyPress = (Dbasic.b4p.del1) this.b4p.htSubs[this.name + "_keypress"];
                    base.KeyPress += new KeyPressEventHandler(this.KeyPressEvent);
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
                    if (str == "click")
                    {
                        this.delClick = (Dbasic.b4p.del0) this.b4p.htSubs[subName];
                        base.Click += new EventHandler(this.ClickEvent);
                    }
                    else if (str == "keypress")
                    {
                        goto Label_0051;
                    }
                }
                return;
            Label_0051:
                this.delKeyPress = (Dbasic.b4p.del1) this.b4p.htSubs[subName];
                base.KeyPress += new KeyPressEventHandler(this.KeyPressEvent);
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

        private void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            this.b4p.sender = this.name;
            this.delKeyPress(e.KeyChar.ToString(Dbasic.b4p.cul));
        }

        public string propName =>
            this.name;
    }
}

