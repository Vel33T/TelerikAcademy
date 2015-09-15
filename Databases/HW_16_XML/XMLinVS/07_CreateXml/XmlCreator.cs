using System;
using System.IO;
using System.Xml.Linq;

public class XmlCreator
{
    static void Main()
    {
        string pathToSourceFile = "../../../person.txt";
        string pathToTargetFile = "../../../person.xml";

        using(StreamReader reader = new StreamReader(pathToSourceFile))
        {
            string name = reader.ReadLine();
            string address = reader.ReadLine();
            string phone = reader.ReadLine();
            XElement booksXml = new XElement("people",
                new XElement("person",
                    new XElement("name", name),
                    new XElement("address", address),
                    new XElement("phone", phone)
                )
            );

            Console.WriteLine(booksXml);
            booksXml.Save(pathToTargetFile);
        }
    }
}