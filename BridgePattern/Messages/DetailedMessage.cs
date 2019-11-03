using System;

namespace BridgePattern.Messages
{
    public class DetailedMessage : ICustomMessage
    {
        public string GetMessage(Exception ex)
        {
            return $"An exception ocurred in date: { DateTime.Now }. StackTrace: { ex.StackTrace } InnerException: { ex.InnerException } Message: { ex.Message }";
        }
    }
}
