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

            WriteToMongo(exception);

            Console.WriteLine("\n=================================================\n");

            WriteToSql(exception);

            Console.WriteLine("\n=================================================\n");

            WriteToTextFile(exception);

            Console.ReadLine();
        }

        private static void WriteToTextFile(Exception exception)
        {
            var textFileLogger = new TextFileLogger();
            Console.WriteLine("Text File Logger");
            textFileLogger.Write(exception);
        }

        private static void WriteToSql(Exception exception)
        {
            var sqlLogger = new SqlLogger();
            Console.WriteLine("SQL Logger");
            sqlLogger.Write(exception);
        }

        private static void WriteToMongo(Exception exception)
        {
            var mongoLogger = new MongoDbLogger();
            Console.WriteLine("Mongo Logger");
            mongoLogger.Write(exception);
        }
    }
}
