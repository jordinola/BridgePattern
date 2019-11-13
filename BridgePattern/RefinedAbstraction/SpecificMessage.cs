using BridgePattern.Abstraction;
using System;

namespace BridgePattern.RefinedAbstraction
{
    public class SpecificMessage : ICustomMessage
    {
        public string GetMessage(Exception ex)
        {
            return $"An exception ocurred in date: { DateTime.Now } with message { ex.Message }";
        }
    }
}
