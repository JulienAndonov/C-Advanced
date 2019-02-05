using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _3._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            using (var reader = new StreamReader("../../../words.txt"))
            {
                while (true)
                {

                    var word = reader.ReadLine();

                    if (word == null)
                    {
                        break;
                    }

                    int wordCounter = 0;

                    using (var readerText = new StreamReader("../../../text.txt"))
                    {
                        var text = readerText.ReadToEnd().ToLower();
                        string[] textText = text.Split(new char[] { ' ', '-', '.', '?', '!',',' }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (var item in textText)
                        {
                            if (item == word)
                            {
                                wordCounter++;
                            }
                        }
                    }
                    wordCount.Add(word,wordCounter);

                    
                }
            }

            
            foreach (var kvp in wordCount.OrderByDescending(v=>v.Value))
            {
                string word = kvp.Key;
                int count = kvp.Value;
                using (var writer = new StreamWriter("../../../actualResult.txt", true))
                {
                    writer.WriteLine($"{word} - {count}");
                }

            }

            bool IsCorrect = true;

            using (var readerActual=new StreamReader("actualResult.txt"))
            {
                using (var readerExpected = new StreamReader("../../../expectedResult.txt"))
                {
                    var lineActual = readerActual.ReadLine();
                    var lineExpected = readerExpected.ReadLine();

                    if (lineActual!=lineExpected)
                    {
                        IsCorrect = false;
                    }
                }
            }
            Console.WriteLine(IsCorrect);
        }
    }
}
