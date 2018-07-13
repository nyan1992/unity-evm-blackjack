﻿using System;

namespace Loom.Unity3d
{
    /// <summary>
    /// Represents an error that occured during an RPC.
    /// </summary>
    public class RpcClientException : LoomException
    {
        public RpcClientException()
        {
        }

        public RpcClientException(string msg) : base(msg)
        {
        }

        public RpcClientException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}