using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P16_Robot_Communication
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                
                if (input == "Report")
                {
                    break;
                }

                int startInd = -1;
                int endIndex = -1;
                char decisionChar = ' ';
                var encodingKey = -1;
                List<string> translatedSentance = new List<string>();

                for (int i = 0; i < input.Length; i++)
                {

                    if (input[i] == ',' || input[i] == '_')
                    {
                        startInd = i + 1;
                        decisionChar = input[i];
                    }

                    if ((int)input[i] >= 48 && (int)input[i] <= 57)
                    {
                        endIndex = i - 1;
                        encodingKey = int.Parse(input[i].ToString());
                    }

                    if (startInd != -1 && endIndex != -1 && endIndex >= startInd)
                    {
                        var cutMessage = input.Substring(startInd, endIndex - startInd + 1);
                        char currentChar = new char();
                        var currentWord = "";

                        for (int j = 0; j < cutMessage.Length; j++)
                        {
                            if (decisionChar == ',')
                            {
                                currentChar = (char)(cutMessage[j] + encodingKey);
                            }
                            else
                            {
                                currentChar = (char) (cutMessage[j] - encodingKey);
                            }
                            currentWord += currentChar;
                        }
                        translatedSentance.Add(currentWord);

                        startInd = -1;
                        endIndex = -1;
                    }
                }

                Console.WriteLine(string.Join(" ",translatedSentance));



            }
        }
    }
}
