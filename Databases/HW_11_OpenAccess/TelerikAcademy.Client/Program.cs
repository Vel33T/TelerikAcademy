using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using TelerikAcademy.Models;
using Telerik.OpenAccess;

//Homework 2
namespace TelerikAcademy.Client
{
    class Program
    {
        static void Main()
        {

        }
        //HW2
        public void SerializeDeserialize(string unit)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            MemoryStream stream = SerializeToBinaryStream(unit);//makes string as byte[] 
            stream.Seek(0, SeekOrigin.Begin);

            Employee employee = formatter.Deserialize(stream) as Employee;

            Console.WriteLine("Name: {0}", employee.FirstName);
        }

        public MemoryStream SerializeToBinaryStream(string employeeFName)//memory stream 
        {
            BinaryFormatter formatter = new BinaryFormatter();

            MemoryStream stream = new MemoryStream();

            using (var dbContext = new EntitiesModel())
            {
                Employee customer = dbContext.Employees.Where(e => e.FirstName == employeeFName).First();

                var sentQueryToServer = customer.FirstName;

                formatter.Serialize(stream, customer);
            }

            return stream;
        }

        //HW3

        public void Insert100000EntitiesInDB()
        {
            using (var context = new EntitiesModel())
            {
                ulong id = 1;
                int counter = 0;
                while (counter < 100000)
                {
                    id += 7;
                    var row = new OpenAccessDemoEntity()
                    {
                        Name = id + "Demo"
                    };

                    context.Add(row);

                    counter += 1;
                    context.SaveChanges();
                }
            }
        }

        public void BulkDelete()
        {
            using (var context = new EntitiesModel())
            {
                context.OpenAccessDemoEntities.DeleteAll();
                
            }
        }

        public void NormalDelete()
        {
            using (var context = new EntitiesModel())
            {
                foreach (var item in context.OpenAccessDemoEntities)
                {
                    context.Delete(item);
                }

                context.SaveChanges();
            }
        }
    }
}
