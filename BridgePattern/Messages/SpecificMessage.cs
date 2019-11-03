using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Messages
{
    public class SpecificMessage : ICustomMessage
    {
        public string GetMessage(Exception ex)
        {
            return $"An exception ocurred in date: { DateTime.Now } with message { ex.Message }";
        }
    }
}
