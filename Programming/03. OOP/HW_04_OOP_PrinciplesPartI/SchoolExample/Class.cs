using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolExample
{
    class Class : ICommentable
    {
        //Fields
        private string className;
        private readonly List<Student> students = new List<Student>();
        private readonly List<Teacher> teachers = new List<Teacher>();

        //Properties
        public string Comments { get; set; }
        public string ClassName
        {
            get { return this.className; }
            private set { this.className = value; }
        }

        //Constructor
        public Class(string className)
        {
            this.ClassName = className;
        }

        //Methods
        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.students.Remove(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Class name: " + className);
            info.AppendLine("--- Teachers ---");
            foreach (Teacher teacher in teachers)
            {
                info.AppendLine(teacher.ToString());
            }
            info.AppendLine("--- Students ---");
            foreach (Student student in students)
            {
                info.AppendLine(student.ToString());
            }
            return info.ToString();
        }

    }
}
