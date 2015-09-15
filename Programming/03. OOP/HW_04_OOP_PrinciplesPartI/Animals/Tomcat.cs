using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, Sex.Male)
        {
        }

        public override string MakeSound()
        {
            return "Tomcat Miyau!";
        }
    }
}
