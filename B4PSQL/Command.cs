namespace B4PSQL
{
    using System;
    using System.Data;
    using System.Data.SQLite;
    using System.IO;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;

    public class Command : IDisposable
    {
        private SQLiteCommand command;
        private double scaleX = 1.0;

        public Command(string CommandText, object Connection)
        {
            this.command = new SQLiteCommand(CommandText, (SQLiteConnection) Connection);
            this.scaleX = Thread.GetData(Thread.GetNamedDataSlot("scaleX"));
        }

        public void AddParameter(string Name)
        {
            this.command.Parameters.Add(new SQLiteParameter("@" + Name));
        }

        public string BytesToBLOB(byte[] Data)
        {
            StringBuilder builder = new StringBuilder((Data.Length * 2) + 6);
            builder.Append("x'");
            for (int i = 0; i < Data.Length; i++)
            {
                builder.Append(((int) Data[i]).ToString("x2"));
            }
            builder.Append("'");
            return builder.ToString();
        }

        public int ExecuteNonQuery() => 
            this.command.ExecuteNonQuery();

        public object ExecuteReader() => 
            this.command.ExecuteReader();

        public void ExecuteTable(DataGrid Table, int Maximum)
        {
            DataTable table = Table.GetType().GetField("dataTable").GetValue(Table);
            Table.DataSource = null;
            table.DefaultView.RowFilter = "";
            table.DefaultView.Sort = "";
            table.Columns.Clear();
            table.Rows.Clear();
            Table.TableStyles[0].GridColumnStyles.Clear();
            using (SQLiteDataReader reader = this.command.ExecuteReader())
            {
                object[] objArray = new object[reader.FieldCount];
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string name = reader.GetName(i);
                    DataGridColumnStyle column = this.NewColumnStyle(name);
                    column.Width = (int) (75.0 * this.scaleX);
                    Table.TableStyles[0].GridColumnStyles.Add(column);
                    System.Type fieldType = reader.GetFieldType(i);
                    if ((((fieldType == typeof(string)) || (fieldType == typeof(char))) || ((fieldType == typeof(bool)) || fieldType.IsArray)) || ((fieldType == typeof(DateTime)) || (fieldType == typeof(Guid))))
                    {
                        table.Columns.Add(name, typeof(string));
                        objArray[i] = "";
                    }
                    else
                    {
                        table.Columns.Add(name, typeof(double));
                        objArray[i] = 0.0;
                    }
                }
                int num2 = 1;
                object[] values = new object[reader.FieldCount];
                while (reader.Read() && (num2++ != Maximum))
                {
                    reader.GetValues(values);
                    for (int j = 0; j < values.Length; j++)
                    {
                        if (DBNull.Value.Equals(values[j]))
                        {
                            values[j] = objArray[j];
                        }
                    }
                    DataRow row = table.NewRow();
                    row.ItemArray = values;
                    table.Rows.Add(row);
                }
                table.EndLoadData();
                Table.DataSource = table.DefaultView;
                reader.Close();
            }
        }

        public string FileToBLOB(string File)
        {
            byte[] buffer = null;
            using (FileStream stream = new FileStream(File, FileMode.Open))
            {
                buffer = new byte[stream.Length];
                stream.Read(buffer, 0, (int) stream.Length);
            }
            return this.BytesToBLOB(buffer);
        }

        private DataGridTextBoxColumn NewColumnStyle(string name) => 
            new DataGridTextBoxColumn { 
                MappingName = name,
                HeaderText = name
            };

        public void SetNullParameter(string Name)
        {
            this.command.Parameters["@" + Name].Value = null;
        }

        public void SetParameter(string Name, string Value)
        {
            this.command.Parameters["@" + Name].Value = Value;
        }

        void IDisposable.Dispose()
        {
            this.command.Dispose();
        }

        public string CommandText
        {
            get => 
                this.command.CommandText;
            set => 
                this.command.CommandText = value;
        }
    }
}

