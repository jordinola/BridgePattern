using BridgePattern.Abstraction;
using BridgePattern.Implementor;
using System;

namespace BridgePattern.ConcreteImplementor
{
    public class TextFileLogger : Logger
    {
        public TextFileLogger(ICustomMessage customMessage) : base (customMessage) { }

        public override void Write(Exception ex)
        {
            // Text file write logic goes here
            Console.WriteLine(_customMessage.GetMessage(ex));
        }
    }
}
