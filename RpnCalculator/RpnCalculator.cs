using System.Collections.Generic;
using System.Linq;

namespace RpnCalculatorApp
{
	public class RpnCalculator
	{
		public int Calculate(string expression)
		{
			Stack<int> rpnStack = new Stack<int>();
			var listOfChars = expression.Split(' ');
			var output = 0;
			foreach (var item in listOfChars)
			{
				int number;
				if (int.TryParse(item, out number))
					rpnStack.Push(number);
				else
				{
					if (isUnary(item) == false)
					{
						var number2 = rpnStack.Pop();
						var number1 = rpnStack.Pop();
						output = binaryOperationsAvailable.First(x => x.IsApplicable(item)).Operation(number1, number2);
						rpnStack.Push(output);
					}
					else
					{
						var number1 = rpnStack.Pop();
						output = unaryOperationsAvailable.First(x => x.IsApplicable(item)).Operation(number1);
						rpnStack.Push(output);
					}
				}
			}
			return output;
		}

		private bool isUnary(string item)
		{
			var unary = true;
			IEnumerable<string> binaryOper = new List<string> { "*", "-", "+" };
			if (binaryOper.Contains(item))
				unary = false;
			return unary;
		}

		IEnumerable<RpnBinaryOperation> binaryOperationsAvailable = new List<RpnBinaryOperation>
		{
			new AddOperation(),
			new SubtractOperation(),
			new MultiplyOperation(),


			RpnBinaryOperation.Null//Null object. make sure operations are added before this.
		};
		IEnumerable<RpnUnaryOperation> unaryOperationsAvailable = new List<RpnUnaryOperation>
		{
			new DoublePlusOperation(),
			new DoubleMinusOperation(),


			RpnUnaryOperation.Null//Null object. make sure operations are added before this.
		};
	};
}
