using System;
using System.Collections.Generic;
using System.Text;

namespace DadosDeContribuintes.Entities
{
    class PeopleCompany : Peoples
    {
        public int Employee { get; private set; }

        public PeopleCompany(string name, double annualIncome, int employee) : base(name, annualIncome)
        {
            Employee = employee;
        }

        public override double Tax()
        {
            if (Employee > 10) 
            {
                return (AnnualIncome * 0.14);
            }

            else
            {
                return (AnnualIncome * 0.16);
            }
        }

    }
}
