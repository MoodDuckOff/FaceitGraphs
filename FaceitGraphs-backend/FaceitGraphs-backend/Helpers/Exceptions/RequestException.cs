using System;

namespace FaceitGraphs_backend.Helpers.Exceptions
{
    public class RequestException : Exception
    {
        public int HttpStatusCode { get;}

        public RequestException(string message, int httpStatusCode) : base(message)
        {
            HttpStatusCode = httpStatusCode;
        }
    }
}