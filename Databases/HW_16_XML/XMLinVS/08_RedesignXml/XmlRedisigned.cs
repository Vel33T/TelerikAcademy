using System;
using System.Xml;
using System.Text;

public class XmlRedisigned
{
    public static void Main()
    {
        string pathToSourceFile = "../../../albums.xml";
        string pathToTargetFile = "../../../album.xml";
        Encoding encoding = Encoding.GetEncoding("windows-1251");
        using (XmlReader reader = XmlReader.Create(pathToSourceFile))
        {
            using (XmlTextWriter writer = new XmlTextWriter(pathToTargetFile, encoding))
            {
                string name = "", artist = "";
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;
                writer.WriteStartDocument();
                writer.WriteStartElement("albums");

                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "name"))
                    {
                        name = reader.ReadElementString();
                    }

                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "artist"))
                    {
                        artist = reader.ReadElementString();
                        WriteAlbum(writer, name, artist);
                    }
                }

                writer.WriteEndDocument();
            }
        }
    }

    private static void WriteAlbum(XmlWriter writer, string title, string author)
    {
        writer.WriteStartElement("album");
        writer.WriteElementString("title", title);
        writer.WriteElementString("artist", author);
        writer.WriteEndElement();
    }
}