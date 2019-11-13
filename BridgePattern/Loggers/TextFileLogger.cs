using System;

namespace BridgePattern.Loggers
{
    public class TextFileLogger : ILogger
    {
        public void Write(Exception ex)
        {
            // Text file write logic goes here
            Console.WriteLine($"An exception ocurred in date: { DateTime.Now }.\n - StackTrace: { ex.StackTrace } \n - InnerException: { ex.InnerException } \n - Message: { ex.Message }");
        }
    }
}
