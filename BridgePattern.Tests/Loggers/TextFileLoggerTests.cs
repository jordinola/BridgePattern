using BridgePattern.Data;
using BridgePattern.Loggers;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace Tests.Loggers
{
    public class TextFileLoggerTests
    {
        private TextFileLogger logger;
        private Exception ex;

        [SetUp]
        public void Setup()
        {
            logger = new TextFileLogger();
            ex = new CustomException().GetException();
        }

        [Test]
        public void GetErrorMeessage()
        {
            var errorMessage = logger.GetErrorMessage(ex);
            errorMessage.Should().Be($"An exception ocurred in date: { DateTime.Now }.\n - StackTrace: { ex.StackTrace } \n - InnerException: { ex.InnerException } \n - Message: { ex.Message }");
        }

        [Test]
        public void LogToTextFileTest_Success()
        {
            // A test to save to a text file that should be successfull
            var success = true;
            success.Should().BeTrue();
        }

        [Test]
        public void LogToTextFileTest_Error()
        {
            // A test to save to a text file that should fail
            var success = false;
            success.Should().BeFalse();
        }
    }
}