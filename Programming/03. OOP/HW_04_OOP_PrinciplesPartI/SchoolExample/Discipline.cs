using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolExample
{
    public class Discipline : ICommentable
    {
        private string name;
        private int lectures;
        private int exercises;

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        public int Lectures
        {
            get { return this.lectures; }
            private set { this.lectures = value; }
        }
        public int Exercises
        {
            get { return this.exercises; }
            private set { this.exercises = value; }
        }
        public string Comments { get; set; }

        public Discipline(string name, int lectures, int exercises)
        {
            this.Name = name;
            this.Lectures = lectures;
            this.Exercises = exercises;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Name: " + this.Name);
            info.AppendLine("Number of Lectures: " + this.Lectures);
            info.AppendLine("Number of Exercises: " + this.Exercises);
            return info.ToString();
        }
    }
}
