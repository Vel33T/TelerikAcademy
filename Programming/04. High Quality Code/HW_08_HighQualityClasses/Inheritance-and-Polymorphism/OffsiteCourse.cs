using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class OffsiteCourse : Course
    {
        //Field
        private string town;

        //Constructor
        public OffsiteCourse(string name, string teacherName = null, IList<string> students = null, string town = null)
            : base(name, teacherName, students)
        {
            this.Town = town;
        }

        //Property
        public string Town
        {
            get { return this.town; }
            set { this.town = value; }
        }

        //Method
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("OffsiteCourse { ");
            result.Append(base.ToString());

            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}
