﻿//
// AIWolfRuntimeException.cs
//
// Copyright (c) 2016 Takashi OTSUKI
//
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//

using System;

namespace AIWolf.Lib
{
    /// <summary>
    /// Exception that occurs during execution of AIWolf application.
    /// </summary>
    public class AIWolfRuntimeException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the AIWolfRuntimeException class.
        /// </summary>
        public AIWolfRuntimeException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AIWolfRuntimeException class with a specified error message.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public AIWolfRuntimeException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AIWolfRuntimeException class with a specified error message
        /// and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception,
        /// or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public AIWolfRuntimeException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}