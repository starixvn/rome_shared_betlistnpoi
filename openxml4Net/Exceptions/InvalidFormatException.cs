using System;
using System.Collections.Generic;
using System.Text;

namespace BetListNPOI.OpenXml4Net.Exceptions
{
    public class InvalidFormatException:OpenXml4NetException
    {

        public InvalidFormatException(String message):base(message)
        {
            
        }

        public InvalidFormatException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
