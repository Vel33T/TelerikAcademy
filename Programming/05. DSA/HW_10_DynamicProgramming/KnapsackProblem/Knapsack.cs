namespace KnapsackProblem
{
    using System;
    using System.Collections.Generic;

    public class Knapsack
    {
        public List<Product> FindBestItems(List<Product> products, int capacity)
        {
            int[,] cost = new int[products.Count + 1, capacity + 1];
            bool[,] keep = new bool[products.Count + 1, capacity + 1];

            for (int i = 1; i <= products.Count; i++)
            {
                Product currentProduct = products[i - 1];

                for (int space = 1; space <= capacity; space++)
                {
                    if (space >= currentProduct.Weigth)
                    {
                        int remainingSpace = space - currentProduct.Weigth;
                        int remaningSpaceValue = 0;
                        if (remainingSpace > 0)
                        {
                            remaningSpaceValue = cost[i - 1, remainingSpace];
                        }

                        int currentProductTotalValue = currentProduct.Cost + remaningSpaceValue;
                        if (currentProductTotalValue > cost[i - 1, space])
                        {
                            keep[i, space] = true;
                            cost[i, space] = currentProductTotalValue;
                        }
                        else
                        {
                            keep[i, space] = false;
                            cost[i, space] = cost[i - 1, space];
                        }
                    }
                }
            }

            List<Product> productsToBePacked = new List<Product>();

            int remainSpace = capacity;
            int productsCount = products.Count;
            while (productsCount > 0)
            {
                bool toBePacked = keep[productsCount, remainSpace];
                if (toBePacked)
                {
                    productsToBePacked.Add(products[productsCount - 1]);
                    remainSpace = remainSpace - products[productsCount - 1].Weigth;
                }
                productsCount--;
            }
            
            return productsToBePacked;
        }
    }
}
