// Decompiled with JetBrains decompiler
// Type: FormLib.ContextMenu
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

using System;
using System.Windows.Forms;

namespace FormLib
{
  public class ContextMenu : IDisposable
  {
    private System.Windows.Forms.ContextMenu cm;
    private object[] eventObject;
    private string selectedText;
    private int selectedIndex;

    public event EventHandler Click;

    public ContextMenu()
    {
      this.cm = new System.Windows.Forms.ContextMenu();
      this.eventObject = new object[2]
      {
        (object) this,
        (object) nameof (Click)
      };
    }

    public void AddItem(string Text)
    {
      MenuItem menuItem = new MenuItem();
      menuItem.Text = Text;
      menuItem.Click += new EventHandler(this.mnu_Click);
      this.cm.MenuItems.Add(menuItem);
    }

    public void RemoveItem(int Index) => this.cm.MenuItems.RemoveAt(Index);

    public string SelectedText => this.selectedText;

    public int SelectedIndex => this.selectedIndex;

    public int Count => this.cm.MenuItems.Count;

    private void mnu_Click(object sender, EventArgs e)
    {
      MenuItem menuItem = (MenuItem) sender;
      this.selectedText = menuItem.Text;
      this.selectedIndex = this.cm.MenuItems.IndexOf(menuItem);
      if (this.Click == null)
        return;
      this.Click((object) this.eventObject, (EventArgs) null);
    }

    public System.Windows.Forms.ContextMenu Value
    {
      get => this.cm;
      set => this.cm = value;
    }

    public void Dispose()
    {
      this.Click = (EventHandler) null;
      this.cm = (System.Windows.Forms.ContextMenu) null;
    }
  }
}
