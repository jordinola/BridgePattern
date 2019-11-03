using BridgePattern.Data;
using BridgePattern.Loggers;
using BridgePattern.Messages;
using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var exception = new CustomException().GetException();

            var mongoLogger = new MongoDbLogger(new SpecificMessage());
            mongoLogger.Write(exception);

            Console.WriteLine("\n=================================================\n");

            var sqlLogger = new SqlLogger(new DetailedMessage());
            sqlLogger.Write(exception);

            Console.WriteLine("\n=================================================\n");

            var textFileLogger = new TextFileLogger(new CustomMessage());
            textFileLogger.Write(exception);

            Console.ReadLine();
        }
    }
}
