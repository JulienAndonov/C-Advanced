using System;

using System.Collections.Generic;

using System.IO;

using System.Linq;

using System.Text;



namespace Session_5_Streams_Lec
{
    class Program
    {
        static void Main(string[] args)

        {
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            using (var writer = new StreamWriter(@"..\..\..\..\Resources\actualResult.txt"))
            {
                using (var readerWords = new StreamReader(@"..\..\..\..\Resources\words.txt"))
                {
                    using (var readerText = new StreamReader(@"..\..\..\..\Resources\text.txt"))
                    {
                        var entriesWords = new List<string>();
                        while (true)
                        {
                            var wordReader = readerWords.ReadLine();
                            if (wordReader == null)
                            {
                                break;
                            }
                            entriesWords.Add((wordReader.ToLower()));

                        }

                        while (true)
                        {
                            var textBuffer = readerText.ReadLine();

                            if (textBuffer == null)
                            {
                                break;
                            }
                            var entriesToCheck = textBuffer.Split(new char[] { ' ', '-', '.', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToLower()).ToList();
                            foreach (var word in entriesToCheck)
                            {
                                if (entriesWords.Contains(word.ToLower()))
                                {
                                    if (!wordsCount.ContainsKey(word))
                                    {
                                        wordsCount[word] = 0;
                                    }
                                    wordsCount[word]++;
                                }
                            }
                        }
                    }
                }

                foreach (var word in wordsCount.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}