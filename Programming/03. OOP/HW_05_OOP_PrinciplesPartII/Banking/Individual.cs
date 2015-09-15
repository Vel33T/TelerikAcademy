using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Individual : Customer
    {
        public Individual(string name, string iDNumber)
        {
            this.Name = name;
            this.IDNumber = iDNumber;
        }
    }
}
