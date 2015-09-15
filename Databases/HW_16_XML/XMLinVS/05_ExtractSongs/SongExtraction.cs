using System;
using System.Xml;

public class SongExtraction
{
    static void Main()
    {
        string pathToFile = "../../../albums.xml";
        Console.WriteLine("Song titles in the library:");
        using (XmlReader reader = XmlReader.Create(pathToFile))
        {
            while (reader.Read())
            {
                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "title"))
                {
                    Console.WriteLine(reader.ReadElementString());
                }
            }
        }
    }
}