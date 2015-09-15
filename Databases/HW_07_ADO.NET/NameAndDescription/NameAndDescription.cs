using System;
using System.Data.SqlClient;

namespace NameAndDescription
{
    class NameAndDescription
    {
        static void Main()
        {
            SqlConnection dbCon = new SqlConnection("Server=.; Database=Northwind; Integrated Security=true");
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand nameAndDescription = new SqlCommand("SELECT CategoryName, Description FROM Categories", dbCon);
                SqlDataReader reader = nameAndDescription.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string name = (string)reader["CategoryName"];
                        string description = (string)reader["Description"];

                        Console.WriteLine("{0,-15} - {1}", name, description);
                    }
                }
            }
        }
    }
}
