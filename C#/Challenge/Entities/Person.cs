using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.Entities
{
    public abstract class Person
    {

        public Person(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }
        
        public string Name { get; set; }

        public double AnnualIncome { get; set; }

        public abstract double CalculateTax();

    }
}