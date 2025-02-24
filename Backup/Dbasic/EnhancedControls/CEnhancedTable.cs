// Decompiled with JetBrains decompiler
// Type: Dbasic.EnhancedControls.CEnhancedTable
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

#nullable disable
namespace Dbasic.EnhancedControls
{
  public class CEnhancedTable : DataGrid, IEnhancedControl, IDisposable
  {
    public string name;
    public DataTable dataTable;
    private DataGridTableStyle dgts = new DataGridTableStyle();
    private b4p b4p;
    private b4p.del2 delSelection;

    public CEnhancedTable(b4p b4p, string name)
    {
      this.b4p = b4p;
      this.name = name;
      this.dataTable = new DataTable(name);
      this.dataTable.Locale = b4p.cul;
      this.dgts.MappingName = name;
      this.RowHeadersVisible = false;
      this.TableStyles.Add(this.dgts);
      this.DataSource = (object) this.dataTable.DefaultView;
      this.AllowSorting = false;
      this.CaptionVisible = false;
      this.ReadOnly = true;
      this.dgts.RowHeadersVisible = false;
      this.dgts.AllowSorting = false;
    }

    public string propName => this.name;

    public Color propColor
    {
      get => this.TableStyles[0].BackColor;
      set
      {
        this.TableStyles[0].BackColor = value;
        this.TableStyles[0].AlternatingBackColor = value;
      }
    }

    private DataGridTextBoxColumn NewColumnStyle(string name)
    {
      DataGridTextBoxColumn gridTextBoxColumn = new DataGridTextBoxColumn();
      gridTextBoxColumn.MappingName = name;
      gridTextBoxColumn.HeaderText = name;
      gridTextBoxColumn.Width = (int) (75.0 * b4p.scaleX);
      return gridTextBoxColumn;
    }

    public void AddCol(System.Type t, string colName, int width, bool unique)
    {
      DataGridTextBoxColumn column = this.NewColumnStyle(colName);
      column.Width = width;
      this.TableStyles[0].GridColumnStyles.Add((DataGridColumnStyle) column);
      this.dataTable.Columns.Add(colName, t);
      for (int index = 0; index < this.dataTable.Rows.Count; ++index)
        this.dataTable.Rows[index][colName] = t != typeof (double) ? (object) "" : (object) 0;
      this.dataTable.Columns[colName].AllowDBNull = false;
      this.dataTable.Columns[colName].Unique = unique;
    }

    public void AddRow(object[] list)
    {
      for (int index = 0; index < list.Length; ++index)
      {
        if (this.dataTable.Columns[index].DataType == typeof (double))
          list[index] = (object) double.Parse((string) list[index], (IFormatProvider) b4p.cul);
      }
      if (list.Length < this.dataTable.Columns.Count)
      {
        object[] destinationArray = new object[this.dataTable.Columns.Count];
        Array.Copy((Array) list, (Array) destinationArray, list.Length);
        for (int length = list.Length; length < this.dataTable.Columns.Count; ++length)
          destinationArray[length] = this.dataTable.Columns[length].DataType != typeof (double) ? (object) "" : (object) 0.0;
        this.dataTable.Rows.Add(destinationArray);
      }
      else
        this.dataTable.Rows.Add(list);
    }

    public void RemoveCol(string colName)
    {
      this.dataTable.DefaultView.RowFilter = "";
      int ordinal = this.dataTable.Columns[colName].Ordinal;
      this.dataTable.Columns.Remove(colName);
      this.TableStyles[0].GridColumnStyles.RemoveAt(ordinal);
      this.dataTable.AcceptChanges();
    }

    public void SetCell(string colName, int row, string value)
    {
      this.dataTable.DefaultView[row][colName] = this.dataTable.Columns[colName].DataType != typeof (double) ? (object) value : (object) double.Parse(value, (IFormatProvider) b4p.cul);
      this.dataTable.AcceptChanges();
    }

    public object GetCell(string colName, int row, bool rString)
    {
      return rString ? (this.dataTable.Columns[colName].DataType == typeof (double) ? (object) ((double) this.dataTable.DefaultView[row][colName]).ToString((IFormatProvider) b4p.cul) : this.dataTable.DefaultView[row][colName]) : (this.dataTable.Columns[colName].DataType == typeof (double) ? this.dataTable.DefaultView[row][colName] : (object) double.Parse((string) this.dataTable.DefaultView[row][colName], (IFormatProvider) b4p.cul));
    }

    public void SaveCSV(string fileName, char sep, bool includeHeader)
    {
      DataTable dataTable = this.dataTable;
      int count1 = dataTable.Rows.Count;
      int count2 = dataTable.Columns.Count;
      bool[] flagArray = new bool[count2];
      StringBuilder stringBuilder = new StringBuilder();
      char[] charArray = ("\"\r\n" + (object) sep).ToCharArray();
      using (StreamWriter streamWriter = new StreamWriter(Path.Combine(this.b4p.b4pdir, fileName), false, Encoding.UTF8))
      {
        for (int index = 0; index < count2; ++index)
        {
          if (includeHeader)
            stringBuilder.Append(this.Word(dataTable.Columns[index].ColumnName, charArray, sep));
          flagArray[index] = dataTable.Columns[index].DataType == typeof (double);
        }
        if (includeHeader)
        {
          stringBuilder[stringBuilder.Length - 1] = '\r';
          stringBuilder.Append('\n');
        }
        foreach (DataRow row in (InternalDataCollectionBase) dataTable.Rows)
        {
          for (int columnIndex = 0; columnIndex < count2; ++columnIndex)
          {
            if (flagArray[columnIndex])
              stringBuilder.Append(this.Word(((double) row[columnIndex]).ToString((IFormatProvider) b4p.cul), charArray, sep));
            else
              stringBuilder.Append(this.Word((string) row[columnIndex], charArray, sep));
          }
          stringBuilder[stringBuilder.Length - 1] = '\r';
          stringBuilder.Append('\n');
        }
        streamWriter.Write((object) stringBuilder);
      }
    }

    private string Word(string word, char[] problemChars, char sep)
    {
      if (word.IndexOfAny(problemChars) > -1)
      {
        word = "\"" + word + "\"";
        for (int startIndex = word.IndexOf('"', 1); startIndex > -1 && startIndex < word.Length - 1; startIndex = word.IndexOf("\"", startIndex + 2))
          word = word.Insert(startIndex, "\"");
      }
      return word + (object) sep;
    }

    public void LoadCSV(string fileName, char sep, bool headerExist, bool createColumns)
    {
      DataTable dataTable = this.dataTable;
      dataTable.BeginLoadData();
      try
      {
        using (StreamReader streamReader = new StreamReader(Path.Combine(this.b4p.b4pdir, fileName), Encoding.UTF8))
        {
          this.DataSource = (object) null;
          StringBuilder stringBuilder = new StringBuilder();
          char[] buffer = new char[4096];
          int i;
          while ((i = streamReader.Read(buffer, 0, 4096)) > 0)
            stringBuilder.Append(buffer, 0, i);
          string data = stringBuilder[stringBuilder.Length - 1] == '\n' ? stringBuilder.ToString() : stringBuilder.ToString() + "\r\n";
          ArrayList arrayList = new ArrayList();
          while (i < data.Length)
          {
            if (data[i] == '"')
            {
              int num = data.IndexOf("\"", i + 1);
              while (num < data.Length && num > -1 && num != data.Length - 1 && data[num + 1] == '"')
                num = data.IndexOf("\"", num + 2);
              arrayList.Add((object) data.Substring(i + 1, num - i - 1));
              i = num + 2;
              if (data[num + 1] == '\r')
              {
                ++i;
                break;
              }
            }
            else
            {
              int num1 = data.IndexOf(sep, i);
              int num2 = data.IndexOf('\r', i);
              if (num2 < num1 || num1 == -1)
              {
                arrayList.Add((object) data.Substring(i, num2 - i));
                i = num2 + 2;
                break;
              }
              arrayList.Add((object) data.Substring(i, num1 - i));
              i = num1 + 1;
            }
          }
          bool[] flagArray = new bool[arrayList.Count];
          int count = arrayList.Count;
          object[] objArray = new object[count];
          if (createColumns)
          {
            dataTable.DefaultView.RowFilter = "";
            dataTable.DefaultView.Sort = "";
            dataTable.Columns.Clear();
            dataTable.Rows.Clear();
            this.TableStyles[0].GridColumnStyles.Clear();
            for (int index = 0; index < count; ++index)
            {
              if (!headerExist)
              {
                this.TableStyles[0].GridColumnStyles.Add((DataGridColumnStyle) this.NewColumnStyle("Column" + (index + 1).ToString()));
                dataTable.Columns.Add("Column" + (index + 1).ToString(), typeof (string));
              }
              else
              {
                this.TableStyles[0].GridColumnStyles.Add((DataGridColumnStyle) this.NewColumnStyle(arrayList[index].ToString()));
                dataTable.Columns.Add(arrayList[index].ToString(), typeof (string));
              }
            }
            if (!headerExist)
            {
              for (int index = 0; index < count; ++index)
                objArray[index] = (object) arrayList[index].ToString();
              dataTable.Rows.Add(objArray);
            }
          }
          else
          {
            if (dataTable.Columns.Count != arrayList.Count)
              throw new Exception("Columns number and type do not match data file.");
            for (int index = 0; index < count; ++index)
            {
              if (dataTable.Columns[index].DataType == typeof (double))
              {
                flagArray[index] = true;
                if (!headerExist)
                  objArray[index] = (object) double.Parse(arrayList[index].ToString(), (IFormatProvider) b4p.cul);
              }
              else
              {
                flagArray[index] = false;
                if (!headerExist)
                  objArray[index] = (object) arrayList[index].ToString();
              }
            }
            if (!headerExist)
              dataTable.Rows.Add(objArray);
          }
          while (i < data.Length - 1)
          {
            int index;
            for (index = 0; index < count - 1; ++index)
              objArray[index] = !flagArray[index] ? (object) this.ReadWord(ref data, ref i, sep) : (object) double.Parse(this.ReadWord(ref data, ref i, sep), (IFormatProvider) b4p.cul);
            objArray[index] = !flagArray[index] ? (object) this.ReadWord(ref data, ref i, '\r') : (object) double.Parse(this.ReadWord(ref data, ref i, '\r'), (IFormatProvider) b4p.cul);
            ++i;
            dataTable.Rows.Add(objArray);
          }
        }
      }
      finally
      {
        dataTable.EndLoadData();
        this.DataSource = (object) dataTable.DefaultView;
        this.dataTable = dataTable;
      }
    }

    private string ReadWord(ref string data, ref int i, char sep)
    {
      string str;
      if (data[i] == '"')
      {
        int num;
        for (num = data.IndexOf("\"", i + 1); num < data.Length && num > -1 && num != data.Length - 1 && data[num + 1] == '"'; num = data.IndexOf("\"", num + 1))
          data = data.Remove(num + 1, 1);
        str = data.Substring(i + 1, num - i - 1);
        i = num + 2;
      }
      else
      {
        int num = data.IndexOf(sep, i);
        str = data.Substring(i, num - i);
        i = num + 1;
      }
      return str;
    }

    public void SaveXML(string file)
    {
      using (XmlTextWriter writer = new XmlTextWriter(Path.Combine(this.b4p.b4pdir, file), Encoding.UTF8))
        this.dataTable.WriteXml((XmlWriter) writer, XmlWriteMode.WriteSchema);
    }

    public void LoadXML(string file)
    {
      using (XmlTextReader reader = new XmlTextReader(Path.Combine(this.b4p.b4pdir, file)))
      {
        this.TableStyles[0].GridColumnStyles.Clear();
        DataSet dataSet = new DataSet("temp");
        int num = (int) dataSet.ReadXml((XmlReader) reader, XmlReadMode.ReadSchema);
        foreach (DataColumn column in (InternalDataCollectionBase) dataSet.Tables[0].Columns)
          this.TableStyles[0].GridColumnStyles.Add((DataGridColumnStyle) this.NewColumnStyle(column.ColumnName));
        this.DataSource = (object) dataSet.Tables[0].DefaultView;
        this.dataTable = dataSet.Tables[0];
        this.dataTable.Locale = b4p.cul;
        dataSet.Tables.Clear();
      }
    }

    public void AddEvents()
    {
      try
      {
        if (!this.b4p.htSubs.Contains((object) (this.name + "_selectionchanged")))
          return;
        this.delSelection = (b4p.del2) this.b4p.htSubs[(object) (this.name + "_selectionchanged")];
        this.CurrentCellChanged += new EventHandler(this.CEnhancedTable_CurrentCellChanged);
      }
      catch
      {
        throw new Exception("Error assigning event to " + this.name.Remove(0, 1) + ".\nCheck the number of arguments of each event sub.");
      }
    }

    private void CEnhancedTable_CurrentCellChanged(object sender, EventArgs e)
    {
      this.b4p.sender = this.name;
      string str = this.delSelection(this.TableStyles[0].GridColumnStyles[this.CurrentCell.ColumnNumber].MappingName, this.CurrentCell.RowNumber.ToString((IFormatProvider) b4p.cul));
    }

    public void AddRunTimeEvent(string eventName, string subName)
    {
      try
      {
        switch (eventName)
        {
          case "selectionchanged":
            this.delSelection = (b4p.del2) this.b4p.htSubs[(object) subName];
            this.CurrentCellChanged += new EventHandler(this.CEnhancedTable_CurrentCellChanged);
            break;
        }
      }
      catch
      {
        throw new Exception("Error assigning event to " + this.name.Remove(0, 1) + ".\nCheck the number of arguments of each event sub.");
      }
    }

    protected override void Dispose(bool disposing)
    {
      try
      {
        this.DataSource = (object) null;
        base.Dispose(disposing);
      }
      catch
      {
      }
    }
  }
}
