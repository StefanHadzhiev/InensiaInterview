using System;
using System.Collections.Generic;
using System.Text;

namespace TaxSystem
{
    public class Worker
    { 
        public Worker(decimal grossSalary)
        {
            this.GrossSalary = grossSalary; 
        }

        public decimal GrossSalary { get; set; }

        public decimal Tax
        {
            get
            {
                return CalculateTax(this.GrossSalary);
            }
        }

        public decimal NetSalary 
        {
            get
            {
                return CalculateNetSalary(this.GrossSalary);
            }
        }

        private static decimal CalculateNetSalary(decimal grossSalary)
        {
            decimal netSalary = 0;
            decimal tax = 0;
            decimal socialContributionsTax = 0;
            decimal incomeTax = 0.10M;
            decimal socialContributionsTaxPercentage = 0.15M;

            if (grossSalary < 1000)
            {
                return grossSalary;
            }

            else if( grossSalary > 1000 && grossSalary < 3000)
            {
                tax = grossSalary * incomeTax;
                netSalary = grossSalary - tax;
            }

            else if(grossSalary >= 3000)
            {
                tax = grossSalary * incomeTax;
                socialContributionsTax = 3000 * socialContributionsTaxPercentage;
                netSalary = grossSalary - tax - socialContributionsTax;
            }
            return netSalary;
        }

        private static decimal CalculateTax(decimal grossSalary)
        {
            decimal tax = 0;
            decimal socialContributionsTax = 0;
            decimal incomeTax = 0.10M;
            decimal socialContributionsTaxPercentage = 0.15M;

            if (grossSalary < 1000)
            {
                tax = 0;
            }
            else if (grossSalary > 1000 && grossSalary < 3000)
            {
                tax = grossSalary * incomeTax;
            }
            else if (grossSalary >= 3000)
            {
                tax = grossSalary * incomeTax;
                socialContributionsTax = 3000 * socialContributionsTaxPercentage;
                tax += socialContributionsTax;
            }
            return tax;
        }
    }
}
