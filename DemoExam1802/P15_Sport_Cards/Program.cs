using System;
using System.Collections.Generic;
using System.Linq;

namespace P15_Sport_Cards
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> sportCards = new Dictionary<string, Dictionary<string, double>>();


            while (true)
            {
                var spliitedInput = Console.ReadLine().Split(new char[] {' ','-'},StringSplitOptions.RemoveEmptyEntries);


                if (spliitedInput[0] == "end")
                {
                    foreach (var card in sportCards.OrderByDescending(c => c.Value.Count))
                    {
                        Console.WriteLine($"{card.Key}:");
                        foreach (var sport in card.Value.OrderBy(s => s.Key))
                        {
                            Console.WriteLine($"  -{sport.Key} - {sport.Value:F2}");
                        }
                    }

                    break;
                }


                if (spliitedInput[0] == "check")
                {
                    var cardToCheck = spliitedInput[1];

                    if (sportCards.ContainsKey(cardToCheck))
                    {
                        Console.WriteLine($"{cardToCheck} is available!");
                    }
                    else
                    {
                        Console.WriteLine($"{cardToCheck} is not available!");
                    }


                }
                else
                {
                    var card = spliitedInput[0];
                    var sport = spliitedInput[1];
                    var price = double.Parse(spliitedInput[2]);

                    if (!sportCards.ContainsKey(card))
                    {
                        sportCards[card] = new Dictionary<string, double>();
                    }

                    if (!sportCards[card].ContainsKey(sport))
                    {
                        sportCards[card][sport] = 0;
                    }
                    sportCards[card][sport] = price;
                }




            }


        }
    }
}
