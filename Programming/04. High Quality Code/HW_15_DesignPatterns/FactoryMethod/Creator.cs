namespace FactoryMethod
{
    using System;

    public abstract class Creator<T>
    {
        public abstract T Create();
    }
}