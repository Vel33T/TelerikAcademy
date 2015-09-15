using System;

namespace StudentData
{
    public class Tests
    {
        static void Main()
        {
            Student student = new Student("Pesho", "Peshov", "Peshonkov", 
                "ul. Krakra bl 20 ap 9", "0886004158", "Course", "8707133807",
                "bathman@gbg.bg", Specialty.Informatics, University.NBU,
                Faculty.Mathematics);

            Student newStudent = student.Clone();

            Console.WriteLine(student.CompareTo(newStudent));
            Console.WriteLine(student == newStudent);

            newStudent.LastName = "Ivanov";

            Console.WriteLine(student.CompareTo(newStudent));
            Console.WriteLine(student != newStudent);

            Console.WriteLine(student);
            Console.WriteLine(newStudent);
        }
    }
}
