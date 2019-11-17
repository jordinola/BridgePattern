using BridgePattern.Abstraction;
using BridgePattern.Data;
using BridgePattern.RefinedAbstraction;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace Tests.RefinedAbstraction
{
    public class CustomErrorTests
    {
        private IError error;
        private Exception ex;

        [SetUp]
        public void Setup()
        {
            error = new CustomError();
            ex = new CustomException().GetException();
        }

        [Test]
        public void GetCustomErrorMeessage()
        {
            var errorMessage = error.GetMessage(ex);
            errorMessage.Should().Be($"An exception ocurred in date: { DateTime.Now }.\n - StackTrace: { ex.StackTrace } \n - InnerException: { ex.InnerException } \n - Message: { ex.Message }");
        }
    }
}