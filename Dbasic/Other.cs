// Decompiled with JetBrains decompiler
// Type: Dbasic.Other
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;


namespace Dbasic
{
  public class Other
  {
    private b4p b4p;
    private int SND_ASYNC = 1;
    private int SND_FILENAME = 131072;
    private static bool scaledSet;

    public Other(b4p b4p) => this.b4p = b4p;

    public double FileSearch(string al, string path, string pattern)
    {
      ArrayList htControl = (ArrayList) this.b4p.htControls[(object) al];
      htControl.AddRange((ICollection) Directory.GetFiles(Path.Combine(this.b4p.b4pdir, path), pattern));
      return (double) htControl.Count;
    }

    public double DirSearch(string al, string path, string pattern)
    {
      ArrayList htControl = (ArrayList) this.b4p.htControls[(object) al];
      htControl.AddRange((ICollection) Directory.GetDirectories(Path.Combine(this.b4p.b4pdir, path), pattern));
      return (double) htControl.Count;
    }

    [DllImport("WinMM.dll")]
    public static extern bool PlaySound(string fname, int Mod, int flag);

    public void Sound(string file) => Other.PlaySound(file, 0, this.SND_FILENAME | this.SND_ASYNC);

    public string SubString(string original, int start, int count)
    {
      if (start + count > original.Length)
      {
        string str = new string(' ', start + count - original.Length);
        original += str;
      }
      return original.Substring(start, count);
    }

    public string IsNumber(string s)
    {
      try
      {
        double.Parse(s, (IFormatProvider) b4p.cul);
        return "true";
      }
      catch
      {
        return "false";
      }
    }

    public Bitmap GetBitmapFromResource(string res)
    {
      return new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream(res.ToLower(b4p.cul).Replace(" ", "~")));
    }

    public Bitmap GetBitmapFromString(object o)
    {
      if (!(o is string))
        return (Bitmap) o;
      if ((string) o == "")
        return (Bitmap) null;
      string str = Path.Combine(this.b4p.b4pdir, (string) o);
      if (File.Exists(str))
        return new Bitmap(str);
      int num = (int) MessageBox.Show("Missing file: \n" + str);
      return (Bitmap) null;
    }

    public IComparer GetComparar(int t)
    {
      switch (t)
      {
        case 0:
          if (this.b4p.caseCompare == null)
            this.b4p.caseCompare = new Comparer(b4p.cul);
          return (IComparer) this.b4p.caseCompare;
        case 1:
          if (this.b4p.caseNotCompare == null)
            this.b4p.caseNotCompare = new CaseInsensitiveComparer(b4p.cul);
          return (IComparer) this.b4p.caseNotCompare;
        default:
          if (this.b4p.numbersCompare == null)
            this.b4p.numbersCompare = new CCompareNumbers();
          return (IComparer) this.b4p.numbersCompare;
      }
    }

    public double DateTimeParse(string time, string format)
    {
      try
      {
        return (double) DateTime.ParseExact(time, format, (IFormatProvider) b4p.cul).Ticks;
      }
      catch
      {
        return 0.0;
      }
    }

    public string[] GetControls(string module, string s)
    {
      string[] controls = (string[]) null;
      if (s == "")
      {
        controls = new string[this.b4p.htControls.Count];
        int num = 0;
        foreach (DictionaryEntry htControl in (Hashtable) this.b4p.htControls)
          controls[num++] = Other.ReturnFullName(htControl.Key.ToString().Remove(0, 1));
      }
      else
      {
        s = Other.FixRuntimeControlName(s, module);
        object htControl = this.b4p.htControls[(object) ("_" + s.ToLower(b4p.cul))];
        switch (htControl)
        {
          case Control _:
            Control control = (Control) htControl;
            controls = new string[control.Controls.Count];
            int num1 = 0;
            IEnumerator enumerator1 = control.Controls.GetEnumerator();
            try
            {
              while (enumerator1.MoveNext())
              {
                Control current = (Control) enumerator1.Current;
                if (current is IEnhancedControl)
                  controls[num1++] = Other.ReturnFullName(((IEnhancedControl) current).propName.Remove(0, 1));
              }
              break;
            }
            finally
            {
              if (enumerator1 is IDisposable disposable)
                disposable.Dispose();
            }
          case Menu _:
            Menu menu = (Menu) htControl;
            controls = new string[menu.MenuItems.Count];
            int num2 = 0;
            IEnumerator enumerator2 = menu.MenuItems.GetEnumerator();
            try
            {
              while (enumerator2.MoveNext())
              {
                object current = enumerator2.Current;
                if (current is IEnhancedControl)
                  controls[num2++] = Other.ReturnFullName(((IEnhancedControl) current).propName.Remove(0, 1));
              }
              break;
            }
            finally
            {
              if (enumerator2 is IDisposable disposable)
                disposable.Dispose();
            }
        }
      }
      return controls;
    }

    public string ControlType(string module, string c)
    {
      c = Other.FixRuntimeControlName(c, module);
      string str = this.b4p.htControls[(object) ("_" + c.ToLower(b4p.cul))].GetType().ToString();
      int num = -1;
      if (str.Length > 9)
        num = str.IndexOf("Enhanced", 10);
      if (num > -1)
      {
        str = str.Substring(num + 8);
        switch (str)
        {
          case "Combo":
            str = "ComboBox";
            break;
          case "DateTime":
            str = "Calendar";
            break;
          case "Menu":
            str = "MenuItem";
            break;
        }
      }
      return str;
    }

    public double GetDouble(FileStream fs, long pos)
    {
      byte[] buffer = new byte[8];
      fs.Seek(pos, SeekOrigin.Begin);
      fs.Read(buffer, 0, 8);
      return BitConverter.ToDouble(buffer, 0);
    }

    public string GetString(FileStream fs, long pos, int length)
    {
      byte[] numArray = new byte[length];
      fs.Seek(pos, SeekOrigin.Begin);
      fs.Read(numArray, 0, numArray.Length);
      return this.b4p.ae.GetString(numArray, 0, numArray.Length);
    }

    public double GetByte(FileStream fs, long pos)
    {
      fs.Seek(pos, SeekOrigin.Begin);
      return (double) fs.ReadByte();
    }

    public void Put(FileStream fs, long pos, object o)
    {
      fs.Seek(pos, SeekOrigin.Begin);
      byte[] buffer = !(o is string) ? BitConverter.GetBytes((double) o) : this.b4p.ae.GetBytes((string) o);
      fs.Write(buffer, 0, buffer.Length);
    }

    public string[] GetRGB(Color c)
    {
      return new string[3]
      {
        c.R.ToString(),
        c.G.ToString(),
        c.B.ToString()
      };
    }

    public void Shell(string file, string args)
    {
      if (File.Exists(Path.Combine(this.b4p.b4pdir, file)))
        file = Path.Combine(this.b4p.b4pdir, file);
      else if (File.Exists(Path.Combine(this.b4p.b4pdir, file + ".exe")))
        file = Path.Combine(this.b4p.b4pdir, file + ".exe");
      Process.Start(file, args);
    }

    public double GetDoubleFromObject(object o)
    {
      return o == null ? 0.0 : double.Parse((string) Convert.ChangeType(o, typeof (string), (IFormatProvider) b4p.cul), (IFormatProvider) b4p.cul);
    }

    public string GetStringFromObject(object o)
    {
      return o == null ? "" : (string) Convert.ChangeType(o, typeof (string), (IFormatProvider) b4p.cul);
    }

    public static string FixRuntimeControlName(string controlName, string moduleName)
    {
      controlName = controlName.ToLower(b4p.cul);
      return controlName.IndexOf(".") > -1 ? "_" + controlName.Replace(".", "_") : "_" + moduleName + "_" + controlName;
    }

    public static string ReturnFullName(string subName)
    {
      int length = subName.IndexOf("_", 1) - 1;
      return subName.Substring(1, length) + "." + subName.Substring(length + 2);
    }

    public static string UnfixModuleName(string subName)
    {
      return subName.Substring(subName.IndexOf("_", 1) + 1);
    }

    public static void SetScale(bool device, bool autoScale, Form shownForm, b4p b4p)
    {
      if (Other.scaledSet)
        return;
      Other.scaledSet = true;
      if (device)
      {
        Graphics graphics = shownForm.CreateGraphics();
        b4p.scaleX = (double) graphics.DpiX / 96.0;
        b4p.scaleY = (double) graphics.DpiY / 96.0;
        graphics.Dispose();
      }
      Thread.SetData(Thread.GetNamedDataSlot("fixX"), (object) 1.0);
      Thread.SetData(Thread.GetNamedDataSlot("fixY"), (object) 1.0);
      Thread.SetData(Thread.GetNamedDataSlot("scaleX"), (object) b4p.scaleX);
      Thread.SetData(Thread.GetNamedDataSlot("scaleY"), (object) b4p.scaleY);
    }

    public static void ScaleControls(Control c)
    {
    }
  }
}
