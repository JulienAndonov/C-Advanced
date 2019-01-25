
using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_VLogger
{

    class VloggerData
    {
        public int followed { get; set; }
        public int following { get; set; }
        public SortedSet<string> followersNames { get; set; }




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
                var scndName = entries[2];

                


            }




        }
    }
}