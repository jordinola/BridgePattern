using System;

namespace BridgePattern.Loggers
{
    public class DetailedSqlLogger : ILogger
    {
        public string GetErrorMessage(Exception ex)
        {
            return $"A more detailed exception ocurred in date: { DateTime.Now }. StackTrace: { ex.StackTrace } InnerException: { ex.InnerException } Message: { ex.Message }";
        }

        public void Write(Exception ex)
        {
            // SQL write logic goes here
            var errorMessage = GetErrorMessage(ex);
            Console.WriteLine(errorMessage);
        }
    }
}
