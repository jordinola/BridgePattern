using BridgePattern.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Loggers
{
    public class MongoDbLogger : Logger
    {
        public MongoDbLogger(ICustomMessage customMessage) : base (customMessage) { }

        public override void Write(Exception ex)
        {
            // MongoDb write logic goes here
            Console.WriteLine(_customMessage.GetMessage(ex));
        }
    }
}
