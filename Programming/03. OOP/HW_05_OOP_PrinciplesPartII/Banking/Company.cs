using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Company : Customer
    {
        public Company(string name, string iDNumber)
        {
            this.Name = name;
            this.IDNumber = iDNumber;
        }
    }
}
