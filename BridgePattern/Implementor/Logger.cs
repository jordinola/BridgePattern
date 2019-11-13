using BridgePattern.Abstraction;
using System;

namespace BridgePattern.Implementor
{
    public abstract class Logger
    {
        public readonly ICustomMessage _customMessage;

        public Logger(ICustomMessage customMessage)
        {
            _customMessage = customMessage;
        }

        public abstract void Write(Exception ex);
    }
}
