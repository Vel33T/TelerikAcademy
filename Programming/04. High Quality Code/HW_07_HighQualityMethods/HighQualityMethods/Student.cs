using System;

namespace Methods
{
    public class Student
    {
        //Properties
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string DateOfBirth { get; private set; }
        public string OtherInfo { get; private set; }

        //Constructors
        public Student(string firstName, string lastName, string dateOfBirth)
            : this(firstName, lastName, dateOfBirth, null)
        {
        }

        public Student(string firstName, string lastName, string dateOfBirth, string otherInfo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.OtherInfo = otherInfo;
        }

        //Public functions
        public bool IsOlderThan(Student other)
        {
            DateTime firstDate = DateTime.Parse(this.DateOfBirth);
            DateTime secondDate = DateTime.Parse(other.DateOfBirth);
            return firstDate > secondDate;
        }
    }
}
