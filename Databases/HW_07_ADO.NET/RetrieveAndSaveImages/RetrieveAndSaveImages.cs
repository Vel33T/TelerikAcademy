using System;
using System.IO;
using System.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace RetrieveAndSaveImages
{
    class RetrieveAndSaveImages
    {
        static void Main()
        {
            List<byte[]> pictures = new List<byte[]>();
            List<string> imageNames = new List<string>();

            SqlConnection dbCon = new SqlConnection("Server=.; Database=Northwind; Integrated Security=true");
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand cmd = new SqlCommand("SELECT CategoryName, Picture FROM Categories", dbCon);
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        pictures.Add(((byte[])reader["Picture"]).Skip(78).ToArray());                       // used Replace because '/' in CategoryName was making path problems
                        imageNames.Add(((string)reader["CategoryName"]).Replace('/', ' ').ToString());      // shortest workaround I came up with :)
                    }
                }
            }

            string path = @"..\..\images\";

            for (int i = 0; i < pictures.Count; i++)
            {
                FileStream stream = File.OpenWrite(path + imageNames[i] + ".jpg");
                using (stream)
                {
                    stream.Write(pictures[i], 0, pictures[i].Length);
                }
            }

            Console.WriteLine("Done!");
        }
    }
}