using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Calculator
{
    public class CalculatorGeneric : CalculatorBase<double>
    {
        public CalculatorGeneric()
        {
            type = "Generic calculator";
        }

        public sealed override double Addition(double left, double right)
        {
            dynamic a = left;
            dynamic b = right;

            return a + b;
        }

        public sealed override double Substraction(double left, double right)
        {
            dynamic a = left;
            dynamic b = right;

            return a - b;
        }

        public override double Multiplication(double left, double right)
        {
            dynamic a = left;
            dynamic b = right;

            return a * b;
        }

        public override double Division(double left, double right)
        {
            dynamic a = left;
            dynamic b = right;

            return a / b;
        }
    }
}
