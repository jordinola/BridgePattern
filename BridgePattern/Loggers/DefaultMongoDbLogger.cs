using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Loggers
{
    public class DefaultMongoDbLogger : ILogger
    {
        public string GetErrorMessage(Exception ex)
        {
            return $"A default way to log an error in date: { DateTime.Now } with message { ex.Message }";
        }

        public void Write(Exception ex)
        {
            // MongoDb write logic goes here
            var errorMessage = GetErrorMessage(ex);
            Console.WriteLine(errorMessage);
        }
    }
}
