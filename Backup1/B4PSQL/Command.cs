// Decompiled with JetBrains decompiler
// Type: B4PSQL.Command
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace B4PSQL
{
  public class Command : IDisposable
  {
    private SQLiteCommand command;
    private double scaleX = 1.0;

    public Command(string CommandText, object Connection)
    {
      this.command = new SQLiteCommand(CommandText, (SQLiteConnection) Connection);
      this.scaleX = (double) Thread.GetData(Thread.GetNamedDataSlot(nameof (scaleX)));
    }

    public string CommandText
    {
      get => this.command.CommandText;
      set => this.command.CommandText = value;
    }

    public int ExecuteNonQuery() => this.command.ExecuteNonQuery();

    public object ExecuteReader() => (object) this.command.ExecuteReader();

    public string BytesToBLOB(byte[] Data)
    {
      StringBuilder stringBuilder = new StringBuilder(Data.Length * 2 + 6);
      stringBuilder.Append("x'");
      for (int index = 0; index < Data.Length; ++index)
        stringBuilder.Append(((int) Data[index]).ToString("x2"));
      stringBuilder.Append("'");
      return stringBuilder.ToString();
    }

    public string FileToBLOB(string File)
    {
      byte[] numArray = (byte[]) null;
      using (FileStream fileStream = new FileStream(File, FileMode.Open))
      {
        numArray = new byte[fileStream.Length];
        fileStream.Read(numArray, 0, (int) fileStream.Length);
      }
      return this.BytesToBLOB(numArray);
    }

    public void AddParameter(string Name)
    {
      this.command.Parameters.Add(new SQLiteParameter("@" + Name));
    }

    public void SetParameter(string Name, string Value)
    {
      this.command.Parameters["@" + Name].Value = (object) Value;
    }

    public void SetNullParameter(string Name)
    {
      this.command.Parameters["@" + Name].Value = (object) null;
    }

    void IDisposable.Dispose() => this.command.Dispose();

    public void ExecuteTable(DataGrid Table, int Maximum)
    {
      DataTable dataTable = (DataTable) Table.GetType().GetField("dataTable").GetValue((object) Table);
      Table.DataSource = (object) null;
      dataTable.DefaultView.RowFilter = "";
      dataTable.DefaultView.Sort = "";
      dataTable.Columns.Clear();
      dataTable.Rows.Clear();
      Table.TableStyles[0].GridColumnStyles.Clear();
      using (SQLiteDataReader sqLiteDataReader = this.command.ExecuteReader())
      {
        object[] objArray = new object[sqLiteDataReader.FieldCount];
        for (int ordinal = 0; ordinal < sqLiteDataReader.FieldCount; ++ordinal)
        {
          string name = sqLiteDataReader.GetName(ordinal);
          DataGridColumnStyle column = (DataGridColumnStyle) this.NewColumnStyle(name);
          column.Width = (int) (75.0 * this.scaleX);
          Table.TableStyles[0].GridColumnStyles.Add(column);
          System.Type fieldType = sqLiteDataReader.GetFieldType(ordinal);
          if (fieldType == typeof (string) || fieldType == typeof (char) || fieldType == typeof (bool) || fieldType.IsArray || fieldType == typeof (DateTime) || fieldType == typeof (Guid))
          {
            dataTable.Columns.Add(name, typeof (string));
            objArray[ordinal] = (object) "";
          }
          else
          {
            dataTable.Columns.Add(name, typeof (double));
            objArray[ordinal] = (object) 0.0;
          }
        }
        int num = 1;
        object[] values = new object[sqLiteDataReader.FieldCount];
        while (sqLiteDataReader.Read() && num++ != Maximum)
        {
          sqLiteDataReader.GetValues(values);
          for (int index = 0; index < values.Length; ++index)
          {
            if (DBNull.Value.Equals(values[index]))
              values[index] = objArray[index];
          }
          DataRow row = dataTable.NewRow();
          row.ItemArray = values;
          dataTable.Rows.Add(row);
        }
        dataTable.EndLoadData();
        Table.DataSource = (object) dataTable.DefaultView;
        sqLiteDataReader.Close();
      }
    }

    private DataGridTextBoxColumn NewColumnStyle(string name)
    {
      DataGridTextBoxColumn gridTextBoxColumn = new DataGridTextBoxColumn();
      gridTextBoxColumn.MappingName = name;
      gridTextBoxColumn.HeaderText = name;
      return gridTextBoxColumn;
    }
  }
}
