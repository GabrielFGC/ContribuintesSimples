using System;
using System.Collections.Generic;
using System.Text;

namespace DadosDeContribuintes.Entities
{
    class PeopleIndividual : Peoples
    {
        public double HealthSpent { get; private set; }

        public PeopleIndividual(string name, double annualIncome, double healthSpent) : base(name, annualIncome)
        {
            HealthSpent = healthSpent;
        }

        public override double Tax()
        {
            if (AnnualIncome < 20000.00) 
            {
                return (AnnualIncome * 0.15) - (HealthSpent * 0.50);
            }
            else
            {
                return (AnnualIncome * 0.25) - (HealthSpent * 0.50);
            }
        }

    }
}
