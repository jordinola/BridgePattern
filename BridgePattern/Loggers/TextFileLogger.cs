using BridgePattern.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Loggers
{
    public class TextFileLogger : Logger
    {
        public TextFileLogger(ICustomMessage customMessage) : base (customMessage) { }

        public override void Write(Exception ex)
        {
            // Text file write logic goes here
            Console.WriteLine(_customMessage.GetMessage(ex));
        }
    }
}
