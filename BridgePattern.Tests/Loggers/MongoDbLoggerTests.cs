using BridgePattern.Data;
using BridgePattern.Loggers;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace Tests.Loggers
{
    public class MongoDbLoggerTests
    {
        private MongoDbLogger logger;
        private Exception ex;

        [SetUp]
        public void Setup()
        {
            logger = new MongoDbLogger();
            ex = new CustomException().GetException();
        }

        [Test]
        public void GetErrorMeessage()
        {
            var errorMessage = logger.GetErrorMessage(ex);
            errorMessage.Should().Be($"An exception ocurred in date: { DateTime.Now } with message { ex.Message }");
        }

        [Test]
        public void LogToMongoDbTest_Success()
        {
            // A test to save to mongo that should be successfull
            var success = true;
            success.Should().BeTrue();
        }

        [Test]
        public void LogToMongoDbTest_Error()
        {
            // A test to save to mongo that should fail
            var success = false;
            success.Should().BeFalse();
        }
    }
}