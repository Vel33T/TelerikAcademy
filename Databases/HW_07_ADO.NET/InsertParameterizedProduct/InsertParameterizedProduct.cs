using System;
using System.Data.SqlClient;

namespace InsertParameterizedProduct
{
    class InsertParameterizedProduct
    {
        static void Main()
        {
            SqlConnection dbCon = new SqlConnection("Server=.; Database=Northwind; Integrated Security=true");
            dbCon.Open();
            using (dbCon)
            {
                InsertProduct(dbCon, "Nervous Meatball2", 7, 3, "10 broiki u tarelka", 10, 2, 2);
                Console.WriteLine("Product added!");
            }
        }

        private static void InsertProduct(SqlConnection dbCon, string productName, int? supplierId = null, int? categoryId = null,
            string quantityPerUnit = null, decimal? unitPrice = null, int? unitsInStock = null,
            int? unitsOnOrder = null)
        {
            string query =  "INSERT INTO Products(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder)" +
                            "VALUES (@productName, @supplierId, @categoryId, @quantityPerUnit, @unitPrice, @unitsInStock, @unitsOnOrder)";
            SqlCommand cmd = new SqlCommand(query, dbCon);
            cmd.Parameters.AddWithValue("@productName", productName);
            cmd.Parameters.AddWithValue("@supplierId", supplierId);
            cmd.Parameters.AddWithValue("@categoryId", categoryId);
            cmd.Parameters.AddWithValue("@quantityPerUnit", quantityPerUnit);
            cmd.Parameters.AddWithValue("@unitPrice", unitPrice);
            cmd.Parameters.AddWithValue("@unitsInStock", unitsInStock);
            cmd.Parameters.AddWithValue("@unitsOnOrder", null);
            cmd.ExecuteNonQuery();
        }
    }
}
