using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnCalculatorApp
{
	class DoubleMinusOperation : RpnUnaryOperation
	{
		public override bool IsApplicable(string oper)
		{
			return oper == "--";
		}

		public override int Operation(int no1)
		{
			return no1 - 1;
		}
	}
}
