﻿using System;
using System.Runtime.Serialization;

namespace Fuchsbau.Components.Data.DataStoring.Contract.Exceptions
{
    [Serializable]
    public class DataStoringException : Exception
    {
        public DataStoringException()
        {
        }

        public DataStoringException( string message )
            : base( message )
        {
        }

        public DataStoringException( string message, Exception inner )
            : base( message, inner )
        {
        }

        protected DataStoringException( SerializationInfo info, StreamingContext context ) 
            : base( info, context )
        {
        }
    }
}
