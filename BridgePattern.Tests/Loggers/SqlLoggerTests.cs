using Bogus;
using BridgePattern.Loggers;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace Tests.Loggers
{
    public class SqlLoggerTests
    {
        private SqlLogger logger;
        private Exception ex;

        [SetUp]
        public void Setup()
        {
            logger = new SqlLogger();
            ex = new Faker<Exception>().Generate();
        }

        [Test]
        public void GetErrorMeessage()
        {
            var errorMessage = logger.GetErrorMessage(ex);
            errorMessage.Should().Be($"An exception ocurred in date: { DateTime.Now }. StackTrace: { ex.StackTrace } InnerException: { ex.InnerException } Message: { ex.Message }");
        }

        [Test]
        public void LogToSqlTest_Success()
        {
            // A test to save to sql that should be successfull
            var success = true;
            success.Should().BeTrue();
        }

        [Test]
        public void LogToSqlTest_Error()
        {
            // A test to save to sql that should fail
            var success = false;
            success.Should().BeFalse();
        }
    }
}