namespace FactoryMethod
{
    using System;

    class FactoryMethod
    {
        static void Main()
        {
            IProduct pc = new PCCreator("PC").Create();

            string pcState = pc.Buy();
            Console.WriteLine(pcState);

            pcState = pc.Sell();
            Console.WriteLine(pcState);
        }
    }
}