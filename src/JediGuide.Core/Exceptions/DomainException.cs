using System;
using System.Runtime.Serialization;

namespace JediGuide.Core.Exceptions
{
    public class DomainException : Exception
    {
        public int ErrCode { get; set; }
        public DomainException(string message, int errCode) : base(message)
        {
            this.ErrCode = errCode;
        }

    }
}