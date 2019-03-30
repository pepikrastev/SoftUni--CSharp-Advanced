using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.TheV_Logger
{
    class StartUp
    {
        static void Main(string[] args)
        {
            HashSet<string> userNames = new HashSet<string>();

            //X followed by...
            Dictionary<string, HashSet<string>> userFollowers = new Dictionary<string, HashSet<string>>();
            //X following...
            Dictionary<string, HashSet<string>> userFollowing = new Dictionary<string, HashSet<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Statistics")
                {
                    break;
                }

                string[] splitedInput = input.Split();

                if (splitedInput.Length == 4)
                {
                    string username = splitedInput[0];
                    if (!userNames.Contains(username))
                    {

                        userNames.Add(username);
                        userFollowers.Add(username, new HashSet<string>());   
                        userFollowing[username] = new HashSet<string>();      
                    }
                }
                else
                {
                    string heFollows = splitedInput[0];
                    string followed = splitedInput[2];

                    if (userNames.Contains(heFollows) &&
                        userNames.Contains(followed) &&
                        heFollows != followed)
                    {
                        userFollowers[followed].Add(heFollows);
                        userFollowing[heFollows].Add(followed);
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {userNames.Count()} vloggers in its logs.");

            var topUser = userFollowers
                .OrderByDescending(x => x.Value.Count())
                .ThenBy(x => userFollowing[x.Key].Count())
                .FirstOrDefault();

            int counter = 2;

            Console.WriteLine($"1. {topUser.Key} : {topUser.Value.Count()} followers, {userFollowing[topUser.Key].Count()} following");

            foreach (var item in topUser.Value.OrderBy(x => x))
            {
                Console.WriteLine($"*  {item}");
            }

            foreach (var kvp in userFollowers
                .OrderByDescending(x => x.Value.Count())
                .ThenBy(x => userFollowing[x.Key].Count())
                .Where(x => x.Key != topUser.Key))
            {
                Console.WriteLine($"{counter++}. {kvp.Key} : {kvp.Value.Count()} followers, {userFollowing[kvp.Key].Count()} following");
            }
        }
    }
}
