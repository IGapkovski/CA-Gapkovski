using System;

namespace SocialNetwork
{
    class InvalidPassword : Exception
    {
        public InvalidPassword(string message):base(message)
        {

        }
    }
    class InvalidEmail : Exception
    {
        public InvalidEmail(string message) : base(message)
        {

        }
    }
    class MaximumSizeLimit : Exception
    {
        public MaximumSizeLimit(int n)
        {
            N = n;
        }
        public int N { get; set; }
    }
}
