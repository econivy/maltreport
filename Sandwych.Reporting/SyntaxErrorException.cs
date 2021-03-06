﻿//Creation Time: 2010-08-20
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Sandwych.Reporting
{
    [Serializable]
	public class SyntaxErrorException : Exception
	{
		public SyntaxErrorException ()
            : base()
		{
		}

		public SyntaxErrorException (string msg)
            : base(msg)
		{
		}

		protected SyntaxErrorException (SerializationInfo si, StreamingContext sc)
            : base(si, sc)
		{
		}

		public SyntaxErrorException (string msg, Exception ex)
            : base(msg, ex)
		{
		}

	}
}
