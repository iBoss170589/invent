namespace FormLib
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    public class ContextMenu : IDisposable
    {
        private System.Windows.Forms.ContextMenu cm = new System.Windows.Forms.ContextMenu();
        private EventHandler Click;
        private object[] eventObject;
        private string selectedText;
        private int selectedIndex;

        public event EventHandler Click;

        public ContextMenu()
        {
            this.eventObject = new object[] { this, "Click" };
        }

        public void AddItem(string Text)
        {
            MenuItem item = new MenuItem {
                Text = Text
            };
            item.Click += new EventHandler(this.mnu_Click);
            this.cm.MenuItems.Add(item);
        }

        public void Dispose()
        {
            this.Click = null;
            this.cm = null;
        }

        private void mnu_Click(object sender, EventArgs e)
        {
            MenuItem item = sender;
            this.selectedText = item.Text;
            this.selectedIndex = this.cm.MenuItems.IndexOf(item);
            if (this.Click != null)
            {
                this.Click(this.eventObject, null);
            }
        }

        public void RemoveItem(int Index)
        {
            this.cm.MenuItems.RemoveAt(Index);
        }

        public string SelectedText =>
            this.selectedText;

        public int SelectedIndex =>
            this.selectedIndex;

        public int Count =>
            this.cm.MenuItems.Count;

        public System.Windows.Forms.ContextMenu Value
        {
            get => 
                this.cm;
            set => 
                this.cm = value;
        }
    }
}

