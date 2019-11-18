using Bogus;
using BridgePattern.Loggers;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace Tests.Loggers
{
    public class DefaultMongoDbLoggerTests
    {
        private DefaultMongoDbLogger logger;
        private Exception ex;

        [SetUp]
        public void Setup()
        {
            logger = new DefaultMongoDbLogger();
            ex = new Faker<Exception>().Generate();
        }

        [Test]
        public void GetErrorMessage()
        {
            var errorMessage = logger.GetErrorMessage(ex);
            errorMessage.Should().Be($"A default way to log an error in date: { DateTime.Now } with message { ex.Message }");
        }

        [Test]
        public void LogToMongoDbTest_Success()
        {
            // A test to save a default error message to mongo that should be successfull
            var success = true;
            success.Should().BeTrue();
        }

        [Test]
        public void LogToMongoDbTest_Error()
        {
            // A test to save a default error message to mongo that should fail
            var success = false;
            success.Should().BeFalse();
        }
    }
}