using System;
using System.Text;

namespace StudentData
{
    public class Student : ICloneable, IComparable<Student>
    {
        #region Properties
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; set; }
        public string SSN { get; private set; }
        public string Address { get; private set; }
        public string MobilePhone { get; private set; }
        public string EMail { get; private set; }
        public string Course { get; private set; }
        public Specialty Specialty { get; private set; }
        public University University { get; private set; }
        public Faculty Faculty { get; private set; } 
        #endregion

        #region Constructor
        public Student(string firstName, string middleName, string lastName,
            string address, string mobilePhone, string course, string ssn, string eMail,
            Specialty specialty, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.EMail = eMail;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        } 
        #endregion

        #region Overridden Methods
        public int CompareTo(Student other)
        {
            if (this.FirstName.CompareTo(other.FirstName) != 0)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
            else if (this.MiddleName.CompareTo(other.MiddleName) != 0)
            {
                return this.MiddleName.CompareTo(other.MiddleName);
            }
            else if (this.LastName.CompareTo(other.LastName) != 0)
            {
                return this.LastName.CompareTo(other.LastName);
            }
            else
            {
                return this.SSN.CompareTo(other.SSN);
            }
        }

        public Student Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.Address, this.MobilePhone, this.Course, this.SSN, this.EMail, this.Specialty, this.University, this.Faculty);
        }

        Object ICloneable.Clone()
        {
            return this.Clone();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(this.FirstName);
            result.AppendLine(this.MiddleName);
            result.AppendLine(this.LastName);
            result.AppendLine(this.SSN);
            result.AppendLine(this.Address);
            result.AppendLine(this.MobilePhone);
            result.AppendLine(this.EMail);
            result.AppendLine(this.Course);
            result.AppendLine(this.Specialty.ToString());
            result.AppendLine(this.University.ToString());
            result.AppendLine(this.Faculty.ToString());
            return result.ToString();
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if (student == null)
            {
                return false;
            }
            if (!Object.Equals(this.SSN, student.SSN))
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ SSN.GetHashCode();
        }

        public static bool operator ==(Student one, Student two)
        {
            return Student.Equals(one, two);
        }

        public static bool operator !=(Student one, Student two)
        {
            return Student.Equals(one, two);
        } 
        #endregion
    }
}
