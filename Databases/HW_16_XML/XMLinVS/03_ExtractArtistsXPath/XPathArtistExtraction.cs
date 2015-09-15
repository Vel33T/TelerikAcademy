using System;
using System.Xml;
using System.Collections;

public class XPathArtistExtraction
{
    static void Main()
    {
        Hashtable artists = new Hashtable();
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load("../../../albums.xml");
        string xPathQuery = "/albums/album/artist";

        XmlNodeList artistsList = xmlDoc.SelectNodes(xPathQuery);
        foreach (XmlNode artistNode in artistsList)
        {
            string artistName = artistNode.InnerText;
            if (artists.ContainsKey(artistName))
            {
                artists[artistName] = (int) artists[artistName] + 1;
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