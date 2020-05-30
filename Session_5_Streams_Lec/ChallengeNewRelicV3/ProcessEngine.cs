using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace NewRelicChallenge
{
    public class ProcessEngine
    {
        public void Run(string[] args)
        {
            Dictionary<string, int> sequences = new Dictionary<string, int>();
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            char systemDirectorySeparatorChar = System.IO.Path.DirectorySeparatorChar;

            try
            {
                if (args.Length > 0)
                {
                    foreach (var file in args)
                    {
                        string fullFIleName = dir + systemDirectorySeparatorChar + file;
                        sequences = ProcessStream(File.OpenText(fullFIleName), sequences);
                    }
                }
                else
                {
                    sequences = ProcessStream(Console.In, sequences);

                }

                foreach (var sequence in sequences.OrderByDescending(x => x.Value).Take(100))
                {
                    Console.WriteLine($"{sequence.Key} - {sequence.Value}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public Dictionary<string, int> ProcessStream(TextReader str, Dictionary<string, int> sequences)
        {
            string currentLine = string.Empty;
            List<string> currentLineList = new List<string>();
            Queue<string> currentSequenceQueue = new Queue<string>();
            while ((currentLine = str.ReadLine()) != null)
            {
                currentLineList = Regex.Replace(currentLine, @"[^A-Za-z0-9]+", " ")
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
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
                    currentSequenceQueue.Dequeue();
                }
            }
            return sequences;
        }



    }
}
