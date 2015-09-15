using System;
using System.Linq;

/* Write a LINQ query that finds the first name and last
 * name of all students with age between 18 and 24.
 */

namespace AgeBetweenInterval
{
    class Tests
    {
        static void Main(string[] args)
        {
            Student[] students = 
            {
                new Student("Gosho", "Stefanov", 20),
                new Student("Gosho", "Angelov", 18),
                new Student("Gosho", "Donchev", 24),
                new Student("Ivan", "Stefanov", 27),
                new Student("Mitko", "Spasov", 15),
            };

            var neededAge =
                from student in students
                where student.Age <= 24 && student.Age >= 18
                select student;
            foreach (var student in neededAge)
            {
                Console.WriteLine(student.FirstName + " " + student.SecondName);
            }
        }
    }
}
