using System;
using System.Collections.Generic;
using System.Linq;

namespace L07_Softuni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> normalGuests = new HashSet<string>();

            var command = Console.ReadLine();

            while (true)
            {
                if (command == "PARTY" || command == "END")
                {
                    break;
                }

                if (command[0] >= '0' && command[0] <= '9')
                {
                    vipGuests.Add(command);
                }
                else
                {
                    normalGuests.Add(command);
                }

                command = Console.ReadLine();
            }


            if (command == "PARTY")
            {
                while (true)
                {
                    if (command == "END")
                    {
                        break;
                    }


                    if (vipGuests.Contains(command))
                    {
                        vipGuests.Remove(command);
                    }

                    if (normalGuests.Contains(command))
                    {
                        normalGuests.Remove(command);
                    }

                    command = Console.ReadLine();
                }
            }


            var remaining = vipGuests.Count() + normalGuests.Count();

            Console.WriteLine(remaining);
            if (vipGuests.Count() > 0)
            {
                Console.WriteLine(String.Join(System.Environment.NewLine, vipGuests));
            }

            if (normalGuests.Count() > 0)
            {
                Console.WriteLine(String.Join(System.Environment.NewLine, normalGuests));
            }
        }
    }
}
