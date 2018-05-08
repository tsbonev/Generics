using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Common.Exceptions
{
	public class InvalidArgumentException : GenericException
	{
		public InvalidArgumentException()
		: base()
		{
		}

		public InvalidArgumentException(String message)
			: base(message)
		{
		}

		public InvalidArgumentException(String message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}
