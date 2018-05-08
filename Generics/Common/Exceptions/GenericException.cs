using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Common.Exceptions
{
	[Serializable]
	public class GenericException : Exception
	{
		public GenericException()
		: base()
		{
		}

		public GenericException(String message)
			: base(message)
		{
		}

		public GenericException(String message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}
