namespace StudentSystem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using StudentSystem.Models;

    public sealed class Configuration : DbMigrationsConfiguration<StudentSystemContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(StudentSystemContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Students.AddOrUpdate(x => new { x.Name, x.FacultyNumber },
                new Student { Name = "Svetlin Nakov", FacultyNumber = "12345" },
                new Student { Name = "Nikolay Kostov", FacultyNumber = "54321" }
            );

            context.Courses.AddOrUpdate(x => new { x.Name, x.Description },
                new Course { Name = "Data Structures", Description = "TelerikAcademy Course" },
                new Course { Name = "Algorithms", Description = "TelerikAcademy Course" }
            );

            context.SaveChanges();

            context.Courses
                .Where(x => x.Name == "Data Structures").First()
                .Students.Add(context.Students
                    .Where(x => x.Name == "Svetlin Nakov").First());

            context.Courses
                .Where(x => x.Name == "Algorithms").First()
                .Students.Add(context.Students
                    .Where(x => x.Name == "Nikolay Kostov").First());

            context.SaveChanges();
        }
    }
}
