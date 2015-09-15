using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace CountWordsInText
{
    class CountWordsInText
    {
        static void Main()
        {
            string text = String.Empty;
            using (StreamReader sr = new StreamReader(@"..\..\TextFile.txt"))
            {
                text = sr.ReadToEnd().ToLower();
            }

            var matches = Regex.Matches(text, @"\w+");

            Dictionary<string, int> occurances = new Dictionary<string, int>();

            foreach (var word in matches)
            {
                string keyWord = word.ToString();
                if (!occurances.Keys.Contains(keyWord))
                {
                    occurances.Add(keyWord, 1);
                }
                else
                {
                    occurances[keyWord]++;
                }
            }

            List<KeyValuePair<string, int>> pairs = occurances.ToList();
            pairs.Sort((x, y) => x.Value.CompareTo(y.Value));

            foreach (var pair in pairs)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
