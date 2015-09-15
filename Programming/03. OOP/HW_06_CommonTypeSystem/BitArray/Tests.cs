using System;

namespace BitArray
{
    class Tests
    {
        static void Main()
        {
            BitArray64 arr1 = new BitArray64(873475629625);
            BitArray64 arr2 = new BitArray64(8);

            Console.WriteLine(arr1);
            Console.WriteLine(arr2);
            Console.WriteLine(arr2.GetHashCode());
            Console.WriteLine(arr1 == arr2);
            Console.WriteLine(arr1 != arr2);
        }
    }
}
