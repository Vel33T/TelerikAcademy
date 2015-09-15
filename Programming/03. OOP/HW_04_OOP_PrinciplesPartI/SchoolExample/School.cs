using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolExample
{
    class School
    {
        private string name;
        private readonly List<Class> classes = new List<Class>();

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public School(string name)
        {
            this.Name = name;
        }

        public void AddClass(Class _class)
        {
            this.classes.Add(_class);
        }

        public void RemoveClass(Class _class)
        {
            this.classes.Remove(_class);
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("--------------- School -----------------");
            info.AppendLine("Name: " + this.Name);
            info.AppendLine("------- Classes -------");
            foreach (Class _class in classes)
            {
                info.AppendLine(_class.ToString());
            }
            return info.ToString();
        }

    }
}
