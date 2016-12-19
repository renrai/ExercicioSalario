using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDaryus.Models
{
    public class Income
    {
        public Double HourlyWorked { get; set; }
        public Double HourlyRate { get; set; }
        public Double IncomeTax { get; set; }
        public Double UniversalSocialCharge { get; set; }
        public Double Pension { get; set; }
        public Double GrossAmount { get; set; }



        public Double CalculateGrossAmount()
        {
            GrossAmount = HourlyRate * HourlyWorked;
            return GrossAmount;
        }

        public Double CalculateIncomeTax(String country)
        {
            switch (country)
            {
                case "Ireland":
                    if (GrossAmount <= 600)
                    {
                        IncomeTax = GrossAmount * 0.25;
                    }
                    else
                    {
                        IncomeTax = GrossAmount * 0.40;
                    }
                    break;
                case "Italy":
                    IncomeTax = GrossAmount * 0.25;
                    break;
                case "Germany":
                    if (GrossAmount <= 400)
                    {
                        IncomeTax = GrossAmount * 0.25;
                    }
                    else
                    {
                        IncomeTax = GrossAmount * 0.32;
                    }
                    break;

            }
            return IncomeTax;
        }

        public Double CalculateUniversalSocialCharge(String country)
        {
            switch (country)
            {
                case "Ireland":
                    if (GrossAmount <= 500)
                    {
                        UniversalSocialCharge = GrossAmount * 0.07;
                    }
                    else
                    {
                        UniversalSocialCharge = GrossAmount * 0.08;
                    }
                    break;
                case "Italy":
                    UniversalSocialCharge = GrossAmount * 0.0919;
                    break;
                case "Germany":
                    UniversalSocialCharge = 0;
                    break;


            }
            return UniversalSocialCharge;
        }

        public Double CalculatePension(String country)
        {
            switch (country)
            {
                case "Ireland":
                    Pension = GrossAmount * 0.04;
                    break;
                case "Italy":
                    Pension = 0;
                    break;
                case "Germany":
                    Pension = GrossAmount * 0.02;
                    break;


            }
            return Pension;
        }
    }
}
