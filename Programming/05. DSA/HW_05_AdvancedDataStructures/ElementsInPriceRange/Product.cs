using System;

namespace ElementsInPriceRange
{
    public class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public int CompareTo(Product other)
        {
            if (this.Price > other.Price)
            {
                return -1;
            }
            else if (this.Price < other.Price)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}: {1}", this.Name, this.Price);
        }
    }
}
