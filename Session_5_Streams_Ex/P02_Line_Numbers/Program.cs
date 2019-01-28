using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Session_5_Streams_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;

            using (var writer = new StreamWriter(@"..\..\..\..\Resources\output.txt"))
            {
                using (var reader = new StreamReader(@"..\..\..\..\Resources\text.txt"))
                {

                    while (true)
                    {
                        var currentLine = reader.ReadLine();
                        int numOfPunction = 0;
                        int numOfSymbols = 0;
                        if (currentLine == null)
                        {
                            break;
                        }

                        for (int i = 0; i < currentLine.Length; i++)
                        {
                            if (currentLine[i] == '-'
                                || currentLine[i] == ','
                                || currentLine[i] == '.'
                                || currentLine[i] == '!'
                                || currentLine[i] == '?'
                                || currentLine[i] == '\'')
                            {
                                numOfPunction++;
                            }


                            if ((currentLine[i] >= 'a' && currentLine[i] <= 'z') ||
                                (currentLine[i] >= 'A' && currentLine[i] <= 'Z'))
                            {
                                numOfSymbols++;
                            }
                        }

                        writer.WriteLine($"Line {index}: {currentLine} ({numOfSymbols})({numOfPunction})");
                        index++;
                    }
                }
            }
        }
    }
}
