using System;
using System.Collections.Generic;
using System.Text;

namespace NaucniTrudovi
{
    class InvalidGradeException: Exception
    {
        public InvalidGradeException (string message): base(message)
        {

        }
    }

    class InvalidPublishDateException : Exception
    {
        public InvalidPublishDateException(string message) : base(message)
        {

        }
    }
}
