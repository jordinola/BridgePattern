using BridgePattern.Abstraction;
using BridgePattern.Data;
using BridgePattern.RefinedAbstraction;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace Tests.RefinedAbstraction
{
    public class DefaultErrorTests
    {
        private IError error;
        private Exception ex;

        [SetUp]
        public void Setup()
        {
            error = new DefaultError();
            ex = new CustomException().GetException();
        }

        [Test]
        public void GetDefaultErrorMessage()
        {
            var errorMessage = error.GetMessage(ex);
            errorMessage.Should().Be("An error ocurred in the application");
        }
    }
}