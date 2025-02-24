namespace Dbasic.EnhancedControls
{
    using Dbasic;
    using System;
    using System.Windows.Forms;

    public class CEnhancedTimer : Timer, IEnhancedControl, IEnabled
    {
        public string name;
        private Dbasic.b4p b4p;
        private Dbasic.b4p.del0 delTick;

        public CEnhancedTimer(Dbasic.b4p b4p)
        {
            this.b4p = b4p;
        }

        public void AddEvents()
        {
            try
            {
                if (this.b4p.htSubs.Contains(this.name + "_tick"))
                {
                    this.delTick = (Dbasic.b4p.del0) this.b4p.htSubs[this.name + "_tick"];
                    base.Tick += new EventHandler(this.TickEvent);
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
            if (((str = eventName) != null) && (str == "tick"))
            {
                this.delTick = (Dbasic.b4p.del0) this.b4p.htSubs[subName];
                base.Tick += new EventHandler(this.TickEvent);
            }
        }

        private void TickEvent(object sender, EventArgs e)
        {
            this.b4p.sender = this.name;
            this.delTick();
        }

        public string propName =>
            this.name;

        string IEnhancedControl.propName =>
            this.name;
    }
}

