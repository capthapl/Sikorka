using System;
using System.Collections.Generic;
using System.Text;

namespace Czapla.Exceptions
{
    class BadResponseException : Exception
    {
        public override string StackTrace => "BadResponseException" + base.StackTrace;
        public BadResponseException() : base("BadResponseException")
        {

        }
    }
}
