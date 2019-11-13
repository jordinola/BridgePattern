using System;

namespace BridgePattern.Abstraction
{
    public interface ICustomMessage
    {
        string GetMessage(Exception ex);
    }
}
