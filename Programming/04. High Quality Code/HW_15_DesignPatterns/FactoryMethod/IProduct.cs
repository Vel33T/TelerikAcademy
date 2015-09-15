namespace FactoryMethod
{
    using System;

    public interface IProduct
    {
        string Name { get; set; }
        string Sell();
        string Buy();
    }
}
