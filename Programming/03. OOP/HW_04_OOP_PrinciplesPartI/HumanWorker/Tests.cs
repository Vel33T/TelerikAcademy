using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanWorker
{
    class Tests
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Martin", "Emilov", 5),
                new Student("Sasho", "Asenov", 6),
                new Student("Stefan", "Mihaylov", 4),
                new Student("Evgeni", "Dimitrov", 6),
                new Student("Mario", "Nikolov", 2),
                new Student("Filip", "Buhov", 3),
                new Student("Aleko", "Dimitrov", 5),
                new Student("Denislav", "Dimitrov", 3),
                new Student("Tako", "Takov", 2),
                new Student("Plamen", "Petkov", 4)
            };

            var sortedStudents = students.OrderBy(x => x.Grade);
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            List<Worker> workers = new List<Worker>
            {
                new Worker("Angel", "Hristov", 8, 200),
                new Worker("Sasho", "Petrov", 3.20, 150.2),
                new Worker("Stefan", "Dimotrov", 4, 130.32),
                new Worker("Evgeni", "Kirov", 13, 470.43),
                new Worker("Mario", "Ivanov", 10, 350),
                new Worker("Filip", "Dimitrov", 11, 280),
                new Worker("Aleko", "Dimotrov", 7, 300),
                new Worker("Denislav", "Adamov", 4, 900),
                new Worker("Tako", "Lyubenov", 2, 1000),
                new Worker("Plamen", "Petkov", 4, 789)
            };

            var sortedWorkers = workers.OrderByDescending(x => x.MoneyPerHour());
            foreach (Worker worker in sortedWorkers)
            {
                Console.WriteLine(worker);
            }
            Console.WriteLine();

            List<Human> mergedList = new List<Human>(students.Concat<Human>(workers));

            var orderedMergedList = mergedList.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            foreach (Human human in orderedMergedList)
            {
                Console.WriteLine(human.FirstName + " " + human.LastName);
            }
            Console.WriteLine();
        }
    }
}
