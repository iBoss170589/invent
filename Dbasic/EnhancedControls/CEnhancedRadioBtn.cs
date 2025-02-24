namespace Dbasic.EnhancedControls
{
    using Dbasic;
    using System;
    using System.Windows.Forms;

    public class CEnhancedRadioBtn : RadioButton, IEnhancedControl, IText, IEnabled, IChecked
    {
        public string name;
        private Dbasic.b4p b4p;
        private Dbasic.b4p.del0 delClick;

        public CEnhancedRadioBtn(Dbasic.b4p b4p)
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
            if (base.Parent is Form)
            {
                if ((base.Parent is CEnhancedForm) && !((CEnhancedForm) base.Parent).activeState)
                {
                    return;
                }
            }
            else
            {
                Control parent = this;
                while (!(parent.Parent is Form))
                {
                    parent = parent.Parent;
                }
                if ((parent.Parent is CEnhancedForm) && !((CEnhancedForm) parent.Parent).activeState)
                {
                    return;
                }
            }
            this.b4p.sender = this.name;
            this.delClick();
        }

        bool IChecked.get_Checked() => 
            base.Checked;

        void IChecked.set_Checked(bool flag1)
        {
            base.Checked = flag1;
        }

        bool IEnabled.get_Enabled() => 
            base.Enabled;

        void IEnabled.set_Enabled(bool flag1)
        {
            base.Enabled = flag1;
        }

        public string propName =>
            this.name;
    }
}

