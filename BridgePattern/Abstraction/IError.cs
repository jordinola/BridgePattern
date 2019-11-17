using System;

namespace BridgePattern.Abstraction
{
    public interface IError
    {
        string GetMessage(Exception ex);
    }
}
