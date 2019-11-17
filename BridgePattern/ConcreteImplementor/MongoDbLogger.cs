using System;

namespace BridgePattern.Loggers
{
    public class MongoDbLogger : ILogger
    {
        public string GetErrorMessage(Exception ex)
        {
            return $"An exception ocurred in date: { DateTime.Now } with message { ex.Message }";
        }

        public void Write(Exception ex)
        {
            // MongoDb write logic goes here
            var errorMessage = GetErrorMessage(ex);
            Console.WriteLine(errorMessage);
        }
    }
}
