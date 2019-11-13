using BridgePattern.Abstraction;
using System;

namespace BridgePattern.RefinedAbstraction
{
    public class CustomMessage : ICustomMessage
    {
        public string GetMessage(Exception ex)
        {
            return $"An exception ocurred in date: { DateTime.Now }.\n - StackTrace: { ex.StackTrace } \n - InnerException: { ex.InnerException } \n - Message: { ex.Message }";
        }
    }
}
