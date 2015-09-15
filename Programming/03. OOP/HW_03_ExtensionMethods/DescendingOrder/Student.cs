using System;

namespace DescendingOrder
{
    class Student
    {
        private string firstName;
        private string secondName;
        private int? age;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }
        public int? Age
        {
            get { return age; }
            set { age = value; }
        }

        public Student(string firstName, string secondName, int? age)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Age = age;
        }
        public Student(string firstName, string secondName)
            : this(firstName, secondName, null)
        {
        }
    }
}
