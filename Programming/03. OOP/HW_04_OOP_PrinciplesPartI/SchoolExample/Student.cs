using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolExample
{
    public class Student : Person, ICommentable
    {
        private int classNumber;

        public int ClassNumber
        {
            get { return this.classNumber; }
            private set { this.classNumber = value; }
        }
        public string Comments { get; set; }

        public Student(string firstName, string lastName, int classNumber)
            : base(firstName, lastName)
        {
            this.ClassNumber = classNumber;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.Append("Student ");
            info.AppendLine(base.ToString());
            info.AppendLine("Number in class: " + this.ClassNumber);
            return info.ToString();
        }
    }
}
