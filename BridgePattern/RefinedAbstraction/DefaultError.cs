using BridgePattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.RefinedAbstraction
{
    public class DefaultError : IError
    {
        public string GetMessage(Exception ex)
        {
            return "An error ocurred in the application";
        }
    }
}
