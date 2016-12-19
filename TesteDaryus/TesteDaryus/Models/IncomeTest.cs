using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDaryus.Models
{       //Three Countries : Ireland / Italy / Germany
        //Gross Amount: Hourly rate * hours worked
        //Income Tax : Ireland - Gross Amount <= 600, Income = Gross Amount *   .25, Else Gross Amount * .40
        //Income Tax : Italy -  Gross Amount *   .25
        //Income Tax : Germany - Gross Amount <= 400, Income = Gross Amount *   .25, Else Gross Amount * .32

    [TestFixture]
    class IncomeTest
    {

        [Test]
        public void Calculate_Gross_Amount()
        {
            //Arrange
            Income obj = new Income();
            //ACT
            obj.HourlyRate = 10;
            obj.HourlyWorked = 40;
            double result = obj.CalculateGrossAmount();
            //Assert
            Assert.AreEqual(400, result);
          
        }

        [Test]
        public void Calculate_Income_Tax()
        {
            //Arrange
            Income obj = new Income();
            //ACT
            obj.GrossAmount = 100;
            double result = obj.CalculateIncomeTax("Italy");
            //Assert
            Assert.AreEqual(25, result);

        }

        [Test]
        public void Calculate_Universal_Social_Charge()
        {
            //Arrange
            Income obj = new Income();
            //ACT
            obj.GrossAmount = 1000;
            double result = obj.CalculateUniversalSocialCharge("Ireland");
            //Assert
            Assert.AreEqual(80, result);

        }


        [Test]
        public void Calculate_Pension()
        {
            //Arrange
            Income obj = new Income();
            //ACT
            obj.GrossAmount = 1000;
            double result = obj.CalculatePension("Germany");
            //Assert
            Assert.AreEqual(20, result);

        }
    }
}
