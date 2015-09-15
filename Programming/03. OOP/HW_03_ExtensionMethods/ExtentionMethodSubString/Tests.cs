using System;
using System.Text;

namespace ExtentionMethodSubString
{
    class Tests
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder("Sralo meche na pyteche!");
            Console.WriteLine(builder.Substring(6));
            Console.WriteLine(builder.Substring(6, 5));
            Console.WriteLine(builder.Substring(22));

            //Console.WriteLine(builder.Substring(20, 20));
            Console.WriteLine(builder.Substring(-1, 5));
        }
    }
}
