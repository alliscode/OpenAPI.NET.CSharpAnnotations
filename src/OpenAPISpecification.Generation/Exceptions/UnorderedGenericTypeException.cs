﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

using System;
using System.Runtime.Serialization;

namespace Microsoft.OpenApiSpecification.Generation.Exceptions
{
    /// <summary>
    /// The exception that is thrown when generic types are not documented in order in the xml documentation.
    /// </summary>
    [Serializable]
    public class UnorderedGenericTypeException : DocumentationException
    {
        /// <summary>
        /// The default constructor.
        /// </summary>
        public UnorderedGenericTypeException()
            : this(SpecificationGenerationMessages.UnorderedGenericType)
        {
        }

        /// <summary>
        /// The Constructor with custom message.
        /// </summary>
        /// <param name="message">Custom message.</param>
        public UnorderedGenericTypeException(string message) : base(message)
        {
        }

        /// <summary>
        /// The Constructor with custom message and inner exception.
        /// </summary>
        /// <param name="message">Custom message.</param>
        /// <param name="inner">Inner exception.</param>
        public UnorderedGenericTypeException(string message, Exception inner) : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UnorderedGenericTypeException class with serialized data.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Streaming context.</param>
        protected UnorderedGenericTypeException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}