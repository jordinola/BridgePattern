using BridgePattern.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Loggers
{
    public class SqlLogger : Logger
    {
        public SqlLogger(ICustomMessage customMessage) : base (customMessage) { }

        public override void Write(Exception ex)
        {
            // SQL write logic goes here
            Console.WriteLine(_customMessage.GetMessage(ex));
        }
    }
}
