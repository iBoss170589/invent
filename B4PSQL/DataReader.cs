// Decompiled with JetBrains decompiler
// Type: B4PSQL.DataReader
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C68EF56F-DE83-49CD-89E2-6C7A60706012
// Assembly location: C:\Users\iHugo\Documents\INVENTARIOS\InventMobileW.exe

using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;


namespace B4PSQL
{
  public class DataReader : IDisposable
  {
    private SQLiteDataReader reader;

    public object Value
    {
      get => (object) this.reader;
      set => this.reader = (SQLiteDataReader) value;
    }

    public bool ReadNextRow() => this.reader.Read();

    public string GetValue(int Index) => this.reader.GetValue(Index).ToString();

    public byte[] GetBytes(int Index)
    {
      long bytes = this.reader.GetBytes(Index, 0L, (byte[]) null, 0, 0);
      byte[] buffer = new byte[bytes];
      this.reader.GetBytes(Index, 0L, buffer, 0, (int) bytes);
      return buffer;
    }

    public Bitmap GetImage(int Index)
    {
      using (MemoryStream memoryStream = new MemoryStream())
      {
        byte[] bytes = this.GetBytes(Index);
        memoryStream.Write(bytes, 0, bytes.Length);
        return new Bitmap((Stream) memoryStream);
      }
    }

    public int FieldCount => this.reader.FieldCount;

    public bool IsDBNull(int index) => this.reader.IsDBNull(index);

    public void Close() => this.reader.Close();

    public void Dispose()
    {
      if (this.reader == null)
        return;
      this.reader.Close();
    }
  }
}
