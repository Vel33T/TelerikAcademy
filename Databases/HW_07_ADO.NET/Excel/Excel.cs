using System;
using System.Data;
using System.Data.OleDb;

namespace Excel
{
    class Excel
    {
        static void Main()
        {
            ReadFromExcel();

            AddRow("Jore Jorev", 17);
        }

        private static void AddRow(string name, int score)
        {
            DataTable dt = new DataTable("table");
            OleDbConnectionStringBuilder csBuilder = new OleDbConnectionStringBuilder();
            csBuilder.Provider = "Microsoft.ACE.OLEDB.12.0";
            csBuilder.DataSource = @"..\..\Table.xlsx";
            csBuilder.Add("Extended Properties", "Excel 12.0 Xml;HDR=YES");

            using (OleDbConnection connection = new OleDbConnection(csBuilder.ConnectionString))
            {
                string insertToTable = @"INSERT INTO [Sheet1$] (Name, Score) VALUES (@name, @score)";
                using (OleDbCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandType = CommandType.Text;
                    command.CommandText = insertToTable;
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@score", score);
                    command.ExecuteNonQuery();
                }
            }
        }

        private static void ReadFromExcel()
        {
            DataTable dt = new DataTable("table");
            OleDbConnectionStringBuilder csBuilder = new OleDbConnectionStringBuilder();
            csBuilder.Provider = "Microsoft.ACE.OLEDB.12.0";
            csBuilder.DataSource = @"..\..\Table.xlsx";
            csBuilder.Add("Extended Properties", "Excel 12.0 Xml;HDR=YES");

            using (OleDbConnection connection  = new OleDbConnection(csBuilder.ConnectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM Sample";

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    adapter.FillSchema(dt, SchemaType.Source);
                    adapter.Fill(dt);
                }
            }

            foreach (DataRow row in dt.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
