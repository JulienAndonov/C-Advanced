using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_VLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> vloggerToFollowers = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> vloggerToFollowing = new Dictionary<string, List<string>>();



            while (true)
            {
                var command = Console.ReadLine();
                if (command == "statistics")
                {
                    break;
                }


                var entries = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var vlogerName = entries[0];
                var action = entries[1];
                var 




            }








        }
    }
}
