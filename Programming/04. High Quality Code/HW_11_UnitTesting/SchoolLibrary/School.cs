using System;
using System.Collections.Generic;

namespace SchoolLibrary
{
    public class School
    {
        private string name;
        private List<Course> courses;

        public School(string name)
        {
            this.Name = name;
            this.courses = new List<Course>();
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("School name must not be empty!");
                }

                name = value;
            }
        }

        public List<Course> Courses
        {
            get { return this.courses; }
        }

        private bool HasCourse(string name)
        {
            foreach (Course course in this.courses)
            {
                if (name == course.Name)
                {
                    return true;
                }
            }
            return false;
        }

        public void AddCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course name cannot be null!");
            }
            if (HasCourse(course.Name))
            {
                throw new InvalidOperationException("There is such course in the school!");
            }

            this.courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            if (!HasCourse(course.Name))
            {
                throw new KeyNotFoundException("Course with this name doesn't exist in the school!");
            }

            for (int i = 0; i < this.courses.Count; i++)
            {
                if (course.Name == this.courses[i].Name)
                {
                    this.courses.RemoveAt(i);
                }
            }
        }
    }
}
