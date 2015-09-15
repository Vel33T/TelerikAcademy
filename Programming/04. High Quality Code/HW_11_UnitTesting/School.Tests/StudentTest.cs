using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolLibrary;

namespace SchoolTests
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Student's name is not entered correctly!")]
        public void TestNameExceptionWhenEmpty()
        {
            Student student = new Student("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Student's name is not entered correctly!")]
        public void TestNameExceptionWhenNull()
        {
            Student student = new Student(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Student's name must be atleast 2 characters long!")]
        public void TestNameExceptionWhenTooShort()
        {
            Student student = new Student("I");
        }

        [TestMethod]
        public void TestConstructor()
        {
            Student student = new Student("Gosho");
            Assert.AreEqual(student.Name, "Gosho");
            Assert.IsTrue(student.Id >= 10000 && student.Id <= 99999);
        }
    }
}
