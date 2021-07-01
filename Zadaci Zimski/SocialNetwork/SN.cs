using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork
{
    class SN
    {
        public SN (List<User> users)
        {
            Users = users;
        }
        public List<User> Users { get; set; }
        public int CountUsers { get; set; }
        public static int MaxUsers { get; set; } = 5;
        public double AvgPopularity()
        {
            var avg = 0.0;
            foreach (var user in Users)
            {
                avg += user.Popularity();
            }
            return avg / CountUsers;
        }
        public void ChangeMaximumSize(int number)
        {
            MaxUsers = number;
        }
        static public void Message(int n)
        {
            Console.WriteLine($"You can't add more than {n} users");
        }
    }
}
