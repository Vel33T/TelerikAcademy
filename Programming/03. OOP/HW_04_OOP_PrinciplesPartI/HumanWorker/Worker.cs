using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanWorker
{
    class Worker : Human
    {
        private const int WorkDaysInWeek = 5;
        private double workHoursPerDay;
        private double weekSalary;

        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            private set { this.workHoursPerDay = value; }
        }

        public double WeekSalary
        {
            get { return this.weekSalary; }
            private set { this.weekSalary = value; }
        }

        public Worker(string firstName, string lastName, double workHoursPerDay, double weekSalary)
            : base(firstName, lastName)
        {
            this.WorkHoursPerDay = workHoursPerDay;
            this.WeekSalary = weekSalary;
        }

        public double MoneyPerHour()
        {
            return this.weekSalary / WorkDaysInWeek / this.workHoursPerDay;
        }

        public override string ToString()
        {
            return String.Format("{0}    | Salary Per Hour: {1}", base.ToString(), this.MoneyPerHour());
        }
    }
}
