using System;

namespace PersonTask
{
    public class Test
    {
        static void Main()
        {
            Person one = new Person("Ivan Ivanov", 20);
            Person two = new Person("Pesho Peshov");

            Console.WriteLine(one);
            Console.WriteLine(two);
        }
    }
}
