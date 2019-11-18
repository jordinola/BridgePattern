﻿using System;

namespace BridgePattern.Loggers
{
    public interface ILogger
    {
        void Write(Exception ex);
        string GetErrorMessage(Exception ex);
    }
}