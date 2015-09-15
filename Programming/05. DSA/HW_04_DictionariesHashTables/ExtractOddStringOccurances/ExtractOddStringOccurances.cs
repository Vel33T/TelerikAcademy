using System;
using System.Linq;
using System.Collections.Generic;

namespace ExtractOddStringOccurances
{
    class ExtractOddStringOccurances
    {
        static void Main()
        {
            List<string> strings = new List<string>() { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            Dictionary<string, int> occurances = new Dictionary<string, int>();

            for (int i = 0; i < strings.Count; i++)
            {
                if (!occurances.Keys.Contains(strings[i]))
                {
                    occurances.Add(strings[i], 1);
                }
                else
                {
                    occurances[strings[i]]++;
                }
            }

            foreach (var pair in occurances)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.Write(pair.Key + " "); 
                }
            }
            Console.WriteLine();
        }
    }
}
