﻿using System;
using System.Runtime.Serialization;

namespace Vedroid.BLL
{
    [Serializable]
    public class NotExistException : Exception
    {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public NotExistException()
        {
        }

        public NotExistException(string message) : base(message)
        {
        }

        public NotExistException(string message, Exception inner) : base(message, inner)
        {
        }

        protected NotExistException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}