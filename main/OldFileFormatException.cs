using System;

namespace BetListNPOI
{
    [Serializable]
    public class OldFileFormatException : UnsupportedFileFormatException
    {
        public OldFileFormatException(String s)
            : base(s)
        { }

    }
}
