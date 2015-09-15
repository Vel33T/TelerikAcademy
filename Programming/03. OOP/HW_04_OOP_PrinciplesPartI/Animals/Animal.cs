using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public abstract class Animal : ISound
    {
        public string Name { get;  set; }
        public int Age { get;  set; }        
        public Sex Sex { get;  set; }

        public abstract string MakeSound();

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Type: " + this.GetType());
            info.AppendLine("Name: " + this.Name);
            info.AppendLine("Age: " + this.Age);
            info.AppendLine("Sex: " + this.Sex);
            info.AppendLine(this.MakeSound());
            return info.ToString();
        }
    }
}
