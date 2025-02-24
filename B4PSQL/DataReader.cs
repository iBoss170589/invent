namespace B4PSQL
{
    using System;
    using System.Data.SQLite;
    using System.Drawing;
    using System.IO;

    public class DataReader : IDisposable
    {
        private SQLiteDataReader reader;

        public void Close()
        {
            this.reader.Close();
        }

        public void Dispose()
        {
            if (this.reader != null)
            {
                this.reader.Close();
            }
        }

        public byte[] GetBytes(int Index)
        {
            long num = this.reader.GetBytes(Index, 0L, null, 0, 0);
            byte[] buffer = new byte[num];
            this.reader.GetBytes(Index, 0L, buffer, 0, (int) num);
            return buffer;
        }

        public Bitmap GetImage(int Index)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                byte[] bytes = this.GetBytes(Index);
                stream.Write(bytes, 0, bytes.Length);
                return new Bitmap(stream);
            }
        }

        public string GetValue(int Index) => 
            this.reader.GetValue(Index).ToString();

        public bool IsDBNull(int index) => 
            this.reader.IsDBNull(index);

        public bool ReadNextRow() => 
            this.reader.Read();

        public object Value
        {
            get => 
                this.reader;
            set => 
                this.reader = value;
        }

        public int FieldCount =>
            this.reader.FieldCount;
    }
}

