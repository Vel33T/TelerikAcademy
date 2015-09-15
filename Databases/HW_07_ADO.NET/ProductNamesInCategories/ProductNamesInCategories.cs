using System;
using System.Data.SqlClient;

namespace ProductNamesInCategories
{
    class ProductNamesInCategories
    {
        static void Main()
        {
            SqlConnection dbCon = new SqlConnection("Server=.; Database=Northwind; Integrated Security=true");
            dbCon.Open();
            using (dbCon)
            {
                string query =  "SELECT c.CategoryName, p.ProductName " +
                                "FROM Products p " +
                                    "JOIN Categories c " +
                                    "ON p.CategoryId = c.CategoryId " +
                                "ORDER BY c.CategoryName";

                SqlCommand cmd = new SqlCommand(query, dbCon);
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string categoryName = (string)reader["CategoryName"];
                        string productName = (string)reader["ProductName"];

                        Console.WriteLine("{0} - {1}", categoryName, productName);
                    }
                }
            }
        }
    }
}
