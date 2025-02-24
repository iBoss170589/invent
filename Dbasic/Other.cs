namespace Dbasic
{
    using System;
    using System.Collections;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using System.Threading;
    using System.Windows.Forms;

    public class Other
    {
        private Dbasic.b4p b4p;
        private int SND_ASYNC = 1;
        private int SND_FILENAME = 0x20000;
        private static bool scaledSet;

        public Other(Dbasic.b4p b4p)
        {
            this.b4p = b4p;
        }

        public string ControlType(string module, string c)
        {
            c = FixRuntimeControlName(c, module);
            object obj2 = this.b4p.htControls["_" + c.ToLower(Dbasic.b4p.cul)];
            string str = obj2.GetType().ToString();
            int index = -1;
            if (str.Length > 9)
            {
                index = str.IndexOf("Enhanced", 10);
            }
            if (index > -1)
            {
                str = str.Substring(index + 8);
                switch (str)
                {
                    case "Combo":
                        return "ComboBox";

                    case "DateTime":
                        return "Calendar";

                    case "Menu":
                        str = "MenuItem";
                        break;
                }
            }
            return str;
        }

        public double DateTimeParse(string time, string format)
        {
            try
            {
                return (double) DateTime.ParseExact(time, format, Dbasic.b4p.cul).Ticks;
            }
            catch
            {
                return 0.0;
            }
        }

        public double DirSearch(string al, string path, string pattern)
        {
            ArrayList list = (ArrayList) this.b4p.htControls[al];
            list.AddRange(Directory.GetDirectories(Path.Combine(this.b4p.b4pdir, path), pattern));
            return (double) list.Count;
        }

        public double FileSearch(string al, string path, string pattern)
        {
            ArrayList list = (ArrayList) this.b4p.htControls[al];
            list.AddRange(Directory.GetFiles(Path.Combine(this.b4p.b4pdir, path), pattern));
            return (double) list.Count;
        }

        public static string FixRuntimeControlName(string controlName, string moduleName)
        {
            controlName = controlName.ToLower(Dbasic.b4p.cul);
            if (controlName.IndexOf(".") > -1)
            {
                return ("_" + controlName.Replace(".", "_"));
            }
            return ("_" + moduleName + "_" + controlName);
        }

        public Bitmap GetBitmapFromResource(string res) => 
            new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream(res.ToLower(Dbasic.b4p.cul).Replace(" ", "~")));

        public Bitmap GetBitmapFromString(object o)
        {
            if (!(o is string))
            {
                return (Bitmap) o;
            }
            if (o == "")
            {
                return null;
            }
            string path = Path.Combine(this.b4p.b4pdir, (string) o);
            if (!File.Exists(path))
            {
                MessageBox.Show("Missing file: \n" + path);
                return null;
            }
            return new Bitmap(path);
        }

        public double GetByte(FileStream fs, long pos)
        {
            fs.Seek(pos, SeekOrigin.Begin);
            return (double) fs.ReadByte();
        }

        public IComparer GetComparar(int t)
        {
            switch (t)
            {
                case 0:
                    if (this.b4p.caseCompare == null)
                    {
                        this.b4p.caseCompare = new Comparer(Dbasic.b4p.cul);
                    }
                    return this.b4p.caseCompare;

                case 1:
                    if (this.b4p.caseNotCompare == null)
                    {
                        this.b4p.caseNotCompare = new CaseInsensitiveComparer(Dbasic.b4p.cul);
                    }
                    return this.b4p.caseNotCompare;
            }
            if (this.b4p.numbersCompare == null)
            {
                this.b4p.numbersCompare = new CCompareNumbers();
            }
            return this.b4p.numbersCompare;
        }

        public string[] GetControls(string module, string s)
        {
            string[] strArray = null;
            if (s == "")
            {
                strArray = new string[this.b4p.htControls.Count];
                int num = 0;
                foreach (DictionaryEntry entry in this.b4p.htControls)
                {
                    strArray[num++] = ReturnFullName(entry.Key.ToString().Remove(0, 1));
                }
                return strArray;
            }
            s = FixRuntimeControlName(s, module);
            object obj2 = this.b4p.htControls["_" + s.ToLower(Dbasic.b4p.cul)];
            switch (obj2)
            {
                case (Control _):
                {
                    Control control = obj2;
                    strArray = new string[control.Controls.Count];
                    int num2 = 0;
                    foreach (Control control2 in control.Controls)
                    {
                        if (control2 is IEnhancedControl)
                        {
                            strArray[num2++] = ReturnFullName(((IEnhancedControl) control2).propName.Remove(0, 1));
                        }
                    }
                    return strArray;
                    break;
                }
            }
            if (obj2 is Menu)
            {
                Menu menu = obj2;
                strArray = new string[menu.MenuItems.Count];
                int num3 = 0;
                foreach (object obj3 in menu.MenuItems)
                {
                    if (obj3 is IEnhancedControl)
                    {
                        strArray[num3++] = ReturnFullName(((IEnhancedControl) obj3).propName.Remove(0, 1));
                    }
                }
            }
            return strArray;
        }

        public double GetDouble(FileStream fs, long pos)
        {
            byte[] buffer = new byte[8];
            fs.Seek(pos, SeekOrigin.Begin);
            fs.Read(buffer, 0, 8);
            return BitConverter.ToDouble(buffer, 0);
        }

        public double GetDoubleFromObject(object o)
        {
            if (o == null)
            {
                return 0.0;
            }
            return double.Parse((string) Convert.ChangeType(o, typeof(string), Dbasic.b4p.cul), Dbasic.b4p.cul);
        }

        public string[] GetRGB(Color c) => 
            new string[] { c.R.ToString(), c.G.ToString(), c.B.ToString() };

        public string GetString(FileStream fs, long pos, int length)
        {
            byte[] buffer = new byte[length];
            fs.Seek(pos, SeekOrigin.Begin);
            fs.Read(buffer, 0, buffer.Length);
            return this.b4p.ae.GetString(buffer, 0, buffer.Length);
        }

        public string GetStringFromObject(object o)
        {
            if (o == null)
            {
                return "";
            }
            return (string) Convert.ChangeType(o, typeof(string), Dbasic.b4p.cul);
        }

        public string IsNumber(string s)
        {
            try
            {
                double.Parse(s, Dbasic.b4p.cul);
                return "true";
            }
            catch
            {
                return "false";
            }
        }

        [DllImport("WinMM.dll")]
        public static extern bool PlaySound(string fname, int Mod, int flag);
        public void Put(FileStream fs, long pos, object o)
        {
            byte[] bytes;
            fs.Seek(pos, SeekOrigin.Begin);
            if (o is string)
            {
                bytes = this.b4p.ae.GetBytes((string) o);
            }
            else
            {
                bytes = BitConverter.GetBytes((double) o);
            }
            fs.Write(bytes, 0, bytes.Length);
        }

        public static string ReturnFullName(string subName)
        {
            int length = subName.IndexOf("_", 1) - 1;
            return (subName.Substring(1, length) + "." + subName.Substring(length + 2));
        }

        public static void ScaleControls(Control c)
        {
        }

        public static void SetScale(bool device, bool autoScale, Form shownForm, Dbasic.b4p b4p)
        {
            if (!scaledSet)
            {
                scaledSet = true;
                if (device)
                {
                    Graphics graphics = shownForm.CreateGraphics();
                    Dbasic.b4p.scaleX = ((double) graphics.DpiX) / 96.0;
                    Dbasic.b4p.scaleY = ((double) graphics.DpiY) / 96.0;
                    graphics.Dispose();
                }
                Thread.SetData(Thread.GetNamedDataSlot("fixX"), 1.0);
                Thread.SetData(Thread.GetNamedDataSlot("fixY"), 1.0);
                Thread.SetData(Thread.GetNamedDataSlot("scaleX"), Dbasic.b4p.scaleX);
                Thread.SetData(Thread.GetNamedDataSlot("scaleY"), Dbasic.b4p.scaleY);
            }
        }

        public void Shell(string file, string args)
        {
            if (File.Exists(Path.Combine(this.b4p.b4pdir, file)))
            {
                file = Path.Combine(this.b4p.b4pdir, file);
            }
            else if (File.Exists(Path.Combine(this.b4p.b4pdir, file + ".exe")))
            {
                file = Path.Combine(this.b4p.b4pdir, file + ".exe");
            }
            Process.Start(file, args);
        }

        public void Sound(string file)
        {
            PlaySound(file, 0, this.SND_FILENAME | this.SND_ASYNC);
        }

        public string SubString(string original, int start, int count)
        {
            if ((start + count) > original.Length)
            {
                string str = new string(' ', (start + count) - original.Length);
                original = original + str;
            }
            return original.Substring(start, count);
        }

        public static string UnfixModuleName(string subName) => 
            subName.Substring(subName.IndexOf("_", 1) + 1);
    }
}

