using BridgePattern.Abstraction;
using BridgePattern.Data;
using BridgePattern.RefinedAbstraction;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace Tests.RefinedAbstraction
{
    public class DetailedErrorTests
    {
        private IError error;
        private Exception ex;

        [SetUp]
        public void Setup()
        {
            error = new DetailedError();
            ex = new CustomException().GetException();
        }

        [Test]
        public void GetDetailedErrorMeessage()
        {
            var errorMessage = error.GetMessage(ex);
            errorMessage.Should().Be($"An exception ocurred in date: { DateTime.Now }. StackTrace: { ex.StackTrace } InnerException: { ex.InnerException } Message: { ex.Message }");
        }
    }
}