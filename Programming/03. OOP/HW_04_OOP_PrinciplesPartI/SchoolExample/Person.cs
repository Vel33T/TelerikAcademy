using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolExample
{
    public class Person : IComparable<Person>
    {
        private string firstName;
        private string lastName;

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                this.lastName = value;
            }
        }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                this.firstName = value;
            }
        }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int CompareTo(Person person)
        {
            return this.FirstName.CompareTo(person.FirstName);
        }

        public override string ToString()
        {
            return String.Format("Name: {0} {1} ", this.FirstName, this.LastName);
        }
    }
}
