using BridgePattern.ConcreteImplementor;
using BridgePattern.Data;
using BridgePattern.RefinedAbstraction;
using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var exception = new CustomException().GetException();

            var mongoLogger = new MongoDbLogger(new DefaultError());
            Console.WriteLine("Mongo Logger");
            mongoLogger.Write(exception);

            Console.WriteLine("\n=================================================\n");

            var sqlLogger = new SqlLogger(new DetailedError());
            Console.WriteLine("SQL Logger");
            sqlLogger.Write(exception);

            Console.WriteLine("\n=================================================\n");

            var textFileLogger = new TextFileLogger(new CustomError());
            Console.WriteLine("Text File Logger");
            textFileLogger.Write(exception);

            Console.ReadLine();
        }
    }
}
