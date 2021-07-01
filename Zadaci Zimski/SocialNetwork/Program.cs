using System;
using System.Collections.Generic;

namespace SocialNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Social Network");
            SN socialNetwork;
            var users = new List<User>();
            Console.Write("Vnesi broj na useri: ");
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("1-FB user, 2-Twitter user");
                var tip = Console.ReadLine();
                if (tip == "1")
                    vnesiFBuser();
                else
                    VnesiTuser();
            }
            try
            {
                if (users.Count > SN.MaxUsers)
                    throw new MaximumSizeLimit(SN.MaxUsers);
                socialNetwork = new SN(users) { CountUsers = users.Count };
                Console.WriteLine(socialNetwork.AvgPopularity());
            }
            catch
            {
                SN.Message(SN.MaxUsers);
            }

            void vnesiFBuser()
            {
                try
                {
                    bool golema = false; bool mala = false; bool brojka = false;
                    Console.Write("Vnesi Username: ");
                    string username = Console.ReadLine();
                    Console.Write("Vnesi Password: ");
                    string password = Console.ReadLine();

                    //Proverka za Password
                    foreach (var bukva in password)
                    {
                        if (char.IsDigit(bukva))
                            brojka = true;
                        else if (char.IsUpper(bukva))
                            golema = true;
                        else if (char.IsLower(bukva))
                            mala = true;
                    }
                    if (!(mala && golema && brojka))
                        throw new InvalidPassword("Password is too weak");
                    Console.Write("Vnesi email: ");
                    string email = Console.ReadLine();

                    //Proverka za Email
                    int brojAt = 0;
                    foreach (var bukva in email)
                    {
                        if (bukva == '@')
                            brojAt++;
                    }
                    if (brojAt != 1)
                        throw new InvalidEmail("Mail is not valid");
                    Console.Write("Vnesi Friends ");
                    var friends = int.Parse(Console.ReadLine());
                    Console.Write("Vnesi Likes ");
                    var likes = int.Parse(Console.ReadLine());
                    Console.Write("Vnesi Comments ");
                    var comments = int.Parse(Console.ReadLine());
                    users.Add(new FacebookUser(username, password, email, friends, likes, comments));
                }
                catch (InvalidPassword ip)
                {
                    FacebookUser.Message(ip.Message);
                }
                catch (InvalidEmail ie)
                {
                    FacebookUser.Message(ie.Message);
                }
            }
            void VnesiTuser()
            {
                try
                {
                    bool golema = false; bool mala = false; bool brojka = false;
                    Console.Write("Vnesi Username: ");
                    string username = Console.ReadLine();
                    Console.Write("Vnesi Password: ");
                    string password = Console.ReadLine();

                    //Proverka za Password
                    foreach (var bukva in password)
                    {
                        if (char.IsDigit(bukva))
                            brojka = true;
                        else if (char.IsUpper(bukva))
                            golema = true;
                        else if (char.IsLower(bukva))
                            mala = true;
                    }
                    if (!(mala && golema && brojka))
                        throw new InvalidPassword("Password is too weak");
                    Console.Write("Vnesi email: ");
                    string email = Console.ReadLine();

                    //Proverka za Email
                    int brojAt = 0;
                    foreach (var bukva in email)
                    {
                        if (bukva == '@')
                            brojAt++;
                    }
                    if (brojAt != 1)
                        throw new InvalidEmail("Mail is not valid");
                    Console.Write("Vnesi followers ");
                    var followers = int.Parse(Console.ReadLine());
                    Console.Write("Vnesi tweets ");
                    var tweets = int.Parse(Console.ReadLine());
                    users.Add(new TwitterUser(username, password, email, followers, tweets));
                }
                catch (InvalidPassword ip)
                {
                    TwitterUser.Message(ip.Message);
                }
                catch (InvalidEmail ie)
                {
                    TwitterUser.Message(ie.Message);
                }
            }
        }
    }
}
