using System;

namespace BridgePattern.Loggers
{
    public class MongoDbLogger : ILogger
    {
        public void Write(Exception ex)
        {
            // MongoDb write logic goes here
            Console.WriteLine($"An exception ocurred in date: { DateTime.Now } with message { ex.Message }");
        }
    }
}
