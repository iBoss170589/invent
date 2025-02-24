// Decompiled with JetBrains decompiler
// Type: Dbasic.EnhancedControls.CEnhancedObject
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

using System;
using System.Collections;
using System.Reflection;
using System.Threading;

#nullable disable
namespace Dbasic.EnhancedControls
{
  public class CEnhancedObject
  {
    private b4p b4p;
    public Hashtable htShemotAzamim = new Hashtable();
    private object eventObject;
    private EventHandler doMethod;

    public CEnhancedObject(b4p b4p)
    {
      this.b4p = b4p;
      this.doMethod = new EventHandler(this.MetapelEruim2);
    }

    public object GetControlStringOrRef(string module, object o)
    {
      return o is string ? this.b4p.htControls[(object) ("_" + Other.FixRuntimeControlName(o.ToString().ToLower(b4p.cul), module))] : o;
    }

    public void AddRunTimeEvent(object o, string name, string eventName, string subName)
    {
      EventInfo eventInfo = o.GetType().GetEvent(eventName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
      this.b4p.htSubs.Remove((object) (name + "_" + eventName));
      this.b4p.htSubs.Add((object) (name + "_" + eventName), this.b4p.htSubs[(object) subName]);
      if (eventInfo == null)
        throw new Exception("Event does not exist in object.");
      eventInfo.AddEventHandler(o, (Delegate) new EventHandler(this.MetapelEruim));
    }

    public void AddEventsForUnknownControls(object o, string name)
    {
      foreach (EventInfo eventInfo in o.GetType().GetEvents(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public))
      {
        if (this.b4p.htSubs.Contains((object) (name + "_" + eventInfo.Name.ToLower(b4p.cul))))
          eventInfo.AddEventHandler(o, (Delegate) new EventHandler(this.MetapelEruim));
      }
    }

    public void MetapelEruim(object sender, EventArgs e)
    {
      try
      {
        if (this.b4p.tdRunning != null && this.b4p.tdRunning != Thread.CurrentThread)
        {
          lock (this)
          {
            this.eventObject = sender;
            if (this.b4p.mainForm == null)
              return;
            this.b4p.mainForm.Invoke((Delegate) this.doMethod);
          }
        }
        else
        {
          object[] objArray = (object[]) sender;
          string str1 = (string) this.htShemotAzamim[objArray[0]];
          this.b4p.sender = str1;
          string str2 = ((b4p.del0) this.b4p.htSubs[(object) (str1 + "_" + ((string) objArray[1]).ToLower(b4p.cul))])();
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
        object[] eventObject = (object[]) this.eventObject;
        this.eventObject = (object) null;
        string str1 = (string) this.htShemotAzamim[eventObject[0]];
        this.b4p.sender = str1;
        string str2 = ((b4p.del0) this.b4p.htSubs[(object) (str1 + "_" + ((string) eventObject[1]).ToLower(b4p.cul))])();
      }
      catch
      {
      }
    }
  }
}
