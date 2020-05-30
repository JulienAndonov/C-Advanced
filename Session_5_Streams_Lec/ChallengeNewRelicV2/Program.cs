using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengeNewRelicV2
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentLine = string.Empty;
            List<string> currentLineList = new List<string>();
            Queue<string> currentSequenceQueue = new Queue<string>();
            Dictionary<string, int> sequences = new Dictionary<string, int>();
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            List<string> atThePresent = new List<string>();

            foreach (var file in args)
            {
                using (StreamReader str = File.OpenText(dir + @"\\" + file.ToString()))
                {
                    while ((currentLine = str.ReadLine()) != null)
                    {
                        currentLineList = Regex.Replace(currentLine,@"[^A-Za-z0-9]+"," ").Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();

                        foreach (var word in currentLineList)
                        {
                            currentSequenceQueue.Enqueue(word);

                            if (currentSequenceQueue.Count < 3)
                            {
                                continue;
                            }

                            string currentSequence = String.Join(" ", currentSequenceQueue).ToLower();

                            if (!sequences.ContainsKey(currentSequence))
                            {
                                sequences[currentSequence] = 1;
                            }
                            else
                            {
                                sequences[currentSequence]++;
                            }

                            if (currentSequence == "at the present")
                            {
                                atThePresent.Add(String.Join(" ",currentLineList));
                            }

                            currentSequenceQueue.Dequeue();
                            
                        }
                    }
                }
            }
            /*
            foreach (var sequence in sequences.OrderByDescending(x => x.Value).Take(100))
            {
                Console.WriteLine($"{sequence.Key} - {sequence.Value}");
            }
            */
            foreach (var atthePresentSequence in atThePresent)
            {
                Console.WriteLine($"{atthePresentSequence}");
            }
        }
    }
}
