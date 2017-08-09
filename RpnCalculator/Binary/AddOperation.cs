namespace RpnCalculatorApp
{
	class AddOperation : RpnBinaryOperation
	{
		public override bool IsApplicable(string oper)
		{
			return oper == "+";
		}

		public override int Operation(int no1, int no2)
		{
			return no1 + no2;
		}
	}
}
