using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.Entities
{
    public class LegalPerson : Person
    {
        

        public LegalPerson (string name, double annualIncome, double numberOfEmployees) : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public double NumberOfEmployees { get; set; }

        public override double CalculateTax()
        {
            double tax = 0;
            if (NumberOfEmployees > 10)
            {
                tax = AnnualIncome * 0.14;
            }
            else
            {
                tax = AnnualIncome * 0.16;
            }
            return tax;
        }
    }
}