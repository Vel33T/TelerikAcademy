using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrintCoursesAlphabeticaly
{
    class PrintCoursesAlphabeticaly
    {
        static void Main()
        {
            SortedDictionary<string, SortedSet<string>> elements = new SortedDictionary<string, SortedSet<string>>();

            List<string[]> input = ProcessInput();

            foreach (var item in input)
            {
                if (elements.ContainsKey(item[1]))
                {
                    elements[item[1]].Add(item[0]);
                }
                else
                {
                    SortedSet<string> sortedNames = new SortedSet<string>();
                    sortedNames.Add(item[0]);
                    elements.Add(item[1], sortedNames);
                }
            }

            foreach (var element in elements)
            {
                Console.Write(element.Key + ": ");
                foreach (var name in element.Value)
                {
                    Console.Write(name + ", ");
                }
                Console.WriteLine();
            }
        }

        private static List<string[]> ProcessInput()
        {
            List<string[]> result = new List<string[]>();

            using (StreamReader reader = new StreamReader(@"..\..\TextFile.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] items = line.Split('|');

                    for (int i = 0; i < items.Length; i++)
                    {
                        items[i] = items[i].Trim();
                    }

                    result.Add(new string[] { items[0] + " " + items[1], items[2] });
                }
            }

            return result;
        }
    }
}
