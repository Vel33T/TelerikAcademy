using System;
using System.Data.SqlClient;

namespace CategoriesRowCount
{
    class CategoriesRowCount
    {
        static void Main()
        {
            SqlConnection dbCon = new SqlConnection("Server=.; Database=Northwind; Integrated Security=true");
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand cmdRowCount = new SqlCommand("SELECT COUNT(*) FROM Categories", dbCon);
                int categoriesCount = (int)cmdRowCount.ExecuteScalar();
                Console.WriteLine("Number of rows in Categories: {0}", categoriesCount);
            }
        }
    }
}
