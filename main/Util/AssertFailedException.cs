using System;

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
