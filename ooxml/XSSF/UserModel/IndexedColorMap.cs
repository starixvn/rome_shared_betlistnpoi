using System;
using System.Collections.Generic;
using System.Text;

namespace BetListNPOI.OOXML.XSSF.UserModel
{
    public interface IIndexedColorMap
    {
        byte[] GetRGB(int index);
    }
}
