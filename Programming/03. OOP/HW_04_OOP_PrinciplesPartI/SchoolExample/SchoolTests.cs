using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolExample
{
    class SchoolTests
    {
        static void Main()
        {
            School testSchool = new School("NBU");

            Class testClass = new Class("Network technologies");

            Teacher testTeacher = new Teacher("Nikolay", "Kostov");

            Discipline testDiscipline1 = new Discipline("C++ Fundamentials", 2, 2);
            Discipline testDiscipline2 = new Discipline("C++ OOP", 2, 2);

            Student testStudent = new Student("Stavri", "Stamenkov", 3);

            testTeacher.AddDiscipline(testDiscipline1);
            testTeacher.AddDiscipline(testDiscipline2);

            testClass.AddStudent(new Student("Aleksandar", "Aleksandrov", 1));
            testClass.AddStudent(new Student("Ivan", "Ivanov", 2));
            testClass.AddStudent(testStudent);
            testClass.AddStudent(new Student("Yavor", "Kolev", 4));
            testClass.AddTeacher(testTeacher);

            testSchool.AddClass(testClass);

            testClass.RemoveStudent(testStudent);

            Console.WriteLine(testSchool);
        }
    }
}
