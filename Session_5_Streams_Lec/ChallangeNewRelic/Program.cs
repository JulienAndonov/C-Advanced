using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;

namespace ChallengeNewRelic
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder currentSequence = new StringBuilder();
            StringBuilder currentWord = new StringBuilder();
            Queue<string> currentSequenceQueue = new Queue<string>();
            Dictionary<string, int> sequences = new Dictionary<string, int>();
            int currentChunk;
            char currentChar;
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);


            foreach (var file in args)
            {
                using (var fs =
                    BufferedStream(dir + @"\\" + file.ToString()))
                {
                    byte[] buffer = new byte[4096];
                    long bytesRead;


                    while ((currentChunk = fs.Read(buffer,0,buffer.Length)) > 0)
                    {
                        for (int i = 0; i < buffer.Length; i++)
                        {
                            currentChar = Char.ToLowerInvariant(Convert.ToChar(buffer[i]));

                            if (char.IsLetterOrDigit(currentChar))
                            {
                                currentWord.Append(currentChar);
                            }

                            if (((char.IsPunctuation(currentChar) || char.IsSeparator(currentChar) ||
                                  char.IsWhiteSpace(currentChar)) || fs.Position == fs.Length) &&
                                currentWord.ToString() != "")
                            {
                                currentSequenceQueue.Enqueue(currentWord.ToString());
                                currentWord.Clear();

                                if (currentSequenceQueue.Count < 3)
                                {
                                    continue;
                                }

                                currentSequence.Append(string.Join(" ", currentSequenceQueue));

                                if (!sequences.ContainsKey(currentSequence.ToString()))
                                {
                                    sequences[currentSequence.ToString()] = 1;
                                }
                                else
                                {
                                    sequences[currentSequence.ToString()]++;
                                }

                                currentSequenceQueue.Dequeue();
                                currentSequence.Clear();
                            }
                        }
                    }
                }
            }

            foreach (var sequence in sequences.OrderByDescending(x => x.Value).Take(100))
            {
                Console.WriteLine($"{sequence.Key} - {sequence.Value}");
            }

        }
    }
}