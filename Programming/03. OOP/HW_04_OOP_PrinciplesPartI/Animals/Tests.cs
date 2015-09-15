using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Tests
    {
        static void Main()
        {
            Animal[] animals = 
            {
                new Dog("Sharo", 8, Sex.Male),
                new Dog("Tara", 2, Sex.Female),
                new Cat("Mariika", 3, Sex.Female),
                new Frog("Kermit", 1, Sex.Male),
                new Kitten("Lili", 3),
                new Tomcat("Ivan Kostov", 12),
            };

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine(animals.Average(x => x.Age));
        }
    }
}
