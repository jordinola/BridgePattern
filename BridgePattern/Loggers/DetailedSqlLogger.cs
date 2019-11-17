using System;

namespace BridgePattern.Loggers
{
    public class DetailedSqlLogger : ILogger
    {
        public void Write(Exception ex)
        {
            // SQL write logic goes here
            Console.WriteLine($"A more detailed exception ocurred in date: { DateTime.Now }. StackTrace: { ex.StackTrace } InnerException: { ex.InnerException } Message: { ex.Message }");
        }
    }
}
