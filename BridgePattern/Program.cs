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

            WriteToMong(exception);

            Console.WriteLine("\n=================================================\n");

            WriteToSql(exception);

            Console.WriteLine("\n=================================================\n");

            WriteToTextFile(exception);

            Console.ReadLine();
        }

        private static void WriteToTextFile(Exception exception)
        {
            var textFileLogger = new TextFileLogger(new CustomError());
            Console.WriteLine("Text File Logger");
            textFileLogger.Write(exception);
        }

        private static void WriteToSql(Exception exception)
        {
            var sqlLogger = new SqlLogger(new DetailedError());
            Console.WriteLine("SQL Logger");
            sqlLogger.Write(exception);
        }

        private static void WriteToMong(Exception exception)
        {
            var mongoLogger = new MongoDbLogger(new DefaultError());
            Console.WriteLine("Mongo Logger");
            mongoLogger.Write(exception);
        }
    }
}
