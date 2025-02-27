﻿//
// Copyright (c) .NET Foundation and Contributors
// See LICENSE file in the project root for full license information.
//

using System;
using System.Runtime.Serialization;

namespace nanoFramework.Tools.FirmwareFlasher
{
    /// <summary>
    /// Verification of DFU write failed.
    /// </summary>
    [Serializable]
    public class NanoDeviceOperationFailedException : Exception
    {
        public NanoDeviceOperationFailedException()
        {
        }

        public NanoDeviceOperationFailedException(string message) : base(message)
        {
        }

        public NanoDeviceOperationFailedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NanoDeviceOperationFailedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
