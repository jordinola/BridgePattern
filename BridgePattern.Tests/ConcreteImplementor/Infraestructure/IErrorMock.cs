﻿using BridgePattern.Abstraction;
using Moq;
using System;

namespace BridgePattern.Tests.ConcreteImplementor.Infraestructure
{
    public static class IErrorMock
    {
        public static IError GetIErrorMock()
        {
            var mock = new Mock<IError>();
            mock.Setup(x => x.GetMessage(It.IsAny<Exception>()))
                .Returns(string.Empty);

            return mock.Object;
        }
    }
}
