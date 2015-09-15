using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolLibrary;
using System.Collections.Generic;

namespace SchoolTests
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Course name must not be empty!")]
        public void TestNameExceptionWhenEmpty()
        {
            Course course = new Course("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Course name must not be empty!")]
        public void TestNameExceptionWhenNull()
        {
            Course course = new Course(null);
        }

        [TestMethod]
        public void TestConstructor()
        {
            Course course = new Course("Math");
            Assert.AreEqual(course.Name, "Math");
        }

        [TestMethod]
        public void TestAddStudentRemoveStudent()
        {
            Course course = new Course("Math");
            Student student = new Student("Pesho");

            course.AddStudent(new Student("Gosho"));
            Assert.AreEqual(course.Students.Count, 1);

            course.AddStudent(student);
            Assert.AreEqual(course.Students.Count, 2);
            Assert.AreEqual(course.Students[1].Name, "Pesho");

            course.RemoveStudent(student);
            Assert.AreEqual(course.Students.Count, 1);
            Assert.AreEqual(course.Students[0].Name, "Gosho");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Student cannot be null!")]
        public void TestAddStudentExceptionWhenNull()
        {
            Course course = new Course("Math");
            course.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This student is already enrolled the course!")]
        public void TestAddStudentExceptionWhenAlreadyAdded()
        {
            Course course = new Course("Math");
            Student student = new Student("Pesho");
            course.AddStudent(student);
            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "The course is full! Cannot add more students!")]
        public void TestAddStudentExceptionWhenStudentsTooMuch()
        {
            Course course = new Course("Math");
            for (int i = 0; i <= 30; i++)
            {
                course.AddStudent(new Student("Pesho"));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException), "Student with this id doesn't exist in the course!")]
        public void TestRemoveStudentExceptionWhenNotExisting()
        {
            Course course = new Course("Math");
            Student studentOne = new Student("Pesho");
            Student studentTwo = new Student("Gosho");
            course.AddStudent(studentOne);
            course.RemoveStudent(studentTwo);
        }
    }
}
