using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteDaryus.Models;

namespace TesteDaryus
{
    class Program
    {
        static void Main(string[] args)
        {

            Income income = new Income();
            String location;
            try
            {
                Console.WriteLine("******TAKE HOME PAY CALCULATION*****");
                Console.WriteLine("************************************");
                Console.WriteLine("Please enter the hours worked:");
                income.HourlyWorked = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nPlease enter the hourly rate:");
                income.HourlyRate = Convert.ToDouble(Console.ReadLine());
                do
                {
                    Console.WriteLine("\nPlease enter the employee’s location(Ireland, Italy or Germany):");
                    location = Console.ReadLine();
                } while (location != "Ireland" && location != "Italy" && location != "Germany");
                
                income.GrossAmount = income.CalculateGrossAmount();
                income.IncomeTax = income.CalculateIncomeTax(location);
                income.UniversalSocialCharge = income.CalculateUniversalSocialCharge(location);
                income.Pension = income.CalculatePension(location);
                Double netAmount = income.GrossAmount - income.IncomeTax - income.UniversalSocialCharge - income.Pension;

                Console.WriteLine("\nEmployee Location:" + location);
                Console.WriteLine("\nGross Amount: $ " + income.GrossAmount);
                Console.WriteLine("\nLess Deductions:");
                Console.WriteLine("Income Tax: $ " + income.IncomeTax);
                Console.WriteLine("Universal Social Change: $ " + income.UniversalSocialCharge);
                Console.WriteLine("Pension: $ " + income.Pension);
                Console.WriteLine("\nNET Amount: $ " + netAmount);

                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("There is an error in input. Program will be terminated.");
                Console.ReadLine();
            }


        }
    }
}
