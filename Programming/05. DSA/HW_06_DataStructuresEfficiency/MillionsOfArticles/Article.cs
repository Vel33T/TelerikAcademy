using System;

namespace MillionsOfArticles
{
    public class Article : IComparable<Article>
    {
        public int Barcode { get; set; }
        public double Price { get; set; }
        public string Vendor { get; set; }
        public string Title { get; set; }

        public Article(int barcode, string vendor, string title, double price)
        {
            this.Barcode = barcode;
            this.Vendor = vendor;
            this.Title = title;
            this.Price = price;
        }

        public int CompareTo(Article other)
        {
            return this.Price.CompareTo(other.Price);
        }
    }
}
