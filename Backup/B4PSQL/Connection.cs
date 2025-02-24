// Decompiled with JetBrains decompiler
// Type: B4PSQL.Connection
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

#nullable disable
namespace B4PSQL
{
  public class Connection : IDisposable
  {
    private SQLiteConnection connection;
    private SQLiteTransaction transaction;

    public double DLLVersion => 1.6;

    public Connection() => this.connection = new SQLiteConnection();

    public object Value
    {
      get => (object) this.connection;
      set => this.connection = (SQLiteConnection) value;
    }

    public void Open(string ConnectionString) => this.Open(ConnectionString, (string) null);

    public void Open(string ConnectionString, string password)
    {
      this.connection.ConnectionString = ConnectionString;
      if (password != null)
        this.connection.SetPassword(password);
      this.connection.Open();
    }

    public void ChangePassword(string password) => this.connection.ChangePassword(password);

    public void RemovePassword() => this.connection.ChangePassword((string) null);

    public void Close() => this.connection.Close();

    public void BeginTransaction() => this.transaction = this.connection.BeginTransaction();

    public void EndTransaction() => this.transaction.Commit();

    public void CreateSQLTable(DataGrid Table, string SQLTableName)
    {
      DataTable dataTable = (DataTable) Table.GetType().GetField("dataTable").GetValue((object) Table);
      string str1 = "";
      string str2 = "";
      for (int index = 0; index < dataTable.Columns.Count; ++index)
      {
        string str3 = dataTable.Columns[index].DataType != typeof (double) ? "TEXT" : "REAL";
        str1 = str1 + "'" + dataTable.Columns[index].ColumnName + "' " + str3 + ",";
        str2 = str2 + ":p" + index.ToString() + ",";
      }
      string str4 = str1.Remove(str1.Length - 1, 1);
      string str5 = str2.Remove(str2.Length - 1, 1);
      using (SQLiteCommand sqLiteCommand = new SQLiteCommand(this.connection))
      {
        using (SQLiteTransaction sqLiteTransaction = this.connection.BeginTransaction())
        {
          sqLiteCommand.CommandText = "CREATE TABLE '" + SQLTableName + "' (" + str4 + ")";
          sqLiteCommand.ExecuteNonQuery();
          sqLiteCommand.CommandText = "INSERT INTO '" + SQLTableName + "' VALUES (" + str5 + ")";
          SQLiteParameter[] sqLiteParameterArray = new SQLiteParameter[dataTable.Columns.Count];
          for (int index = 0; index < dataTable.Columns.Count; ++index)
          {
            sqLiteParameterArray[index] = new SQLiteParameter("p" + index.ToString());
            sqLiteCommand.Parameters.Add(sqLiteParameterArray[index]);
          }
          for (int index = 0; index < dataTable.Rows.Count; ++index)
          {
            for (int columnIndex = 0; columnIndex < dataTable.Columns.Count; ++columnIndex)
              sqLiteParameterArray[columnIndex].Value = dataTable.Rows[index][columnIndex];
            sqLiteCommand.ExecuteNonQuery();
          }
          sqLiteTransaction.Commit();
        }
      }
    }

    public void Dispose() => this.connection.Close();
  }
}
