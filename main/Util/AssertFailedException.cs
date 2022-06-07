using System;
using System.Collections.Generic;
using System.Text;

namespace BetListNPOI.Util
{
    internal class AssertFailedException : ApplicationException
    {
        public AssertFailedException(string message)
            : base(message)
        {

        }
    }
}
