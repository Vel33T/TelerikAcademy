namespace StudentSystem.Client
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using StudentSystem.Data;
    using StudentSystem.Data.Migrations;

    internal class Client
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemContext, Configuration>());
         
            var dbContext = new StudentSystemContext();
            // Force Initialization.
            dbContext.Database.Initialize(true);

            Console.WriteLine("All Students:");
            ListAllStudents(dbContext);

            Console.WriteLine("All Courses:");
            ListAllCourses(dbContext);
        }

        private static void ListAllStudents(StudentSystemContext context)
        {
            foreach (var student in context.Students.Include("Courses"))
            {
                Console.WriteLine(
                    "Student: {0}; FacultyNumber: {1}; Courses: {2}",
                    student.Name,
                    student.FacultyNumber,
                    string.Join(", ", student.Courses.Select(x => x.Name)));
            }
        }

        private static void ListAllCourses(StudentSystemContext context)
        {
            foreach (var course in context.Courses.Include("Students"))
            {
                Console.WriteLine(
                    "Course: {0}; Description: {1}; Courses: {2}",
                    course.Name,
                    course.Description,
                    string.Join(", ", course.Students.Select(x => x.Name)));
            }
        }
    }
}
