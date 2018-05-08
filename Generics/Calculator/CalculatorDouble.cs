using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Calculator
{
	public class CalculatorDouble : CalculatorBase<double>
	{
		public override double Addition(double left, double right)
		{
			return left + right;
		}

		public override double Division(double left, double right)
		{
			return left / right;
		}

		public override double Multiplication(double left, double right)
		{
			return left * right;
		}

		public override double Substraction(double left, double right)
		{
			return left - right;
		}
	}
}
