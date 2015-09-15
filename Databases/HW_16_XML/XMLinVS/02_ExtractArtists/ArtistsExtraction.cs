using System;
using System.Xml;
using System.Collections;

public class ArtistsExtraction
{
    static void Main()
    {
        Hashtable artists = new Hashtable();
        XmlDocument doc = new XmlDocument();
        doc.Load("../../../albums.xml");
        XmlNode rootNode = doc.DocumentElement;

        foreach (XmlNode album in rootNode.ChildNodes)
        {
            string artistName = album["artist"].InnerText;
            if (artists.ContainsKey(artistName))
            {
                artists[artistName] = (int)artists[artistName] + 1;
            }
            else
            {
                artists.Add(artistName, 1);
            }
        }

        var artistsEnumerator = artists.GetEnumerator();

        while (artistsEnumerator.MoveNext())
        {
            Console.WriteLine(artistsEnumerator.Key + " " + artistsEnumerator.Value);
        }
    }
}