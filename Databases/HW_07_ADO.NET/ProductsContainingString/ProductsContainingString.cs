using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace ProductsContainingString
{
    class ProductsContainingString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> allProducts = new List<string>();

            SqlConnection dbCon = new SqlConnection("Server=.; Database=Northwind; Integrated Security=true");
            dbCon.Open();
            using (dbCon)
            {
                string query = "SELECT ProductName FROM Products where ProductName LIKE @input";
                SqlParameter userInput = new SqlParameter("@input", "%" + input + "%");
                SqlCommand cmd = new SqlCommand(query, dbCon);
                cmd.Parameters.Add(userInput);

                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        allProducts.Add((string)reader["ProductName"]);
                    }
                }
            }

            foreach (var item in allProducts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
