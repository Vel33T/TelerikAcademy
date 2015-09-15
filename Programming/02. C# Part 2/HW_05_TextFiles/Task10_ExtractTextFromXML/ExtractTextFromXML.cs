using System;
using System.IO;
using System.Text.RegularExpressions;

/* Write a program that extracts from given 
 * XML file all the text without the tags. Example:
 * 
 * <?xml version="1.0"><student><name>Pesho</name>
 * <age>21</age><interests count="3"><interest>
 * Games</instrest><interest>C#</instrest><interest>
 * Java</instrest></interests></student>
 */

class ExtractTextFromXML
{
    static void Main()
    {
        StreamReader input = new StreamReader("../../TextFile1.txt");
        StreamWriter output = new StreamWriter("../../TextFile2.txt");
        using (input)
        {
            string line = input.ReadLine();
            using (output)
            {
                while (line != null)
                {
                    MatchCollection match = Regex.Matches(line, "(?<=^|>)[^><]+?(?=<|$)");
                    foreach (var item in match)
                    {
                        output.WriteLine(item);
                    }
                    line = input.ReadLine();
                }
            }
        }
    }
}
