using System;
using System.Linq;

/* Using the extension methods OrderBy() and
 * ThenBy() with lambda expressions sort the students
 * by first name and last name in descending order.
 * Rewrite the same with LINQ.
 */

namespace DescendingOrder
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
            Console.WriteLine("Ordered by using Lambda!");

            var descendingByLambda = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.SecondName);

            foreach (var student in descendingByLambda)
            {
                Console.WriteLine(student.FirstName + " " + student.SecondName);
            }
            Console.WriteLine();
            Console.WriteLine("Ordered by LINQ!");

            var descendingByLINQ =
                from student in students
                orderby student.FirstName descending, student.SecondName descending
                select student;

            foreach (var student in descendingByLINQ)
            {
                Console.WriteLine(student.FirstName + " " + student.SecondName);
            }
        }
    }
}
