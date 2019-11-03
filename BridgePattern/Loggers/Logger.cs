using BridgePattern.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Loggers
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
