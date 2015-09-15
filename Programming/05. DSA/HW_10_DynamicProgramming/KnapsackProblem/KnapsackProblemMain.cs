namespace KnapsackProblem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class KnapsackProblemMain
    {
        static void Main()
        {
            Product beer = new Product("beer", 3, 2);
            Product vodka = new Product("vodka", 8, 12);
            Product cheese = new Product("cheese", 4, 5);
            Product nuts = new Product("nuts", 1, 4);
            Product ham = new Product("ham", 2, 3);
            Product whiskey = new Product("whiskey", 8, 13);

            List<Product> products = new List<Product>();
            products.Add(beer);
            products.Add(vodka);
            products.Add(cheese);
            products.Add(nuts);
            products.Add(ham);
            products.Add(whiskey);

            int bagCapacity = 10;

            Knapsack sack = new Knapsack();

            List<Product> productsInSack = sack.FindBestItems(products, bagCapacity);
            
            Console.WriteLine(ListToString(productsInSack));
        }
  
        private static StringBuilder ListToString(List<Product> productsInSack)
        {
            StringBuilder sb = new StringBuilder();
            int weigth = 0;
            int cost = 0;
            foreach (Product product in productsInSack)
            {
                sb.AppendFormat("{0} + ", product.Name);
                weigth += product.Weigth;
                cost += product.Cost;
            }
            sb.Length -= 3;
            sb.Append(Environment.NewLine);
            sb.AppendFormat("weight = {0}", weigth);
            sb.Append(Environment.NewLine);
            sb.AppendFormat("cost = {0}", cost);
            return sb;
        }
    }
}
