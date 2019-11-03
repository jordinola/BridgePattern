using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Messages
{
    public interface ICustomMessage
    {
        string GetMessage(Exception ex);
    }
}
