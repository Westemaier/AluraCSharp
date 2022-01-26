using System;
using System.Runtime.Serialization;

namespace ByteBank
{
    [Serializable]
    internal class IOExcepption : Exception
    {
        public IOExcepption()
        {
        }

        public IOExcepption(string message) : base(message)
        {
        }

        public IOExcepption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IOExcepption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}