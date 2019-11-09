using System;
using System.Runtime.Serialization;

namespace FigureLib
{
    public class FigureException : Exception
    {
        public FigureException()
        {
        }

        public FigureException(string message) : base(message)
        {
        }

        public FigureException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FigureException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
