using System;
using System.Text;

namespace PersonTask
{
    public class Person
    {
        public string Name { get; set; }
        public int? Age { get; set; }

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(this.Name);
            result.AppendLine(this.Age != null ? this.Age.ToString() : "Age not specified!");
            return result.ToString();
        }
    }
}
