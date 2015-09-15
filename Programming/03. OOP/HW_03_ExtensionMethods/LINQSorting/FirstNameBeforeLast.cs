using System;
using System.Linq;

/* Write a method that from a given array of students
 * finds all students whose first name is before its last
 * name alphabetically. Use LINQ query operators.
 */

namespace LINQSorting
{
    class FirstNameBeforeLast
    {
        static void Main(string[] args)
        {
            Student[] students = 
            {
                new Student("Gosho", "Stefanov"),
                new Student("Gosho", "Angelov"),
                new Student("Gosho", "Donchev"),
                new Student("Ivan", "Stefanov"),
                new Student("Mitko", "Spasov"),
            };

            var firstBeforeLast =
                from student in students
                where student.FirstName.CompareTo(student.SecondName) < 0
                select student;
            foreach (var student in firstBeforeLast)
            {
                Console.WriteLine(student.FirstName + " " + student.SecondName);
            }
        }
    }
}
