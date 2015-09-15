using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;
using System.Diagnostics;

namespace MillionsOfArticles
{
    class MillionsOfArticles
    {
        static void Main()
        {
            OrderedMultiDictionary<double, Article> articles =
                new OrderedMultiDictionary<double, Article>(true);

            for (int i = 0; i < 2000000; i++)
            {
                // Followint two lines... Generating some shits to fill the dictionary :)
                double price = i % 500000;
                Article article = new Article(987342, "Vendor" + i.ToString(), "Title " + (i / 5).ToString(), price);
                articles.Add(price, article);
            }

            Stopwatch watch = new Stopwatch();
            watch.Start();
            // Taking 100 000 different ranges (Damn! This shit is fast!)
            var articlesRange = articles.Range(0, true, 200000, false);
            for (int i = 0; i < 100000; i++)
            {
                articlesRange = articles.Range(1 + i * 2, true, 200001 + i * 2, false);
            }
            watch.Stop();
            Console.WriteLine("Range found in: " + watch.Elapsed);
            Console.WriteLine(articlesRange.Count);

            // Uncomment if you want like 10-20 seconds printing of meaningless data on the console :)
            //StringBuilder sb = new StringBuilder();
            //foreach (var node in articlesRange)
            //{
            //    foreach (var item in node.Value)
            //    {
            //        sb.AppendFormat("{3}: {0} {1} {2}\n", item.Barcode, item.Vendor, item.Title, item.Price);
            //    }
            //}
            //Console.WriteLine(sb.ToString());
        }
    }
}
