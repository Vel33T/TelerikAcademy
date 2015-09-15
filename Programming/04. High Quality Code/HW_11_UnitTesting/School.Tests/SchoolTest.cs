using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolLibrary;
using System.Collections.Generic;

namespace SchoolTests
{
    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "School name must not be empty!")]
        public void TestNameExceptionWhenEmpty()
        {
            School school = new School("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "School name must not be empty!")]
        public void TestNameExceptionWhenNull()
        {
            School school = new School(null);
        }

        [TestMethod]
        public void TestConstructor()
        {
            School course = new School("GLFL Simeon Radev");
            Assert.AreEqual(course.Name, "GLFL Simeon Radev");
        }

        [TestMethod]
        public void TestAddCourseRemoveCourse()
        {
            School school = new School("GLFL Simeon Radev");
            Course course = new Course("Math");

            school.AddCourse(new Course("Physics"));
            Assert.AreEqual(school.Courses.Count, 1);

            school.AddCourse(course);
            Assert.AreEqual(school.Courses.Count, 2);
            Assert.AreEqual(school.Courses[1].Name, "Math");

            school.RemoveCourse(course);
            Assert.AreEqual(school.Courses.Count, 1);
            Assert.AreEqual(school.Courses[0].Name, "Physics");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Course name cannot be null!")]
        public void TestAddCourseExceptionWhenNull()
        {
            School school = new School("GLFL Simeon Radev");
            school.AddCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This student is already enrolled the course!")]
        public void TestAddStudentExceptionWhenAlreadyAdded()
        {
            School school = new School("GLFL Simeon Radev");
            Course course = new Course("There is such course in the school!");
            school.AddCourse(course);
            school.AddCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException), "Course with this name doesn't exist in the school!")]
        public void TestRemoveStudentExceptionWhenNotExisting()
        {
            School school = new School("GLFL Simeon Radev");
            Course courseOne = new Course("Math");
            Course courseTwo = new Course("Physics");
            school.AddCourse(courseOne);
            school.RemoveCourse(courseTwo);
        }
    }
}
