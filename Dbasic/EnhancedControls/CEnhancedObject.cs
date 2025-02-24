namespace Dbasic.EnhancedControls
{
    using Dbasic;
    using System;
    using System.Collections;
    using System.Reflection;
    using System.Threading;

    public class CEnhancedObject
    {
        private Dbasic.b4p b4p;
        public Hashtable htShemotAzamim = new Hashtable();
        private object eventObject;
        private EventHandler doMethod;

        public CEnhancedObject(Dbasic.b4p b4p)
        {
            this.b4p = b4p;
            this.doMethod = new EventHandler(this.MetapelEruim2);
        }

        public void AddEventsForUnknownControls(object o, string name)
        {
            foreach (EventInfo info in o.GetType().GetEvents(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance))
            {
                if (this.b4p.htSubs.Contains(name + "_" + info.Name.ToLower(Dbasic.b4p.cul)))
                {
                    info.AddEventHandler(o, new EventHandler(this.MetapelEruim));
                }
            }
        }

        public void AddRunTimeEvent(object o, string name, string eventName, string subName)
        {
            EventInfo info = o.GetType().GetEvent(eventName, BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.IgnoreCase);
            this.b4p.htSubs.Remove(name + "_" + eventName);
            this.b4p.htSubs.Add(name + "_" + eventName, this.b4p.htSubs[subName]);
            if (info == null)
            {
                throw new Exception("Event does not exist in object.");
            }
            info.AddEventHandler(o, new EventHandler(this.MetapelEruim));
        }

        public object GetControlStringOrRef(string module, object o)
        {
            if (o is string)
            {
                return this.b4p.htControls["_" + Other.FixRuntimeControlName(o.ToString().ToLower(Dbasic.b4p.cul), module)];
            }
            return o;
        }

        public void MetapelEruim(object sender, EventArgs e)
        {
            try
            {
                if ((this.b4p.tdRunning != null) && (this.b4p.tdRunning != Thread.CurrentThread))
                {
                    lock (this)
                    {
                        this.eventObject = sender;
                        if (this.b4p.mainForm != null)
                        {
                            this.b4p.mainForm.Invoke(this.doMethod);
                        }
                    }
                }
                else
                {
                    object[] objArray = sender;
                    string str = (string) this.htShemotAzamim[objArray[0]];
                    this.b4p.sender = str;
                    Dbasic.b4p.del0 del = (Dbasic.b4p.del0) this.b4p.htSubs[str + "_" + ((string) objArray[1]).ToLower(Dbasic.b4p.cul)];
                    del();
                }
            }
            catch
            {
            }
        }

        private void MetapelEruim2(object sender, EventArgs e)
        {
            try
            {
                object[] eventObject = this.eventObject;
                this.eventObject = null;
                string str = (string) this.htShemotAzamim[eventObject[0]];
                this.b4p.sender = str;
                Dbasic.b4p.del0 del = (Dbasic.b4p.del0) this.b4p.htSubs[str + "_" + ((string) eventObject[1]).ToLower(Dbasic.b4p.cul)];
                del();
            }
            catch
            {
            }
        }
    }
}

