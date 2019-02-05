using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _1._Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("../../../text.txt"))
            {
                int lineNumber = -1;
                while (true)
                {
                    string inputLine = reader.ReadLine();

                    if (inputLine==null)
                    {
                        break;
                    }
                    string[] line = inputLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    lineNumber++;
                    Stack<string> editedLine = new Stack<string>();

                    string sym = "-,.!?";

                    for (int i = 0; i < line.Length; i++)
                    {
                        string word = line[i];
                        StringBuilder sb = new StringBuilder();
                        for (int j = 0; j < word.Length; j++)
                        {
                            char symbol = word[j];
                            if (sym.Contains(symbol))
                            {
                                sb.Append('@');
                            }
                            else
                            {
                                sb.Append(symbol);
                            }

                        }
                        editedLine.Push(sb.ToString());
                    }
                    if (lineNumber==0 || lineNumber%2==0)
                    {

                      Console.WriteLine(string.Join(" ",editedLine));
                    }
                }
            }
        }
    }
}
