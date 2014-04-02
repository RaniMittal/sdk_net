﻿using System;

namespace Riskified.NetSDK.Exceptions
{
    public class OrderTransactionException : RiskifiedException
    {
        public OrderTransactionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public OrderTransactionException(string message) : base(message)
        {
        }
    }
}