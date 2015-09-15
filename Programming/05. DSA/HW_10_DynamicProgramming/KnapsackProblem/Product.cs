namespace KnapsackProblem
{
    using System;

    public class Product
    {
        public string Name { get; set; }
        public int Weigth { get; set; }
        public int Cost { get; set; }

        public Product(string name, int weigth, int cost)
        {
            this.Name = name;
            this.Weigth = weigth;
            this.Cost = cost;
        }
    }
}
