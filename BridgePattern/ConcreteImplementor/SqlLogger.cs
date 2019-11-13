using BridgePattern.Abstraction;
using BridgePattern.Implementor;
using System;

namespace BridgePattern.ConcreteImplementor
{
    public class SqlLogger : Logger
    {
        public SqlLogger(ICustomMessage customMessage) : base (customMessage) { }

        public override void Write(Exception ex)
        {
            // SQL write logic goes here
            Console.WriteLine(_customMessage.GetMessage(ex));
        }
    }
}
