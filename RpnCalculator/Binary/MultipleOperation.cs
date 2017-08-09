using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnCalculatorApp
{
	class MultiplyOperation : RpnBinaryOperation
	{
		public override bool IsApplicable(string oper)
		{
			return oper == "*";
		}

		public override int Operation(int no1, int no2)
		{
			return no1 * no2;
		}
	}
}
