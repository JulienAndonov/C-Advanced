
using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_VLogger
{

    class VloggerData
    {
        public int followers { get; set; }
        public int following { get; set; }
        public SortedSet<string> followersNames { get; set; }

        public VloggerData(int followers, int following, SortedSet<string> followersNames)
        {
            this.followers = followers;
            this.following = following;
            this.followersNames = followersNames;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, VloggerData> vloggers = new Dictionary<string, VloggerData>();
            int index = 1;

            while (true)
            {
                var entryCommand = Console.ReadLine();


                if (entryCommand == "Statistics")
                {
                    Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");


                    foreach (var vlogger in vloggers.OrderByDescending(x => x.Value.followers).ThenBy(x => x.Value.following))
                    {
                        Console.WriteLine($"{index}. {vlogger.Key} : {vlogger.Value.followers} followers, {vlogger.Value.following} following");
                        if (index == 1)
                        {
                            foreach (var follower in vlogger.Value.followersNames)
                            {
                                Console.WriteLine($"*  {follower}");
                            }
                        }
                        index++;
                    }
                    break;
                }


                var entries = entryCommand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var vloggerName = entries[0];
                var action = entries[1];
                var scndName = entries[2];


                switch (action)
                {
                    case "joined":
                        if (!vloggers.ContainsKey(vloggerName))
                        {
                            vloggers[vloggerName] = new VloggerData(0, 0, new SortedSet<string>());
                        }
                        break;
                    case "followed":
                        if (vloggers.ContainsKey(vloggerName)
                            && vloggers.ContainsKey(scndName)
                            && vloggerName != scndName
                            && !vloggers[scndName].followersNames.Contains(vloggerName))
                        {
                            vloggers[vloggerName].following++;
                            vloggers[scndName].followers++;
                            vloggers[scndName].followersNames.Add(vloggerName);
                        }
                        break;
                }
            }
        }
    }
}