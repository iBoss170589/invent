namespace Dbasic.EnhancedControls
{
    using Dbasic;
    using System;
    using System.Windows.Forms;

    public class CEnhancedNumUpDown : NumericUpDown, IEnhancedControl, IEnabled
    {
        public string name;
        private Dbasic.b4p b4p;
        private Dbasic.b4p.del0 delValueChanged;

        public CEnhancedNumUpDown(Dbasic.b4p b4p)
        {
            this.b4p = b4p;
            base.Maximum = 100M;
            base.Minimum = 0M;
            base.Value = 0M;
        }

        public void AddEvents()
        {
            try
            {
                if (this.b4p.htSubs.Contains(this.name + "_valuechanged"))
                {
                    this.delValueChanged = (Dbasic.b4p.del0) this.b4p.htSubs[this.name + "_valuechanged"];
                    base.ValueChanged += new EventHandler(this.ValueChangedEvent);
                }
            }
            catch
            {
                throw new Exception("Error assigning event to " + this.name.Remove(0, 1) + ".\nCheck the number of arguments of each event sub.");
            }
        }

        public void AddRunTimeEvent(string eventName, string subName)
        {
            string str;
            if (((str = eventName) != null) && (str == "valuechanged"))
            {
                this.delValueChanged = (Dbasic.b4p.del0) this.b4p.htSubs[subName];
                base.ValueChanged += new EventHandler(this.ValueChangedEvent);
            }
        }

        bool IEnabled.get_Enabled() => 
            base.Enabled;

        void IEnabled.set_Enabled(bool flag1)
        {
            base.Enabled = flag1;
        }

        private void ValueChangedEvent(object sender, EventArgs e)
        {
            this.b4p.sender = this.name;
            this.delValueChanged();
        }

        public string propName =>
            this.name;
    }
}

