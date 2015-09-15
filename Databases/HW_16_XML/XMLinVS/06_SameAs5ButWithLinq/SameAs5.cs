using System;
using System.Linq;
using System.Xml.Linq;

public class SameAs5
{
    static void Main()
    {
        string pathToFile = "../../../albums.xml";
        XDocument xmlDoc = XDocument.Load(pathToFile);
        var songs =
            from song in xmlDoc.Descendants("track")
            select song.Element("title").Value;

        Console.WriteLine("Song titles in the library:");
        foreach (var song in songs)
        {
            Console.WriteLine(song);
        }
    }
}