using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnCalculatorApp
{
	abstract class RpnBinaryOperation
	{
		public static RpnBinaryOperation Null = new NullOperation();
		public abstract bool IsApplicable(string oper);

		public abstract int Operation(int no1, int no2);

		class NullOperation : RpnBinaryOperation
		{
			public override bool IsApplicable(string oper)
			{
				return true;
			}

			public override int Operation(int no1, int no2)
			{
				throw new Exception("Operator Invalid");
			}
		}
	}
}
