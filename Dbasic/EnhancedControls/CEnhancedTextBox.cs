namespace Dbasic.EnhancedControls
{
    using Dbasic;
    using System;
    using System.Windows.Forms;

    public class CEnhancedTextBox : TextBox, IEnhancedControl, IText, IEnabled
    {
        public string name;
        public bool handled;
        private Dbasic.b4p b4p;
        private Dbasic.b4p.del1 delKeyPress;
        private Dbasic.b4p.del0 delGotFocus;
        private Dbasic.b4p.del0 delLostFocus;

        public CEnhancedTextBox(Dbasic.b4p b4p)
        {
            this.b4p = b4p;
            base.AcceptsReturn = true;
            base.AcceptsTab = true;
            base.WordWrap = true;
        }

        public void AddEvents()
        {
            try
            {
                if (this.b4p.htSubs.Contains(this.name + "_gotfocus"))
                {
                    this.delGotFocus = (Dbasic.b4p.del0) this.b4p.htSubs[this.name + "_gotfocus"];
                    base.GotFocus += new EventHandler(this.GotFocusEvent);
                }
                if (this.b4p.htSubs.Contains(this.name + "_lostfocus"))
                {
                    this.delLostFocus = (Dbasic.b4p.del0) this.b4p.htSubs[this.name + "_lostfocus"];
                    base.LostFocus += new EventHandler(this.LostFocusEvent);
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
                    if (str != "gotfocus")
                    {
                        if (str == "lostfocus")
                        {
                            goto Label_0064;
                        }
                        if (str == "keypress")
                        {
                            goto Label_0094;
                        }
                    }
                    else
                    {
                        this.delGotFocus = (Dbasic.b4p.del0) this.b4p.htSubs[subName];
                        base.GotFocus += new EventHandler(this.GotFocusEvent);
                    }
                }
                return;
            Label_0064:
                this.delLostFocus = (Dbasic.b4p.del0) this.b4p.htSubs[subName];
                base.LostFocus += new EventHandler(this.LostFocusEvent);
                return;
            Label_0094:
                this.delKeyPress = (Dbasic.b4p.del1) this.b4p.htSubs[subName];
                base.KeyPress += new KeyPressEventHandler(this.KeyPressEvent);
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

        private void GotFocusEvent(object sender, EventArgs e)
        {
            this.b4p.sender = this.name;
            this.delGotFocus();
        }

        private void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            this.handled = false;
            this.b4p.sender = this.name;
            this.delKeyPress(e.KeyChar.ToString(Dbasic.b4p.cul));
            if (this.handled)
            {
                e.Handled = true;
            }
        }

        private void LostFocusEvent(object sender, EventArgs e)
        {
            this.b4p.sender = this.name;
            this.delLostFocus();
        }

        public string propName =>
            this.name;

        public bool multiline
        {
            get => 
                this.Multiline;
            set
            {
                if (value)
                {
                    this.Multiline = true;
                    base.ScrollBars = ScrollBars.Vertical;
                }
                else
                {
                    this.Multiline = false;
                    base.ScrollBars = ScrollBars.None;
                }
            }
        }
    }
}

