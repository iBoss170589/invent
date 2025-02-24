namespace Dbasic.EnhancedControls
{
    using Dbasic;
    using System;
    using System.Windows.Forms;

    public class CEnhancedCombo : ComboBox, IEnhancedControl, IEnabled, IText
    {
        public string name;
        private Dbasic.b4p b4p;
        private Dbasic.b4p.del0 delGotFocus;
        private Dbasic.b4p.del0 delLostFocus;
        private Dbasic.b4p.del2 delIndexChanged;

        public CEnhancedCombo(Dbasic.b4p b4p)
        {
            this.b4p = b4p;
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
                if (this.b4p.htSubs.Contains(this.name + "_selectionchanged"))
                {
                    this.delIndexChanged = (Dbasic.b4p.del2) this.b4p.htSubs[this.name + "_selectionchanged"];
                    base.SelectedIndexChanged += new EventHandler(this.SelectedIndexChangedEvent);
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
                        if (str == "selectionchanged")
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
                this.delIndexChanged = (Dbasic.b4p.del2) this.b4p.htSubs[subName];
                base.SelectedIndexChanged += new EventHandler(this.SelectedIndexChangedEvent);
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

        private void LostFocusEvent(object sender, EventArgs e)
        {
            this.b4p.sender = this.name;
            this.delLostFocus();
        }

        private void SelectedIndexChangedEvent(object sender, EventArgs e)
        {
            this.b4p.sender = this.name;
            this.delIndexChanged(this.SelectedIndex.ToString(Dbasic.b4p.cul), (this.SelectedIndex > -1) ? base.SelectedItem.ToString() : "");
        }

        public string propName =>
            this.name;
    }
}

