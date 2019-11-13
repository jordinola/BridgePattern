using BridgePattern.Data;
using BridgePattern.Loggers;
using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var exception = new CustomException().GetException();

            var mongoLogger = new MongoDbLogger();
            Console.WriteLine("Mongo Logger");
            mongoLogger.Write(exception);

            Console.WriteLine("\n=================================================\n");

            var sqlLogger = new SqlLogger();
            Console.WriteLine("SQL Logger");
            sqlLogger.Write(exception);

            Console.WriteLine("\n=================================================\n");

            var textFileLogger = new TextFileLogger();
            Console.WriteLine("Text File Logger");
            textFileLogger.Write(exception);

            Console.ReadLine();
        }
    }
}
