using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;
using System.Diagnostics;

namespace ElementsInPriceRange
{
    class Program
    {
        static void Main()
        {
            Stopwatch watch = new Stopwatch();
            OrderedBag<Product> bag = new OrderedBag<Product>();
            
            watch.Start();
            for (int i = 1; i <= 500000; i++)
            {
                bag.Add(new Product(i.ToString(), i));
            }
            watch.Stop();
            Console.WriteLine("Adding of 500000 products time:      {0}", watch.Elapsed);

            watch.Restart();
            for (int i = 1; i <= 10000; i++)
            {
                List<Product> found = First20Found(bag, 500, 500 + i);
            }
            watch.Stop();

            Console.WriteLine("Taking different ranges 10000 times: {0}", watch.Elapsed);
        }

        private static List<Product> First20Found(OrderedBag<Product> bag, int lowPrice, int highPrice)
        {
            var result = bag.Range(new Product("searchItem", highPrice), true,
                new Product("searchItem", lowPrice), true);

            List<Product> listResult = new List<Product>();

            if (result.Count == 0)
            {
                return listResult;
            }

            for (int i = 0; i < 20 && i < result.Count; i++)
            {
                listResult.Add(result[i]);
            }

            return listResult;
        }
    }
}
