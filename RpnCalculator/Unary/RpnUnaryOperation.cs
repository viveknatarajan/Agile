using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnCalculatorApp
{
	abstract class RpnUnaryOperation
	{
		public static RpnUnaryOperation Null = new NullUnary();
		public abstract bool IsApplicable(string oper);

		public abstract int Operation(int no1);

		private class NullUnary : RpnUnaryOperation
		{
			public override bool IsApplicable(string oper)
			{
				return true;
			}

			public override int Operation(int no1)
			{
				throw new Exception("Operator Invalid");
			}
		}

	}
}
