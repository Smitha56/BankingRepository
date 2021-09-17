using System;
using NUnit.Framework;

namespace BankingLibrary.Tests
{
    [TestFixture]
    public class CalcInterestTests
    {
        [Test]
        public void Calculate_AcceptsPNR_ReturnsSI()
        {
            int ExpectedResult = 1000;
            ICalcInterest calc = new CalcInterest();
            int ActualResult = calc.Calculate(10000, 1, 10);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        
    }
}