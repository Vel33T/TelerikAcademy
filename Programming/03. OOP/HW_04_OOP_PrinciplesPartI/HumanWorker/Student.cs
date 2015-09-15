using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanWorker
{
    class Student : Human
    {
        public int Grade { get; private set; }

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public override string ToString()
        {
            return String.Format("Grade: {0}    {1}", this.Grade, base.ToString());
        }
    }
}
