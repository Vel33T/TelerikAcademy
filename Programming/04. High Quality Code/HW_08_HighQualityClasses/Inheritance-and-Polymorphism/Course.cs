namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course
    {
        //Fields
        private string name;
        private string teacherName;
        private IList<string> students;

        //Constructor
        public Course(string name, string teacherName, IList<string> students)
        {
            this.Name = name;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        //Properties
        public string Name 
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Course name must not be empty or null!");
                }
                this.name = value;
            }
        }
        public string TeacherName
        {
            get { return this.teacherName; }
            set { this.teacherName = value; }
        }
        public IList<string> Students 
        {
            get { return this.students; }
            set { this.students = value; }
        }

        //Methods
        private string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Name = ");
            result.Append(this.Name);

            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
        
            return result.ToString();
        }
    }
}
