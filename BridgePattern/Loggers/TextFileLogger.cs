using System;

namespace BridgePattern.Loggers
{
    public class TextFileLogger : ILogger
    {
        public string GetErrorMessage(Exception ex)
        {
            return $"An exception ocurred in date: { DateTime.Now }.\n - StackTrace: { ex.StackTrace } \n - InnerException: { ex.InnerException } \n - Message: { ex.Message }";
        }

        public void Write(Exception ex)
        {
            // Text file write logic goes here
            var errorMessage = GetErrorMessage(ex);
            Console.WriteLine(errorMessage);
        }
    }
}
