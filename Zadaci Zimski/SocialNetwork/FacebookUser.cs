using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork
{
    class FacebookUser : User
    {
        public FacebookUser(string username, string password, string email, int friends, int likes, int comments)
        {
            Username = username; Password = password; Email = email; Friends = friends; Likes = likes; Comments = comments;
        }
        public int Friends { get; set; }
        public int Likes { get; set; }
        public int Comments { get; set; }

        public override double Popularity()
        {
            return Friends + Likes*0.1 + Comments*0.5;
        }
        static public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
