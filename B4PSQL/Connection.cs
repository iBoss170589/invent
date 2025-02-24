namespace B4PSQL
{
    using System;
    using System.Data;
    using System.Data.SQLite;
    using System.Windows.Forms;

    public class Connection : IDisposable
    {
        private SQLiteConnection connection = new SQLiteConnection();
        private SQLiteTransaction transaction;

        public void BeginTransaction()
        {
            this.transaction = this.connection.BeginTransaction();
        }

        public void ChangePassword(string password)
        {
            this.connection.ChangePassword(password);
        }

        public void Close()
        {
            this.connection.Close();
        }

        public void CreateSQLTable(DataGrid Table, string SQLTableName)
        {
            DataTable table = Table.GetType().GetField("dataTable").GetValue(Table);
            string str = "";
            string str2 = "";
            for (int i = 0; i < table.Columns.Count; i++)
            {
                string str3;
                if (table.Columns[i].DataType == typeof(double))
                {
                    str3 = "REAL";
                }
                else
                {
                    str3 = "TEXT";
                }
                string str4 = str;
                str = str4 + "'" + table.Columns[i].ColumnName + "' " + str3 + ",";
                str2 = str2 + ":p" + i.ToString() + ",";
            }
            str = str.Remove(str.Length - 1, 1);
            str2 = str2.Remove(str2.Length - 1, 1);
            using (SQLiteCommand command = new SQLiteCommand(this.connection))
            {
                using (SQLiteTransaction transaction = this.connection.BeginTransaction())
                {
                    command.CommandText = "CREATE TABLE '" + SQLTableName + "' (" + str + ")";
                    command.ExecuteNonQuery();
                    command.CommandText = "INSERT INTO '" + SQLTableName + "' VALUES (" + str2 + ")";
                    SQLiteParameter[] parameterArray = new SQLiteParameter[table.Columns.Count];
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        parameterArray[j] = new SQLiteParameter("p" + j.ToString());
                        command.Parameters.Add(parameterArray[j]);
                    }
                    for (int k = 0; k < table.Rows.Count; k++)
                    {
                        for (int m = 0; m < table.Columns.Count; m++)
                        {
                            parameterArray[m].Value = table.Rows[k][m];
                        }
                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
            }
        }

        public void Dispose()
        {
            this.connection.Close();
        }

        public void EndTransaction()
        {
            this.transaction.Commit();
        }

        public void Open(string ConnectionString)
        {
            this.Open(ConnectionString, null);
        }

        public void Open(string ConnectionString, string password)
        {
            this.connection.ConnectionString = ConnectionString;
            if (password != null)
            {
                this.connection.SetPassword(password);
            }
            this.connection.Open();
        }

        public void RemovePassword()
        {
            this.connection.ChangePassword((string) null);
        }

        public double DLLVersion =>
            1.6;

        public object Value
        {
            get => 
                this.connection;
            set => 
                this.connection = value;
        }
    }
}

