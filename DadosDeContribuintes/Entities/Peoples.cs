using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace DadosDeContribuintes.Entities
{
    abstract class Peoples
    {
        public string Name { get; private set; }
        public double AnnualIncome { get; private set; }

        protected Peoples(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();

        public override string ToString()
        {
            return $"{Name}: ${Tax().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
