using System;
using System.IO;

namespace _2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("../../../text.txt"))
            {
                int lineCount = 0;

                while (true)
                {
                    string line = reader.ReadLine();

                    if (line==null)
                    {
                        break;
                    }

                    lineCount++;
                    char[] symbols = line.ToCharArray();
                    int letterCount = 0;
                    int punctuationCount = 0;

                    foreach (var symbol in symbols)
                    {
                        if (char.IsLetter(symbol))
                        {
                            letterCount++;
                        }
                        else if (char.IsPunctuation(symbol))
                        {
                            punctuationCount++;
                        }
                    }

                    using (var writer=new StreamWriter("../../../output.txt", true))
                    {
                        writer.WriteLine($"Line {lineCount}: {line} ({letterCount})({punctuationCount})");
                       
                    }

                }

            }
        }
    }
}
