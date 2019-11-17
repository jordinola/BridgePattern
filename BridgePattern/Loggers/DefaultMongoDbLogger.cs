using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Loggers
{
    public class DefaultMongoDbLogger : ILogger
    {
        public void Write(Exception ex)
        {
            // MongoDb write logic goes here
            Console.WriteLine($"A default way to log an error in date: { DateTime.Now } with message { ex.Message }");
        }
    }
}
