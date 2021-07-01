using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork
{
    class TwitterUser : User
    {
        public TwitterUser(string username, string password, string email, int followers, int tweets)
        {
            Username = username; Password = password; Email = email; Followers = followers; Tweets = tweets;
        }
        public int Followers { get; set; }
        public int Tweets { get; set; }

        public override double Popularity()
        {
            return Followers + 0.5*Tweets;
        }
        static public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
