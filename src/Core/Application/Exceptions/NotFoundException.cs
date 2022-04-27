using System;
using System.Globalization;

namespace N5.Application.Exceptions
{
    public class NotFoundException : Exception
    {
        public string ErrorMessage { get; set; }
        public NotFoundException() : base()
        {
        }

        public NotFoundException(string message, string errorMessage) : base(message)
        {
            ErrorMessage = errorMessage;
        }

        public NotFoundException(string message, params object[] args) : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}
