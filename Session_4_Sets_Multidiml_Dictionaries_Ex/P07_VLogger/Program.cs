using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_VLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> vloggerFollowers = new Dictionary<string, HashSet<string>>();
            Dictionary<string, HashSet<string>> vloggerFolloed = new Dictionary<string, HashSet<string>>();



            while (true)
            {
                var command = Console.ReadLine();
                if (command == "Statistics")
                {


                    break;
                }


                var entries = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var vlogerName = entries[0];
                var action = entries[1];
                var followed = entries[2];

                switch (action)
                {
                    case "joined":
                        if (!vloggerFollowers.ContainsKey(vlogerName))
                        {
                            vloggerFollowers[vlogerName] = new HashSet<string>();
                        }

                        if (!vloggerFolloed.ContainsKey(vlogerName))
                        {
                            vloggerFolloed[vlogerName] = new HashSet<string>();
                        }

                        break;
                    case "followed":
                        vloggerFollowers[vlogerName].Add(followed);
                        vloggerFolloed[followed].Add(vlogerName); ;
                        break;
                }





            }








        }
    }
}
