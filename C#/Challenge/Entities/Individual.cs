using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.Entities
{
    public class Individual : Person
    {


        public Individual (string name, double annualIncome, double healthSpending) : base(name, annualIncome)
        {
            HealthSpending = healthSpending;
        }
        public double HealthSpending { get; set; }

        public override double CalculateTax()
        {
            double tax = 0;
            if (AnnualIncome < 20000)
            {
                tax = AnnualIncome * 0.15 ;
            }
            else
            {
                tax = AnnualIncome * 0.25;
            }
            if (HealthSpending > 0)
            {
                tax -= (HealthSpending * 0.5);
            }
            return tax;
        } 
        
    }
}