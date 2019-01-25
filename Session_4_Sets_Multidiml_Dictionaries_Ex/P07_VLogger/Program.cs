using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

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




            while (true)
            {
                var entryCommand = Console.ReadLine();


                if (entryCommand == "Statistics")
                {



                    break;
                }


                var entries = entryCommand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var vloggerName = entries[0];
                var action = entries[1];
                var followed = entries[2];



                switch (action)
                {

                    case "joined":
                        if (!vloggers.ContainsKey(vloggerName))
                        {
                            vloggers[vloggerName] = new VloggerData(0, 0, new SortedSet<string>());
                        }
                        break;
                    case "followed":
                        if (vloggers.ContainsKey(vloggerName) && vloggers.ContainsKey(followed) && vloggerName != followed)
                        {
                            vloggers[vloggerName].following++;
                            vloggers[followed].followers++;
                            vloggers[followed].followersNames.Add(vloggerName);
                        }
                        break;
                }
            }
        }
    }
}
