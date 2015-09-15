using System;
using System.Xml;
using System.Diagnostics;

public class DeleteItemsWithDom
{
    static void Main()
    {
        string pathToFile = "../../../albums.xml";
        XmlDocument doc = new XmlDocument();
        doc.Load(pathToFile);
        XmlNode rootNode = doc.DocumentElement;
        XmlNodeList albums = rootNode.ChildNodes;

        for (int i = albums.Count - 1; i >= 0; i--)
        {
            decimal albumPrice = decimal.Parse(albums[i]["price"].InnerText);
            if (albumPrice < 20)
            {
                albums[i].ParentNode.RemoveChild(albums[i]);
            }
        }

        doc.Save(pathToFile);
        Process.Start(pathToFile);
    }
}