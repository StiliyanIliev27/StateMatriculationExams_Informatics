using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_26
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, int age, decimal wage, int workHours) 
            : base(firstName, lastName, age)
        {
            Wage = wage;
            WorkHours = workHours;
        }
        public decimal Wage { get; private set; }
        public int WorkHours { get; private set; }
        public override string ToString()
        {
            return base.ToString() + $", salary: ${(Wage * WorkHours):f2}";
        }
    }
}
