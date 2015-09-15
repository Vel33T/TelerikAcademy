using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolExample
{
    public class Teacher : Person, ICommentable
    {
        private readonly List<Discipline> disciplines = new List<Discipline>();

        public string Comments { get; set; }

        public Teacher(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.disciplines.Remove(discipline);
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.Append("Teacher ");
            info.AppendLine(base.ToString());
            info.AppendLine("---- Disciplines ----");
            foreach (Discipline discipline in disciplines)
            {
                info.AppendLine(discipline.ToString());
            }
            return info.ToString();
        }
    }
}
