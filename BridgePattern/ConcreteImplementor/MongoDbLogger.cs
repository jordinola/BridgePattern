using BridgePattern.Abstraction;
using BridgePattern.Implementor;
using System;

namespace BridgePattern.ConcreteImplementor
{
    public class MongoDbLogger : Logger
    {
        public MongoDbLogger(IError customMessage) : base (customMessage) { }

        public override void Write(Exception ex)
        {
            // MongoDb write logic goes here
            Console.WriteLine(_customMessage.GetMessage(ex));
        }
    }
}
