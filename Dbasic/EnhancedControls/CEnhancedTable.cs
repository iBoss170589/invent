namespace Dbasic.EnhancedControls
{
    using Dbasic;
    using System;
    using System.Collections;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Text;
    using System.Windows.Forms;
    using System.Xml;

    public class CEnhancedTable : DataGrid, IEnhancedControl, IDisposable
    {
        public string name;
        public DataTable dataTable;
        private DataGridTableStyle dgts = new DataGridTableStyle();
        private Dbasic.b4p b4p;
        private Dbasic.b4p.del2 delSelection;

        public CEnhancedTable(Dbasic.b4p b4p, string name)
        {
            this.b4p = b4p;
            this.name = name;
            this.dataTable = new DataTable(name);
            this.dataTable.Locale = Dbasic.b4p.cul;
            this.dgts.MappingName = name;
            base.RowHeadersVisible = false;
            base.TableStyles.Add(this.dgts);
            base.DataSource = this.dataTable.DefaultView;
            base.AllowSorting = false;
            base.CaptionVisible = false;
            base.ReadOnly = true;
            this.dgts.RowHeadersVisible = false;
            this.dgts.AllowSorting = false;
        }

        public void AddCol(System.Type t, string colName, int width, bool unique)
        {
            DataGridTextBoxColumn column = this.NewColumnStyle(colName);
            column.Width = width;
            base.TableStyles[0].GridColumnStyles.Add(column);
            this.dataTable.Columns.Add(colName, t);
            for (int i = 0; i < this.dataTable.Rows.Count; i++)
            {
                if (t == typeof(double))
                {
                    this.dataTable.Rows[i][colName] = 0;
                }
                else
                {
                    this.dataTable.Rows[i][colName] = "";
                }
            }
            this.dataTable.Columns[colName].AllowDBNull = false;
            this.dataTable.Columns[colName].Unique = unique;
        }

        public void AddEvents()
        {
            try
            {
                if (this.b4p.htSubs.Contains(this.name + "_selectionchanged"))
                {
                    this.delSelection = (Dbasic.b4p.del2) this.b4p.htSubs[this.name + "_selectionchanged"];
                    base.CurrentCellChanged += new EventHandler(this.CEnhancedTable_CurrentCellChanged);
                }
            }
            catch
            {
                throw new Exception("Error assigning event to " + this.name.Remove(0, 1) + ".\nCheck the number of arguments of each event sub.");
            }
        }

        public void AddRow(object[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (this.dataTable.Columns[i].DataType == typeof(double))
                {
                    list[i] = double.Parse((string) list[i], Dbasic.b4p.cul);
                }
            }
            if (list.Length < this.dataTable.Columns.Count)
            {
                object[] destinationArray = new object[this.dataTable.Columns.Count];
                Array.Copy(list, destinationArray, list.Length);
                for (int j = list.Length; j < this.dataTable.Columns.Count; j++)
                {
                    if (this.dataTable.Columns[j].DataType == typeof(double))
                    {
                        destinationArray[j] = 0.0;
                    }
                    else
                    {
                        destinationArray[j] = "";
                    }
                }
                this.dataTable.Rows.Add(destinationArray);
            }
            else
            {
                this.dataTable.Rows.Add(list);
            }
        }

        public void AddRunTimeEvent(string eventName, string subName)
        {
            try
            {
                string str;
                if (((str = eventName) != null) && (str == "selectionchanged"))
                {
                    this.delSelection = (Dbasic.b4p.del2) this.b4p.htSubs[subName];
                    base.CurrentCellChanged += new EventHandler(this.CEnhancedTable_CurrentCellChanged);
                }
            }
            catch
            {
                throw new Exception("Error assigning event to " + this.name.Remove(0, 1) + ".\nCheck the number of arguments of each event sub.");
            }
        }

        private void CEnhancedTable_CurrentCellChanged(object sender, EventArgs e)
        {
            this.b4p.sender = this.name;
            this.delSelection(base.TableStyles[0].GridColumnStyles[base.CurrentCell.ColumnNumber].MappingName, base.CurrentCell.RowNumber.ToString(Dbasic.b4p.cul));
        }

        protected override void Dispose(bool disposing)
        {
            try
            {
                base.DataSource = null;
                base.Dispose(disposing);
            }
            catch
            {
            }
        }

        public object GetCell(string colName, int row, bool rString)
        {
            if (rString)
            {
                if (this.dataTable.Columns[colName].DataType == typeof(double))
                {
                    double num = (double) this.dataTable.DefaultView[row][colName];
                    return num.ToString(Dbasic.b4p.cul);
                }
                return this.dataTable.DefaultView[row][colName];
            }
            if (this.dataTable.Columns[colName].DataType == typeof(double))
            {
                return this.dataTable.DefaultView[row][colName];
            }
            return double.Parse((string) this.dataTable.DefaultView[row][colName], Dbasic.b4p.cul);
        }

        public void LoadCSV(string fileName, char sep, bool headerExist, bool createColumns)
        {
            DataTable dataTable = this.dataTable;
            dataTable.BeginLoadData();
            try
            {
                using (StreamReader reader = new StreamReader(Path.Combine(this.b4p.b4pdir, fileName), Encoding.UTF8))
                {
                    int index;
                    string str;
                    base.DataSource = null;
                    StringBuilder builder = new StringBuilder();
                    char[] buffer = new char[0x1000];
                    int charCount = 0;
                    while ((charCount = reader.Read(buffer, 0, 0x1000)) > 0)
                    {
                        builder.Append(buffer, 0, charCount);
                    }
                    if (builder[builder.Length - 1] != '\n')
                    {
                        str = builder.ToString() + "\r\n";
                    }
                    else
                    {
                        str = builder.ToString();
                    }
                    ArrayList list = new ArrayList();
                    while (charCount < str.Length)
                    {
                        if (str[charCount] == '"')
                        {
                            index = str.IndexOf("\"", (int) (charCount + 1));
                            while ((index < str.Length) && (index > -1))
                            {
                                if ((index == (str.Length - 1)) || (str[index + 1] != '"'))
                                {
                                    break;
                                }
                                index = str.IndexOf("\"", (int) (index + 2));
                            }
                            list.Add(str.Substring(charCount + 1, (index - charCount) - 1));
                            charCount = index + 2;
                            if (str[index + 1] != '\r')
                            {
                                continue;
                            }
                            charCount++;
                            break;
                        }
                        index = str.IndexOf(sep, charCount);
                        int num3 = str.IndexOf('\r', charCount);
                        if ((num3 < index) || (index == -1))
                        {
                            list.Add(str.Substring(charCount, num3 - charCount));
                            charCount = num3 + 2;
                            break;
                        }
                        list.Add(str.Substring(charCount, index - charCount));
                        charCount = index + 1;
                    }
                    bool[] flagArray = new bool[list.Count];
                    int count = list.Count;
                    object[] values = new object[count];
                    if (createColumns)
                    {
                        dataTable.DefaultView.RowFilter = "";
                        dataTable.DefaultView.Sort = "";
                        dataTable.Columns.Clear();
                        dataTable.Rows.Clear();
                        base.TableStyles[0].GridColumnStyles.Clear();
                        for (index = 0; index < count; index++)
                        {
                            if (!headerExist)
                            {
                                int num5 = index + 1;
                                base.TableStyles[0].GridColumnStyles.Add(this.NewColumnStyle("Column" + num5.ToString()));
                                int num6 = index + 1;
                                dataTable.Columns.Add("Column" + num6.ToString(), typeof(string));
                            }
                            else
                            {
                                base.TableStyles[0].GridColumnStyles.Add(this.NewColumnStyle(list[index].ToString()));
                                dataTable.Columns.Add(list[index].ToString(), typeof(string));
                            }
                        }
                        if (!headerExist)
                        {
                            for (index = 0; index < count; index++)
                            {
                                values[index] = list[index].ToString();
                            }
                            dataTable.Rows.Add(values);
                        }
                    }
                    else
                    {
                        if (dataTable.Columns.Count != list.Count)
                        {
                            throw new Exception("Columns number and type do not match data file.");
                        }
                        index = 0;
                        while (index < count)
                        {
                            if (dataTable.Columns[index].DataType == typeof(double))
                            {
                                flagArray[index] = true;
                                if (!headerExist)
                                {
                                    values[index] = double.Parse(list[index].ToString(), Dbasic.b4p.cul);
                                }
                            }
                            else
                            {
                                flagArray[index] = false;
                                if (!headerExist)
                                {
                                    values[index] = list[index].ToString();
                                }
                            }
                            index++;
                        }
                        if (!headerExist)
                        {
                            dataTable.Rows.Add(values);
                        }
                    }
                    while (charCount < (str.Length - 1))
                    {
                        index = 0;
                        while (index < (count - 1))
                        {
                            if (flagArray[index])
                            {
                                values[index] = double.Parse(this.ReadWord(ref str, ref charCount, sep), Dbasic.b4p.cul);
                            }
                            else
                            {
                                values[index] = this.ReadWord(ref str, ref charCount, sep);
                            }
                            index++;
                        }
                        if (flagArray[index])
                        {
                            values[index] = double.Parse(this.ReadWord(ref str, ref charCount, '\r'), Dbasic.b4p.cul);
                        }
                        else
                        {
                            values[index] = this.ReadWord(ref str, ref charCount, '\r');
                        }
                        charCount++;
                        dataTable.Rows.Add(values);
                    }
                }
            }
            finally
            {
                dataTable.EndLoadData();
                base.DataSource = dataTable.DefaultView;
                this.dataTable = dataTable;
            }
        }

        public void LoadXML(string file)
        {
            using (XmlTextReader reader = new XmlTextReader(Path.Combine(this.b4p.b4pdir, file)))
            {
                base.TableStyles[0].GridColumnStyles.Clear();
                DataSet set = new DataSet("temp");
                set.ReadXml(reader, XmlReadMode.ReadSchema);
                foreach (DataColumn column in set.Tables[0].Columns)
                {
                    base.TableStyles[0].GridColumnStyles.Add(this.NewColumnStyle(column.ColumnName));
                }
                base.DataSource = set.Tables[0].DefaultView;
                this.dataTable = set.Tables[0];
                this.dataTable.Locale = Dbasic.b4p.cul;
                set.Tables.Clear();
                set = null;
            }
        }

        private DataGridTextBoxColumn NewColumnStyle(string name) => 
            new DataGridTextBoxColumn { 
                MappingName = name,
                HeaderText = name,
                Width = (int) (75.0 * Dbasic.b4p.scaleX)
            };

        private string ReadWord(ref string data, ref int i, char sep)
        {
            int index;
            string str;
            if (data[i] != '"')
            {
                index = data.IndexOf(sep, i);
                str = data.Substring(i, index - i);
                i = index + 1;
                return str;
            }
            index = data.IndexOf("\"", (int) (i + 1));
            while ((index < data.Length) && (index > -1))
            {
                if ((index == (data.Length - 1)) || (data[index + 1] != '"'))
                {
                    break;
                }
                data = data.Remove(index + 1, 1);
                index = data.IndexOf("\"", (int) (index + 1));
            }
            str = data.Substring(i + 1, (index - i) - 1);
            i = index + 2;
            return str;
        }

        public void RemoveCol(string colName)
        {
            this.dataTable.DefaultView.RowFilter = "";
            int ordinal = this.dataTable.Columns[colName].Ordinal;
            this.dataTable.Columns.Remove(colName);
            base.TableStyles[0].GridColumnStyles.RemoveAt(ordinal);
            this.dataTable.AcceptChanges();
        }

        public void SaveCSV(string fileName, char sep, bool includeHeader)
        {
            DataTable dataTable = this.dataTable;
            int count = dataTable.Rows.Count;
            int num = dataTable.Columns.Count;
            bool[] flagArray = new bool[num];
            StringBuilder builder = new StringBuilder();
            char[] problemChars = ("\"\r\n" + sep).ToCharArray();
            using (StreamWriter writer = new StreamWriter(Path.Combine(this.b4p.b4pdir, fileName), false, Encoding.UTF8))
            {
                for (int i = 0; i < num; i++)
                {
                    if (includeHeader)
                    {
                        builder.Append(this.Word(dataTable.Columns[i].ColumnName, problemChars, sep));
                    }
                    if (dataTable.Columns[i].DataType == typeof(double))
                    {
                        flagArray[i] = true;
                    }
                    else
                    {
                        flagArray[i] = false;
                    }
                }
                if (includeHeader)
                {
                    builder[builder.Length - 1] = '\r';
                    builder.Append('\n');
                }
                foreach (DataRow row in dataTable.Rows)
                {
                    for (int j = 0; j < num; j++)
                    {
                        if (flagArray[j])
                        {
                            double num4 = (double) row[j];
                            builder.Append(this.Word(num4.ToString(Dbasic.b4p.cul), problemChars, sep));
                        }
                        else
                        {
                            builder.Append(this.Word((string) row[j], problemChars, sep));
                        }
                    }
                    builder[builder.Length - 1] = '\r';
                    builder.Append('\n');
                }
                writer.Write(builder);
            }
        }

        public void SaveXML(string file)
        {
            DataTable dataTable = this.dataTable;
            using (XmlTextWriter writer = new XmlTextWriter(Path.Combine(this.b4p.b4pdir, file), Encoding.UTF8))
            {
                dataTable.WriteXml(writer, XmlWriteMode.WriteSchema);
            }
        }

        public void SetCell(string colName, int row, string value)
        {
            if (this.dataTable.Columns[colName].DataType == typeof(double))
            {
                this.dataTable.DefaultView[row][colName] = double.Parse(value, Dbasic.b4p.cul);
            }
            else
            {
                this.dataTable.DefaultView[row][colName] = value;
            }
            this.dataTable.AcceptChanges();
        }

        private string Word(string word, char[] problemChars, char sep)
        {
            if (word.IndexOfAny(problemChars) > -1)
            {
                word = "\"" + word + "\"";
                for (int i = word.IndexOf('"', 1); (i > -1) && (i < (word.Length - 1)); i = word.IndexOf("\"", (int) (i + 2)))
                {
                    word = word.Insert(i, "\"");
                }
            }
            return (word + sep);
        }

        public string propName =>
            this.name;

        public Color propColor
        {
            get => 
                base.TableStyles[0].BackColor;
            set
            {
                base.TableStyles[0].BackColor = value;
                base.TableStyles[0].AlternatingBackColor = value;
            }
        }
    }
}

