using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Calculator
{
    public class IntegerCalculator : CalculatorBase<int>
    {

		public IntegerCalculator()
		{
			type = "Integer calculator";
		}

        public override int Addition(int left, int right)
        {
            throw new NotImplementedException();
        }

        public override int Division(int left, int right)
        {
            throw new NotImplementedException();
        }

        public override int Multiplication(int left, int right)
        {
            throw new NotImplementedException();
        }

        public override int Substraction(int left, int right)
        {
            throw new NotImplementedException();
        }
    }
}
