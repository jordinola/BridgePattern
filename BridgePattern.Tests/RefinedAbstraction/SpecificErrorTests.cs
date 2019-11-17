using BridgePattern.Abstraction;
using BridgePattern.Data;
using BridgePattern.RefinedAbstraction;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace Tests.RefinedAbstraction
{
    public class SpecificErrorTests
    {
        private IError error;
        private Exception ex;

        [SetUp]
        public void Setup()
        {
            error = new SpecificError();
            ex = new CustomException().GetException();
        }

        [Test]
        public void GetSpecificErrorMessage()
        {
            var errorMessage = error.GetMessage(ex);
            errorMessage.Should().Be($"An exception ocurred in date: { DateTime.Now } with message { ex.Message }");
        }
    }
}