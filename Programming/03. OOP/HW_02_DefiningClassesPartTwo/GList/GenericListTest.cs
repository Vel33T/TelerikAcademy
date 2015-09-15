using System;

namespace GList
{
    class GenericListTest
    {
        static void Main()
        {
            GenericList<string> list = new GenericList<string>(2);
            list.Add("first");
            Console.WriteLine(list);
            Console.WriteLine();
            list.Add("second");
            Console.WriteLine(list);
            Console.WriteLine();
            list.InsertAt("zero", 0);
            Console.WriteLine(list);
            Console.WriteLine();
            list.RemoveAt(0);
            Console.WriteLine(list);
            Console.WriteLine();
            Console.WriteLine("first is at possition: " + list.Find("first"));
            list.InsertAt("zero", 0);
            Console.WriteLine();
            Console.WriteLine("Max is: " + list.Max());
            Console.WriteLine();
            Console.WriteLine("Min is: " + list.Min());
            Console.WriteLine();
            Console.WriteLine(list.Count);
        }
    }
}
