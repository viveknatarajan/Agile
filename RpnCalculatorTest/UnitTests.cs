using NUnit.Framework;
using RpnCalculatorApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnCalculatorTest
{
	[TestFixture]
	class UnitTests
	{
		RpnCalculator calc;
		string expression;

		[SetUp]
		public void Setup()
		{
			calc = new RpnCalculator();
			expression = string.Empty;
		}

		[Test]
		public void testCase1()
		{
			expression = "2 2 +";
			Assert.AreEqual(4, calc.Calculate(expression));
		}

		[Test]
		public void testCase2()
		{
			expression = "2 3 +";
			Assert.AreEqual(5, calc.Calculate(expression));
		}

		[Test]
		public void testCase3()
		{
			expression = "2 3 -";
			Assert.AreEqual(-1, calc.Calculate(expression));
		}

		[Test]
		public void testCase4()
		{
			expression = "2 3 *";
			Assert.AreEqual(6, calc.Calculate(expression));
		}

		[Test]
		public void testCase5()
		{
			expression = "2 2 3 + +";
			Assert.AreEqual(7, calc.Calculate(expression));
		}

		[Test]
		public void testCase6()
		{
			expression = "5 1 2 + 4 * + 3 -";
			Assert.AreEqual(14, calc.Calculate(expression));
		}

		[Test]
		public void testCase7()
		{
			expression = "2 3 _";
			try
			{
				calc.Calculate(expression);
			}
			catch (Exception ex)
			{
				Assert.AreEqual("Operator Invalid", ex.Message);
			}
			
		}

		[Test]
		public void testCase8()
		{
			expression = "5 ++";
			Assert.AreEqual(6, calc.Calculate(expression));
		}

		[Test]
		public void testCase9()
		{
			expression = "5 --";
			Assert.AreEqual(4, calc.Calculate(expression));
			
		}
	}
}
