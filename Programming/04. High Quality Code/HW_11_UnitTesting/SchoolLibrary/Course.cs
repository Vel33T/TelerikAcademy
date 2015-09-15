namespace SchoolLibrary
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private const int MaxStudentsInCourse = 29;
        private string name;
        private List<Student> students;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
        }

        public string Name
        {
            get { return name; }
            set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Course name must not be empty!");
                }
                name = value; 
            }
        }

        public List<Student> Students
        { 
            get { return this.students; } 
        }

        private bool HasStudent(int id)
        {
            foreach (Student student in this.students)
            {
                if (id == student.Id)
                {
                    return true;
                }
            }
            return false;
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student cannot be null!");
            }
            if (students.Count > MaxStudentsInCourse)
            {
                throw new InvalidOperationException("The course is full! Cannot add more students!");
            }
            if (HasStudent(student.Id))
            {
                throw new InvalidOperationException("This student is already enrolled the course!");
            }
            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (!HasStudent(student.Id))
            {
                throw new KeyNotFoundException("Student with this id doesn't exist in the course!");
            }

            for (int i = 0; i < this.students.Count; i++)
            {
                if (this.students[i].Id == student.Id)
                {
                    this.students.RemoveAt(i);
                    break;
                }
            }
        }

    }
}
