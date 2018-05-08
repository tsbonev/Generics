using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate int Callback(int a, int b);

namespace Generics.Calculator
{
    abstract public class CalculatorBase<T>
    {
        protected internal string type = null;

		public string Type => this.type;

        public abstract T Addition(T left, T right);

        public abstract T Substraction(T left, T right);

        public abstract T Multiplication(T left, T right);

        public abstract T Division(T left, T right);
    }
}
