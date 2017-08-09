using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecsByExample.RpnCalculator
{
    [Binding]
    public class RpnCalculatorSteps
    {
		RpnCalculatorApp.RpnCalculator calc;
		int output;
        [Given(@"user opens RpnCalculator")]
        public void GivenUserOpensRpnCalculator()
        {
			calc = new RpnCalculatorApp.RpnCalculator();
		}
        
        [When(@"user enters ""(.*)""")]
        public void WhenUserEnters(string p0)
        {
			output = calc.Calculate(p0);
		}
        
        [Then(@"user is displayed (.*)")]
        public void ThenUserIsDisplayed(int p0)
        {
			Assert.AreEqual(p0, output);
        }
    }
}
