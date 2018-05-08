using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics.Calculator;
using Generics.Common.Exceptions;

namespace AppConsumer
{

    class Program
    {
        
        static void Main(string[] args)
        {
            IntegerCalculator intCalc = new IntegerCalculator();
            Console.WriteLine(intCalc.Type);


			string a = "2.5d";

			string b = "2.5";

			double c = 0;

			try
			{
				intCalc.Addition(Int32.Parse(a), Int32.Parse(b));

				if (!(b is double))
				{
					throw new InvalidArgumentException();
				}

			}
			catch (InvalidArgumentException e)
			{
				Console.WriteLine(e.StackTrace);
				Console.WriteLine(e.Message);
			}
			catch (GenericException e)
			{
				Console.WriteLine(e.StackTrace);
				Console.WriteLine(e.Message);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.StackTrace);
				Console.WriteLine(e.Message);
			}

		}
    }
}
